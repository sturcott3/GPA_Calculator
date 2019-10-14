using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GPA_Calculator_2;

namespace GPA_Calculator_UI_2
{
    public partial class Display : Form
    {
        private ListBox currentListBox;

        private DataGridView currentGrid;

        string[] defaultTargetMessage;
        string[] defaultMinimumMessage;

        public Display()
        {
            InitializeComponent();

            //Set default display messages for the two windows that don't always get output,
            //so that if nothing is calculated, it will give the user a hint as to why

            defaultTargetMessage = new string[] {
                "No Scenario was calculated for the current target. ",
                "This is usually because the entered grades are too low to reach the target without repeating courses.",
                "Please refer to the \"Highest Possible\" tab for details.",
                "",
                "***Coming soon: option to determine which courses to repeat.***"};

            defaultMinimumMessage = new string[] {
                "No Graduating scenario possible. This is because either the highest achievable GPA is below 2.0, or",
                "a course has been recorded as an F, but is not repeated.",
                "Show a course as repeated by entering it again on a separate line with (exactly) the same course code and credit hours.",
                "If the repeat of the course is incomplete, leave the grade field blank as normal."};

            foreach (string line in defaultTargetMessage)
            {
                lbxSummaryTarget.Items.Add(line);
            }

            foreach (string line in defaultMinimumMessage)
            {
                lbxSummaryMinimum.Items.Add(line);
            }
        }

        public void SetDisplayPage(TabType tabType, Transcript toDisplay, List<string> summary)
        {
            switch (tabType)
            {
                case TabType.Original:
                    currentListBox = lbxSummaryOriginal;
                    currentGrid = grdDisplay_Original;
                    SetupDisplayTarget(toDisplay, summary);
                    break;

                case TabType.Minimum:
                    currentListBox = lbxSummaryMinimum;
                    currentGrid = grdDisplayMinimum;
                    SetupDisplayTarget(toDisplay, summary);
                    break;

                case TabType.Target:
                    currentListBox = lbxSummaryTarget;
                    currentGrid = grdDisplayTarget;
                    SetupDisplayTarget(toDisplay, summary);
                    break;

                case TabType.Maximum:
                    currentListBox = lbxSummaryHighest;
                    currentGrid = grdDisplayMaximum;
                    SetupDisplayTarget(toDisplay, summary);
                    break;
            }
        }

        void SetupDisplayTarget(Transcript toDisplay, List<string> summary)
        {
            string[] rowValues;
            currentListBox.Items.Clear();
            
            foreach (string line in summary)
            {
                currentListBox.Items.Add(line);
            }

            foreach (Semester currentSemester in toDisplay.Semesters)
            {
                foreach (Course currentCourse in currentSemester.Courses)
                {
                    rowValues = new string[6];
                    rowValues[0] =  currentCourse.Code;
                    rowValues[1] =  currentCourse.CreditHours.ToString("F2");
                    rowValues[2] =  currentCourse.PercentGrade.ToString("F2");
                    rowValues[3] =  currentCourse.LetterGrade.ToString();
                    rowValues[4] =  currentCourse.Completed? "Complete" : "Incomplete";
                    rowValues[5] =  currentCourse.Included;
                    currentGrid.Rows.Add(rowValues);
                }
                //blank line in the grid
                currentGrid.Rows.Add();
            }

            foreach (DataGridViewRow row in currentGrid.Rows)
            {
                Color color = DetermineRowColor(row);

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Selected = false;
                    cell.Style.BackColor = color;
                }
            }
        }

        private Color DetermineRowColor(DataGridViewRow current)
        {
            Color result = new Color();

            //Excluded courses
            if ((string)current.Cells[5].Value == "EXCLUDED")
            {
                result = Transcript.ShadeExclude;
            }

            //Failing Course, Stops transcript from passing
            else if ((string)current.Cells[5].Value == "INCLUDED" &&
                (string)current.Cells[3].Value == "F")
            {
                result = Transcript.ShadeFail;
            }

            //Incomplete (generated) courses
            else if ((string)current.Cells[5].Value == "INCLUDED" &&
                (string)current.Cells[4].Value == "Incomplete")
            {
                result = Transcript.ShadeIncomplete;
            }

            //completed passing courses
            else if ((string)current.Cells[5].Value == "INCLUDED" &&
                (string)current.Cells[4].Value == "Complete")
            {

                result = Transcript.Shadepass;
            }

            return result;
        }
    }

    public enum TabType
    {
        Original = 0,
        Minimum = 1,
        Target = 2,
        Maximum = 3
    }
}
