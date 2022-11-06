using FMA.Core.Entities;

namespace FMA.BL.Services.Interfaces;

public interface IEmployeeBiz
{
    Task<IEnumerable<Work>> ListAsync();
}