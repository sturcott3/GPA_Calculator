using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_initial
{
    class Transcript
    {
        public List<Semester> semesters { get; set; }

        public double cumulativeGPA { get; set; }

        public Transcript(List<Semester> semesters)
        {
            this.semesters = semesters;

            this.cumulativeGPA = calculateCumulativeGPA(this.semesters);
        }

        public Transcript()
        {
            this.semesters = new List<Semester> { new Semester() };
        }

        private double calculateCumulativeGPA(List<Semester> semesters)
        {
            double cumulativeGPA = 0;
            double creditHouraccumulator = 0;
            double qualityPointAccumulator = 0;

            foreach (Semester singleSemester in semesters)
            {
                foreach (Course singleCourse in singleSemester.courses)
                {
                    creditHouraccumulator += singleCourse.creditHours;
                    qualityPointAccumulator += singleCourse.qualityPoints;
                }
            }

            cumulativeGPA = qualityPointAccumulator / creditHouraccumulator;

            return cumulativeGPA;

        }

        public Transcript calculateMinimumGrades(Transcript incompleteTranscript)
        {
            Transcript completeTranscript = new Transcript(new List<Semester>());

            return completeTranscript;
        }

    }
}
