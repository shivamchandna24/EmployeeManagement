using EmployeeManagement.Interfaces.Employee;
using EmployeeManagement.Models.Employee;
using EmployeeManagement.Services.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EmployeeManagement.Helpers.EmployeeHelper;

namespace EmployeeManagement.Controllers.Employee
{
    /// <summary>
    /// Controller to deal with Delete Employee Scenario
    /// </summary>
    public class EmployeeDelete
    {
        #region Variables
        private IEmployeeDelete iEmployeeDelete { get; set; }
        #endregion

        #region Constructors
        public EmployeeDelete()
        {
            iEmployeeDelete = new EmployeeDeleteService();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to call delete Service.
        /// </summary>
        /// <param name="employeeId"></param>
        public async void DeleteEmployee(int employeeId)
        {
            try
            {
                EmployeeRequest employeeRequest = new EmployeeRequest()
                {
                    EmployeeId = employeeId
                };
                string responseStatus = string.Empty;
                responseStatus = await this.iEmployeeDelete.DeleteEmployee(employeeRequest.EmployeeId);

                MessageBox.Show($"Employee ID {employeeId} : {responseStatus}", "DELETE");
            }
            catch (Exception ) 
            {
                MessageBox.Show(EmployeeConstants.DeleteEmployee, EmployeeConstants.Exception);
            }
        }

        #endregion
    }
}
