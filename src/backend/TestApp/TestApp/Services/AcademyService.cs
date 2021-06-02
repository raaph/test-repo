using System;
using System.Linq;
using TestApp.Models;

namespace TestApp.Services
{
    public class AcademyService : IAcademyService
    {
        public Academy AddStudent(Academy academy, Student student)
        {
            if (!academy.Students.Any(s => s.Id == student.Id))
            {
                academy.Students.Add(student);
            }
            else
            {
                Console.WriteLine($"Student with the id {student.Id} aleady exists in this academy");
            }
            return academy;
        }

        public Academy RemoveStudent(Academy academy, Student student)
        {
            if (academy.Students.Any(s => s.Id == student.Id))
            {
                academy.Students.Remove(student);
            }
            else
            {
                Console.WriteLine($"Student with the id {student.Id} does not exist in this academy");
            }
            return academy;
        }
    }
}
