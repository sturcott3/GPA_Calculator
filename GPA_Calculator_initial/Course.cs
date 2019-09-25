using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_initial
{
    class Course
    {
        public string courseCode { get; set; }

        public double creditHours { get; set; }

        public double percentGrade { get; set; }

        public bool isComplete { get; set; }

        public char letterGrade { get; set; }

        public double qualityPoints { get; set; }

        /// <summary>
        /// Data structure to hold info about a single course. Self-determines letter grade from percent grade,
        /// Quality points from letter grade and credit hours,
        /// and incomplete status from the value [-1] in percent grade. 
        /// </summary>
        /// <param name="courseCode">ID of course</param>
        /// <param name="creditHours">the number of credit hours the course is worth</param>
        /// <param name="percentGrade">the final grade achieved in the course. [-1] means incomplete</param>
        public Course( string courseCode, double creditHours, double percentGrade)
        {
            this.courseCode = courseCode;
            this.creditHours = creditHours;
            this.percentGrade = percentGrade;

            this.isComplete = TestIfCourseCompleted(this);

            if (this.isComplete)
            {
                this.letterGrade = determineLetterGrade(percentGrade);
                this.qualityPoints = determineQualityPoints(this.creditHours, this.letterGrade);
            }
        }
               
        public static char determineLetterGrade(double percentGrade)
        {//determine letter grade from percent grade
            char letterGrade;

            if (percentGrade < 50.0)
            {
                letterGrade = 'F';
            }
            else if (percentGrade >= 50.0 && percentGrade < 60.0)
            {
                letterGrade = 'D';
            }
            else if (percentGrade >= 60.0 && percentGrade < 70)
            {
                letterGrade = 'C';
            }
            else if (percentGrade >= 70.0 && percentGrade < 80)
            {
                letterGrade = 'B';
            }
            else
            {
                letterGrade = 'A';
            }

            return letterGrade;
        }

        private static double determineQualityPoints(double creditHours, char letterGrade)
        {//determine QPs from credit hours and letter grade
            double qualityPoints = 0;

            switch (letterGrade)
            {
                case 'A':
                    qualityPoints = creditHours * 4.0;
                    break;
                case 'B':
                    qualityPoints = creditHours * 3.0;
                    break;
                case 'C':
                    qualityPoints = creditHours * 2.0;
                    break;
                case 'D':
                    qualityPoints = creditHours * 1.0;
                    break;
                case 'F':
                    qualityPoints = 0.0;
                    break;
            }

            return qualityPoints;
        }

        public static bool TestIfCourseCompleted(Course course)
        {//determine complete/incomplete status. may need to acces this outside
            bool isComplete = true;

                if (course.percentGrade == -1)
                {
                    isComplete = false;
                }

            return isComplete;
        }
    }
}
