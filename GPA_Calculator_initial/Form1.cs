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
        List<Course> testCourses1 = new List<Course>{
                new Course("CP101" , 42.0 , 101.5),
                new Course("CP102" , 42.0 , 100.0),
                new Course("CP103" , 42.0 , 95.5),
                new Course("CP104" , 42.0 , 90.0),
                new Course("CP105" , 42.0 , 82.5),
                new Course("CP106" , 42.0 , 94.2),
                new Course("CP107" , 42.0 , 90.9)};

        List<Course> testCourses2 = new List<Course>{
                new Course("CP201" , 42.0 , 101.5),
                new Course("CP202" , 42.0 , 100.0),
                new Course("CP203" , 42.0 , 95.5),
                new Course("CP204" , 42.0 , 90.0),
                new Course("CP205" , 42.0 , 82.5),
                new Course("CP206" , 42.0 , 94.2),
                new Course("CP207" , 72.0 , 75.5)};

        List<Course> testCourses3 = new List<Course>{
                new Course("CP301" , 42.0 , -1),
                new Course("CP302" , 42.0 , -1),
                new Course("CP303" , 42.0 , -1),
                new Course("CP304" , 42.0 , -1),
                new Course("CP305" , 42.0 , -1),
                new Course("CP306" , 42.0 , -1),
                new Course("CP307" , 42.0 , -1)};

        List<Course> testCourses4 = new List<Course>{
                new Course("CP401" , 42.0 , -1),
                new Course("CP402" , 42.0 , -1),
                new Course("CP403" , 42.0 , -1),
                new Course("CP404" , 42.0 , -1),
                new Course("CP405" , 42.0 , -1),
                new Course("CP406" , 42.0 , -1)};
    
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

            testSemester1 = new Semester(testCourses1);
            testSemester2 = new Semester(testCourses2);
            testSemester3 = new Semester(testCourses3);
            testSemester4 = new Semester(testCourses4);

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
