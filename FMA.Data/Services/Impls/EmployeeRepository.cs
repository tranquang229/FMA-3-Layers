using FMA.Core.Entities;
using FMA.Data.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FMA.Data.Services.Impls;
public class EmployeeRepository : IEmployeeRepository
{
    private readonly DemoContext _demoContext;

    public EmployeeRepository(DemoContext demoContext)
    {
        _demoContext = demoContext;
    }

    public async Task<IEnumerable<Work>> ListAsync()
    {
        return await _demoContext.Works.ToListAsync();
    }
}
