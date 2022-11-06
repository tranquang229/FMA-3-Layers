using FMA.Core.Entities;

namespace FMA.Data.Services.Interfaces;

public interface IEmployeeRepository
{
    Task<IEnumerable<Work>> ListAsync();
}