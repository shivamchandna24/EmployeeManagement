using EmployeeManagement.Helpers;
using EmployeeManagement.Helpers.EmployeeHelper;
using EmployeeManagement.Interfaces.Employee;
using EmployeeManagement.Models.Employee;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Services.Employee
{
    /// <summary>
    /// Class to invoke API related to create new employee.
    /// </summary>
    public class EmployeeCreateService : IEmployeeCreate
    {
        #region Variables and Constructor
        public HttpClient ServiceClient { get; set; }


        public EmployeeCreateService()
        {
            ServiceClient = new HttpClient();
            ServiceClient.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BaseUrl"]));
            ServiceClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", CommonHelper.DecodeFromBase64(ConfigurationManager.AppSettings["BearerToken"]));
        }

        /// <summary>
        /// Test Project constructor
        /// </summary>
        /// <param name="unitTest"></param>
        public EmployeeCreateService(bool unitTest)
        {
            ServiceClient = new HttpClient();
            ServiceClient.BaseAddress = new Uri(EmployeeConstants.TestAPIURL);
            ServiceClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", EmployeeConstants.TestAccessToken);
        }

        #endregion

        #region Method
        /// <summary>
        /// Service method to invoke API.
        /// </summary>
        /// <param name="employeeRequest"></param>
        /// <returns></returns>
        public async Task<string> CreateNewEmployee(EmployeeRequest employeeRequest)
        {
            string jsonString = JsonConvert.SerializeObject(employeeRequest);
            string result = string.Empty;
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await this.ServiceClient.PostAsync("users", content);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
                CreateEmployeeResponse? obj = JsonConvert.DeserializeObject<CreateEmployeeResponse>(result);
                if (obj == null)
                    result = EmployeeConstants.SucessStatus;
                else
                {
                    result = obj.code == 201 ? EmployeeConstants.SucessStatus
                        : obj.code == 422 ? ("Please enter all employee information to create new Emplooyee. ") : obj.data.ToString();//objData.ToString()

                    employeeRequest.EmployeeId = (obj.code == 201) ? JsonConvert.DeserializeObject<EmployeeRequest>(obj.data.ToString()).EmployeeId : 0;
                }

            }
            return result;

            
        }
        #endregion




    }
}
