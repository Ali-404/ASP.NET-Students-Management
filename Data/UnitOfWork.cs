using StudentsManagement.Data.Repositories.ClasseRepository;
using StudentsManagement.Data.Repositories.StudentRepository;

namespace StudentsManagement.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;

        public IStudentRepository Students { get; private set; }

        public IClasseRepository Classes { get; private set; }

        //constructor
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Students = new StudentRepository(context);
            Classes = new ClasseRepository(context);
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }


        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
