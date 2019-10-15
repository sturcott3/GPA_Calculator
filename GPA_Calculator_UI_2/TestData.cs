using System.Collections.Generic;

/*Major Assignment 1
 CP-350: Critical Thinking II
 Prof. Troy Mangatal
 Developed by Samuel Turcotte
 2019-09-23*/
namespace GPA_Calculator_2
{

    //This class is deprecated, but was used in unit testing to directly initialize Transcripts without input.
    //Leaving it in the project to get feedback about this use of a static class
    //...should i be using something else to do this?

    public static class TestData
    {
        //Test dataset 1-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public static List<string> student1 = new List<string>(){
            "Name: Samuel Turcotte",
            "Class of: 2020",
            "Campus: Thunder Bay",
            "StudentId:100192852",
            "email: sturcot3@confederationcollege.ca",
            "sTurcot3"};

        public static List<Course> testCourses1_1 = new List<Course>{
                new Course("CP101" , 42.0 , 99),
                new Course("CP102" , 42.0 , 90),
                new Course("CP103" , 42.0 , 85),
                new Course("CP104" , 42.0 , 92),
                new Course("CP105" , 42.0 , 89),
                new Course("CP106" , 42.0 , 97),
                new Course("CP107" , 42.0 , 92)};

        public static List<Course> testCourses1_2 = new List<Course>{
                new Course("CP201" , 42.0 , 93),
                new Course("CP202" , 42.0 , 85),
                new Course("CP203" , 42.0 , 96),
                new Course("CP204" , 42.0 , 88),
                new Course("CP205" , 42.0 , 96),
                new Course("CP206" , 42.0 , 89),
                new Course("CP207" , 72.0 , 76)};

        public static List<Course> testCourses1_3 = new List<Course>{
                new Course("CP301" , 42.0 , -1),
                new Course("CP302" , 42.0 , -1),
                new Course("CP303" , 42.0 , -1),
                new Course("CP304" , 42.0 , -1),
                new Course("CP305" , 42.0 , -1),
                new Course("CP306" , 42.0 , -1),
                new Course("CP307" , 42.0 , -1)};

        public static List<Course> testCourses1_4 = new List<Course>{
                new Course("CP401" , 42.0 , -1),
                new Course("CP402" , 42.0 , -1),
                new Course("CP403" , 42.0 , -1),
                new Course("CP404" , 42.0 , -1),
                new Course("CP405" , 42.0 , -1),
                new Course("CP406" , 42.0 , -1)};

        //Test dataset 2-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public static List<string> student2 = new List<string>(){
            "Name: Wile e. Coyote",
            "Class of: 1951",
            "Campus: Acme Labs",
            "StudentId:900925673",
            "email: weCoyote@acmelabs.net",
            "weCoyote"};

        public static List<Course> testCourses2_1 = new List<Course>{
                new Course("CP101" , 42.0 , 55.5),
                new Course("CP102" , 42.0 , 55.5),
                new Course("CP103" , 42.0 , 55.5),
                new Course("CP104" , 42.0 , 55.5),
                new Course("CP105" , 42.0 , 55.5),
                new Course("CP106" , 42.0 , 55.5),
                new Course("CP107" , 42.0 , 55.5)};

        public static List<Course> testCourses2_2 = new List<Course>{
                new Course("CP201" , 42.0 , 55.5),
                new Course("CP202" , 42.0 , 55.5),
                new Course("CP203" , 42.0 , 55.5),
                new Course("CP204" , 42.0 , 55.5),
                new Course("CP205" , 42.0 , 55.5),
                new Course("CP206" , 42.0 , 55.5),
                new Course("CP207" , 72.0 , 55.5)};

        public static List<Course> testCourses2_3 = new List<Course>{
                new Course("CP301" , 42.0 , 65.5),
                new Course("CP302" , 42.0 , 65.5),
                new Course("CP303" , 42.0 , 65.5),
                new Course("CP304" , 42.0 , 65.5),
                new Course("CP305" , 42.0 , 65.5),
                new Course("CP306" , 42.0 , 65.5),
                new Course("CP307" , 42.0 , 65.5)};

        public static List<Course> testCourses2_4 = new List<Course>{
                new Course("CP401" , 42.0 , -1),
                new Course("CP402" , 42.0 , -1),
                new Course("CP403" , 42.0 , -1),
                new Course("CP404" , 42.0 , -1),
                new Course("CP405" , 42.0 , -1),
                new Course("CP406" , 42.0 , -1)};

        //Test dataset 3-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public static List<string> student3 = new List<string>(){
            "Name: Mary Poppins",
            "Class of: 1936",
            "Campus: London",
            "StudentId:000000009",
            "email: mPoppins@supercalifragilisticexpialadocious.com",
            "mPoppins"};

        public static List<Course> testCourses3_1 = new List<Course>{
                new Course("CP101" , 42.0 , 101.5),
                new Course("CP102" , 42.0 , 100.0),
                new Course("CP103" , 42.0 , 95.5),
                new Course("CP104" , 42.0 , 90.0),
                new Course("CP105" , 42.0 , 82.5),
                new Course("CP106" , 42.0 , 94.2),
                new Course("CP107" , 42.0 , 90.9)};

        public static List<Course> testCourses3_2 = new List<Course>{
                new Course("CP201" , 42.0 , 101.5),
                new Course("CP202" , 42.0 , 100.0),
                new Course("CP203" , 42.0 , 95.5),
                new Course("CP204" , 42.0 , 90.0),
                new Course("CP205" , 42.0 , 82.5),
                new Course("CP206" , 42.0 , 94.2),
                new Course("CP207" , 72.0 , 75.5)};

        public static List<Course> testCourses3_3 = new List<Course>{
                new Course("CP301" , 42.0 , -1),
                new Course("CP302" , 42.0 , -1),
                new Course("CP303" , 42.0 , -1),
                new Course("CP304" , 42.0 , -1),
                new Course("CP305" , 42.0 , -1),
                new Course("CP306" , 42.0 , -1),
                new Course("CP307" , 42.0 , -1)};

        public static List<Course> testCourses3_4 = new List<Course>{
                new Course("CP401" , 42.0 , -1),
                new Course("CP402" , 42.0 , -1),
                new Course("CP403" , 42.0 , -1),
                new Course("CP404" , 42.0 , -1),
                new Course("CP405" , 42.0 , -1),
                new Course("CP406" , 42.0 , -1)};

        //Test dataset 4-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

        public static List<string> student4 = new List<string>(){
            "Name: James Kirk",
            "Class of: 3972",
            "Campus: Kuiper Belt",
            "StudentId:009999999",
            "email: jKirk@starfleet.space",
            "jKirk"};

        public static List<Course> testCourses4_1 = new List<Course>{
                new Course("CP101" , 42.0 , 101.5),
                new Course("CP102" , 42.0 , 100.0),
                new Course("CP103" , 42.0 , 95.5),
                new Course("CP104" , 42.0 , 90.0),
                new Course("CP105" , 42.0 , 82.5),
                new Course("CP106" , 42.0 , 94.2),
                new Course("CP107" , 42.0 , 90.9)};

        public static List<Course> testCourses4_2 = new List<Course>{
                new Course("CP201" , 42.0 , 101.5),
                new Course("CP202" , 42.0 , 100.0),
                new Course("CP203" , 42.0 , 95.5),
                new Course("CP204" , 42.0 , 90.0),
                new Course("CP205" , 42.0 , 82.5),
                new Course("CP206" , 42.0 , 94.2),
                new Course("CP207" , 72.0 , 75.5)};

        public  static List<Course> testCourses4_3 = new List<Course>{
                new Course("CP301" , 42.0 , -1),
                new Course("CP302" , 42.0 , -1),
                new Course("CP303" , 42.0 , -1),
                new Course("CP304" , 42.0 , -1),
                new Course("CP305" , 42.0 , -1),
                new Course("CP306" , 42.0 , -1),
                new Course("CP307" , 42.0 , -1)};

        public static List<Course> testCourses4_4 = new List<Course>{
                new Course("CP401" , 42.0 , -1),
                new Course("CP402" , 42.0 , -1),
                new Course("CP403" , 42.0 , -1),
                new Course("CP404" , 42.0 , -1),
                new Course("CP405" , 42.0 , -1),
                new Course("CP406" , 42.0 , -1)};


    }
}
