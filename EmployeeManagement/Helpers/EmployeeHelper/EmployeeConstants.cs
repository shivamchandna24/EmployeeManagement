using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Helpers.EmployeeHelper
{
    /// <summary>
    /// Class having constant values used across Employee project.
    /// </summary>
    public  class EmployeeConstants
    {
        #region API
        public const string SucessStatus = "Success";
        public const string FailureStatus = "Failed";
        public const string NotFound = "Not Found";
        public const string ValidationErrors = "Errors found in data submitted.";
        public const string APIException = "Exception";
        public const string TestAPIURL = "https://gorest.co.in/public-api/";
        public const string TestAccessToken = "0bf7fb56e6a27cbcadc402fc2fce8e3aa9ac2b40d4190698eb4e8df9284e2023";


        #endregion

        #region Config
        public static string FileSavepath = ConfigurationManager.AppSettings["FileSavePath"].ToString();
        #endregion

        #region Gender
        public const string Male = "Male";
        public const string Female = "Female";
        #endregion

        #region Status
        public const string Active = "Active";
        public const string Inactive = "Inactive";
        #endregion

        #region Employee Validation Messages
        public const string Validation = "Validation";
        public const string InvalidEmployeeId = "Please enter valid employee id.";
        public const string InvalidStatus = "Please select status from Active or Inactive.";
        public const string InvalidGender = "Please select status from Male or Female.";
        public const string InvalidName = "Please enter employee name.";
        public const string InvalidEmail = "Please enter valid email.";


        public const string Search = "Search";
        public const string InvalidPage = "Please enter valid page number";
        public const string InvalidPageGreaterThanTotalPage = "Please enter go to page less than total page.";

        #endregion

        #region Employee  Exception

        public const string Exception = "Exception";
        public const string CreateEmployee = "Exception in Create Employee controller.";
        public const string SearchEmployee = "Exception in Search Employee controller.";
        public const string DeleteEmployee = "Exception in Delete Employee controller.";
        public const string UpdateEmployee = "Exception in Update Employee controller.";
        public const string ErrorExportingData = "Error Exporting filnename : ";
        #endregion

        #region Employee Messages

        public const string EmployeeCreated = "Employee created with ID: ";
        public const string EmployeeNotCreated = "New employee not created. Message from service - ";
        public const string NewEmployee = "New";
        #endregion


    }
}
