using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

/*Major Assignment 1
 CP-350: Critical Thinking II
 Prof. Troy Mangatal
 Developed by Samuel Turcotte
 2019-09-23*/
namespace GPA_Calculator_2
{
    public class Transcript
    {
        //color definitions to make changes/updates easier...(and make code more readable?)
        public static Color ShadeBad = Color.Salmon;
        public static Color ShadeFail = Color.LightSalmon;
        public static Color ShadeExclude = Color.Tan;
        public static Color ShadeIncomplete = Color.CornflowerBlue;
        public static Color Shadepass = Color.LightSeaGreen;

//-_-_Properties-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

        public List<Semester> Semesters { get; set; }
        public List<Course> CourseList { get; set; }
        public double CumulativeGPA { get; set; }
        public List<string> Header { get; set; }

//-_-_End Properties-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
//-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
//-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
//-_-_Constructors-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

        public Transcript(List<Semester> semesters, List<string> studentInfo)
        {//to instantiate from an existing list (static data sets in TestData.cs passed in Semester Constructor)
            Header = new List<string>(studentInfo);
            Semesters = new List<Semester>(semesters);
            SetupCourseList();
            CalcCumuGPA();
        }

        public Transcript(Transcript other)
        {//to instantiate from an existing semester (copy existing)
            Header = new List<string>(other.Header);
            Semesters = new List<Semester>(other.Semesters);
            SetupCourseList();
            CalcCumuGPA();
        }
   
        public Transcript()
        {//no-arg constructor to set default values until I add functionality to intake user data
            Header = new List<string>() {
            "Name: Guest Student",
            "Class of: 2020",
            "Campus: Thunder Bay",
            "StudentId:999999999",
            "email: guest@confederationcollege.ca",
            "guest_01"};
            Semesters = new List<Semester>();
            CourseList = new List<Course>();
            CumulativeGPA = 0;
        }

//-_-_End Constructors-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
//-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
//-_-_-_-_-_-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
//-_-_Methods-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public void CalcCumuGPA()
        {
            double creditHouraccumulator = 0;
            double qualityPointAccumulator = 0;
            
            foreach (Course singleCourse in CourseList)
            {
                if (singleCourse.LetterGrade != 'I')
                {
                    creditHouraccumulator += singleCourse.CreditHours;
                    qualityPointAccumulator += singleCourse.QualityPoints;
                }
            }
            CumulativeGPA = qualityPointAccumulator / creditHouraccumulator;
        }
        
        //test a single transcript to see whether it is eligible for graduation
        public bool TestGraduating()
        {
            //start with flag set to passing
            bool isPassing = true;

            //check that each course has a passing grade

                foreach (Course singleCourse in CourseList)
                {
                    if (singleCourse.LetterGrade == 'F')
                    {
                        isPassing = false;
                    }
                }
            
            //check that cumulative GPA is acceptable
            if (CumulativeGPA < 1.994)
            {
                isPassing = false;
            }

            //If we get past all checks without setting to false, the transcript passes
            return isPassing;
        }

        public bool TestMaxChecked()
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

        //gather all courses in all semesters in a single list 
        //this list should only contain the highest of each course (by course code for now)
        public void SetupCourseList()
        {
            CourseList = new List<Course>();
            CourseList.Clear();

            //start with every course in the Transcript
            foreach (Semester singleSemester in Semesters)
            {
                foreach (Course singleCourse in singleSemester.Courses)
                {
                    singleCourse.Included = "INCLUDED";
                    CourseList.Add(singleCourse);
                }
            }

            // to get ahold of the courses one at a time, separate from the list
            Course tester; 

            for (int current = 0; current < CourseList.Count; current++)
            {
                tester = CourseList[current];

                //look at each course, and compare it's Course Code to the tester
                for (int idx = 0; idx < CourseList.Count; idx++)
                {
                    //if the course codes are equal, 
                    if (tester.Code.Equals(CourseList[idx].Code))
                    {
                        //compare the marks, 
                        if (tester.PercentGrade > CourseList[idx].PercentGrade)
                        {
                            //if the tester is higher, get rid of the lower grade, and mark it as EXClUDED
                            CourseList[idx].Included = "EXCLUDED";
                            CourseList.RemoveAt(idx);
                        }
                    }
                }
            }
        }

        public List<string> PrintTranscript(string filename, PrintType userPreference)
        {
            List<string> outputSummary = new List<string>();

            switch (userPreference)
            {
                case PrintType.PlainText:
                    outputSummary = GenerateSummary(filename);
                    PrintToPlainTxt(filename);
                    break;

                case PrintType.FancyText:
                    outputSummary = GenerateSummary(filename);
                    PrintToFancyTxt(filename);
                    break;

                case PrintType.Csv:
                    GenerateSummary(filename);
                    //<stretch>
                    break;

                case PrintType.None:
                    outputSummary = GenerateSummary(filename);
                    break;
            }
            return outputSummary; 
        }

        private List<string> GenerateSummary(string filename)
        {
            List<string> outputSummary = new List<string>();

            //the student's name, defaults to guest
            outputSummary.Add(Header[0]);

            //Summarize the semesters
            int numSemester = 1;
            foreach (Semester semester in Semesters)
            {
                outputSummary.Add(
                    semester.Completed ? "Semester " + numSemester + " All courses complete. Semester GPA: " + semester.SemesterGPA.ToString("F2")
                                       : "Semester " + numSemester + " Incomplete, generated. \n");
                numSemester++;
            }
            //GPA to summary
            outputSummary.Add( "Cumulative GPA: " + CumulativeGPA.ToString("F2"));

            //add in the filename for easy access
            outputSummary.Add(filename);

            return outputSummary;
        }

        //PrintToFancy and PrintToPlain work exactly the same way, one just has lines instead of whitespace
        private void PrintToPlainTxt(string filename)
        {
            StreamWriter outputFile = new StreamWriter(filename);

            int numSemester = 1;

            foreach (string line in Header)
            {//print student info
                outputFile.WriteLine(line);
            }

            foreach (Semester semester in Semesters)
            {//print each semester one at a time

                outputFile.WriteLine("Semester " + numSemester++);
                outputFile.WriteLine();

                foreach (Course course in semester.Courses)
                {//print relevant info for each course
                    outputFile.WriteLine("Course Code: " + course.Code);
                    outputFile.WriteLine("Credit Hours: " + course.CreditHours);
                    outputFile.WriteLine(course.Completed ? "Course Completed" : "Course Incomplete");
                    outputFile.WriteLine(course.Completed ? "Percent Grade: " + course.PercentGrade : "Percent Grade: N/A");
                    outputFile.WriteLine("Letter Grade: " + course.LetterGrade);
                    outputFile.WriteLine(course.Completed ? "Quality Points: " + course.QualityPoints : "Quality Points: N/A");
                    outputFile.WriteLine();
                }

                //check if the semester was completed and print its GPA if it was
                outputFile.WriteLine(semester.Completed ? "Semester Complete" : "Semester Incomplete");
                outputFile.WriteLine(semester.Completed ? "Semester GPA : " + semester.SemesterGPA : "Semester GPA: N/A");

            }

            //print cumulative gpa and add it to the summary (always excludes incomplete courses)
            outputFile.WriteLine("Current cumulative GPA: " + CumulativeGPA);

            outputFile.Close();
        }

        private void PrintToFancyTxt(string filename)
        {
            StreamWriter outputFile = new StreamWriter(filename);

            int numSemester = 0;

            foreach (string line in Header)
            {//print student info
                outputFile.WriteLine(line);
            }

            foreach (Semester semester in Semesters)
            {//print each semester one at a time
                outputFile.WriteLine("================================================================================================");
                outputFile.WriteLine("Semester " + numSemester++);
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

            //print cumulative gpa and add it to the summary (always excludes incomplete courses)
            outputFile.WriteLine("Current cumulative GPA: " + CumulativeGPA);

            outputFile.Close();
        }

        private void PrintToCsv(string filename)
        {//<stretch goal> print for consumption in Excel
 
        }
    }

    public enum PrintType
    {
        PlainText = 0,
        FancyText = 1,
        Csv = 2,
        None = 3
    }
}
