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
    /// Service to Invoke API for Delete Employee 
    /// </summary>
    public class EmployeeDeleteService : IEmployeeDelete
    {
        #region Variables and Constructor
        public HttpClient ServiceClient { get; set; }

        public EmployeeDeleteService()
        {
            ServiceClient = new HttpClient();
            ServiceClient.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BaseUrl"]));
            ServiceClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", CommonHelper.DecodeFromBase64(ConfigurationManager.AppSettings["BearerToken"]));

        }

        /// <summary>
        /// Test project Constuctor
        /// </summary>
        /// <param name="isUnitTest"></param>
        public EmployeeDeleteService(bool isUnitTest)
        {
            ServiceClient = new HttpClient();
            ServiceClient.BaseAddress = new Uri(EmployeeConstants.TestAPIURL);
            ServiceClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", EmployeeConstants.TestAccessToken);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method calling API to delete employee records. 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<string> DeleteEmployee(int employeeId)
        {
            string result = string.Empty;
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri(this.ServiceClient?.BaseAddress?.ToString() + "users/" + employeeId.ToString());
            request.Method = HttpMethod.Delete;
            var response = await this.ServiceClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
                DeleteEmployeeResponse obj = JsonConvert.DeserializeObject<DeleteEmployeeResponse>(result);
                if (obj.data == null && obj.code == 204)
                {
                    result = EmployeeConstants.SucessStatus;
                }
                else if (obj.code == 404)
                {
                    result = EmployeeConstants.NotFound;
                }

            }
            return result;
        }
        #endregion

    }
}
