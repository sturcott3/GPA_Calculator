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
    public partial class OutputForm : Form
    {
        private Label targetLabel;

        private DataGridView targetGrid;


        public OutputForm()
        {
            InitializeComponent();
        }

        public void SetDisplayPage(TabType tabType, Transcript toDisplay, string[] summary)
        {
            switch (tabType)
            {
                case TabType.Original:
                    targetLabel = lblSummaryOriginal;
                    targetGrid = grdDisplay_Original;
                    SetupDisplayTarget(toDisplay, summary);
                    break;

                case TabType.Minimum:
                    targetLabel = lblSummaryMinimum;
                    targetGrid = grdDisplayMinimum;
                    SetupDisplayTarget(toDisplay, summary);
                    break;

                case TabType.Target:
                    targetLabel = lblSummaryTarget;
                    targetGrid = grdDisplayTarget;
                    SetupDisplayTarget(toDisplay, summary);
                    break;

                case TabType.Maximum:
                    targetLabel = lblSummaryMaximum;
                    targetGrid = grdDisplayMaximum;
                    SetupDisplayTarget(toDisplay, summary);
                    break;
            }
        }

        void SetupDisplayTarget(Transcript toDisplay, string[] summary)
        {
            string[] rowValues;
            targetLabel.Text = String.Empty;
            
            foreach (string line in summary)
            {
                targetLabel.Text += line + "\n";
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
                    targetGrid.Rows.Add(rowValues);
                }
                //blank line in the grid
                targetGrid.Rows.Add();
            }

            foreach (DataGridViewRow row in targetGrid.Rows)
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
                result = Color.Tan;
            }

            //Failing Course, Stops transcript from passing
            else if ((string)current.Cells[5].Value == "INCLUDED" &&
                (string)current.Cells[3].Value == "F")
            {
                result = Color.Salmon;
            }

            //Incomplete (generated) courses
            else if ((string)current.Cells[5].Value == "INCLUDED" &&
                (string)current.Cells[4].Value == "Incomplete")
            {
                result = Color.CornflowerBlue;
            }

            //completed passing courses
            else if ((string)current.Cells[5].Value == "INCLUDED" &&
                (string)current.Cells[4].Value == "Complete")
            {

                result = Color.LightSeaGreen;
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
