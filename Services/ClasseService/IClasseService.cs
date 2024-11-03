using StudentsManagement.Data.Models;

namespace StudentsManagement.Services.ClasseService
{
    public interface IClasseService
    {
        Task AddClasse(string name);
        Task DeleteClasseByName(string name);
        Task DeleteClasseById(int id);

        Task<IEnumerable<Classe>> GetAllClasse();


        Task AddStudentToClasse(Student student,int id);
    }
}
