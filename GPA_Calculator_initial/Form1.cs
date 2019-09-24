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
        Course[] testCourses1 = new Course[]{
                new Course("CP001" , 42.0 , 101.5),
                new Course("CP002" , 42.0 , 100.0),
                new Course("CP003" , 42.0 , 95.5),
                new Course("CP004" , 42.0 , 90.0),
                new Course("CP005" , 42.0 , 82.5),
                new Course("CP006" , 42.0 , 94.2),
                new Course("CP007" , 42.0 , 90.9)};

        Course[] testCourses2 = new Course[]{
                new Course("CP001" , 42.0 , 101.5),
                new Course("CP002" , 42.0 , 100.0),
                new Course("CP003" , 42.0 , 95.5),
                new Course("CP004" , 42.0 , 90.0),
                new Course("CP005" , 42.0 , 82.5),
                new Course("CP006" , 42.0 , 94.2),
                new Course("CP007" , 72.0 , 75.5)};

        Semester testSemester1;
        Semester testSemester2;

        Semester[] testSemesters;

        Transcript testTranscript;

        public Form1()
        {
            InitializeComponent();

            testSemester1 = new Semester(testCourses1);
            testSemester2 = new Semester(testCourses2);

            testSemesters = new Semester[] { testSemester1, testSemester2};

            testTranscript = new Transcript(testSemesters);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Semester 1 GPA: " + testSemester1.semesterGPA);
            Console.WriteLine("Semester 2 GPA: " + testSemester2.semesterGPA);

            Console.WriteLine("Cumulative GPA: " + testTranscript.cumulativeGPA);
        }
    }
}
