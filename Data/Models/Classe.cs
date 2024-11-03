namespace StudentsManagement.Data.Models
{
    public class Classe
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<Student> Students { get; set; } = [];

    }
}
