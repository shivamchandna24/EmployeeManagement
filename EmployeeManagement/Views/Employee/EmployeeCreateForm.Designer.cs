namespace EmployeeManagement.Views.Employee
{
    partial class EmployeeCreateForm
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
            gbCreateEmployee = new GroupBox();
            btnResetCreateEmployee = new Button();
            btnCreate = new Button();
            rbInactive = new RadioButton();
            rbActive = new RadioButton();
            cbGender = new ComboBox();
            lblStatus = new Label();
            lblGender = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtName = new TextBox();
            lblName = new Label();
            gbCreateEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // gbCreateEmployee
            // 
            gbCreateEmployee.Controls.Add(btnResetCreateEmployee);
            gbCreateEmployee.Controls.Add(btnCreate);
            gbCreateEmployee.Controls.Add(rbInactive);
            gbCreateEmployee.Controls.Add(rbActive);
            gbCreateEmployee.Controls.Add(cbGender);
            gbCreateEmployee.Controls.Add(lblStatus);
            gbCreateEmployee.Controls.Add(lblGender);
            gbCreateEmployee.Controls.Add(txtEmail);
            gbCreateEmployee.Controls.Add(lblEmail);
            gbCreateEmployee.Controls.Add(txtName);
            gbCreateEmployee.Controls.Add(lblName);
            gbCreateEmployee.Dock = DockStyle.Fill;
            gbCreateEmployee.Location = new Point(0, 0);
            gbCreateEmployee.Name = "gbCreateEmployee";
            gbCreateEmployee.Size = new Size(1135, 823);
            gbCreateEmployee.TabIndex = 0;
            gbCreateEmployee.TabStop = false;
            gbCreateEmployee.Text = "New";
            // 
            // btnResetCreateEmployee
            // 
            btnResetCreateEmployee.Location = new Point(555, 339);
            btnResetCreateEmployee.Name = "btnResetCreateEmployee";
            btnResetCreateEmployee.Size = new Size(112, 34);
            btnResetCreateEmployee.TabIndex = 12;
            btnResetCreateEmployee.Text = "Reset";
            btnResetCreateEmployee.UseVisualStyleBackColor = true;
            btnResetCreateEmployee.Click += btnResetCreateEmployee_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(356, 339);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // rbInactive
            // 
            rbInactive.AutoSize = true;
            rbInactive.Location = new Point(555, 263);
            rbInactive.Name = "rbInactive";
            rbInactive.Size = new Size(97, 29);
            rbInactive.TabIndex = 10;
            rbInactive.TabStop = true;
            rbInactive.Text = "Inactive";
            rbInactive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Checked = true;
            rbActive.Location = new Point(356, 263);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(85, 29);
            rbActive.TabIndex = 9;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // cbGender
            // 
            cbGender.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbGender.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female", "Don't want to specify" });
            cbGender.Location = new Point(356, 194);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(182, 33);
            cbGender.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(198, 265);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 25);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(189, 202);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(73, 25);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(356, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(182, 31);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(185, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(81, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email ID:";
            // 
            // txtName
            // 
            txtName.Location = new Point(356, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 31);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(199, 101);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // EmployeeCreateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 823);
            Controls.Add(gbCreateEmployee);
            Name = "EmployeeCreateForm";
            Text = "Create Employee";
            gbCreateEmployee.ResumeLayout(false);
            gbCreateEmployee.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCreateEmployee;
        private Label lblStatus;
        private Label lblGender;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtName;
        private Label lblName;
        private RadioButton rbInactive;
        private RadioButton rbActive;
        private ComboBox cbGender;
        private Button btnCreate;
        private Button btnResetCreateEmployee;
    }
}