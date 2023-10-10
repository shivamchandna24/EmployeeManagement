using EmployeeManagement.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Interfaces.Employee
{
    public interface IEmployeeCreate
    {
        Task<string>  CreateNewEmployee(EmployeeRequest employeeRequest);

    }
}
