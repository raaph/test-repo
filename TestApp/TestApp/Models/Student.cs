using TestApp.Enums;

namespace TestApp.Models
{
    public class Student
    {
        public Student(string firstName, string lastName, int id, StudentType type)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Type = type;
        }

        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
        public StudentType Type { get; set; }
    }
}
