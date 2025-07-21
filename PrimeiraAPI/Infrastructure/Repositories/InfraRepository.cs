using PrimeiraAPI.Domain.DTOs;
using PrimeiraAPI.Domain.Model.EmployeeAggregate;
using PrimeiraAPI.Infraestrutura;

namespace PrimeiraAPI.Infrastructure.Repositories
{
    public class InfraRepository : EmployeeRepository
    {

        private readonly DataBase _connection = new DataBase();


        public void Add(Employee employee)
        {
            _connection.Employees.Add(employee);
            _connection.SaveChanges();
        }

        public List<EmployeeDTO> Get(int pageNumber, int pageQuantity)
        {
            return _connection.Employees.Skip(pageNumber * pageQuantity)
                .Take(pageQuantity)
                .Select(b =>
                new EmployeeDTO()
                {  // o primeiro é de DTO e o segundo de Employee normal
                    Id = b.id, 
                    NameEmployee = b.name,
                   // Age = b.age,
                    Photo = b.photo
                }).ToList();
        }

        public Employee? Get(int id)
        {
            return _connection.Employees.Find(id);
        }
    }
}
