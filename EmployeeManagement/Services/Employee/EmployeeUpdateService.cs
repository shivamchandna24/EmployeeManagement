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
    /// Service Class to handle update employee operation.
    /// </summary>
    public class EmployeeUpdateService : IEmployeeUpdate
    {
        #region Variables and Constructor
        public HttpClient ServiceClient { get; set; }
        

        public EmployeeUpdateService() 
        {
            ServiceClient = new HttpClient();
            ServiceClient.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BaseUrl"]));
            ServiceClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", CommonHelper.DecodeFromBase64(ConfigurationManager.AppSettings["BearerToken"]));

        }

        /// <summary>
        /// Test Project Setting  
        /// </summary>
        /// <param name="isUnitTest"></param>
        public EmployeeUpdateService(bool isUnitTest)
        {
            ServiceClient = new HttpClient();
            ServiceClient.BaseAddress = new Uri(EmployeeConstants.TestAPIURL);
            ServiceClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", EmployeeConstants.TestAccessToken);

        }
        #endregion

        #region Methods

        /// <summary>
        /// Service method to Update employee record.
        /// </summary>
        /// <param name="employeeRequest"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> UpdateEmployee(EmployeeRequest employeeRequest)
        {
            try
            {
                string result = string.Empty;
                string jsonString = JsonConvert.SerializeObject(employeeRequest);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                HttpResponseMessage httpResponseMessage = await this.ServiceClient.PutAsync("users/" + employeeRequest.EmployeeId.ToString(), content);
                return httpResponseMessage;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, EmployeeConstants.APIException);
                return null;
            }
          
        }

        /// <summary>
        /// Service method to fetch details of employee to be updated.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<SingleEmployeeResponse> GetEmployeeById(int employeeId)
        {
            try
            {
                var response = (await this.ServiceClient.GetAsync("users/" + employeeId.ToString())).Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SingleEmployeeResponse?>(response.Result.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, EmployeeConstants.APIException);
                return null;
            }
        }
        #endregion
    }
}
