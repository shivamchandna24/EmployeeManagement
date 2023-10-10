using EmployeeManagement.Controllers.Employee;
using EmployeeManagement.Helpers;
using EmployeeManagement.Helpers.EmployeeHelper;
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
    public partial class EmployeeDeleteForm : Form
    {

        public EmployeeDeleteForm()
        {
            InitializeComponent();
        }

        #region Events
        /// <summary>
        /// REset the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// Delete functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            if (IsFormValid())
            {
                EmployeeDelete employeeDelete = new EmployeeDelete();
                employeeDelete.DeleteEmployee(Convert.ToInt32(txtDeleteEmployeeId.Text.ToString()));
                txtDeleteEmployeeId.Enabled = false;
            }
            else
            {
                MessageBox.Show(EmployeeConstants.InvalidEmployeeId, EmployeeConstants.Validation);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// to clear the field on form
        /// </summary>
        private void ClearForm()
        {
            txtDeleteEmployeeId.Text = string.Empty;
            txtDeleteEmployeeId.Enabled = true;
        }

        /// <summary>
        /// To Validate fields on forms.
        /// </summary>
        /// <returns></returns>
        private bool IsFormValid()
        {
            return CommonHelper.IsValidInt(txtDeleteEmployeeId.Text.ToString());
        }
        #endregion

    }
}
