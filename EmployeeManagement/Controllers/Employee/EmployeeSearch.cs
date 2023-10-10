using EmployeeManagement.Helpers.EmployeeHelper;
using EmployeeManagement.Interfaces.Employee;
using EmployeeManagement.Models.Employee;
using EmployeeManagement.Services.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers.Employee
{
    /// <summary>
    /// Controller to deal with search employee operations only.
    /// </summary>
    public class EmployeeSearch
    {
        #region Variables and COnstructor
        private IEmployeeSearch iEmployeeSearchService;
        public EmployeeSearch()
        {
            iEmployeeSearchService = new EmployeeSearchService();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Call to invoke service which will return all employees.
        /// </summary>
        /// <returns></returns>
        public async Task<SearchEmployeeResponse> GetAllEmployees()
        {
            try
            {
                SearchEmployeeResponse searchEmployeeResponse = await iEmployeeSearchService.GetEmployees();
                return searchEmployeeResponse;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, EmployeeConstants.Exception);
                return null;
            }
        }

        /// <summary>
        /// Call to invoke service which will return all employees on a given page.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public async Task<SearchEmployeeResponse> GetEmployeesByPagenumber(int pageNumber)
        {
            try
            {
                SearchEmployeeResponse searchEmployeeResponse = await iEmployeeSearchService.GetEmployeeByPagenumber(pageNumber);
                return searchEmployeeResponse;
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, EmployeeConstants.Exception);
                return null;
            }
        }

        /// <summary>
        /// Call to invoke service which will return employee based on ID.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<SingleEmployeeResponse> GetEmployeeById(int employeeId)
        {
            try
            {
                SingleEmployeeResponse searchEmployeeIdResponse = await iEmployeeSearchService.GetEmployeeById(employeeId);
                return searchEmployeeIdResponse;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, EmployeeConstants.Exception);
                return null;
            }
        }

        public async Task<SearchEmployeeResponse> GetEmployeeByName(string name)
        {
            try
            {
                SearchEmployeeResponse searchEmployeeNameResponse = await iEmployeeSearchService.SearchEmployeeByName(name);
                return searchEmployeeNameResponse;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, EmployeeConstants.Exception);
                return null;
            }
        }

        #endregion
    }
}
