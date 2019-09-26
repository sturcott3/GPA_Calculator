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
    class Transcript
    {
        //-_-_Properties-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public List<Semester> Semesters { get; set; }
        public List<Course> CourseList { get; set; }
        public double CumulativeGPA { get; set; }
        public List<string> Header { get; set; }

        //-_-_End Properties-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_Constructors-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public Transcript(List<Semester> semesters, List<string> studentInfo)
        {//to instantiate from an existing list (static data sets in TestData.cs passed in Semester Constructor)
            Header = new List<string>(studentInfo);
            Semesters = new List<Semester>(semesters);
            CourseList = new List<Course>(Transcript.SetupCourseList(semesters));
            CumulativeGPA = CalcCumuGPA(Semesters);
        }

        public Transcript(Transcript other)
        {//to instantiate from an existing semester (copy existing)
            Header = new List<string>(other.Header);
            Semesters = new List<Semester>(other.Semesters);
            CourseList = new List<Course>(Transcript.SetupCourseList(other.Semesters));
            CumulativeGPA = CalcCumuGPA(Semesters);
        }

        //-_-_End Constructors-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public Transcript calcMinPassing(Transcript incomplete)
        {
            //create a transcript to operate on
            Transcript current  = new Transcript(incomplete);

            //set each incomplete course to [%50 / D]



            //loop until passing
            while (current.CumulativeGPA < 2.0)
            {
                

            }



            return current;
        }

        private static double CalcCumuGPA(List<Semester> semesters)
        {
            double cumulativeGPA = 0;
            double creditHouraccumulator = 0;
            double qualityPointAccumulator = 0;

            foreach (Semester singleSemester in semesters)
            {
                foreach (Course singleCourse in singleSemester.Courses)
                {
                    if (singleCourse.PercentGrade != -1)
                    {
                        creditHouraccumulator += singleCourse.CreditHours;
                        qualityPointAccumulator += singleCourse.QualityPoints;
                    }
                }
            }

            cumulativeGPA = qualityPointAccumulator / creditHouraccumulator;

            return cumulativeGPA;
        }
        
        //test a single transcript to see whether it is eligible for graduation
        public static bool TestIsGraduating(Transcript transcript)
        {
            //start with flag set to passing
            bool isPassing = true;

            //check that each course has a passing grade
            foreach (Semester singleSemester in transcript.Semesters)
            {
                foreach (Course singleCourse in singleSemester.Courses)
                {
                    if (singleCourse.PercentGrade < 50)
                    {
                        isPassing = false;
                    }
                }
            }

            //check that cumulative GPA is acceptable
            if (CalcCumuGPA(transcript.Semesters) < 2.0)
            {
                isPassing = false;
            }

            //If we get past all checks without setting to false, the transcript passes
            return isPassing;
        }


        //gather all courses in all semesters in a single list to facilitate easier iteration in other transcript methods 
        static List<Course> SetupCourseList(List<Semester> semesters)
        {
            List<Course> fullCourseList = new List<Course>();

            foreach (Semester singleSemester in semesters)
            {
                foreach (Course singleCourse in singleSemester.Courses)
                {
                    fullCourseList.Add(singleCourse);
                }
            }

            return fullCourseList;
        }

        //-_-_End Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_


    }
}
