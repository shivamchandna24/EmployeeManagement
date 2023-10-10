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
    /// Service Class having Search Employee Functionality
    /// </summary>
    public class EmployeeSearchService : IEmployeeSearch
    {
        #region variables and constructor
        public HttpClient ServiceClient { get; set; }
       
        public EmployeeSearchService()
        {
            ServiceClient = new HttpClient();
            ServiceClient.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BaseUrl"]));
            ServiceClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", CommonHelper.DecodeFromBase64(ConfigurationManager.AppSettings["BearerToken"]));

        }

        /// <summary>
        /// Test project Constructor
        /// </summary>
        /// <param name="isUnitTest"></param>
        public EmployeeSearchService(bool isUnitTest)
        {
            ServiceClient = new HttpClient();
            ServiceClient.BaseAddress = new Uri(EmployeeConstants.TestAPIURL);
            ServiceClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", EmployeeConstants.TestAccessToken);

        }
        #endregion

        #region Methods
        /// <summary>
        /// Service Method to Get All Employees.
        /// </summary>
        /// <returns></returns>
        public async Task<SearchEmployeeResponse> GetEmployees()
        {
            try
            {
                var response = (await this.ServiceClient.GetAsync("users")).Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SearchEmployeeResponse>(response?.Result.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, EmployeeConstants.APIException);
                return null;
            }

        }

        /// <summary>
        /// Service Method to Get Employees from a given page.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public async Task<SearchEmployeeResponse> GetEmployeeByPagenumber(int pageNumber)
        {
            try
            {
                var response = (await this.ServiceClient.GetAsync("users?page=" + pageNumber.ToString())).Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SearchEmployeeResponse>(response.Result?.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, EmployeeConstants.APIException);
                return null;
            }
        }

        /// <summary>
        /// Service method to get Employee by Id.
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, EmployeeConstants.APIException);
                return null;
            }
        }

        /// <summary>
        /// Method to search Employee by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<SearchEmployeeResponse> SearchEmployeeByName(string name)
        {
            try
            {
                var response = (await this.ServiceClient.GetAsync("users?name=" + name)).Content.ReadAsStringAsync();
                SearchEmployeeResponse empresponse = JsonConvert.DeserializeObject<SearchEmployeeResponse>(response.Result.ToString());
                return empresponse;
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
