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
    public partial class EmployeeMaster : Form
    {
        public EmployeeMaster()
        {
            InitializeComponent();
        }

        private void btnCreateEmploye_Click(object sender, EventArgs e)
        {
            EmployeeCreateForm employeeCreateForm = new EmployeeCreateForm();
            employeeCreateForm.ShowDialog();
        }

        private void btnDeleteEmployeeMaster_Click(object sender, EventArgs e)
        {
            EmployeeDeleteForm employeeDeleteForm = new EmployeeDeleteForm();
            employeeDeleteForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeSearchForm employeeSearchForm = new EmployeeSearchForm();
            employeeSearchForm.ShowDialog();
        }

        private void btnUpdateEmployeeMaster_Click(object sender, EventArgs e)
        {
            EmployeeUpdateForm employeeUpdateForm = new EmployeeUpdateForm();
            employeeUpdateForm.ShowDialog();
        }
    }
}
