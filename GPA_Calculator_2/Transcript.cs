using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            CourseList = Transcript.SetupCourseList(semesters);
            CumulativeGPA = CalcCumuGPA(Semesters);
        }

        public Transcript(Transcript other)
        {//to instantiate from an existing semester (copy existing)
            Header = new List<string>(other.Header);
            Semesters = new List<Semester>(other.Semesters);
            CourseList = Transcript.SetupCourseList(Semesters);
            CumulativeGPA = CalcCumuGPA(Semesters);
        }

        //-_-_End Constructors-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
        //-_-_Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public static Transcript CalcOutcome(Transcript incomplete, double targetGPA)
        {
            //-_-Setup_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
            //create a transcript to operate on, and print the original to file
            PrintTranscript(incomplete, "../test/original.txt");
            Transcript current  = new Transcript(incomplete);

            //tracking variable (number of *different* Transcripts tested)
            int numEx = 1;
            double lastPrinted = 0.0;

            //set each course at -1 (incomplete) to [%50 / D / recalc QPs]
            for (int i = 0; i < current.CourseList.Count ; i++ )
            {
                if (current.CourseList[i].PercentGrade == -1) { current.CourseList[i].PercentGrade = 50.0; } 
            }
            //recalculate cumulative GPA
            current.CumulativeGPA = Transcript.CalcCumuGPA(current.Semesters);


            //-Initial Checks-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
            //***If GPA meets the target, print it out and return 
            //(means that existing grades are high enough to pass with all 50s) 

            if (current.CumulativeGPA >= targetGPA)
            {
                Console.WriteLine("Congrats, your existing marks are high enough to reach your goal with minimums in all remaining courses");
                PrintTranscript(current, "../test/Calculated_all50s.txt");
                return current;
            }

            //If the transcript graduates, print it to file and set the lastPrinted tracker
            if (TestGraduating(current))
            {
                PrintTranscript(current, "../test/Calculated_graduating" + numEx + ".txt");
                lastPrinted = current.CumulativeGPA;
            }

            //-Iterative Checks_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
            // if not at the target, loop until meeting requirements
            while ((current.CumulativeGPA < targetGPA) && (!current.TestMaxChecked()))
            {
                //loop over all courses
                for (int i = 0; i < current.CourseList.Count; i++)
                {
                    //ignore courses that are marked as completed (TODO deal with scenario where courses need to be repeated)
                    if (!current.CourseList[i].Completed)
                    {
                        //increment one course by one letter grade
                        current.CourseList[i].PercentGrade += 10.0;

                        // recalculate and check the gpa. if meeting the target, print to file and return
                        current.CumulativeGPA = Transcript.CalcCumuGPA(current.Semesters);
                        if (current.CumulativeGPA >= targetGPA)
                        {
                            PrintTranscript(current, "../test/testCalculated_final.txt");
                            return current;
                        }
                        //otherwise, check if it graduates and surpasses the last printed by at least .10
                        //if it does, print to file and continue checks
                        else if ((TestGraduating(current)) && (current.CumulativeGPA >= (lastPrinted + 0.10)))
                        {
                            PrintTranscript(current, "../test/testCalculated" + numEx++ + ".txt");
                            lastPrinted += 0.10;
                        }
                    }
                }
            }

            //-ShutDown-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
            //record number of attempts
            Console.WriteLine(numEx + " cases tested");

            //returned transcript should be the closest possibly achievable to the target without repeating courses
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
        public static bool TestGraduating(Transcript transcript)
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

        bool TestMaxChecked()
        {
            bool allCasesChecked = true;

            foreach (Course course in CourseList)
            {
                //if the course is marked as incomplete, but does not yet have an A assigned 
                if (!course.Completed && course.LetterGrade != 'A')
                {//then there are still combinations to test
                    allCasesChecked = false;
                }
            }
            return allCasesChecked;
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

        public static void PrintTranscript(Transcript toPrint, string filename)
        {
            StreamWriter outputFile = new StreamWriter(filename);

            int i = 1;

            foreach (string line in toPrint.Header)
            {//print student info
                outputFile.WriteLine(line);
            }

            foreach (Semester semester in toPrint.Semesters)
            {//print each semester one at a time
                outputFile.WriteLine("================================================================================================");
                outputFile.WriteLine("Semester " + i++);
                outputFile.WriteLine("-------------------------------------------------------------------------------------");

                foreach (Course course in semester.Courses)
                {//print relevant info for each course
                    outputFile.WriteLine("Course Code: " + course.Code);
                    outputFile.WriteLine("Credit Hours: " + course.CreditHours);
                    outputFile.WriteLine(course.Completed ? "Course Completed" : "Course Incomplete");
                    outputFile.WriteLine(course.Completed ? "Percent Grade: " + course.PercentGrade : "Percent Grade: N/A");
                    outputFile.WriteLine("Letter Grade: " + course.LetterGrade);
                    outputFile.WriteLine(course.Completed ? "Quality Points: " + course.QualityPoints : "Quality Points: N/A");
                    outputFile.WriteLine("-------------------------------------------------------------------------------------");
                }

                //check if the semester was completed and print its GPA if it was
                outputFile.WriteLine(semester.Completed ? "Semester Complete" : "Semester Incomplete");
                outputFile.WriteLine(semester.Completed ? "Semester GPA : " + semester.SemesterGPA : "Semester GPA: N/A");
            }

            //print cumulative gpa (always excludes incomplete courses)
            outputFile.WriteLine("Current cumulative GPA: " + toPrint.CumulativeGPA);

            outputFile.Close();
        }

        //-_-_End Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_


    }
}
