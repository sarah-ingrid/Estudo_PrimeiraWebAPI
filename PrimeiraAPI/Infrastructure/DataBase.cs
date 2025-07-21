using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Domain.Model.CompanyAggregate;
using PrimeiraAPI.Domain.Model.EmployeeAggregate;

namespace PrimeiraAPI.Infraestrutura
{
    public class DataBase : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                const string servidor = "localhost";
                const string bancoDados = "dbWebAPI";
                const string usuario = "root";
                const string senha = "683493";

                string connectionString = $"server={servidor};user id={usuario};database={bancoDados};password={senha};";

                optionsBuilder.UseMySQL(connectionString);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar no banco", ex);
            }
        }

    }
}
