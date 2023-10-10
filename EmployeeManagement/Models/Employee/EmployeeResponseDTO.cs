using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.Employee
{/// <summary>
/// Constains classes usually to read the response from API for different operation.
/// </summary>
    public class EmployeeResponseDTO
    {

    }


    #region Create
    public class CreateEmployeeResponse
    {
        public int code { get; set; }
        public object data { get; set; }

    }
    #endregion

    #region Delete
    public class DeleteEmployeeResponse
    {
        public int code { get; set; }
        public object data { get; set; }

        public string Message { get; set; }

    }
    public class DeleteEmployeeMessage
    {
        public string Message { get; set; }
    }
    #endregion

    #region Search
    public class SearchEmployeeResponse
    {
        public int code { get; set; }
        public MetaData meta { get; set; }
        public List<EmployeeRequest> data { get; set; }
    }
    public class SingleEmployeeResponse
    {
        public int code { get; set; }
        public MetaData meta { get; set; }
        public EmployeeRequest data { get; set; }
    }
    public class MetaData
    {
        public Pagination pagination { get; set; }
    }
    public class Pagination
    {
        public int total { get; set; }
        public int pages { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
    }
    #endregion

}
