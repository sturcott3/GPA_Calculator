using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                new Course("CP301" , 42.0 , 80.05),
                new Course("CP302" , 42.0 , 80.05),
                new Course("CP303" , 42.0 , 80.05),
                new Course("CP304" , 42.0 , 80.05),
                new Course("CP305" , 42.0 , 80.05),
                new Course("CP306" , 42.0 , 80.05),
                new Course("CP307" , 42.0 , 80.05)};

        List<Course> testCourses4 = new List<Course>{
                new Course("CP401" , 42.0 , 80.05),
                new Course("CP402" , 42.0 , 80.05),
                new Course("CP403" , 42.0 , 80.05),
                new Course("CP404" , 42.0 , 80.05),
                new Course("CP405" , 42.0 , 80.05),
                new Course("CP406" , 42.0 , 80.05)};
    
        Semester testSemester1;
        Semester testSemester2;
        Semester testSemester3;
        Semester testSemester4;

        List<Semester> testSemesters;

        Transcript testTranscript;

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
            Console.WriteLine("Semester 1 GPA: " + testSemester1.semesterGPA);
            Console.WriteLine("Semester 2 GPA: " + testSemester2.semesterGPA);
            Console.WriteLine("Semester 3 GPA: " + testSemester3.semesterGPA);
            Console.WriteLine("Semester 4 GPA: " + testSemester4.semesterGPA);

            Console.WriteLine("Cumulative GPA: " + testTranscript.cumulativeGPA);
        }
    }
}
