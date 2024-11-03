using Microsoft.EntityFrameworkCore;
using StudentsManagement.Data.Models;
using StudentsManagement.Data.Repositories;

namespace StudentsManagement.Data.Repositories.StudentRepository
{


    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext context) : base(context)
        {
        }



    }
}
