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

        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_Setup-_-_-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        
            //declare fields to recieve input
        Transcript input_Transcript;

        //to track which semester is currently being worked on/displayed
        int displaySemester;
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            //Initialize fields to recieve input
            input_Transcript = new Transcript();

            input_Transcript.Semesters.Add(new Semester());
            
            displaySemester = 0;
        }
        
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_Non-Event Methods_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        private bool ValidateSemester()
        {//determine whether the inputs given on the currently displayed semester are valid
         //must handle both complete and Incomplete courses/semesters
         
            bool isValid = true;

            if ((string)grdCourseDisplay.Rows[0].Cells[0].Value == string.Empty)
            {
                isValid = false;
            }

            return isValid;
        }

        private void AddSemesterToTranscript()
        {// should only be called directly after ValidateSemester() returns true

            //create a new course list
            List<Course> tempCourseList = new List<Course>();
            string[] row = new string[5];

            //iterate over each row in the grid, adding a new course to the Semester for each row. 
            for (int i = 0; i < grdCourseDisplay.Rows.Count; i++)
            {
                row[0] = (string)grdCourseDisplay.Rows[i].Cells[0].Value;
                row[1] = (string)grdCourseDisplay.Rows[i].Cells[1].Value;
                row[2] = (string)grdCourseDisplay.Rows[i].Cells[2].Value;
                //row[3] = Convert.ToString(grdCourseDisplay.Rows[i].Cells[3].Value);

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

        private void CalculateOutput()
        {
            Transcript.PrintTranscript(input_Transcript, "./UITESTING/testOutput.txt");
        }

        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_Event Methods_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
        private void lbxSemesters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Check the currently displayed semester for validity. 
            //if (ValidateSemester())
            //{
            //    //If valid, write it to the input transcript,
            //    AddSemesterToTranscript();
                 
            //    //change where we are looking,
            //    displaySemester = lbxSemesters.SelectedIndex;

            //    //clear the grid of the old semester
            //    grdCourseDisplay.Rows.Clear();

            //    //then display the newly selected semester
            //    foreach (Course course in input_Transcript.Semesters[displaySemester].Courses)
            //    {
            //        grdCourseDisplay.Rows.Add(GenDisplayRow(course));
            //    }
            //}
            //else
            //{
            //    //prompt user to complete input, and re-select the appropriate semester in the listbox
            //}
        }


        private void btnAddSemester_Click(object sender, EventArgs e)
        {
            //Check the currently displayed semester for validity. 
            if (ValidateSemester())
            {
                //If valid, write it to the input transcript, 
                AddSemesterToTranscript();

                //then add the new semester to the semesters listbox
                lbxSemesters.Items.Add("Semester " + input_Transcript.Semesters.Count.ToString());
                
                //then display the newly added blank semester

            }
            else
            {
                //prompt user to complete input
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Check the currently displayed semester for validity. 
            if (ValidateSemester())
            {
                AddSemesterToTranscript();
                //If valid, write it to the input transcript, then calculate output
                CalculateOutput();
            }
            else
            {
                //prompt user to complete input
            }
        }

        private void grdCourseDisplay_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {//this is required to allow me to read data from the cells of the dataGridView without the user 
            //needing to press a button to save their changes
            grdCourseDisplay.EndEdit();
        }
    }
}
