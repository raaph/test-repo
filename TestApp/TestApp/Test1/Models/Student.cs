namespace TestApp.Test1.Models
{
    public class Student
    {
        public Student(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
    }
}
