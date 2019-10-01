using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPA_Calculator_2;
using System.Windows.Forms;

/*GPA Form revision 1
 Sam Turcotte
 CP-350 Crit Thinking II
 Major assignment 1
 */

/*TODO LIST
 1. >>btnRemoveCourse_Click - add code to remove data, not just hide the fields
 
2. >>btnRecordSemester_Click - add code to handle blank course codes 
(auto generate based on position in input list + semesters.Count)

3. 

 END TODO LIST*/

namespace GPA_Calculator_UI
{
    public partial class Input_Display : Form
    {
        //-_Setup/Fields-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        
        //constants
        const int NUM_COURSE_FIELDS = 10;

        //private fields
        private int numCourseFieldsShown;
        private TextBox[] courseCodeFields;
        private TextBox[] creditHourFields;
        private TextBox[] gradeFields;

        //To hold user input
        private Transcript input_Transcript;

        public Input_Display()
        {
            InitializeComponent();
        }

        //-_End Setup/Fields-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_Initializaion-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        private void Form1_Load(object sender, EventArgs e)
        {
            ////The form is complicated, so at startup, prompt the user to look at instructions
            //MessageBox.Show("Thank you for using the Robust GPA calculator. " +
            //    "Before proceeding, please refer to the user guide in the main " +
            //    "menu under Help >> Instructions.");

            //initialize member for input collection
            input_Transcript = new Transcript();

            //initialize members for visibility control
            numCourseFieldsShown = 0;
            courseCodeFields = new TextBox[NUM_COURSE_FIELDS];
            creditHourFields = new TextBox[NUM_COURSE_FIELDS];
            gradeFields = new TextBox[NUM_COURSE_FIELDS];

            //populate lists for visibility control
            PopulateVisibilityLists();
        }
        
        //-_End Initialization-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_Event Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

        /// <summary>
        /// Adds another row of fields to the form, allowing the user to 
        /// input additional courses. Current limit is 10.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (numCourseFieldsShown < (NUM_COURSE_FIELDS - 1))
            {
                numCourseFieldsShown += 1;
                courseCodeFields[numCourseFieldsShown].Show();
                creditHourFields[numCourseFieldsShown].Show();
                gradeFields[numCourseFieldsShown].Show();
            }
        }

        /// <summary>
        /// Hides the fields at the end of the list. 
        /// TODO removes any data that might have been entered from the current semester
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            if (numCourseFieldsShown > 0)
            {
                courseCodeFields[numCourseFieldsShown].Hide();
                creditHourFields[numCourseFieldsShown].Hide();
                gradeFields[numCourseFieldsShown].Hide();
                numCourseFieldsShown -= 1;
            }

            //TODO 1 : Add code that removes courses from the currently tracked semester to handle cases 
            //where user is editing a semester that has already been added. 
        }
        
        /// <summary>
        /// Adds the current data in the input section of the form into a new semester in the input Transcript
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecordSemester_Click(object sender, EventArgs e)
        {
            Semester toInput = new Semester();
            double credHr;
            double grd;

            for (int i = 0; i < numCourseFieldsShown; i++)
            {
                //set courses with no grade recorded to -1 to set course as 'Incomplete'
                if (gradeFields[i].Text == null || gradeFields[i].Text == " ")
                {
                    gradeFields[i].Text = "-1";
                }

                //only add the semester if the input is readable (type check)
                //between this check and previous line, allow for grades and/or course codes to be left blank,
                //but require credit hours to be filled in (this is the very minimum information needed)
                if (double.TryParse(creditHourFields[i].Text, out credHr) && 
                    double.TryParse(gradeFields[i].Text, out grd))
                {
                    //TODO 2: handle blank inputs for course codes
                    toInput.Courses.Add(new Course(courseCodeFields[i].Text,
                                      double.Parse(creditHourFields[i].Text),
                                      double.Parse(gradeFields[i].Text)));
                }
            }

            if (toInput.Courses.Count != 0)
            {
                input_Transcript.Semesters.Add(toInput);
                UpdateSemesterListbox();
            }
        }

        /// <summary>
        /// Update the Course List display whenever the selected semester in the semeseter list changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxSemesters_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbxDisplayCourses.Items.Clear();

            ////loop through the appropriate semester's course list
            //foreach (Course course in input_Transcript.Semesters[lbxSemesters.SelectedIndex].Courses)
            //{
            //    lbxDisplayCourses.Items.Add(PrintCourseToListbox(course));
            //}

            grdDisplayCourses.Rows.Clear();

            foreach (Course course in input_Transcript.Semesters[lbxSemesters.SelectedIndex].Courses)
            {
                string[] currentRow = { course.Code, course.CreditHours.ToString(), course.PercentGrade.ToString(), course.LetterGrade.ToString() };

                grdDisplayCourses.Rows.Add(currentRow);
            }

        }

        //Exit program
        private void mnuMainFileQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-_End Event Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_Internal Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_


        /// <summary>
        /// prepares a string for display in the Courses listbox
        /// </summary>
        /// <param name="toPrint"></param>
        /// <returns></returns>
        private string PrintCourseToListbox(Course toPrint)
        {
            string line = String.Format("{0,-8}       |       {1,-8}       |       {2,-8}       |      {3,-8}",
                toPrint.Code, toPrint.CreditHours, toPrint.PercentGrade, toPrint.LetterGrade);
            return line;
        }


        /// <summary>
        /// Updates the semester list (list box control) according to the current state of the input transcript
        /// </summary>
        void UpdateSemesterListbox()
        {
            lbxSemesters.Items.Clear();
            for (int i = 0; i < input_Transcript.Semesters.Count; i++)
            {
                lbxSemesters.Items.Add("Semester "+ (i+1) );
            }
        }
        
        /// <summary>
        /// Entirely dependant on this form
        /// gets the controls from the form and puts them into arrays for easy access
        /// </summary>
        void PopulateVisibilityLists()
        {
            courseCodeFields[0] = txtCode_C1;
            courseCodeFields[1] = txtCode_C2;
            courseCodeFields[2] = txtCode_C3;
            courseCodeFields[3] = txtCode_C4;
            courseCodeFields[4] = txtCode_C5;
            courseCodeFields[5] = txtCode_C6;
            courseCodeFields[6] = txtCode_C7;
            courseCodeFields[7] = txtCode_C8;
            courseCodeFields[8] = txtCode_C9;
            courseCodeFields[9] = txtCode_C10;

            creditHourFields[0] = txtHours_C1;
            creditHourFields[1] = txtHours_C2;
            creditHourFields[2] = txtHours_C3;
            creditHourFields[3] = txtHours_C4;
            creditHourFields[4] = txtHours_C5;
            creditHourFields[5] = txtHours_C6;
            creditHourFields[6] = txtHours_C7;
            creditHourFields[7] = txtHours_C8;
            creditHourFields[8] = txtHours_C9;
            creditHourFields[9] = txtHours_C10;

            gradeFields[0] = txtGrade_C1;
            gradeFields[1] = txtGrade_C2;
            gradeFields[2] = txtGrade_C3;
            gradeFields[3] = txtGrade_C4;
            gradeFields[4] = txtGrade_C5;
            gradeFields[5] = txtGrade_C6;
            gradeFields[6] = txtGrade_C7;
            gradeFields[7] = txtGrade_C8;
            gradeFields[8] = txtGrade_C9;
            gradeFields[9] = txtGrade_C10;
        }
    }
}
