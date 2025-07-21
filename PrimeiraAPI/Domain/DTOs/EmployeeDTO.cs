namespace PrimeiraAPI.Domain.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string NameEmployee { get; set; }
        // sem o Age que vai ser o 'dado sensivel'
       // public int? Age { get; set; }
        public string? Photo { get; set; }


    }
}
