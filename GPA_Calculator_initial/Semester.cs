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

        public Semester(List<Course> courses)
        {
            this.courses = courses;
            this.semesterGPA = calculateSemesterGPA(this.courses);
        }

        public Semester()
        {
            this.courses = new List<Course>();
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

    }
}
