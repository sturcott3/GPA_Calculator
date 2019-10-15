using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GPA_Calculator_2;

namespace GPA_Calculator_UI_2
{
    public partial class Editor : Form
    {
        /*
         TODO 
         - add a control to allow user to delete rows

         - add instructions
            
         - <stretch goal> have courses of same code highlight each other
         - <stretch goal> Handle course equivalencies 
         - <stretch goal> Handle cases where students have taken more than one program i.e. many electives (need equivalencies for this)
         - <stretch goal> Handle differing grading modes i.e. Aviation Management(B pass) vs Social Worker(C pass) vs Computer Programmer(D pass) 
         - <stretch goal> Get input for course requirements and evaluate based on that i.e. different required numbers of electives
         - <stretch goal> Handle program other requirements like placements, and add input for what those requirments are
         - <stretch goal> Automatic setup of program requirements like courses in the editor? would be a huge amount of work to record all the data
         - <stretch goal> Allow user to enter either letter grade or percent grade instead of requiring only percent
         - <stretch goal> Fill in print method (with PrintType.Csv) for consumption in Excel, 
                            and add a control to the form allowing the user to change output type
         - <stretch goal> Allow the user to choose output directory instead of just telling them where it goes
        */

        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_Setup-_-_-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

        //declare fields to recieve input
        private Transcript input_Transcript;
        private List<DataGridView> semesterPages;


        private string calculationSummaryItems;//the summary of calculation results
        

        //to hold the user input values that control calculations
        private double targetGPA;
        private double increment;

        string startPath;

        //to control the status strip
        private Timer delay = new Timer();

        public Editor()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            //Initialize fields to recieve input
            input_Transcript = new Transcript();
            semesterPages = new List<DataGridView>() { grdDisplay_Sem_1,grd_Display_Sem2,
                                                       grd_Display_Sem3, grd_Display_Sem4 };
            
            lblWarning.Text = "Please enter data, then press \"Validate Input\"";

            startPath = Application.StartupPath;
        }

        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_Non-Event Methods_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        private bool ValidateOtherInputs()
        {
            //if control gets through every check, isValid will stay in its initial state
            bool isValid = true;

            //-----targetGPA textbox-------------------------------------------------------------------------------------------------------
            if (txtTargetGPA.Text == null || txtTargetGPA.Text == String.Empty)
            {
                lblWarning.Text = "Missing target GPA. Please enter a number (2.0 >> 4.0)";
                txtTargetGPA.Select();
                isValid = false;
                return isValid;
            }

            if (!Double.TryParse(txtTargetGPA.Text, out targetGPA))
            {

                lblWarning.Text = "Target GPA invalid data. Must be a number (2.0 >> 4.0)";
                txtTargetGPA.Select();
                isValid = false;
                return isValid;

            }
            
            if (targetGPA < 2.0 || targetGPA > 4.0)
            {
                lblWarning.Text = "Target GPA out of range. Must be a number (2.0 >> 4.0)";
                txtTargetGPA.Select();
                isValid = false;
                return isValid;
            }

            //-----increment textbox-------------------------------------------------------------------------------------------------------
            if (!Double.TryParse(cbxIncrement.Text, out increment))
            {
                lblWarning.Text = "Increment out of range. Please choose one of the available values.";
                cbxIncrement.Select();
                isValid = false;
                return isValid;
            }

            if (increment != 0.25 && increment != 0.50 && increment != 1.0 && increment != 0.10)
            {
                lblWarning.Text = "Increment out of range. Please choose one of the available values.";
                cbxIncrement.Select();
                isValid = false;
                return isValid;
            }
            return isValid;
        }

        private bool ValidateSemesters(List<DataGridView> semesterGrids)
        {//determine whether the inputs given on the currently displayed semester are valid
         //data type and reasonableness. Also autofills additional fields when possible.

            //Throughout this method, the conditions that return true indicate bad input, and will return false immediately, 
            //effectively short circuiting the rest of the checks. If control reaches the end of the method, the flag will 
            //have remained in its original state, set here
            bool isValid = true;

            DataGridView semesterGrid;
            double throwaway = -2.0; //default to invalid here to make sure I get input, or blank

            //set cursor position out of datagrid to avoid user frustration from typing in the wrong cell
            btnTestInput.Select();

            //iterate over each page (Semester)
            for (int currentPage = 0; currentPage < semesterGrids.Count; currentPage++ )
            {
                semesterGrid = semesterGrids[currentPage];

                //clear last cell colouring and highlighting
                foreach (DataGridViewRow row in semesterGrid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.White;
                        cell.Selected = false;
                    }
                }

                //Handle the case where they switch to another semester without entering anything
                if ((string)semesterGrid.Rows[0].Cells[0].Value == null)
                {
                    isValid = false;
                    lblWarning.Text = "Empty Semester " + (currentPage+1) + " cannot be read. Please delete it if there is no data to be considered.";
                }

               //Iterate over each row of input
                for (int currentRow = 0; currentRow < (semesterGrid.Rows.Count - 1); currentRow++)
                {
                    //Check each row for minimum input (avoiding the perpetually blank line at the end  of the grid with Count-1)
                    //if there are partial inputs that stop the calculation from working, i.e. course code with no credit hours
                    // stop validation and notify the user.
                    if ((string)semesterGrid.Rows[currentRow].Cells[0].Value == null ||
                        (string)semesterGrid.Rows[currentRow].Cells[1].Value == null)
                    {
                        //indicate whats wrong
                        lblWarning.Text = "Semester "  + (currentPage+1) + ", line " + (currentRow+1) +": " +
                            "Minimum input not entered.";
                        
                        //highlight bad inputs
                        foreach (DataGridViewCell cell in semesterGrid.Rows[currentRow].Cells)
                        {
                            cell.Style.BackColor = Transcript.ShadeBad;
                            cell.Selected = false;
                        }

                        //return control to user, but invalidate calculate button
                        isValid = false;
                        return isValid;
                    }

                    //Check Credit hours for valid input
                    if (!double.TryParse((string)semesterGrid.Rows[currentRow].Cells[1].Value, out throwaway))
                    {
                        //if input is not a double, stop validating and notify the user
                        lblWarning.Text = "Semester " + (currentPage + 1) + ", line " + (currentRow + 1) + ": " +
                        "Non-numeric Credit Hours input (must be 28 >> 128)";

                        //highlight bad inputs
                        foreach (DataGridViewCell cell in semesterGrid.Rows[currentRow].Cells)
                        {
                            cell.Style.BackColor = Transcript.ShadeBad;
                            cell.Selected = false;
                        }
                        //return control to user, but invalidate calculate button
                        isValid = false;
                        return isValid;
                    }
                    else if (throwaway > 128 || throwaway < 24)//Ensure the number is reasonable 
                    {
                        lblWarning.Text = "Semester " + (currentPage + 1) + ", line " + (currentRow + 1) + ": " +
                        "Credit Hours out of range (must be 28 >> 128)";

                        //highlight bad inputs
                        foreach (DataGridViewCell cell in semesterGrid.Rows[currentRow].Cells)
                        {
                            cell.Style.BackColor = Transcript.ShadeBad;
                            cell.Selected = false;
                        }
                        //return control to user, but invalidate calculate button
                        isValid = false;
                        return isValid;
                    }
                    
                    //Check Percent Grade Column for valid input
                    if ((string)semesterGrid.Rows[currentRow].Cells[2].Value != null) //Only do further checks if not empty, 
                    {                                                      //empty is acceptable and means Incomplete
                        if (!double.TryParse((string)semesterGrid.Rows[currentRow].Cells[2].Value, out throwaway)) 
                        {
                            //if input is not a double, stop validating and notify the user
                            lblWarning.Text = "Semester " + (currentPage + 1) + ", line " + (currentRow + 1) + ": " +
                            "Non-numeric Grade(%) input (must be -1(incomplete) >> 100)";

                            //highlight bad inputs
                            foreach (DataGridViewCell cell in semesterGrid.Rows[currentRow].Cells)
                            {
                                cell.Style.BackColor = Transcript.ShadeBad;
                                cell.Selected = false;
                            }
                            //return control to user, but invalidate calculate button
                            isValid = false;
                            return isValid;
                        }
                        else if (throwaway > 100 || throwaway < -1)//Ensure the number is reasonable (i.e percent grades cant be negative)
                        {
                            lblWarning.Text = "Semester " + (currentPage + 1) + ", line " + (currentRow + 1) + ": " +
                            "Grade(%) out of range (must be -1(incomplete) >> 100)";

                            //highlight bad inputs
                            foreach (DataGridViewCell cell in semesterGrid.Rows[currentRow].Cells)
                            {
                                cell.Style.BackColor = Transcript.ShadeBad;
                                cell.Selected = false;
                            }
                            //return control to user, but invalidate calculate button
                            isValid = false;
                            return isValid;
                        }
                    }
                }
            }
            return isValid;
        }

        private void AutoFill(List<DataGridView> semesterGrids)
        {//should only be called after input is validated
            foreach (DataGridView semesterGrid in semesterGrids)
            {
                for (int currentRow = 0; currentRow < (semesterGrid.Rows.Count - 1); currentRow++)
                {
                    //If we get past all validation, start autofill
                    //set all incomplete courses to -1, I, and not completed
                    if ((string)semesterGrid.Rows[currentRow].Cells[2].Value == null)
                    {
                        semesterGrid.Rows[currentRow].Cells[2].Value = "-1";
                        semesterGrid.Rows[currentRow].Cells[3].Value = "I";
                        semesterGrid.Rows[currentRow].Cells[4].Value = "Incomplete";

                        foreach (DataGridViewCell cell in semesterGrid.Rows[currentRow].Cells)
                        {//color incomplete rows light blue to indicate they will be calculated
                            cell.Style.BackColor = Transcript.ShadeIncomplete;
                        }
                    }
                    else
                    {
                        semesterGrid.Rows[currentRow].Cells[3].Value =
                                Course.CalcLetterGrade(Double.Parse((string)semesterGrid.Rows[currentRow].Cells[2].Value));

                        if (double.Parse((string)semesterGrid.Rows[currentRow].Cells[2].Value) == -1)
                        {
                            semesterGrid.Rows[currentRow].Cells[4].Value = "Incomplete";

                            foreach (DataGridViewCell cell in semesterGrid.Rows[currentRow].Cells)
                            {//color incomplete rows light blue to indicate they will be calculated
                                cell.Style.BackColor = Transcript.ShadeIncomplete;
                            }
                        }
                        else
                        {
                            semesterGrid.Rows[currentRow].Cells[4].Value = "Complete";

                            foreach (DataGridViewCell cell in semesterGrid.Rows[currentRow].Cells)
                            {//color complete rows light green to indicate they will not be touched
                                cell.Style.BackColor = Transcript.Shadepass;
                            }
                        }
                    }
                    
                    if (double.Parse((string)semesterGrid.Rows[currentRow].Cells[2].Value) < 50.0 &&
                        double.Parse((string)semesterGrid.Rows[currentRow].Cells[2].Value) != -1)
                    {
                        foreach (DataGridViewCell cell in semesterGrid.Rows[currentRow].Cells)
                        {//color failed courses yellow to show they will cause the transcript to fail unless they have been repeated
                            cell.Style.BackColor = Transcript.ShadeFail;
                        }
                    }
                }
            }
        }

        private void AddSemesterToTranscript(DataGridView current)
        {// should only be called directly after ValidateSemester() returns true

            //create a new course list
            List<Course> tempCourseList = new List<Course>();

            tempCourseList.Clear();//test, not needed

            string[] row = new string[3];

            //iterate over each row in the grid, adding a new course to the Semester for each row. 
            //goes to Count - 1 to eliminate the last row (always empty because of dataGridView) 
            //TODO make it so it avoids empty rows instead
            for (int i = 0; i < (current.Rows.Count - 1) ; i++)
            {
                //eliminate the read of the final empty row (happens by default due to dataGrid)
                if ((string)current.Rows[i].Cells[0].Value != null)
                {
                    row[0] = (string)current.Rows[i].Cells[0].Value;
                    row[1] = (string)current.Rows[i].Cells[1].Value;
                    row[2] = (string)current.Rows[i].Cells[2].Value;
                }
                //use the Course constructor to calculate letter grade/ quality points
                Course tempCourse = new Course(row[0], Convert.ToDouble(row[1]), Convert.ToDouble(row[2]));

                //add the course to the courselist for the semester
                tempCourseList.Add(tempCourse);
            }
            //add the Semester to the transcript
            input_Transcript.Semesters.Add(new Semester(tempCourseList));
        }

        public string CalcOutcome_Formbound(double targetGPA, double increment)
        {
            bool minimumPrinted = false;
            bool targetPrinted = false;

            //create the output form
            Display frmOut = new Display(); 

            //print the original to file <TODO> according to user preference
            List<string> temp = input_Transcript.PrintTranscript(startPath +  "\\Output\\Original.txt", PrintType.FancyText);

            frmOut.SetDisplayPage(TabType.Original, input_Transcript, temp);

            //to catch the output summary
            string overallSummary = String.Empty;

            //save the starting cumulative GPA in output summary
            overallSummary += "Starting Cumulative GPA: " + input_Transcript.CumulativeGPA.ToString("F2");

            //tracking variable (number of Transcripts printed)
            int numEx = 0;
            double lastPrinted = 0.0;

            //set each course at -1 (incomplete) to [D / recalc QPs]
            for (int i = 0; i < input_Transcript.CourseList.Count; i++)
            {
                if (input_Transcript.CourseList[i].PercentGrade == -1) { input_Transcript.CourseList[i].LetterGrade = 'D'; }
            }
            //recalculate cumulative GPA
            input_Transcript.CalcCumuGPA();

            //-Initial Checks-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
            //***If GPA meets the target, print it out and save that as both minimum  and target
            //(means that existing grades are high enough to pass with all 50s) 

            if (input_Transcript.CumulativeGPA >= targetGPA  && input_Transcript.TestGraduating()) 
            {
                temp = input_Transcript.PrintTranscript(startPath + "\\Output\\Minimum.txt", PrintType.FancyText);
                overallSummary += "\n\n Congrats, your existing grades are high enough that with a D in all outstanding courses," +
                    " your GPA would be: " + input_Transcript.CumulativeGPA.ToString("F2");

                frmOut.SetDisplayPage(TabType.Minimum, input_Transcript, temp);
                minimumPrinted = true;

                frmOut.SetDisplayPage(TabType.Target, input_Transcript, temp);
                targetPrinted = true;
            }

            else if (input_Transcript.TestGraduating())
            {
                //If the transcript graduates but does not meet the target, set it to the minimum,
                //print it to file and set the lastPrinted tracker
                minimumPrinted = true;
                temp = input_Transcript.PrintTranscript(startPath + "\\Output\\Minimum.txt", PrintType.FancyText);
                lastPrinted = input_Transcript.CumulativeGPA;
                overallSummary += "\n\n The lowest possible graduating GPA achievable is: " + input_Transcript.CumulativeGPA.ToString("F2");
                frmOut.SetDisplayPage(TabType.Minimum, input_Transcript, temp);
            }

            // if not at the target, loop until hit A in every incomplete course
            while (!input_Transcript.TestMaxChecked())
            {
                //loop over all courses
                for (int i = 0; i < input_Transcript.CourseList.Count; i++)
                {
                    //ignore courses that are marked as completed 
                    if (!input_Transcript.CourseList[i].Completed)
                    {
                        //increment one course by one letter grade
                        input_Transcript.CourseList[i].IncrementLetterGrade();

                        //recalculate and check the gpa. if meeting the target, print 
                        input_Transcript.CalcCumuGPA();
                        if (!targetPrinted && input_Transcript.CumulativeGPA >= targetGPA && input_Transcript.TestGraduating())
                        {
                            targetPrinted = true;
                            overallSummary += "\n\n Congratulations, target is achievable!";
                            temp = input_Transcript.PrintTranscript(startPath + "\\Output\\Target.txt", PrintType.FancyText);
                            frmOut.SetDisplayPage(TabType.Target, input_Transcript, temp);
                        }

                        //if the minimum hasn't been printed yet, do so
                        if (!minimumPrinted && input_Transcript.TestGraduating())
                        {
                            minimumPrinted = true;
                            lastPrinted = input_Transcript.CumulativeGPA;
                            overallSummary += "\n\n The lowest possible graduating GPA achievable is: " + input_Transcript.CumulativeGPA.ToString("F2");
                            temp = input_Transcript.PrintTranscript(startPath + "\\Output\\Minimum.txt", PrintType.FancyText);
                            frmOut.SetDisplayPage(TabType.Minimum, input_Transcript, temp);
                        }

                        //check if it graduates and surpasses the last printed by the user defined increment
                        //if it does, print to file and continue checks
                        if ((input_Transcript.CumulativeGPA >= (lastPrinted + increment)) && input_Transcript.TestGraduating())
                        {
                            input_Transcript.PrintTranscript(startPath + "\\Output\\Simulated-V" + numEx++ + ".txt", PrintType.FancyText);
                            lastPrinted += increment;
                        }
                    }
                }
            }
            temp = input_Transcript.PrintTranscript(startPath + "\\Output\\Maximum.txt", PrintType.FancyText);

            frmOut.SetDisplayPage(TabType.Maximum, input_Transcript, temp);

            overallSummary += "\n\n The highest GPA achievable without repeating courses is: "+
                                            input_Transcript.CumulativeGPA.ToString("F2");

            //-ShutDown-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
            //record number of attempts
            overallSummary += "\n\n" + numEx + " cases tested";

            //save the path for the output folder
            overallSummary += "\n\n Please find additional detailed results at " +startPath + "\\Output";

            //make the output window visible
            frmOut.Show();

            return overallSummary;
        }

        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_Event Methods_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

        private void btnAddSemester_Click(object sender, EventArgs e)
        {
            //add a new page to the tabcontrol and set it's text
            tbConSemesters.TabPages.Add(new TabPage());
            tbConSemesters.TabPages[tbConSemesters.TabPages.Count - 1].Text = "Semester " + tbConSemesters.TabPages.Count ;

            //add a datagridview to the new tabPage, 
            DataGridView newGrid = new DataGridView();
            
            //add the appropriate columns to it,
            newGrid.Columns.Add("colCourseCode" + tbConSemesters.TabCount.ToString(),"Course Code");
            newGrid.Columns.Add("colCCreditHours" + tbConSemesters.TabCount.ToString(), "Credit Hours");
            newGrid.Columns.Add("colPercentGrade" + tbConSemesters.TabCount.ToString(), "Grade (%)");
            newGrid.Columns.Add("colLetterGrade" + tbConSemesters.TabCount.ToString(), "Grade (Letter)");
            newGrid.Columns.Add("colCompleted" + tbConSemesters.TabCount.ToString(), "Completed");
            
            //add it to the List of available semesters,
            semesterPages.Add(newGrid);

            //add it to its parent container and dock it within for display
            tbConSemesters.TabPages[tbConSemesters.TabPages.Count - 1].Controls.Add(newGrid);
            newGrid.Dock = DockStyle.Fill; 
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //clear the transcript in case they punch the button more than once 
            input_Transcript = new Transcript();
            
            //input validation for whole form now
            if (ValidateSemesters(semesterPages) && ValidateOtherInputs())
            {
                //fill in the form if there were any changes
                AutoFill(semesterPages);
                lblWarning.Text = "No Warnings";

                //loop over grids
                foreach (DataGridView semesterPage in semesterPages)
                {//Get the semesters from the datagrids and put them in the transcript
                    AddSemesterToTranscript(semesterPage);
                }

                //setup courselist and cumulative GPA
                input_Transcript.SetupCourseList();
                input_Transcript.CalcCumuGPA();

                //Calculate 
                calculationSummaryItems = CalcOutcome_Formbound(targetGPA, increment);

                //Show overall summary
                MessageBox.Show(calculationSummaryItems);
            }

        }

        private void btnDelSemester_Click(object sender, EventArgs e)
        {
            //prompt the user for confirmation of deletion
            DialogResult delResult;
            MessageBoxButtons messButtons = MessageBoxButtons.OKCancel;
            string title = "Permanently Delete Semester?";
            string message = "Are you sure you want to delete " + tbConSemesters.SelectedTab.Text + "? " +
                "This action is permanent, and you will not be able to retrieve any data entered in the Semester.";

            delResult = MessageBox.Show(message, title, messButtons);

            //if they confirm, remove the page, and remove the Datagridview from the semester collection
            if (delResult == DialogResult.OK)
            {
                semesterPages.RemoveAt(tbConSemesters.SelectedIndex);
                tbConSemesters.TabPages.RemoveAt(tbConSemesters.SelectedIndex);  
                //remove from list
            }            
        }


        private void btnTestInput_Click(object sender, EventArgs e)
        {
            if (ValidateSemesters(semesterPages))
            {
                AutoFill(semesterPages);
            }
        }
        
        //ValueChanged events are needed to save changes without needing a user generated event (i.e. save button), 
        //and allow the user to jump around without losing data. 
        private void grd_Display_Sem1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            grdDisplay_Sem_1.EndEdit();

        }

        private void grd_Display_Sem2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            grd_Display_Sem2.EndEdit();

        }

        private void grd_Display_Sem3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            grd_Display_Sem3.EndEdit();

        }

        private void grd_Display_Sem4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            grd_Display_Sem4.EndEdit();

        }

        private void txtTargetGPA_TextChanged(object sender, EventArgs e)
        {

        }

        //close the form from the menu
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO : Add form with instructions");
        }

        private void cbxIncrement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
