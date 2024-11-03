using StudentsManagement.Data;
using StudentsManagement.Data.Models;

namespace StudentsManagement.Services.ClasseService
{
    public class ClasseService : IClasseService
    {

        private readonly IUnitOfWork _unitOfWork;

        public ClasseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddClasse(string name)
        {
            Classe classe = new Classe() { Name = name};
            await _unitOfWork.Classes.AddAsync(classe);
        }

        public async Task AddStudentToClasse(Student student, int id)
        {
            if (student.StudentClasse?.Id == id) {
                //dispaly a messaage
                return;
            }
            Classe classe = await _unitOfWork.Classes.GetAsync(id);
            classe.Students.Add(student);

        }

        public async Task DeleteClasseById(int id)
        {
            Classe classe = await _unitOfWork.Classes.GetAsync(id);
            _unitOfWork.Classes.Remove(classe);

        }

        public async Task DeleteClasseByName(string name)
        {
            IEnumerable<Classe> classes = await _unitOfWork.Classes.FindAsync(c => c.Name == name);
            _unitOfWork.Classes.RemoveRange(classes);
        }

        public async Task<IEnumerable<Classe>> GetAllClasse()
        {
            return await _unitOfWork.Classes.GetAllAsync();
        }

       

    }
}
