using EmployeeManagement;
using EmployeeManagement.Models.Employee;
using EmployeeManagement.Services;
using EmployeeManagement.Services.Employee;
using System.Net.Http;

namespace EmployeeManagementTest
{
    [TestClass]
    public class EmployeeSearchTest
    {
        #region Positive
        [TestMethod]
        public void TestGetEmployees()
        {
            SearchEmployeeResponse response = new EmployeeSearchService(true).GetEmployees().Result;
            Assert.AreEqual(response.code, 200);
        }
        

        [TestMethod]
        public void TestGetEmployeeByExistingId()
        {
            //5313601
            SingleEmployeeResponse response = new EmployeeSearchService(true).GetEmployeeById(5327279).Result;
            Assert.AreEqual(response.code, 200);
        }

        #endregion

        #region Negative
        [TestMethod]
        public void TestGetEmployeeByNonExistingId()
        {
            SingleEmployeeResponse response = new EmployeeSearchService(true).GetEmployeeById(99).Result;
            Assert.AreEqual(response.code, 404);
        }
        #endregion


    }
}