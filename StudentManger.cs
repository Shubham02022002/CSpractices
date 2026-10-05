using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(string name, int age, decimal marks)
        {
            Student student = new Student(name, age, marks);
            students.Add(student);
        }
        public void RemoveStudent(int id)
        {
            if (id >= 0 && id <= students.Count)
            {
                students.RemoveAt(students.FindIndex(student => student.Id == id));
            }
            else
            {
                Console.WriteLine("Invalid id, please enter a valid id");
            }
        }

        public void DisplayStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Student Details: {student}");
            }
        }

        public Student FindStudent(int id)
        {
            int studentIndex = students.Find((student) => student.Id == id);

            if (studentIndex < 0){
                throw new Exception("Student not found");
            }
            else
            { 
            return students[studentIndex];
            }
        }

        public List<Student> Toppers()
        {
            List<Student> toppers = new List<Student>();
            foreach (Student student in students) {
                if (student.Marks >= 75)
                {
                    toppers.Add(student);
                }
            }
            return toppers;
        }
        public Student Topper()
        {
            Student? topper=null;
            decimal maxMarks = 0;

            foreach (Student student in students)
            {
                if(student.Marks > maxMarks)
                {
                    maxMarks = student.Marks;
                    topper = student;
                }
            }
            return topper;
        }

        public void UpdateMarks(int studentId, decimal marks)
        {
            Student s = FindStudent(studentId);
            s.Marks = marks;
        }
    }
}
