using EmployeeManagement.Views.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Views
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will be developed after PEAK");
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeMaster employeeMaster = new EmployeeMaster();
            employeeMaster.ShowDialog();
        }
    }
}
