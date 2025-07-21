using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Application.ViewModel;
using AutoMapper;
using PrimeiraAPI.Domain.DTOs;
using PrimeiraAPI.Domain.Model.EmployeeAggregate;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly ILogger<EmployeeController> _logger;
        private readonly IMapper _mapper;

        public EmployeeController(EmployeeRepository employeeRepository, ILogger<EmployeeController> logger, IMapper mapper)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [Authorize]
        [HttpPost] // add funcionario no banco
        public IActionResult Add([FromForm] EmployeeViewModel employeeView) // vai ficar lá tipo um formulario (no https)
        {
            var filePath = Path.Combine("Storage", employeeView.photo.FileName);

            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            employeeView.photo.CopyTo(fileStream); // copiar o arquivo para o Storage

            var employee = new Employee(employeeView.Name, employeeView.Age, filePath);

            _employeeRepository.Add(employee);


            return Ok();

        }

        [Authorize]
        [HttpPost]
        [Route("{id}/download")]
        public IActionResult DownloadPhoto(int id)
        {
            var employee = _employeeRepository.Get(id);

            var dataBytes = System.IO.File.ReadAllBytes(employee.photo); // tem que retornar data bytes

            return File(dataBytes, "image/png");
        }


        //[Authorize]
        [HttpGet]
        [Route("{id}")]
        public IActionResult Search(int id)
        {

            var employees = _employeeRepository.Get(id);

            var employeesDTOS = _mapper.Map<EmployeeDTO>(employees);

            return Ok(employeesDTOS);
        }
    }
}
