namespace EmployeeManagement.Views.Employee
{
    partial class EmployeeUpdateForm
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
            gbUpdate = new GroupBox();
            btnResetUpdate = new Button();
            btnFetch = new Button();
            txtUpdateEmployeeId = new TextBox();
            lblUpdateEmployeeId = new Label();
            dgvUpdateRecord = new DataGridView();
            pnlRecordPanel = new Panel();
            btnUpdateRecords = new Button();
            gbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateRecord).BeginInit();
            pnlRecordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gbUpdate
            // 
            gbUpdate.Controls.Add(btnResetUpdate);
            gbUpdate.Controls.Add(btnFetch);
            gbUpdate.Controls.Add(txtUpdateEmployeeId);
            gbUpdate.Controls.Add(lblUpdateEmployeeId);
            gbUpdate.Location = new Point(116, 26);
            gbUpdate.Name = "gbUpdate";
            gbUpdate.Size = new Size(604, 209);
            gbUpdate.TabIndex = 0;
            gbUpdate.TabStop = false;
            gbUpdate.Text = "Update";
            // 
            // btnResetUpdate
            // 
            btnResetUpdate.Location = new Point(432, 156);
            btnResetUpdate.Name = "btnResetUpdate";
            btnResetUpdate.Size = new Size(112, 34);
            btnResetUpdate.TabIndex = 3;
            btnResetUpdate.Text = "Reset";
            btnResetUpdate.UseVisualStyleBackColor = true;
            btnResetUpdate.Click += btnResetUpdate_Click;
            // 
            // btnFetch
            // 
            btnFetch.Location = new Point(267, 156);
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new Size(112, 34);
            btnFetch.TabIndex = 2;
            btnFetch.Text = "Fetch";
            btnFetch.UseVisualStyleBackColor = true;
            btnFetch.Click += btnFetch_Click;
            // 
            // txtUpdateEmployeeId
            // 
            txtUpdateEmployeeId.Location = new Point(267, 77);
            txtUpdateEmployeeId.Name = "txtUpdateEmployeeId";
            txtUpdateEmployeeId.Size = new Size(150, 31);
            txtUpdateEmployeeId.TabIndex = 1;
            // 
            // lblUpdateEmployeeId
            // 
            lblUpdateEmployeeId.AutoSize = true;
            lblUpdateEmployeeId.Location = new Point(81, 80);
            lblUpdateEmployeeId.Name = "lblUpdateEmployeeId";
            lblUpdateEmployeeId.Size = new Size(111, 25);
            lblUpdateEmployeeId.TabIndex = 0;
            lblUpdateEmployeeId.Text = "Employee Id";
            // 
            // dgvUpdateRecord
            // 
            dgvUpdateRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateRecord.Location = new Point(20, 16);
            dgvUpdateRecord.Name = "dgvUpdateRecord";
            dgvUpdateRecord.RowHeadersWidth = 62;
            dgvUpdateRecord.RowTemplate.Height = 33;
            dgvUpdateRecord.Size = new Size(604, 110);
            dgvUpdateRecord.TabIndex = 1;
            // 
            // pnlRecordPanel
            // 
            pnlRecordPanel.Controls.Add(btnUpdateRecords);
            pnlRecordPanel.Controls.Add(dgvUpdateRecord);
            pnlRecordPanel.Location = new Point(116, 285);
            pnlRecordPanel.Name = "pnlRecordPanel";
            pnlRecordPanel.Size = new Size(724, 221);
            pnlRecordPanel.TabIndex = 2;
            // 
            // btnUpdateRecords
            // 
            btnUpdateRecords.Location = new Point(159, 167);
            btnUpdateRecords.Name = "btnUpdateRecords";
            btnUpdateRecords.Size = new Size(193, 34);
            btnUpdateRecords.TabIndex = 2;
            btnUpdateRecords.Text = "Update Record";
            btnUpdateRecords.UseVisualStyleBackColor = true;
            btnUpdateRecords.Click += btnUpdateRecords_Click;
            // 
            // EmployeeUpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 518);
            Controls.Add(pnlRecordPanel);
            Controls.Add(gbUpdate);
            Name = "EmployeeUpdateForm";
            Text = "Update Employee";
            gbUpdate.ResumeLayout(false);
            gbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateRecord).EndInit();
            pnlRecordPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbUpdate;
        private Button btnFetch;
        private TextBox txtUpdateEmployeeId;
        private Label lblUpdateEmployeeId;
        private DataGridView dgvUpdateRecord;
        private Panel pnlRecordPanel;
        private Button btnUpdateRecords;
        private Button btnResetUpdate;
    }
}