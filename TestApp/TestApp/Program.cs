using TestApp.Models;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var modernItAcademy = new Academy("Bern", "Modern IT Academy");
            modernItAcademy.AddStudent(new Student("Feniks", "Imeri", 1001));
            modernItAcademy.AddStudent(new Student("Luca", "Ramseyer", 1002));
            modernItAcademy.AddStudent(new Student("Lukas", "Schumacher", 1003));
            modernItAcademy.AddStudent(new Student("Yachta", "Tran", 1004));
        }
    }
}
