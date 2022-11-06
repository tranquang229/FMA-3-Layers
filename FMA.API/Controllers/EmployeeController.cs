using FMA.BL.Services.Interfaces;
using FMA.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FMA.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController
{
    private readonly IEmployeeBiz _employeeBiz;

    public EmployeeController(IEmployeeBiz employeeBiz)
    {
        _employeeBiz = employeeBiz;
    }

    [HttpGet(Name = "List")]
    public async Task<IEnumerable<Work>> ListAsync()
    {
        return await _employeeBiz.ListAsync();
    }
}