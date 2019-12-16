using System;
using System.Collections.Generic;
using System.Text;

namespace task0504
{
    class Student
    {
        public Student(string LastName, string FirstName, params int[] Marks)
        {
            if (Marks.Length < 3) throw new Exception("Нет оценок");

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Mark1 = Marks[0];
            this.Mark2 = Marks[0];
            this.Mark3 = Marks[0];
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }

        public double AverangeMark
        {
            get
            {
                return Math.Round(((double)(this.Mark1 + this.Mark2 + this.Mark3)) / 3, 2);
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName,20} {this.LastName, 15} {this.Mark1, 3} {this.Mark2, 3} {this.Mark3, 3} {this.AverangeMark, 3}";
        }
    }
}
