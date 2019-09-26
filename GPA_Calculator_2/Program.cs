using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GPA_Calculator_2
{
    // limit my test data to one incomplete semester
    // limit output to each .25 gpa (do this by having calculateMinimum grades work on a target value, then )
    class Program
    {
        static void Main(string[] args)
        {
            Random randall = new Random();

            List<Semester> testSems1 = new List<Semester>(){
            new Semester(TestData.testCourses1_1),
            new Semester(TestData.testCourses1_2),
            new Semester(TestData.testCourses1_3),
            new Semester(TestData.testCourses1_4)};

            Transcript testTrans1 = new Transcript(testSems1, TestData.student1);

            PrintTranscript(testTrans1, "../test/test1"+randall.Next(1000,9999)+".txt");

            Console.WriteLine("Execution Successful");
            Console.ReadKey();
        }

        private static void PrintTranscript(Transcript toPrint, string filename)
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
                    outputFile.WriteLine("Percent Grade: " + course.PercentGrade);
                    outputFile.WriteLine("Letter Grade: " + course.LetterGrade);
                    outputFile.WriteLine("Quality Points: " + course.QualityPoints);
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
    }
}
