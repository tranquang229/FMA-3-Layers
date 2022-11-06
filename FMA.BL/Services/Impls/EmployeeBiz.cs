using FMA.BL.Services.Interfaces;
using FMA.Core.Entities;
using FMA.Data.Services.Interfaces;

namespace FMA.BL.Services.Impls;

public class EmployeeBiz : IEmployeeBiz
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeBiz(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }


    public async Task<IEnumerable<Work>> ListAsync()
    {
        return await _employeeRepository.ListAsync();
    }
}