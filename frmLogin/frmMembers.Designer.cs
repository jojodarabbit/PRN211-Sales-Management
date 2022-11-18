namespace SalesWinApp
{
    partial class frmMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembers));
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dgvMemberData = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMemberID
            // 
            resources.ApplyResources(this.lbMemberID, "lbMemberID");
            this.lbMemberID.Name = "lbMemberID";
            // 
            // lbCompanyName
            // 
            resources.ApplyResources(this.lbCompanyName, "lbCompanyName");
            this.lbCompanyName.Name = "lbCompanyName";
            // 
            // lbEmail
            // 
            resources.ApplyResources(this.lbEmail, "lbEmail");
            this.lbEmail.Name = "lbEmail";
            // 
            // lbCity
            // 
            resources.ApplyResources(this.lbCity, "lbCity");
            this.lbCity.Name = "lbCity";
            // 
            // lbCountry
            // 
            resources.ApplyResources(this.lbCountry, "lbCountry");
            this.lbCountry.Name = "lbCountry";
            // 
            // lbPassword
            // 
            resources.ApplyResources(this.lbPassword, "lbPassword");
            this.lbPassword.Name = "lbPassword";
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
            // 
            // txtMemberId
            // 
            resources.ApplyResources(this.txtMemberId, "txtMemberId");
            this.txtMemberId.Name = "txtMemberId";
            // 
            // txtCompanyName
            // 
            resources.ApplyResources(this.txtCompanyName, "txtCompanyName");
            this.txtCompanyName.Name = "txtCompanyName";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // txtCity
            // 
            resources.ApplyResources(this.txtCity, "txtCity");
            this.txtCity.Name = "txtCity";
            // 
            // txtCountry
            // 
            resources.ApplyResources(this.txtCountry, "txtCountry");
            this.txtCountry.Name = "txtCountry";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // dgvMemberData
            // 
            this.dgvMemberData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvMemberData, "dgvMemberData");
            this.dgvMemberData.Name = "dgvMemberData";
            this.dgvMemberData.ReadOnly = true;
            this.dgvMemberData.RowTemplate.Height = 29;
            this.dgvMemberData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberData_CellDoubleClick);
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbSearch
            // 
            resources.ApplyResources(this.lbSearch, "lbSearch");
            this.lbSearch.Name = "lbSearch";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmMembers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvMemberData);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbMemberID);
            this.Name = "frmMembers";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMemberID;
        private Label lbCompanyName;
        private Label lbEmail;
        private Label lbCity;
        private Label lbCountry;
        private Label lbPassword;
        private Label lbTitle;
        private TextBox txtMemberId;
        private TextBox txtCompanyName;
        private TextBox txtEmail;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private DataGridView dgvMemberData;
        private Button btnNew;
        private Button btnDelete;
        private Button btnExit;
        private Label lbSearch;
        private TextBox txtSearch;
    }
}