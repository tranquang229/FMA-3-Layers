using FMA.Domain.Abstractions;
using FMA.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace FMA.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IDepartmentService departmentService, ILogger<WeatherForecastController> logger)
        {
            _departmentService = departmentService;
            _logger = logger;
        }


        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Department> Get()
        {
            return _departmentService.ProcessDepartments();
        }
    }
}