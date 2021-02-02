using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp.Test1.Models
{
    public class Academy
    {
        public Academy(string location, string name)
        {
            Location = location;
            Name = name;
            Students = new List<Student>();
        }

        public string Location { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; }

        public void AddStudent(Student student)
        {
            if (!Students.Any(s => s.Id == student.Id))
            {
                Students.Add(student);
            }
            else
            {
                Console.WriteLine($"Student with the id {student.Id} aleady exists in this academy");
            }
        }

        public void RemoveStudent(Student student)
        {
            if (Students.Any(s => s.Id == student.Id))
            {
                Students.Remove(student);
            }
            else
            {
                Console.WriteLine($"Student with the id {student.Id} does not exist in this academy");
            }
        }
    }
}
