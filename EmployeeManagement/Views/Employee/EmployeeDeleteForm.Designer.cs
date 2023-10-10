namespace EmployeeManagement.Views.Employee
{
    partial class EmployeeDeleteForm
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
            gbDelete = new GroupBox();
            btnDeleteReset = new Button();
            btnEmployeeDelete = new Button();
            txtDeleteEmployeeId = new TextBox();
            lblDelete = new Label();
            gbDelete.SuspendLayout();
            SuspendLayout();
            // 
            // gbDelete
            // 
            gbDelete.AutoSize = true;
            gbDelete.BackColor = SystemColors.Control;
            gbDelete.Controls.Add(btnDeleteReset);
            gbDelete.Controls.Add(btnEmployeeDelete);
            gbDelete.Controls.Add(txtDeleteEmployeeId);
            gbDelete.Controls.Add(lblDelete);
            gbDelete.Location = new Point(56, 88);
            gbDelete.Name = "gbDelete";
            gbDelete.Size = new Size(676, 244);
            gbDelete.TabIndex = 0;
            gbDelete.TabStop = false;
            gbDelete.Text = "Delete";
            // 
            // btnDeleteReset
            // 
            btnDeleteReset.Location = new Point(493, 178);
            btnDeleteReset.Name = "btnDeleteReset";
            btnDeleteReset.Size = new Size(112, 34);
            btnDeleteReset.TabIndex = 3;
            btnDeleteReset.Text = "Reset";
            btnDeleteReset.UseVisualStyleBackColor = true;
            btnDeleteReset.Click += btnDeleteReset_Click;
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.Location = new Point(312, 178);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(112, 34);
            btnEmployeeDelete.TabIndex = 2;
            btnEmployeeDelete.Text = "Delete";
            btnEmployeeDelete.UseVisualStyleBackColor = true;
            btnEmployeeDelete.Click += btnEmployeeDelete_Click;
            // 
            // txtDeleteEmployeeId
            // 
            txtDeleteEmployeeId.Location = new Point(312, 65);
            txtDeleteEmployeeId.MaxLength = 9;
            txtDeleteEmployeeId.Name = "txtDeleteEmployeeId";
            txtDeleteEmployeeId.Size = new Size(150, 31);
            txtDeleteEmployeeId.TabIndex = 1;
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Location = new Point(137, 71);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(117, 25);
            lblDelete.TabIndex = 0;
            lblDelete.Text = "Employee ID:";
            // 
            // EmployeeDeleteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 553);
            Controls.Add(gbDelete);
            Name = "EmployeeDeleteForm";
            Text = "Delete Employee";
            gbDelete.ResumeLayout(false);
            gbDelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDelete;
        private Button btnDeleteReset;
        private Button btnEmployeeDelete;
        private TextBox txtDeleteEmployeeId;
        private Label lblDelete;
    }
}