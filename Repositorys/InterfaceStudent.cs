using UOW_APP.Models;

namespace UOW_APP.Repositorys
{
    public interface InterfaceStudent : IDisposable
    {
        IEnumerable<Student> GetStudents()
        {
            return null;
        }
        public Student GetStudentByID(int studentId)
        {
            return null;
        }
        public void InsertStudent(Student student)
        {
          
        }
        public void DeleteStudent(int studentID)
        {

        }
        public void UpdateStudent(Student student)
        {

        }
        public void Save()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        } 
    }
}
