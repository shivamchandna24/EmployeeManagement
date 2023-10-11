using EmployeeManagement;
using EmployeeManagement.Models.Employee;
using EmployeeManagement.Services;
using EmployeeManagement.Services.Employee;
using System.Net.Http;

namespace EmployeeManagementTest
{
    [TestClass]
    public class EmployeeCreateTest
    { 
        #region Tests Positive
        [TestMethod]
        
        public void TestCreateActiveMaleEmployee()
        {
            EmployeeRequest employeeInfo = new EmployeeRequest();

            employeeInfo.Name = "rohit_sharma";
            employeeInfo.Email = "rohit_sharma@test.com";
            employeeInfo.Gender = "Male";
            employeeInfo.Status = "Active";


            var response = new EmployeeCreateService(true).CreateNewEmployee(employeeInfo).Result;
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void TestCreateActiveFemaleEmployee()
        {
            EmployeeRequest employeeInfo = new EmployeeRequest
            {
                Name = "anjum",
                Email = "anjumchopra@test.com",
                Gender = "Female",
                Status = "Active"
            };
            var response = new EmployeeCreateService(true).CreateNewEmployee(employeeInfo).Result;
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void TestCreateInactiveMaleEmployee()
        {
            EmployeeRequest employeeInfo = new EmployeeRequest
            {
                Name = "Sourav_ganguly",
                Email = "dada@test.com",
                Gender = "Male",
                Status = "Inactive"
            };
            var response = new EmployeeCreateService(true).CreateNewEmployee(employeeInfo).Result;
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void TestCreateInactiveFemaleEmployee()
        {
            EmployeeRequest employeeInfo = new EmployeeRequest
            {
                Name = "jhulan",
                Email = "1goswami@test.com",
                Gender = "Female",
                Status = "Inactive"
            };
            var response = new EmployeeCreateService(true).CreateNewEmployee(employeeInfo).Result;
            Assert.IsNotNull(response);
        }
        #endregion

        #region Negative
        [TestMethod]
        public void TestCreateWrongGenderEmployee()
        {
            EmployeeRequest employeeInfo = new EmployeeRequest
            {
                Name = "1",
                Email = "1goswami@test.com",
                Gender = "Fmale",
                Status = "Inactive"
            };
            var response = new EmployeeCreateService(true).CreateNewEmployee(employeeInfo).Result;
            Assert.IsNull(response);
        }

        [TestMethod]
        public void TestCreateWrongStatusEmployee()
        {
            EmployeeRequest employeeInfo = new EmployeeRequest
            {
                Name = "1",
                Email = "12@test.com",
                Gender = "Male",
                Status = "tive"
            };
            var response = new EmployeeCreateService(true).CreateNewEmployee(employeeInfo).Result;
            Assert.IsNull(response);
        }
        #endregion
    }
}