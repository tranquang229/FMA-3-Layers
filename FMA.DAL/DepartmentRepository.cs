using FMA.Domain.Abstractions;
using FMA.Domain.Models;

namespace FMA.DAL
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public List<Department> ProcessDepartments()
        {
            return Enumerable.Range(1, 5).Select(index => new Department
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
                .ToList();
        }
    }
}