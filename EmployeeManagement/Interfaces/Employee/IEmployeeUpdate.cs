using EmployeeManagement.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Interfaces.Employee
{
    public  interface IEmployeeUpdate
    {
        Task<SingleEmployeeResponse> GetEmployeeById(int empId);
       
        Task<HttpResponseMessage> UpdateEmployee(EmployeeRequest employeeRequest);
       
    }
}
