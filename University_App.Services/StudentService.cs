using University_App.Models;

namespace University_App.Services
{
    public class StudentService : IStudentService
    {
        static List<Student> students = new List<Student>();
        public void Create(Student? student)
        {
            if (student != null)
                students.Add(student);
        }

        public void Delete(Guid id)
        {
            students.RemoveAll(i => i.Id == id);
        }

        public Student? Get(Guid id)
        {
            return students.FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Student>? GetAll()
        {
            return students;
        }

        public void Update(Student? student)
        {
            Student? currStudent = new Student();
            if (student != null)
                currStudent = students.FirstOrDefault(i => i.Id == student.Id);
            int currentStudIndex = -1;
            if (currStudent != null)
                currentStudIndex = students.IndexOf(currStudent);
            if (student != null)
                students[currentStudIndex] = student;
        }
    }
}