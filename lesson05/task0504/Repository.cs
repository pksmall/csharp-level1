using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace task0504
{
    class Repository
    {
        int count;
        Student[] students;

        public Repository(string path = "db.txt")
        {
            using (StreamReader sr = new StreamReader(path))
            {
                this.count = Convert.ToInt32(sr.ReadLine());
                this.students = new Student[this.count];

                for (int i = 0; i < this.count; i++)
                {
                    var args = sr.ReadLine().Split(' ');
                    this.students[i] = new Student(
                        LastName: args[0],
                        FirstName: args[1],
                        Marks: new int[]
                        {
                            Convert.ToInt32(args[2]),
                            Convert.ToInt32(args[3]),
                            Convert.ToInt32(args[4])
                        });
                }
            }
        }
        public Repository Print()
        {
            Console.WriteLine("\n-------------\n");
            foreach(var e in this.students)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("\n-------------\n");
            return this;
        }

        public Student[] BadStudents()
        {
            Student[] temp;

            int k = 0, length = 0;

            for(int i = 1 ; i < this.students.Length; i++)
            {
                if (this.students[i].AverangeMark != this.students[i - 1].AverangeMark)
                {
                    k++;
                }
                if (k == 3) { 
                    length = i; 
                    break; 
                }
            }
            temp = new Student[length];
            Array.Copy(this.students, temp, length);
            
            return temp;
        }

        public Repository Sort()
        {
            Array.Sort(this.students, SortMethod);
            return this;
        }

        private int SortMethod(Student x, Student y)
        {
            return x.AverangeMark < y.AverangeMark ? -1 : 1;
        }
    }
}
