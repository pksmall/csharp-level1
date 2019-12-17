using System;
using System.Collections.Generic;
using System.Text;

namespace task0603
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        public Student(string lastName, string firstName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.course = course;
            this.department = department;
            this.group = group;
            this.city = city;
            this.age = age;
        }
    }
}
