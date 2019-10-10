using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPA_Calculator_2;

namespace GPA_Calculator_UI_2
{
    public partial class Calculator : Form
    {
        /*
         TODO 
         - Add another form with instructions - accessed through menu

         - Handle repeated courses
            - change every cumulative/graduating test to operate only on Transcript.CourseList, and not Transcript.Semesters.Courses
            - test to ensure GPA calculations are accurate
            - test to ensure that transcript still prints properly
            - add a column to the form to display included/not included

         - Run more test cases, more unit tests

         - Change SetupCourseList to be an instance method
         - Change CalcCumuGPA to be an instance method

         - <stretch goal> handle course equivalencies 
         - <stretch goal> handle cases where students have taken more than one program (hand in hand with equivalencies)
         - <stretch goal> handle differing grading modes i.e. Aviation Management(B pass) vs Social Worker(C pass) vs Computer Programmer(D pass) 
         - <stretch goal> get input for course requirements and evaluate based on that i.e. different required numbers of electives
         - <stretch goal> allow user to enter either letter grade or percent grade instead of requiring only percent
        */

        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_Setup-_-_-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

        //declare fields to recieve input
        private Transcript input_Transcript;
        private List<DataGridView> semesterPages;


        private List<string> outputSummaryItems;//the summary of calculation results
        private bool isInputValid;//flag to turn on/off the calculate button based on input validity

        //to hold the user input values that control calculations
        private double targetGPA;
        private double increment;

        //to control the status strip
        private Timer delay = new Timer();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            //Initialize fields to recieve input
            input_Transcript = new Transcript();
            semesterPages = new List<DataGridView>() { grdDisplay_Sem_1,grd_Display_Sem2,
                                                       grd_Display_Sem3, grd_Display_Sem4 };
            isInputValid = false;
            lblWarning.Text = "Please enter data, then press \"Validate Input\"";
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
                            cell.Style.BackColor = Color.Salmon;
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
                            cell.Style.BackColor = Color.Salmon;
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
                            cell.Style.BackColor = Color.Salmon;
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
                                cell.Style.BackColor = Color.Salmon;
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
                                cell.Style.BackColor = Color.Salmon;
                                cell.Selected = false;
                            }
                            //return control to user, but invalidate calculate button
                            isValid = false;
                            return isValid;
                        }
                    }

                    //If we get past all validation, start autofill
                    //set all incomplete courses to -1, I, and not completed
                    if ((string)semesterGrid.Rows[currentRow].Cells[2].Value == null)
                    {
                        semesterGrid.Rows[currentRow].Cells[2].Value = "-1";
                        semesterGrid.Rows[currentRow].Cells[3].Value = "I";
                        semesterGrid.Rows[currentRow].Cells[4].Value = "Incomplete";
                    }
                    else
                    {
                        semesterGrid.Rows[currentRow].Cells[3].Value = 
                            Course.CalcLetterGrade(Double.Parse((string)semesterGrid.Rows[currentRow].Cells[2].Value));
                        if (double.Parse((string)semesterGrid.Rows[currentRow].Cells[2].Value) == -1)
                        {
                            semesterGrid.Rows[currentRow].Cells[4].Value = "Incomplete";
                        }
                        else
                        {
                            semesterGrid.Rows[currentRow].Cells[4].Value = "Complete";
                        }
                    }
                }
            }
            return isValid;
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

        private string[] GenDisplayRow(Course toDisplay)
        {//createsfrom a Course object a set of strings for consumption in the grid
            string[] line = new string[4];

            line[0] = toDisplay.Code;
            line[1] = toDisplay.CreditHours.ToString();
            line[2] = "%" + toDisplay.PercentGrade.ToString();
            line[3] = toDisplay.LetterGrade.ToString();

            return line;
        }

        public string[] CalcOutcome_Formbound(Transcript incomplete, double targetGPA, double increment)
        {
            //create a transcript to operate on, and print the original to file
            Transcript.PrintTranscript(incomplete, "../test/" + incomplete.Header[5] + "/original.txt");
            Transcript current = new Transcript(incomplete);
            
            //create an object to catch the output summary
            string[] summary = new string[4];

            //save the starting cumulative GPA in output summary
            summary[2] = current.CumulativeGPA.ToString("F2");

            //save the path for the output folder
            summary[3] = "bin/test/" + current.Header[5] + "/";

            //tracking variable (number of *different* Transcripts tested)
            int numEx = 1;
            double lastPrinted = 0.0;

            //set each course at -1 (incomplete) to [%50 / D / recalc QPs]
            for (int i = 0; i < current.CourseList.Count; i++)
            {
                if (current.CourseList[i].PercentGrade == -1) { current.CourseList[i].PercentGrade = 50.0; }
            }
            //recalculate cumulative GPA
            current.CumulativeGPA = Transcript.CalcCumuGPA(current.CourseList);

            //-Initial Checks-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
            //***If GPA meets the target, print it out and save that as the minimum  
            //(means that existing grades are high enough to pass with all 50s) 

            if (current.CumulativeGPA >= targetGPA)
            {
                Console.WriteLine("Congrats, your existing marks are high enough to reach your goal with " +
                    "minimum passing marks in all remaining courses");
                Transcript.PrintTranscript(current, "../test/" + current.Header[5] + "/Calculated_minimum.txt");
                summary[0] = current.CumulativeGPA.ToString("F2");
            }
            else if (Transcript.TestGraduating(current))
            {
                //If the transcript graduates but does not meet the target, 
                //print it to file and set the lastPrinted tracker
                Transcript.PrintTranscript(current, "../test/" + current.Header[5] + "/minimum.txt");
                lastPrinted = current.CumulativeGPA;
                summary[0] = current.CumulativeGPA.ToString("F2");
            }

            // if not at the target, loop until meeting requirements
            while ((current.CumulativeGPA < targetGPA) && (!current.TestMaxChecked()))
            {
                //loop over all courses
                for (int i = 0; i < current.CourseList.Count; i++)
                {
                    //ignore courses that are marked as completed (TODO deal with scenario where courses need to be repeated)
                    if (!current.CourseList[i].Completed)
                    {
                        //increment one course by one letter grade
                        current.CourseList[i].PercentGrade += 10.0;

                        // recalculate and check the gpa. if meeting the target, print to file and return
                        current.CumulativeGPA = Transcript.CalcCumuGPA(current.CourseList);
                        if (current.CumulativeGPA >= targetGPA)
                        {
                            Transcript.PrintTranscript(current, "../test/" + current.Header[5] + "/target.txt");
                        }
                        //otherwise, check if it graduates and surpasses the last printed by at least .10
                        //if it does, print to file and continue checks
                        else if ((Transcript.TestGraduating(current)) && (current.CumulativeGPA >= (lastPrinted + increment)))
                        {
                            Transcript.PrintTranscript(current, "../test/" + current.Header[5] + "/Calculated_" + numEx++ + ".txt");
                            lastPrinted += increment;
                        }
                    }
                }
            }
            Transcript.PrintTranscript(current, "../test/" + current.Header[5] + "/final.txt");
            summary[1] = current.CumulativeGPA.ToString("F2");

            //-ShutDown-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
            //record number of attempts
            Console.WriteLine(numEx + " cases tested");

            return summary;

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
            if (isInputValid)
            {
                //Calculate 
                outputSummaryItems = new List<string>(CalcOutcome_Formbound(input_Transcript, targetGPA, increment));

                //Construct and Show output summary in new form
                frmOutput outputSummary = new frmOutput(outputSummaryItems[0], outputSummaryItems[1],
                                                    outputSummaryItems[2], outputSummaryItems[3]);
                outputSummary.Show();
            }
            else
            {
                lblWarning.Text = "Please use the Validate Form button to ensure that all inputs are acceptable.";
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
            //clear the semester list in case they punch the button more than once in a split second - was getting duplicate inputs from this 
            input_Transcript.Semesters.Clear();
            lblWarning.Text = String.Empty;
            if (ValidateSemesters(semesterPages) && ValidateOtherInputs())
            {
                foreach (DataGridView semesterPage in semesterPages)
                {//Get the semesters from the datagrids and put them in the transcript
                    AddSemesterToTranscript(semesterPage);
                }

                input_Transcript.CourseList = Transcript.SetupCourseList(input_Transcript.Semesters);
                isInputValid = true;
                lblWarning.Text = "No Warnings";
            }
        }
        
        //ValueChanged events are needed to save changes without needing a user generated event (i.e. save button), 
        //and ollow the user to jump around without losing data. They are doubly useful to detect changes and require the user to validate (autofill)
        //the form every time they make a change
        private void grd_Display_Sem1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            grdDisplay_Sem_1.EndEdit();
            isInputValid = false;
        }

        private void grd_Display_Sem2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            grd_Display_Sem2.EndEdit();
            isInputValid = false;
        }

        private void grd_Display_Sem3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            grd_Display_Sem3.EndEdit();
            isInputValid = false;
        }

        private void grd_Display_Sem4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            grd_Display_Sem4.EndEdit();
            isInputValid = false;
        }

        private void txtTargetGPA_TextChanged(object sender, EventArgs e)
        {
            isInputValid = false;
        }
   
        private void txtIncrement_TextChanged(object sender, EventArgs e)
        {
            isInputValid = false;
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
    }
}
