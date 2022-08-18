using FMA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMA.Domain.Abstractions
{
    public interface IDepartmentRepository
    {
        List<Department> ProcessDepartments();
    }
}
