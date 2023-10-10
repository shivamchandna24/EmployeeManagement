using EmployeeManagement.Controllers.Employee;
using EmployeeManagement.Helpers;
using EmployeeManagement.Helpers.EmployeeHelper;
using EmployeeManagement.Interfaces.Employee;
using EmployeeManagement.Models.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeManagement.Views.Employee
{
    public partial class EmployeeSearchForm : Form
    {
        EmployeeSearch searchEmployeeController;

        private List<EmployeeRequest> employeeDataList { get; set; }
        public EmployeeSearchForm()
        {
            InitializeComponent();
            HideControls();
            searchEmployeeController = new EmployeeSearch();
        }

        #region Event
        private async void btnSearchAll_Click(object sender, EventArgs e)
        {
            txtSearchText.Text = string.Empty; btnGoToPage.Visible = true;
            SearchEmployeeResponse employeeData = await searchEmployeeController.GetAllEmployees();
            FillControls(employeeData);
        }

        private async void btnGoToPage_Click(object sender, EventArgs e)
        {
            txtSearchText.Clear();
            if (!CommonHelper.IsValidInt(txtGoToPage.Text.ToString()))
            {
                MessageBox.Show(EmployeeConstants.InvalidPage, EmployeeConstants.Validation);
                return;
            }

            int goToPageNumber = Convert.ToInt32(txtGoToPage.Text.ToString());
            if (goToPageNumber < 1 || goToPageNumber > Convert.ToInt32(txtTotalPage.Text.ToString()))
            {
                MessageBox.Show(EmployeeConstants.InvalidPageGreaterThanTotalPage, EmployeeConstants.Validation);
                return;
            }
            dgvSearchRecords.DataSource = null;
            SearchEmployeeResponse employeePageData = await searchEmployeeController.GetEmployeesByPagenumber(goToPageNumber);
            FillControls(employeePageData);
        }

        private async void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (IsEmployeeNameValid())
            {

                SearchEmployeeResponse employeeNameData = await searchEmployeeController.GetEmployeeByName(txtSearchText.Text.ToString());
                FillControls(employeeNameData);
            }
            else
            {
                MessageBox.Show(EmployeeConstants.InvalidName, EmployeeConstants.Validation);
                return;
            }
        }

        private async void btnSearchByID_Click(object sender, EventArgs e)
        {
            btnGoToPage.Visible = false;
            btnExportToCSV.Enabled = false;
            if (IsEmployeeIdValid())
            {
                int employeeId = Convert.ToInt32(txtSearchText.Text.ToString());
                SingleEmployeeResponse employeeIDData = await searchEmployeeController.GetEmployeeById(employeeId);
                FillControlsForSingleResponse(employeeIDData);
            }
            else
            {
                MessageBox.Show(EmployeeConstants.InvalidEmployeeId, EmployeeConstants.Validation);
                return;
            }

        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (employeeDataList.Count > 0)
            {
                ExportToCSV<EmployeeRequest>.objList = employeeDataList;
                string filename = ExportToCSV<EmployeeRequest>.ExportData();
            }
        }


        #endregion

        #region Methods

        /// <summary>
        /// Fill the pagination related fields
        /// </summary>
        /// <param name="metaData"></param>
        private void FillPaginationFields(MetaData metaData)
        {
            txtTotalPage.Text = (metaData.pagination != null) ? metaData.pagination.pages.ToString() : string.Empty;
            txtCurrentPage.Text = (metaData.pagination != null) ? metaData.pagination.page.ToString() : string.Empty;
            txtTotalRecords.Text = (metaData.pagination != null) ? metaData.pagination.total.ToString() : string.Empty;
            txtLimitPerPage.Text = (metaData.pagination != null) ? metaData.pagination.limit.ToString() : string.Empty;
        }

        /// <summary>
        /// Fill The Grid and Pagination data
        /// </summary>
        /// <param name="employeeData"></param>
        private void FillControls(SearchEmployeeResponse employeeData)
        {
            btnExportToCSV.Enabled = true;
            if (employeeData == null)
            {
                MessageBox.Show(EmployeeConstants.NotFound, EmployeeConstants.Search);
            }
            if (employeeData != null && employeeData.meta != null)
            {
                gbSearchData.Visible = true;
                FillPaginationFields(employeeData.meta);
            }
            if (employeeData?.data.Count > 0)
            {
                ResetGrid();
                employeeDataList = employeeData.data;
                dgvSearchRecords.DataSource = employeeData.data;
                MakeReadOnlyColumnsGrid();

            }
        }

        /// <summary>
        /// Hide controls on form
        /// </summary>
        private void HideControls()
        {
            gbSearchData.Visible = false;
            btnExportToCSV.Enabled = false;
        }

        /// <summary>
        /// Fill Control when one employee is searched.
        /// </summary>
        /// <param name="employee"></param>
        private void FillControlsForSingleResponse(SingleEmployeeResponse employee)
        {
            if (employee == null)
            {
                MessageBox.Show(EmployeeConstants.NotFound, EmployeeConstants.Validation);
                return;
            }
            else if (employee != null)
            {
                if (employee.meta != null)
                {
                    FillPaginationFields(employee.meta);
                }
                else
                {
                    ResetPaginationFields();
                }

            }
            // Status
            ShowStatusMessageForSingleResponse(employee);

        }

        /// <summary>
        /// Show status messages when one employee is searched. 
        /// </summary>
        /// <param name="singleEmployeeResponse"></param>
        private void ShowStatusMessageForSingleResponse(SingleEmployeeResponse singleEmployeeResponse)
        {
            if (singleEmployeeResponse.code == 200)
            {

                List<EmployeeRequest> employeeData = new List<EmployeeRequest> { singleEmployeeResponse.data };
                if (employeeData.Count > 0)
                {
                    gbSearchData.Visible = true;
                }
                ResetGrid();
                dgvSearchRecords.DataSource = employeeData;
                MakeReadOnlyColumnsGrid();
            }
            else if (singleEmployeeResponse.code == 404)
            {
                MessageBox.Show($"Employee Id: {txtSearchText.Text} not found");
            }
        }

        /// <summary>
        ///  TO Reset pagination fields
        /// </summary>
        private void ResetPaginationFields()
        {
            txtCurrentPage.Clear();
            txtGoToPage.Clear();
            txtLimitPerPage.Clear();
            txtTotalPage.Clear();
            txtTotalRecords.Clear();
        }

        /// <summary>
        /// Reset the Grid data
        /// </summary>
        private void ResetGrid()
        {
            dgvSearchRecords.DataSource = null;
            dgvSearchRecords.Rows.Clear();
            dgvSearchRecords.Columns.Clear();

        }

        /// <summary>
        /// To validate the fields in Form
        /// </summary>
        /// <returns></returns>
        private bool IsEmployeeIdValid()
        {
            return CommonHelper.IsValidInt(txtSearchText.Text.ToString());
        }

        /// <summary>
        /// TO check if Field has employee name to be searched.
        /// </summary>
        /// <returns></returns>
        private bool IsEmployeeNameValid()
        {
            return CommonHelper.IsNotEmptyText(txtSearchText.Text.ToString());
        }
        /// <summary>
        /// To make few columns read only.
        /// </summary>
        private void MakeReadOnlyColumnsGrid()
        {
            foreach (DataGridViewColumn column in dgvSearchRecords.Columns)
            {
                column.ReadOnly = true;
            }
        }

        #endregion

    }
}
