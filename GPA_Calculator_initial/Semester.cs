using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_initial
{
    class Semester
    {
        public List<Course> courses { get; set; }
        public double semesterGPA { get; set; }        
        public bool isComplete { get; set; }

        public Semester(List<Course> courses)
        {//to initialize from a complete data set (from hardcode, file, or form inputs)
            this.courses = courses;
            this.isComplete = TestIfComplete(this);

            if (this.isComplete)
            {
                this.semesterGPA = calculateSemesterGPA(this.courses);
            }
        }

        public Semester()
        {//To initialize empty
            this.courses = new List<Course>();
        }

        public Semester(Semester other)
        {//to initialize from an incomplete transcript
            this.courses = other.courses;
            this.isComplete = TestIfComplete(this);
        }

        public double calculateSemesterGPA(List<Course> courses)
        {
            double GPA = 0.0;
            double creditHouraccumulator = 0;
            double qualityPointAccumulator = 0;

            foreach (Course course in courses)
            {
                creditHouraccumulator += course.creditHours;
                qualityPointAccumulator += course.qualityPoints;
            }

            GPA = qualityPointAccumulator / creditHouraccumulator;

            return GPA;
        }

        public static bool TestIfComplete(Semester semester)
        {
            bool isComplete = true;

            foreach (Course course in semester.courses)
            {
                if (!course.isComplete)
                {
                    isComplete = false;
                }
            }

            return isComplete;
        }
    }
}
