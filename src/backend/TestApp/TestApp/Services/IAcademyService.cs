using TestApp.Models;

namespace TestApp.Services
{
    public interface IAcademyService
    {
        Academy AddStudent(Academy academy, Student student);
        Academy RemoveStudent(Academy academy, Student student);
    }
}
