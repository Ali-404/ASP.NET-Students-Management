using StudentsManagement.Data.Repositories.ClasseRepository;
using StudentsManagement.Data.Repositories.StudentRepository;

namespace StudentsManagement.Data
{
    public interface IUnitOfWork: IAsyncDisposable
    {

        IStudentRepository Students { get; }
        IClasseRepository Classes { get; }

        public Task<int> Complete();

        
    }
}
