namespace EmployeeManagement.Views
{
    partial class Welcome
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
            lblWelcome = new Label();
            lblSelectEntity = new Label();
            btnEmployee = new Button();
            btnOthers = new Button();
            gbWelcome = new GroupBox();
            gbWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(105, 27);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(421, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to entity Management.";
            // 
            // lblSelectEntity
            // 
            lblSelectEntity.AutoSize = true;
            lblSelectEntity.Location = new Point(172, 97);
            lblSelectEntity.Name = "lblSelectEntity";
            lblSelectEntity.Size = new Size(293, 25);
            lblSelectEntity.TabIndex = 1;
            lblSelectEntity.Text = "Select entity you want to work with.";
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(47, 203);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(226, 66);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnOthers
            // 
            btnOthers.Location = new Point(319, 203);
            btnOthers.Name = "btnOthers";
            btnOthers.Size = new Size(207, 66);
            btnOthers.TabIndex = 3;
            btnOthers.Text = "Others";
            btnOthers.UseVisualStyleBackColor = true;
            btnOthers.Click += btnOthers_Click;
            // 
            // gbWelcome
            // 
            gbWelcome.Controls.Add(lblWelcome);
            gbWelcome.Controls.Add(btnOthers);
            gbWelcome.Controls.Add(lblSelectEntity);
            gbWelcome.Controls.Add(btnEmployee);
            gbWelcome.Location = new Point(77, 27);
            gbWelcome.Name = "gbWelcome";
            gbWelcome.Size = new Size(685, 396);
            gbWelcome.TabIndex = 4;
            gbWelcome.TabStop = false;
            gbWelcome.Text = "ZXC Solutions";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbWelcome);
            Name = "Welcome";
            Text = "Welcome";
            gbWelcome.ResumeLayout(false);
            gbWelcome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Label lblSelectEntity;
        private Button btnEmployee;
        private Button btnOthers;
        private GroupBox gbWelcome;
    }
}