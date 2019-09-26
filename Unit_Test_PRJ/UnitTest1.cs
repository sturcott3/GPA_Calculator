using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GPA_Calculator_2;

namespace Unit_Test_PRJ
{
    [TestClass]
    public class UnitTest1
    {
        //use dataset 1 from TestData.cs
        //test my own transcript and hand calculations
        //expected vs actual minPassing, maxAchievable, iterations
        [TestMethod]
        public void Test_actual_Transcript()
        {
            double targetGPA = 4.0;

            double expectedMaxGPA = 3.93814432989691;

            List<Semester> testSems = new List<Semester>(){
            new Semester(TestData.testCourses1_1),
            new Semester(TestData.testCourses1_2),
            new Semester(TestData.testCourses1_3),
            new Semester(TestData.testCourses1_4)};

            Transcript StartingTranscript = new Transcript(testSems, TestData.student1);

            Transcript CalculatedTranscript = Transcript.CalcOutcome(StartingTranscript, targetGPA);
                                                                                   
            Assert.AreEqual(expectedMaxGPA, CalculatedTranscript.CumulativeGPA, 0.0000000000001, "incorrect GPA calculation");
        }

        //use dataset 2 from TestData.cs
        //test with a transcript that cannot obtain a passing grade (existing marks too low)
        //Does the output match the expected minimum passing, highest possible, and number of checks executed? 
        [TestMethod]
        public void Test_failing_Transcript()
        {
            double targetGPA = 4.0;

            double expectedMaxGPA = 1.9020618556701;

            List<Semester> testSems = new List<Semester>(){
            new Semester(TestData.testCourses2_1),
            new Semester(TestData.testCourses2_2),
            new Semester(TestData.testCourses2_3),
            new Semester(TestData.testCourses2_4)};

            Transcript StartingTranscript = new Transcript(testSems, TestData.student2);

            Transcript CalculatedTranscript = Transcript.CalcOutcome(StartingTranscript, targetGPA);

            Assert.AreEqual(expectedMaxGPA, CalculatedTranscript.CumulativeGPA, 0.0000000000001, "incorrect GPA calculation");

        }

        ////use dataset 3 from TestData.cs
        ////test a transcript with no completed courses.
        ////Does the output match the expected minimum passing, highest possible, and number of checks executed?
        //[TestMethod]
        //public void Test_empty_Transcript()
        //{

        //}


        ////use dataset 4 from TestData.cs
        ////test a transcript with only 1 semester completed
        //////Does the output match the expected minimum passing, highest possible, and number of checks executed?
        //[TestMethod]
        //public void Test_singleSemester_Transcript()
        //{

        //}

        ////use dataset 1,2,3, and 4 from TestData.cs
        ////test a transcript made up of all data added together
        //////Does the program work? perform well? give output that makes sense?
        //[TestMethod]
        //public void Test_giant_Transcript()
        //{

        //}
    }
}
