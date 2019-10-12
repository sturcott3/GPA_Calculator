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
    public class Semester
    {
        //-_-_Properties-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public List<Course> Courses { get; set; }
        public double SemesterGPA { get; set; }
        public bool Completed { get; set; }

        //-_-_End Properties-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_Constructors-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public Semester()
        {//To initialize empty
            Courses = new List<Course>();
            SemesterGPA = -1.0;//sentinel means incomplete
            Completed = false;
        }

        public Semester(List<Course> courses)
        {//To initialize from existing sets of Data from TestData.cs. passes up to Transcript.
            Courses = new List<Course>(courses);
            Completed = TestSemesterCompleted(this);

            if (this.Completed)
            {
                this.SemesterGPA = CalcGPA(Courses);
            }
        }

        public Semester(Semester other)
        {//to initialize from an incomplete transcript
            Courses = new List<Course>(other.Courses);
            Completed = other.Completed;
            SemesterGPA = CalcGPA(Courses);
        }

        //-_-_End Constructors-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public static double CalcGPA(List<Course> courses)
        {
            double GPA = 0.0;
            double creditHouraccumulator = 0;
            double qualityPointAccumulator = 0;

            foreach (Course course in courses)
            {
                if (course.PercentGrade != -1)//only consider completed courses
                { 
                creditHouraccumulator += course.CreditHours;
                qualityPointAccumulator += course.QualityPoints;
                }
            }

            GPA = qualityPointAccumulator / creditHouraccumulator;

            return GPA;
        }

        public static bool TestSemesterCompleted(Semester semester)
        {//may need this outside
            bool isComplete = true;

            foreach (Course course in semester.Courses)
            {
                if (!course.Completed)
                {
                    isComplete = false;
                }
            }
            return isComplete;
        }

        //-_-_End Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

    }
}
