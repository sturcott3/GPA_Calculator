﻿using System;
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

        public char letterGrade { get; set; }

        public double qualityPoints { get; set; }

        public Course( string courseCode, double creditHours, double percentGrade)
        {
            this.courseCode = courseCode;
            this.creditHours = creditHours;
            this.percentGrade = percentGrade;

            this.letterGrade = determineLetterGrade(percentGrade);
            this.qualityPoints = determineQualityPoints(this.creditHours, this.letterGrade);
        }

        public char determineLetterGrade(double percentGrade)
        {
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

        private double determineQualityPoints(double creditHours, char letterGrade)
        {
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
    }
}
