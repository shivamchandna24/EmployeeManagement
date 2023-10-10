using EmployeeManagement;
using EmployeeManagement.Models.Employee;
using EmployeeManagement.Services;
using EmployeeManagement.Services.Employee;
using System.Net.Http;

namespace EmployeeManagementTest
{
    [TestClass]
    public class EmployeeUpdateTest
    {
        #region Positive
        [TestMethod]
        public void TestUpdateExistingEmployee()
        {
            EmployeeRequest employeeRequest = new EmployeeRequest
            {
                EmployeeId = 5313601,
                Name = "Name",
                Email = "123@fgv.com",
                Gender = "Male",
                Status = "Active"
            };
            var response = new EmployeeUpdateService(true).UpdateEmployee(employeeRequest);
            Assert.IsNotNull(response);


        }
        #endregion

        #region Negative
        [TestMethod]
        public void TestUpdateNotExistingEmployee()
        {
            EmployeeRequest employeeRequest = new EmployeeRequest
            {
                EmployeeId = 99,
                Name = "Name",
                Email = "123@fgv.com",
                Gender = "Male",
                Status = "Active"
            };
            var response = new EmployeeUpdateService(true).UpdateEmployee(employeeRequest);
            Assert.IsNotNull(response);
        }

        #endregion


    }
}