using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

/*
 * Павел Корженко
 */

/*
 * 3. *Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
 */
namespace task0803
{
    // <summary>
    // Класс студентов
    // </summary>
    [Serializable]
    public class Student
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

        public Student() { }

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

    // <summary>
    // Класс для хранения списка студентов. А также для сериализации в XML и 
    // десериализации из XML
    // </summary>
    class StudentsToXml
    {
        string fileName;
        List<Student> list;
        public string FileName
        {
            set { fileName = value; }
        }
        public StudentsToXml(string fileName)
        {
            this.fileName = fileName;
            list = new List<Student>();
        }

        public StudentsToXml()
        {
            list = new List<Student>();
        }

        public void Add(string lastName, string firstName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            list.Add(new Student(lastName, firstName, university, faculty, department, course, age, group, city));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        public Student this[int index]
        {
            get { return list[index]; }
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void Save(string saveFileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(saveFileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Student>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public int Count
        {
            get { return list.Count; }
        }

        public override string ToString()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            using (StringWriter textWriter = new StringWriter())
            {
                xmlFormat.Serialize(textWriter, list);
                return textWriter.ToString();
            }
        }
    }

}
