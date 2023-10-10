using EmployeeManagement;
using EmployeeManagement.Models.Employee;
using EmployeeManagement.Services;
using EmployeeManagement.Services.Employee;
using System.Net.Http;

namespace EmployeeManagementTest
{
    [TestClass]
    public class EmployeeDeleteTest
    {
        #region Positive

        [TestMethod]
        public void TestDeleteEmployeeByIdNotExists()
        {
            var response = new EmployeeDeleteService(true).DeleteEmployee(47).Result;
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void TestDeleteEmployeeByValidId()
        {
            string response = new EmployeeDeleteService(true).DeleteEmployee(5327398).Result;
            Assert.IsNotNull(response);
            Assert.AreEqual(response, "Success");
        }
        #endregion

        #region Negative
        [TestMethod]
        public void TestDeleteEmployeeByNegativeId()
        {
            string response = new EmployeeDeleteService(true).DeleteEmployee(-47).Result;
            Assert.IsNotNull(response);
        }
        #endregion
    }
}