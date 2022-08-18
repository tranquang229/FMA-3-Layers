using FMA.Domain.Abstractions;
using FMA.Domain.Models;

namespace FMA.Service
{
    public class DepartmentService: IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public List<Department> ProcessDepartments()
        {
            return _departmentRepository.ProcessDepartments();
        }
    }
}
