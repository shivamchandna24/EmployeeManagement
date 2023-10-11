using EmployeeManagement.Helpers.EmployeeHelper;
using EmployeeManagement.Interfaces.Employee;
using EmployeeManagement.Models.Employee;
using EmployeeManagement.Services.Employee;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers.Employee
{
    /// <summary>
    /// Controller linked with form when we create a new employee
    /// </summary>
    public class EmployeeCreate
    {
        #region variable
        public IEmployeeCreate iEmployeeCreate { get; set; }
        #endregion

        #region Constructor
        public EmployeeCreate()
        {
            iEmployeeCreate = new EmployeeCreateService();
        }

        #endregion

        #region Methods
        /// <summary>
        /// Method from which CreateEmployeeService would be called. 
        /// </summary>
        /// <param name="employeeRequest"></param>
        public async void CreateNewEmployee(EmployeeRequest employeeRequest)
        {
            try
            {
                string result = string.Empty;
                result = await this.iEmployeeCreate.CreateNewEmployee(employeeRequest);
                ShowMessage(employeeRequest.EmployeeId, result);
            }
            catch (Exception)
            {
                MessageBox.Show(EmployeeConstants.CreateEmployee, EmployeeConstants.Exception);
            }
            finally
            {

            }
        }

        /// <summary>
        /// Method to show message based on response from API.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="message"></param>
        private void ShowMessage(int employeeId, string message) 
        {
            if(employeeId>0)
            {
                MessageBox.Show($"{EmployeeConstants.EmployeeCreated} {employeeId}", EmployeeConstants.NewEmployee);

            }
            else
            {
                MessageBox.Show($"{EmployeeConstants.EmployeeNotCreated}{message}", EmployeeConstants.NewEmployee);
            }


        }
        #endregion
    }
}
