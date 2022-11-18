namespace SalesWinApp
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportSales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManageMember = new System.Windows.Forms.Button();
            this.btnReportSales = new System.Windows.Forms.Button();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatusTrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(688, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManageMember,
            this.mnuManageProduct,
            this.mnuReportSales,
            this.mnuLogout,
            this.mnuExit});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mnuManageMember
            // 
            this.mnuManageMember.Name = "mnuManageMember";
            this.mnuManageMember.Size = new System.Drawing.Size(206, 26);
            this.mnuManageMember.Text = "Manage Member";
            this.mnuManageMember.Click += new System.EventHandler(this.mnuManageMember_Click);
            // 
            // mnuManageProduct
            // 
            this.mnuManageProduct.Name = "mnuManageProduct";
            this.mnuManageProduct.Size = new System.Drawing.Size(206, 26);
            this.mnuManageProduct.Text = "Manage Product";
            this.mnuManageProduct.Click += new System.EventHandler(this.mnuManageProduct_Click);
            // 
            // mnuReportSales
            // 
            this.mnuReportSales.Name = "mnuReportSales";
            this.mnuReportSales.Size = new System.Drawing.Size(206, 26);
            this.mnuReportSales.Text = "Manage Order";
            this.mnuReportSales.Click += new System.EventHandler(this.mnuReportSales_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(206, 26);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(206, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutUs});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mnuAboutUs
            // 
            this.mnuAboutUs.Name = "mnuAboutUs";
            this.mnuAboutUs.Size = new System.Drawing.Size(151, 26);
            this.mnuAboutUs.Text = "About us";
            this.mnuAboutUs.Click += new System.EventHandler(this.mnuAboutUs_Click);
            // 
            // btnManageMember
            // 
            this.btnManageMember.AutoSize = true;
            this.btnManageMember.Location = new System.Drawing.Point(148, 121);
            this.btnManageMember.Name = "btnManageMember";
            this.btnManageMember.Size = new System.Drawing.Size(389, 55);
            this.btnManageMember.TabIndex = 1;
            this.btnManageMember.Text = "Manage Member";
            this.btnManageMember.UseVisualStyleBackColor = true;
            this.btnManageMember.Click += new System.EventHandler(this.btnManageMember_Click);
            this.btnManageMember.MouseLeave += new System.EventHandler(this.btnManageMember_MouseLeave);
            this.btnManageMember.MouseHover += new System.EventHandler(this.btnManageMember_MouseHover);
            // 
            // btnReportSales
            // 
            this.btnReportSales.AutoSize = true;
            this.btnReportSales.Location = new System.Drawing.Point(148, 222);
            this.btnReportSales.Name = "btnReportSales";
            this.btnReportSales.Size = new System.Drawing.Size(389, 55);
            this.btnReportSales.TabIndex = 3;
            this.btnReportSales.Text = "Manage Order";
            this.btnReportSales.UseVisualStyleBackColor = true;
            this.btnReportSales.Click += new System.EventHandler(this.btnReportSales_Click);
            this.btnReportSales.MouseLeave += new System.EventHandler(this.btnReportSales_MouseLeave);
            this.btnReportSales.MouseHover += new System.EventHandler(this.btnReportSales_MouseHover);
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.AutoSize = true;
            this.btnManageProduct.Location = new System.Drawing.Point(148, 317);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(389, 54);
            this.btnManageProduct.TabIndex = 2;
            this.btnManageProduct.Text = "Manage Product";
            this.btnManageProduct.UseVisualStyleBackColor = true;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            this.btnManageProduct.MouseLeave += new System.EventHandler(this.btnManageProduct_MouseLeave);
            this.btnManageProduct.MouseHover += new System.EventHandler(this.btnManageProduct_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(565, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatusTrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatusTrip
            // 
            this.lbStatusTrip.Name = "lbStatusTrip";
            this.lbStatusTrip.Size = new System.Drawing.Size(13, 20);
            this.lbStatusTrip.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(293, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(688, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnManageProduct);
            this.Controls.Add(this.btnReportSales);
            this.Controls.Add(this.btnManageMember);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStore Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btnManageMember;
        private Button btnReportSales;
        private Button btnManageProduct;
        private Button btnExit;
        private ToolStripMenuItem mnuManageMember;
        private ToolStripMenuItem mnuManageProduct;
        private ToolStripMenuItem mnuReportSales;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuAboutUs;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbStatusTrip;
        private Label label1;
        private ToolStripMenuItem mnuLogout;
    }
}