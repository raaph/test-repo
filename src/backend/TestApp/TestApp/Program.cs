using TestApp.Models;
using TestApp.Services;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var modernItAcademy = new Academy("Bern", "Modern IT Academy");
            var academyService = new AcademyService();
            modernItAcademy = academyService.AddStudent(modernItAcademy, new Student("Feniks", "Imeri", 1001, Enums.StudentType.FullTime));
            modernItAcademy = academyService.AddStudent(modernItAcademy, new Student("Luca", "Ramseyer", 1002, Enums.StudentType.FullTime));
            modernItAcademy = academyService.AddStudent(modernItAcademy, new Student("Lukas", "Schumacher", 1003, Enums.StudentType.FullTime));
            modernItAcademy = academyService.AddStudent(modernItAcademy, new Student("Yachta", "Tran", 1004, Enums.StudentType.FullTime));
        }
    }
}
