namespace EmployeeManagement.Views.Employee
{
    partial class EmployeeMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbSelectEmployeeOperation = new GroupBox();
            btnUpdateEmployeeMaster = new Button();
            btnSearch = new Button();
            btnDeleteEmployeeMaster = new Button();
            btnCreateEmploye = new Button();
            gbSelectEmployeeOperation.SuspendLayout();
            SuspendLayout();
            // 
            // gbSelectEmployeeOperation
            // 
            gbSelectEmployeeOperation.Controls.Add(btnUpdateEmployeeMaster);
            gbSelectEmployeeOperation.Controls.Add(btnSearch);
            gbSelectEmployeeOperation.Controls.Add(btnDeleteEmployeeMaster);
            gbSelectEmployeeOperation.Controls.Add(btnCreateEmploye);
            gbSelectEmployeeOperation.Location = new Point(96, 51);
            gbSelectEmployeeOperation.Name = "gbSelectEmployeeOperation";
            gbSelectEmployeeOperation.Size = new Size(1100, 348);
            gbSelectEmployeeOperation.TabIndex = 0;
            gbSelectEmployeeOperation.TabStop = false;
            gbSelectEmployeeOperation.Text = "Select Operation";
            // 
            // btnUpdateEmployeeMaster
            // 
            btnUpdateEmployeeMaster.BackColor = SystemColors.ButtonHighlight;
            btnUpdateEmployeeMaster.Image = Properties.Resources.Edit_Small;
            btnUpdateEmployeeMaster.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateEmployeeMaster.Location = new Point(587, 225);
            btnUpdateEmployeeMaster.Name = "btnUpdateEmployeeMaster";
            btnUpdateEmployeeMaster.Size = new Size(259, 102);
            btnUpdateEmployeeMaster.TabIndex = 3;
            btnUpdateEmployeeMaster.Text = "Update";
            btnUpdateEmployeeMaster.UseVisualStyleBackColor = false;
            btnUpdateEmployeeMaster.Click += btnUpdateEmployeeMaster_Click;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.Search_small;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(63, 225);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(264, 102);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search and Export";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDeleteEmployeeMaster
            // 
            btnDeleteEmployeeMaster.Image = Properties.Resources.Delete_Small1;
            btnDeleteEmployeeMaster.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteEmployeeMaster.Location = new Point(587, 69);
            btnDeleteEmployeeMaster.Name = "btnDeleteEmployeeMaster";
            btnDeleteEmployeeMaster.Size = new Size(259, 87);
            btnDeleteEmployeeMaster.TabIndex = 1;
            btnDeleteEmployeeMaster.Text = "Delete";
            btnDeleteEmployeeMaster.UseVisualStyleBackColor = true;
            btnDeleteEmployeeMaster.Click += btnDeleteEmployeeMaster_Click;
            // 
            // btnCreateEmploye
            // 
            btnCreateEmploye.Image = Properties.Resources.Add_small;
            btnCreateEmploye.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateEmploye.Location = new Point(63, 69);
            btnCreateEmploye.Name = "btnCreateEmploye";
            btnCreateEmploye.Size = new Size(264, 87);
            btnCreateEmploye.TabIndex = 0;
            btnCreateEmploye.Text = "Create ";
            btnCreateEmploye.UseVisualStyleBackColor = true;
            btnCreateEmploye.Click += btnCreateEmploye_Click;
            // 
            // EmployeeMaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 579);
            Controls.Add(gbSelectEmployeeOperation);
            Name = "EmployeeMaster";
            Text = "Employee Master";
            gbSelectEmployeeOperation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSelectEmployeeOperation;
        private Button btnCreateEmploye;
        private Button btnDeleteEmployeeMaster;
        private Button btnSearch;
        private Button btnUpdateEmployeeMaster;
    }
}