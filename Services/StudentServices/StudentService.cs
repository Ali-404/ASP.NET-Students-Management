using StudentsManagement.Data;
using StudentsManagement.Data.Models;
using System.Collections;

namespace StudentsManagement.Services.StudentServices
{



    public class StudentService : IStudentService
    {

        private readonly IUnitOfWork _unitofwork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitofwork = unitOfWork;
        }




        public async Task CreateStudent(string firstName, string lastName, int gendar, DateTime birdDate)
        {
            Student student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Gender = gendar,
                BirdDate = birdDate

            };
            await _unitofwork.Students.AddAsync(student);


        }

        public async Task DeleteStudentById(int id)
        {
            Student studentToRemove = await _unitofwork.Students.GetAsync(id);
            _unitofwork.Students.Remove(studentToRemove);
            await _unitofwork.Complete();
        }

        public async Task DeleteStudentByName(string firstName, string lastName)
        {
             IEnumerable<Student> studentsToRemove = await _unitofwork.Students.FindAsync(
                c => c.FirstName == firstName && c.LastName == lastName
            );

            _unitofwork.Students.RemoveRange(studentsToRemove);

        }


        public async Task SetStudentFinalMark(int id, int mark)
        {
            Student student = await _unitofwork.Students.GetAsync(id);
            student.FinalMark = mark;

            
        }


        public async Task SaveChanges()
        {
            await _unitofwork.Complete();
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _unitofwork.Students.GetAllAsync();
        }

	}
}
