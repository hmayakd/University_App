using University_App.Models;

namespace University_App.Services
{
    public interface IStudentService
    {
        IEnumerable<Student>? GetAll();
        Student? Get(Guid id);
        void Create(Student? student);
        void Update(Student? student);
        void Delete(Guid id);
    }
}
