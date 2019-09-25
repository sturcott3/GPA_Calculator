using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GPA_Calculator_initial
{
    public partial class Form1 : Form
    {   
        Semester testSemester1;
        Semester testSemester2;
        Semester testSemester3;
        Semester testSemester4;

        List<Semester> testSemesters;

        Transcript testTranscript;
        Transcript testTranscript2;

        StreamWriter outputFile;


        public Form1()
        {
            InitializeComponent();

            testSemester1 = new Semester(TestData.testCourses2_1);
            testSemester2 = new Semester(TestData.testCourses2_2);
            testSemester3 = new Semester(TestData.testCourses2_3);
            testSemester4 = new Semester(TestData.testCourses2_4);

            testSemesters = new  List<Semester> { testSemester1, testSemester2, testSemester3, testSemester4};

            testTranscript = new Transcript(testSemesters);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Execution Finished");
            
            outputFile = new StreamWriter("original.txt");
            printTranscript(testTranscript);
            outputFile.Close();

            testTranscript2 = new Transcript(Transcript.calculateMinimumGrades(testTranscript));

            outputFile = new StreamWriter("firstMinimum.txt");
            printTranscript(testTranscript2);
            outputFile.Close();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void printTranscript(Transcript toPrint)
        {
            int i = 1;

            foreach (Semester semester in toPrint.semesters)
            {
                outputFile.WriteLine("================================================================================================");
                outputFile.WriteLine("================================================================================================");
                outputFile.WriteLine("================================================================================================");
                outputFile.WriteLine("Semester " + i++);

                foreach (Course course in semester.courses)
                { 
                    outputFile.WriteLine("Course Code: " + course.courseCode);
                    outputFile.WriteLine("Credit Hours: " + course.creditHours);
                    outputFile.WriteLine(course.isComplete? "Course Completed" : "Course Incomplete");
                    outputFile.WriteLine("Percent Grade: " + course.percentGrade);
                    outputFile.WriteLine("Letter Grade: " + course.letterGrade);
                    outputFile.WriteLine("Quality Points: " + course.qualityPoints);
                    outputFile.WriteLine("-------------------------------------------------------------------------------------");
                    outputFile.WriteLine("-------------------------------------------------------------------------------------");
                    outputFile.WriteLine("-------------------------------------------------------------------------------------");
                }

                outputFile.WriteLine(semester.isComplete? "Semester Complete" : "Semester Incomplete");
                outputFile.WriteLine(semester.isComplete? "Semester GPA : " + semester.semesterGPA : "Semester GPA: N/A");
            }

            outputFile.WriteLine("Cumulative GPA: " + toPrint.cumulativeGPA);
            outputFile.WriteLine("-------------------------------------------------------------------------------------");
            outputFile.WriteLine("-------------------------------------------------------------------------------------");
            outputFile.WriteLine("-------------------------------------------------------------------------------------");
        }

       
    }
}
