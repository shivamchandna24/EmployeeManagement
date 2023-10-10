using EmployeeManagement.Controllers.Employee;
using EmployeeManagement.Helpers;
using EmployeeManagement.Helpers.EmployeeHelper;
using EmployeeManagement.Models.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Views.Employee
{
    public partial class EmployeeUpdateForm : Form
    {
        EmployeeUpdate updateController;
        public EmployeeUpdateForm()
        {
            InitializeComponent();
            updateController = new EmployeeUpdate();
            HideControls();
        }

        private void HideControls()
        {
            pnlRecordPanel.Visible = false;
        }
        private async void btnFetch_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                MessageBox.Show(EmployeeConstants.InvalidEmployeeId, EmployeeConstants.Validation);
                return;
            }
            pnlRecordPanel.Visible = false;
            int employeeId = Convert.ToInt32(txtUpdateEmployeeId.Text.ToString());
            SingleEmployeeResponse employeeIDData = await updateController.GetEmployeeById(employeeId);

            PerformGridOperations(employeeIDData);
        }

        private void ShowMesages(SingleEmployeeResponse employeeResponse)
        {
            if (employeeResponse.code == 404)
            {
                MessageBox.Show($"EmployeeID: {txtUpdateEmployeeId.Text} {EmployeeConstants.NotFound}");
            }
        }
        private void PerformGridOperations(SingleEmployeeResponse employeeIDData)
        {
            if (employeeIDData == null)
            {
                MessageBox.Show(EmployeeConstants.NotFound);
                return;
            }
            if (employeeIDData != null && employeeIDData.data != null && employeeIDData.data.EmployeeId > 0)
            {
                List<EmployeeRequest> employeeData = new List<EmployeeRequest> { employeeIDData.data };
                if (employeeData.Count > 0)
                {
                    pnlRecordPanel.Visible = true;

                }
                ResetGrid();
                dgvUpdateRecord.DataSource = employeeData;
                MakeReadOnlyColumnsGrid();
            }

            else
            {
                ShowMesages(employeeIDData);
            }
        }
        private bool IsFormValid()
        {
            return CommonHelper.IsValidInt(txtUpdateEmployeeId.Text.ToString());
        }
        private void ResetGrid()
        {
            dgvUpdateRecord.DataSource = null;
            dgvUpdateRecord.Rows.Clear();
            dgvUpdateRecord.Columns.Clear();
        }

        private void btnUpdateRecords_Click(object sender, EventArgs e)
        {
            EmployeeRequest employeeUpdateRequest = new EmployeeRequest();

            foreach (DataGridViewRow row in dgvUpdateRecord.Rows)
            {
                employeeUpdateRequest.EmployeeId = Convert.ToInt32(row.Cells[0].Value.ToString());
                employeeUpdateRequest.Name = row.Cells[1].Value.ToString();
                employeeUpdateRequest.Email = row.Cells[2].Value.ToString();
                employeeUpdateRequest.Gender = row.Cells[3].Value.ToString().Trim();
                employeeUpdateRequest.Status = row.Cells[4].Value.ToString().Trim();
            }
            if (ValidUpdateRequest(employeeUpdateRequest))
            {
                updateController.UpdateEmployee(employeeUpdateRequest);
            }

        }
        private void MakeReadOnlyColumnsGrid()
        {
            foreach (DataGridViewColumn column in dgvUpdateRecord.Columns)
            {
                if (column.DataPropertyName == "EmployeeId" || column.DataPropertyName == "Gender")
                {
                    column.ReadOnly = true;
                }

            }
        }

        private bool ValidUpdateRequest(EmployeeRequest employeeUpdateRequest)
        {
            if (!employeeUpdateRequest.Gender.IsOneOf(new string[] { EmployeeConstants.Male, EmployeeConstants.Female }))
            {
                MessageBox.Show(EmployeeConstants.InvalidGender, EmployeeConstants.Validation);
                return false;
            }
            else if (!employeeUpdateRequest.Status.IsOneOf(new string[] { EmployeeConstants.Active, EmployeeConstants.Inactive }))
            {
                MessageBox.Show(EmployeeConstants.InvalidStatus, EmployeeConstants.Validation);
                return false;
            }
            else if (!CommonHelper.IsValidEmail(employeeUpdateRequest.Email))
            {
                MessageBox.Show(EmployeeConstants.InvalidEmail, EmployeeConstants.Validation);
                return false;
            }
            return true;
        }

        private void btnResetUpdate_Click(object sender, EventArgs e)
        {
            pnlRecordPanel.Visible = false;
            txtUpdateEmployeeId.Clear();
        }
    }
}
