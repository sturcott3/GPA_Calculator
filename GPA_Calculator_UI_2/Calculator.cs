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
        /*TODO LIST
         1. Add form with instructions
         2. Make input Validation more robust
         3. Create Output form, send Basic outputs to it
         4. 

             */

        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_Setup-_-_-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        
            //declare fields to recieve input
        Transcript input_Transcript;
        List<DataGridView> semesterPages;

        string[] outputSummaryItems;

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
            outputSummaryItems = new string[4];

        }
        
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_Non-Event Methods_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        private bool ValidateSemester(List<DataGridView> semesters)
        {//determine whether the inputs given on the currently displayed semester are valid
         //must handle both complete and Incomplete courses/semesters
         
            bool isValid = true;

            foreach (DataGridView semester in semesters)
            {

                //Handle the case where they switch to another semester without entering anything
                if ((string)semester.Rows[0].Cells[0].Value == null)
                {
                    isValid = false;
                    MessageBox.Show("Empty Semester cannot be read");
                }

                //Check each line for minimum input (avoiding the blank line at the end with Count-1)
                for (int i = 0; i < (semester.Rows.Count - 1); i++)
                {
                    if ((string)semester.Rows[i].Cells[0].Value == null ||
                        (string)semester.Rows[i].Cells[1].Value == null)
                    {
                        MessageBox.Show("Missing a required input. Each course must have at least " +
                            "Course Code and Credit Hours filled out. To show a course as incomplete, leave " +
                            "only the Grade(%) field blank");
                        isValid = false;
                        return isValid;
                    }

                    if ((string)semester.Rows[i].Cells[2].Value == null)
                    {
                        semester.Rows[i].Cells[2].Value = "-1";
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

        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_Event Methods_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

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
            //Calculate 


            //Construct and Show output summary in new form
            frmOutput outputSummary = new frmOutput(outputSummaryItems[0],outputSummaryItems[1], 
                                                outputSummaryItems[2], outputSummaryItems[3]);
            outputSummary.Show();
           
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
                tbConSemesters.TabPages.RemoveAt(tbConSemesters.SelectedIndex);
                //remove from list
            }            
        }


        private void btnTestInput_Click(object sender, EventArgs e)
        {
            //clear the semester list in case they puch the button more than once 
            input_Transcript.Semesters.Clear();

            if (ValidateSemester(semesterPages))
            {
                foreach (DataGridView semesterPage in semesterPages)
                {//Get the semesters from the datagrids and put them in the transcript
                    AddSemesterToTranscript(semesterPage);
                }
            }
            //print the transcript to file as 'original'
            Transcript.PrintTranscript(input_Transcript, "./UITESTING/original.txt");
        }


        //below events are required to allow me to read data from the cells of the dataGridViews 
        //without the user pressing a button to save their changes
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
