
using StudentsManagement.Data.Models;
using System.Collections;

namespace StudentsManagement.Services.StudentServices
{
    public interface IStudentService
    {
        public Task CreateStudent(string firstName, string lastName, int gendar, DateTime birdDate);
        public Task DeleteStudentById(int id);
        public Task DeleteStudentByName(string firstName, string lastName);

        public Task SetStudentFinalMark(int id, int mark);

        public Task<IEnumerable<Student>> GetAllStudents();

        public Task SaveChanges();


	}


   
}
