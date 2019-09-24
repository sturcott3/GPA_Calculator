﻿using System;
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

        public string header { get; set; }

        public Transcript(List<Semester> semesters)
        {
            this.semesters = new List<Semester>(semesters);

            this.cumulativeGPA = calculateCumulativeGPA(this.semesters);
        }

        public Transcript(Transcript other)
        {
            this.semesters = new List<Semester>(other.semesters);

            this.cumulativeGPA = calculateCumulativeGPA(this.semesters);
        }


        private static double calculateCumulativeGPA(List<Semester> semesters)
        {
            double cumulativeGPA = 0;
            double creditHouraccumulator = 0;
            double qualityPointAccumulator = 0;

            foreach (Semester singleSemester in semesters)
            {
                if (singleSemester.isComplete)
                {
                    foreach (Course singleCourse in singleSemester.courses)
                    {
                        creditHouraccumulator += singleCourse.creditHours;
                        qualityPointAccumulator += singleCourse.qualityPoints;
                    }
                }
            }
            cumulativeGPA = qualityPointAccumulator / creditHouraccumulator;

            return cumulativeGPA;
        }

        //calculate a single complete transcript from an incomplete one, with minimum passing grades 
        public static Transcript calculateMinimumGrades(Transcript incompleteTranscript)
        {
            Transcript completeTranscript = new Transcript(incompleteTranscript);

            for (int i = 0; i < completeTranscript.semesters.Count; i++)
            {//iterate over each semester
                if (!completeTranscript.semesters[i].isComplete)
                {//iterate over each course in the semester if the semester is ot marked as complete
                    for (int ii = 0; ii < completeTranscript.semesters[i].courses.Count; ii++)
                    {//set each grade to minimum passing requirement
                        completeTranscript.semesters[i].courses[ii] = new Course(incompleteTranscript.semesters[i].courses[ii].courseCode, 
                                                                                 incompleteTranscript.semesters[i].courses[ii].creditHours, 
                                                                                 50.0);
                        completeTranscript.semesters[i].courses[ii].isComplete = true;
                    }
                    completeTranscript.semesters[i].isComplete = true;
                    completeTranscript.semesters[i].semesterGPA = completeTranscript.semesters[i].calculateSemesterGPA(completeTranscript.semesters[i].courses);
                }
            }
            
            completeTranscript.cumulativeGPA = Transcript.calculateCumulativeGPA(completeTranscript.semesters);    
            return completeTranscript;
        }

        public List<Transcript> calculatePermutations(Transcript incompleteTranscript)
        {
            List<Transcript> permutations = new List<Transcript>();



            return permutations;

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
