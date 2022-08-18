using FMA.Domain.Models;

namespace FMA.Domain.Abstractions
{
    public interface IDepartmentService
    {
        List<Department> ProcessDepartments();
    }
}
