using EmployeeManagement.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Interfaces.Employee
{
    public interface IEmployeeSearch
    {
        Task<SearchEmployeeResponse> GetEmployees();
        
        Task<SearchEmployeeResponse> GetEmployeeByPagenumber(int pageNumber);

        Task<SingleEmployeeResponse> GetEmployeeById(int empId);

        Task<SearchEmployeeResponse> SearchEmployeeByName(string name);

    }
}
