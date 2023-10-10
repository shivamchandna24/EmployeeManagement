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
    /// Controller to deal with Employee Update operations.
    /// </summary>
    public  class EmployeeUpdate
    {
        #region Variables and Constuctor
        public IEmployeeUpdate iEmployeeUpdate { get; set; }
        public EmployeeUpdate()
        {
            iEmployeeUpdate = new EmployeeUpdateService();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to invoke service which Returns employee details based on id.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<SingleEmployeeResponse> GetEmployeeById(int employeeId)
        {
            SingleEmployeeResponse searchEmployeeIdResponse = await iEmployeeUpdate.GetEmployeeById(employeeId);
            return searchEmployeeIdResponse;
        }

        /// <summary>
        /// Method to invoke service to update employee record
        /// </summary>
        /// <param name="employeeRequest"></param>
        public async void UpdateEmployee(EmployeeRequest employeeRequest)
        {
            try
            {
                string result = string.Empty, message = string.Empty;
                var response = await this.iEmployeeUpdate.UpdateEmployee(employeeRequest);
                if (response != null)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadAsStringAsync();
                        CreateEmployeeResponse? obj = JsonConvert.DeserializeObject<CreateEmployeeResponse>(result);
                        employeeRequest.EmployeeId = (obj?.code == 200) ? JsonConvert.DeserializeObject<EmployeeRequest>(obj.data.ToString()).EmployeeId : 0;
                        message = CreateDisplayMessage(obj);
                    }
                    else
                    {
                        message = Convert.ToString(response.StatusCode);
                    }
                    ShowMessage(employeeRequest.EmployeeId, message);
                }
            }
            catch(Exception ) 
            {
                MessageBox.Show(EmployeeConstants.UpdateEmployee, EmployeeConstants.Exception);
            }
        }

        /// <summary>
        /// Method to create the message to be shown to user
        /// </summary>
        /// <param name="responseObject"></param>
        /// <returns></returns>
        private string CreateDisplayMessage(CreateEmployeeResponse responseObject)
        {
            if (responseObject.code == 200)
            {
                return EmployeeConstants.SucessStatus;
            }
            else if (responseObject.code == 202 )
            {
                return "Request accepted by API";
            }
            else if (responseObject.code == 204)
            {
                return "No content returned by API";
            }

            else if (responseObject.code == 422)
            {
                return EmployeeConstants.ValidationErrors;
            }
            else if (responseObject.code == 404)
            {
                return "Not Found";
            }
            else
            {
                return responseObject.data.ToString();
            }



        }

        /// <summary>
        /// Method to show the message to user.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="message"></param>
        private void ShowMessage(int employeeId, string message)
        {
            if (employeeId > 0)
            {
                MessageBox.Show($"Employee updated with ID {employeeId}", "Update");

            }
            else
            {
                MessageBox.Show($"Employee not update. Message from service - {message}", "Update");
            }


        }

        #endregion

    }
}
