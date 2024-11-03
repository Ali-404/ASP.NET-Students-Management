namespace StudentsManagement.Data.Models
{
    public class Student
    {

        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime BirdDate { get; set; }
        public int Gender { get; set; }
        public int FinalMark { get; set; }
            

        public Classe? StudentClasse { get; set; }


    }
}
