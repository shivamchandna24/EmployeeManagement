namespace EmployeeManagement.Views.Employee
{
    partial class EmployeeSearchForm
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
            gbSearch = new GroupBox();
            btnExportToCSV = new Button();
            btnSearchByName = new Button();
            btnSearchByID = new Button();
            btnSearchAll = new Button();
            txtSearchText = new TextBox();
            lblSearchText = new Label();
            gbSearchData = new GroupBox();
            dgvSearchRecords = new DataGridView();
            clmEmployeeID = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            clmGender = new DataGridViewTextBoxColumn();
            clmStatus = new DataGridViewTextBoxColumn();
            btnGoToPage = new Button();
            txtGoToPage = new TextBox();
            lblGoToPage = new Label();
            txtLimitPerPage = new TextBox();
            lblLimitPerPage = new Label();
            txtTotalPage = new TextBox();
            lblTotalPages = new Label();
            txtCurrentPage = new TextBox();
            lblCurrentPage = new Label();
            txtTotalRecords = new TextBox();
            lblTotalRecords = new Label();
            gbSearch.SuspendLayout();
            gbSearchData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchRecords).BeginInit();
            SuspendLayout();
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnExportToCSV);
            gbSearch.Controls.Add(btnSearchByName);
            gbSearch.Controls.Add(btnSearchByID);
            gbSearch.Controls.Add(btnSearchAll);
            gbSearch.Controls.Add(txtSearchText);
            gbSearch.Controls.Add(lblSearchText);
            gbSearch.Location = new Point(91, 64);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(707, 297);
            gbSearch.TabIndex = 0;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search and Export";
            // 
            // btnExportToCSV
            // 
            btnExportToCSV.Location = new Point(531, 236);
            btnExportToCSV.Name = "btnExportToCSV";
            btnExportToCSV.Size = new Size(150, 34);
            btnExportToCSV.TabIndex = 5;
            btnExportToCSV.Text = "Export CSV";
            btnExportToCSV.UseVisualStyleBackColor = true;
            btnExportToCSV.Click += btnExportToCSV_Click;
            // 
            // btnSearchByName
            // 
            btnSearchByName.Location = new Point(335, 178);
            btnSearchByName.Name = "btnSearchByName";
            btnSearchByName.Size = new Size(150, 34);
            btnSearchByName.TabIndex = 4;
            btnSearchByName.Text = "Search By Name";
            btnSearchByName.UseVisualStyleBackColor = true;
            btnSearchByName.Click += btnSearchByName_Click;
            // 
            // btnSearchByID
            // 
            btnSearchByID.Location = new Point(335, 120);
            btnSearchByID.Name = "btnSearchByID";
            btnSearchByID.Size = new Size(149, 34);
            btnSearchByID.TabIndex = 3;
            btnSearchByID.Text = "Search by ID";
            btnSearchByID.UseVisualStyleBackColor = true;
            btnSearchByID.Click += btnSearchByID_Click;
            // 
            // btnSearchAll
            // 
            btnSearchAll.Location = new Point(334, 236);
            btnSearchAll.Name = "btnSearchAll";
            btnSearchAll.Size = new Size(150, 34);
            btnSearchAll.TabIndex = 2;
            btnSearchAll.Text = "Search All";
            btnSearchAll.UseVisualStyleBackColor = true;
            btnSearchAll.Click += btnSearchAll_Click;
            // 
            // txtSearchText
            // 
            txtSearchText.Location = new Point(335, 47);
            txtSearchText.Name = "txtSearchText";
            txtSearchText.Size = new Size(150, 31);
            txtSearchText.TabIndex = 1;
            // 
            // lblSearchText
            // 
            lblSearchText.AutoSize = true;
            lblSearchText.Location = new Point(32, 53);
            lblSearchText.Name = "lblSearchText";
            lblSearchText.Size = new Size(249, 25);
            lblSearchText.TabIndex = 0;
            lblSearchText.Text = "Search by Employee ID/Name";
            // 
            // gbSearchData
            // 
            gbSearchData.Controls.Add(dgvSearchRecords);
            gbSearchData.Controls.Add(btnGoToPage);
            gbSearchData.Controls.Add(txtGoToPage);
            gbSearchData.Controls.Add(lblGoToPage);
            gbSearchData.Controls.Add(txtLimitPerPage);
            gbSearchData.Controls.Add(lblLimitPerPage);
            gbSearchData.Controls.Add(txtTotalPage);
            gbSearchData.Controls.Add(lblTotalPages);
            gbSearchData.Controls.Add(txtCurrentPage);
            gbSearchData.Controls.Add(lblCurrentPage);
            gbSearchData.Controls.Add(txtTotalRecords);
            gbSearchData.Controls.Add(lblTotalRecords);
            gbSearchData.Location = new Point(91, 399);
            gbSearchData.Name = "gbSearchData";
            gbSearchData.Size = new Size(1038, 617);
            gbSearchData.TabIndex = 1;
            gbSearchData.TabStop = false;
            gbSearchData.Text = "Search Data";
            // 
            // dgvSearchRecords
            // 
            dgvSearchRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchRecords.Columns.AddRange(new DataGridViewColumn[] { clmEmployeeID, clmName, clmEmail, clmGender, clmStatus });
            dgvSearchRecords.Location = new Point(20, 170);
            dgvSearchRecords.Name = "dgvSearchRecords";
            dgvSearchRecords.RowHeadersWidth = 62;
            dgvSearchRecords.RowTemplate.Height = 33;
            dgvSearchRecords.Size = new Size(946, 423);
            dgvSearchRecords.TabIndex = 11;
            // 
            // clmEmployeeID
            // 
            clmEmployeeID.HeaderText = "Id";
            clmEmployeeID.MinimumWidth = 8;
            clmEmployeeID.Name = "clmEmployeeID";
            clmEmployeeID.Width = 150;
            // 
            // clmName
            // 
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 8;
            clmName.Name = "clmName";
            clmName.Width = 150;
            // 
            // clmEmail
            // 
            clmEmail.HeaderText = "Email";
            clmEmail.MinimumWidth = 8;
            clmEmail.Name = "clmEmail";
            clmEmail.Width = 150;
            // 
            // clmGender
            // 
            clmGender.HeaderText = "Gender";
            clmGender.MinimumWidth = 8;
            clmGender.Name = "clmGender";
            clmGender.Width = 150;
            // 
            // clmStatus
            // 
            clmStatus.HeaderText = "Status";
            clmStatus.MinimumWidth = 8;
            clmStatus.Name = "clmStatus";
            clmStatus.Width = 150;
            // 
            // btnGoToPage
            // 
            btnGoToPage.Location = new Point(620, 79);
            btnGoToPage.Name = "btnGoToPage";
            btnGoToPage.Size = new Size(112, 34);
            btnGoToPage.TabIndex = 10;
            btnGoToPage.Text = "Go To Page";
            btnGoToPage.UseVisualStyleBackColor = true;
            btnGoToPage.Click += btnGoToPage_Click;
            // 
            // txtGoToPage
            // 
            txtGoToPage.Location = new Point(448, 78);
            txtGoToPage.Name = "txtGoToPage";
            txtGoToPage.Size = new Size(113, 31);
            txtGoToPage.TabIndex = 9;
            // 
            // lblGoToPage
            // 
            lblGoToPage.AutoSize = true;
            lblGoToPage.Location = new Point(314, 84);
            lblGoToPage.Name = "lblGoToPage";
            lblGoToPage.Size = new Size(96, 25);
            lblGoToPage.TabIndex = 8;
            lblGoToPage.Text = "GoTo Page";
            // 
            // txtLimitPerPage
            // 
            txtLimitPerPage.Location = new Point(156, 81);
            txtLimitPerPage.Name = "txtLimitPerPage";
            txtLimitPerPage.ReadOnly = true;
            txtLimitPerPage.Size = new Size(113, 31);
            txtLimitPerPage.TabIndex = 7;
            // 
            // lblLimitPerPage
            // 
            lblLimitPerPage.AutoSize = true;
            lblLimitPerPage.Location = new Point(20, 84);
            lblLimitPerPage.Name = "lblLimitPerPage";
            lblLimitPerPage.Size = new Size(130, 25);
            lblLimitPerPage.TabIndex = 6;
            lblLimitPerPage.Text = "Limit Per Pages";
            // 
            // txtTotalPage
            // 
            txtTotalPage.Location = new Point(760, 39);
            txtTotalPage.Name = "txtTotalPage";
            txtTotalPage.ReadOnly = true;
            txtTotalPage.Size = new Size(113, 31);
            txtTotalPage.TabIndex = 5;
            // 
            // lblTotalPages
            // 
            lblTotalPages.AutoSize = true;
            lblTotalPages.Location = new Point(620, 42);
            lblTotalPages.Name = "lblTotalPages";
            lblTotalPages.Size = new Size(100, 25);
            lblTotalPages.TabIndex = 4;
            lblTotalPages.Text = "Total Pages";
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.Location = new Point(448, 36);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.ReadOnly = true;
            txtCurrentPage.Size = new Size(113, 31);
            txtCurrentPage.TabIndex = 3;
            // 
            // lblCurrentPage
            // 
            lblCurrentPage.AutoSize = true;
            lblCurrentPage.Location = new Point(314, 39);
            lblCurrentPage.Name = "lblCurrentPage";
            lblCurrentPage.Size = new Size(113, 25);
            lblCurrentPage.TabIndex = 2;
            lblCurrentPage.Text = "Current Page";
            // 
            // txtTotalRecords
            // 
            txtTotalRecords.Location = new Point(156, 33);
            txtTotalRecords.Name = "txtTotalRecords";
            txtTotalRecords.ReadOnly = true;
            txtTotalRecords.Size = new Size(113, 31);
            txtTotalRecords.TabIndex = 1;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Location = new Point(20, 39);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(117, 25);
            lblTotalRecords.TabIndex = 0;
            lblTotalRecords.Text = "Total Records";
            // 
            // EmployeeSearchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 1050);
            Controls.Add(gbSearchData);
            Controls.Add(gbSearch);
            Name = "EmployeeSearchForm";
            Text = "Search/Export Employee";
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbSearchData.ResumeLayout(false);
            gbSearchData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSearch;
        private Button btnSearchAll;
        private TextBox txtSearchText;
        private Label lblSearchText;
        private GroupBox gbSearchData;
        private TextBox txtTotalRecords;
        private Label lblTotalRecords;
        private TextBox txtGoToPage;
        private Label lblGoToPage;
        private TextBox txtLimitPerPage;
        private Label lblLimitPerPage;
        private TextBox txtTotalPage;
        private Label lblTotalPages;
        private TextBox txtCurrentPage;
        private Label lblCurrentPage;
        private DataGridView dgvSearchRecords;
        private DataGridViewTextBoxColumn clmEmployeeID;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmEmail;
        private DataGridViewTextBoxColumn clmGender;
        private DataGridViewTextBoxColumn clmStatus;
        private Button btnGoToPage;
        private Button btnSearchByID;
        private Button btnSearchByName;
        private Button btnExportToCSV;
    }
}