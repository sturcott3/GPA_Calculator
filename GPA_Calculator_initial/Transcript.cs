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

        private static double calculateCumulativeGPA(List<Semester> semesters)
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

        //calculate a single complete transcript from an incomplete one, with minimum passing grades 
        public static Transcript calculateMinimumGrades(Transcript incompleteTranscript)
        {
            Transcript completeTranscript = new Transcript(new List<Semester>());

            for (int i = 0; i < incompleteTranscript.semesters.Count; i++)
            {
                if (incompleteTranscript.semesters[i].isComplete)
                {//if the semester is complete, add it to the working complete transcript
                    completeTranscript.semesters.Add(new Semester(incompleteTranscript.semesters[i]));
                }
                else
                {//set all the grades in incomplete courses to %50 (the minimum required to pass a single course
                    completeTranscript.semesters.Add(new Semester(incompleteTranscript.semesters[i]));
                    foreach (Course course in completeTranscript.semesters[i].courses)
                    {
                        if (!course.isComplete)
                        {
                            course.percentGrade = 50.0;
                        }
                    }
                }
            }
            return completeTranscript;
        }


        //test a single transcript to see whether it is eligible for graduation
        public static bool TestIsGraduating(Transcript transcript)
        {
            //start with flag set to passing
            bool isPassing = true;

            //check that each course has a passing grade
            foreach (Semester singleSemester in transcript.semesters)
            {
                foreach (Course singleCourse in singleSemester.courses)
                {
                    if (singleCourse.percentGrade < 50)
                    {
                        isPassing = false;
                    }
                }
            }

            //check that cumulative GPA is acceptable
            if (calculateCumulativeGPA(transcript.semesters) < 2.0 )
            {
                isPassing = false;
            }

            //If we get past all checks without setting to false, the transcript passes
            return isPassing;
        }

    }
}
