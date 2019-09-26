using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Major Assignment 1
 CP-350: Critical Thinking II
 Prof. Troy Mangatal
 Developed by Samuel Turcotte
 2019-09-23*/
namespace GPA_Calculator_2
{
    class Course
    {
        //-_-_Properties-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public string Code { get; set; }
        public double CreditHours { get; set; }
        public bool Completed { get; set; }
        public char LetterGrade { get; set; }
        public double QualityPoints { get; set; }

        //using the property notation to force update the letter grade whenever the percent grade is changed
        private double percentGrade;
        public double PercentGrade {
            get => percentGrade;
            set {percentGrade = value;
                 LetterGrade = CalcLetterGrade(percentGrade);} }

        //-_-_End Properties-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_Constructors-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public Course(string courseCode, double creditHours, double percentGrade)
        {
            Code = courseCode;
            CreditHours = creditHours;
            PercentGrade = percentGrade;

            Completed = (percentGrade == -1)? false: true;


            QualityPoints = CalcQualityPoints(creditHours, LetterGrade);
           
        }

        //-_-_End Constructors-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        static char CalcLetterGrade(double percentGrade)
        {//determine letter grade from percent grade
            char letterGrade;

            if (percentGrade < 50.0)
            {//fail
                letterGrade = 'F';
            }
            else if (percentGrade >= 50.0 && percentGrade < 60.0)
            {//minimum passing
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

        static double CalcQualityPoints(double creditHours, char letterGrade)
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
                //default:
                //    qualityPoints = -1;
                //    break;
            }
            return qualityPoints;
        }       
        //-_-_End Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

    }
}
