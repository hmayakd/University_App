using University_App.Models;

namespace University_App.Services
{
    public interface ITeacherService
    {
        IEnumerable<Teacher>? GetAll();
        Teacher? Get(Guid id);
        void Create(Teacher? teacher);
        void Update(Teacher? teacher);
        void Delete(Guid id);
    }
}
