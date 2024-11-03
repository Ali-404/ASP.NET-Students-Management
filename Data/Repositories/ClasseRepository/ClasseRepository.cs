using Microsoft.EntityFrameworkCore;
using StudentsManagement.Data.Models;

namespace StudentsManagement.Data.Repositories.ClasseRepository
{
    public class ClasseRepository : Repository<Classe>, IClasseRepository
    {


        public ClasseRepository(DbContext context) : base(context)
        {
            
        }

        
    }
}
