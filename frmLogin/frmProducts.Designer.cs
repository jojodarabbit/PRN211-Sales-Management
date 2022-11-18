namespace SalesWinApp
{
    partial class frmProducts
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbProductId = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbUnitsInStock = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.dgvProductData = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbSearchByIdOrName = new System.Windows.Forms.Label();
            this.txtSearchByIdOrName = new System.Windows.Forms.TextBox();
            this.lbSearchByUnits = new System.Windows.Forms.Label();
            this.txtSearchByUnits = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(240, 37);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(435, 45);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "FStore Product Management";
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(115, 115);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(79, 20);
            this.lbProductId.TabIndex = 0;
            this.lbProductId.Text = "Product ID";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(115, 161);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(115, 211);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(88, 20);
            this.lbCategoryId.TabIndex = 0;
            this.lbCategoryId.Text = "Category ID";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(495, 119);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 0;
            this.lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(495, 165);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 0;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Location = new System.Drawing.Point(495, 213);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(98, 20);
            this.lbUnitsInStock.TabIndex = 0;
            this.lbUnitsInStock.Text = "Units In Stock";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(241, 112);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(222, 27);
            this.txtProductId.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(241, 157);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(222, 27);
            this.txtProductName.TabIndex = 2;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(241, 207);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(222, 27);
            this.txtCategoryId.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(610, 116);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(159, 27);
            this.txtWeight.TabIndex = 4;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(610, 163);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(159, 27);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(610, 211);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(159, 27);
            this.txtUnitsInStock.TabIndex = 6;
            // 
            // dgvProductData
            // 
            this.dgvProductData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductData.Location = new System.Drawing.Point(73, 308);
            this.dgvProductData.Name = "dgvProductData";
            this.dgvProductData.ReadOnly = true;
            this.dgvProductData.RowHeadersWidth = 51;
            this.dgvProductData.RowTemplate.Height = 29;
            this.dgvProductData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductData.Size = new System.Drawing.Size(739, 188);
            this.dgvProductData.TabIndex = 11;
            this.dgvProductData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductData_CellDoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(718, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(73, 515);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 515);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbSearchByIdOrName
            // 
            this.lbSearchByIdOrName.AutoSize = true;
            this.lbSearchByIdOrName.Location = new System.Drawing.Point(73, 267);
            this.lbSearchByIdOrName.Name = "lbSearchByIdOrName";
            this.lbSearchByIdOrName.Size = new System.Drawing.Size(154, 20);
            this.lbSearchByIdOrName.TabIndex = 11;
            this.lbSearchByIdOrName.Text = "Search By ID or Name";
            // 
            // txtSearchByIdOrName
            // 
            this.txtSearchByIdOrName.Location = new System.Drawing.Point(238, 263);
            this.txtSearchByIdOrName.Name = "txtSearchByIdOrName";
            this.txtSearchByIdOrName.Size = new System.Drawing.Size(158, 27);
            this.txtSearchByIdOrName.TabIndex = 7;
            this.txtSearchByIdOrName.TextChanged += new System.EventHandler(this.txtSearchByIdOrName_TextChanged);
            // 
            // lbSearchByUnits
            // 
            this.lbSearchByUnits.AutoSize = true;
            this.lbSearchByUnits.Location = new System.Drawing.Point(583, 268);
            this.lbSearchByUnits.Name = "lbSearchByUnits";
            this.lbSearchByUnits.Size = new System.Drawing.Size(110, 20);
            this.lbSearchByUnits.TabIndex = 11;
            this.lbSearchByUnits.Text = "Search By Units";
            // 
            // txtSearchByUnits
            // 
            this.txtSearchByUnits.Location = new System.Drawing.Point(707, 263);
            this.txtSearchByUnits.Name = "txtSearchByUnits";
            this.txtSearchByUnits.Size = new System.Drawing.Size(105, 27);
            this.txtSearchByUnits.TabIndex = 7;
            this.txtSearchByUnits.TextChanged += new System.EventHandler(this.txtSearchByUnits_TextChanged);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(885, 563);
            this.Controls.Add(this.txtSearchByUnits);
            this.Controls.Add(this.lbSearchByUnits);
            this.Controls.Add(this.txtSearchByIdOrName);
            this.Controls.Add(this.lbSearchByIdOrName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvProductData);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lbUnitsInStock);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbCategoryId);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Product";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private Label lbProductId;
        private Label lbProductName;
        private Label lbCategoryId;
        private Label lbWeight;
        private Label lbUnitPrice;
        private Label lbUnitsInStock;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtCategoryId;
        private TextBox txtWeight;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private DataGridView dgvProductData;
        private Button btnExit;
        private Button btnNew;
        private Button btnDelete;
        private Label lbSearchByIdOrName;
        private TextBox txtSearchByIdOrName;
        private Label lbSearchByUnits;
        private TextBox txtSearchByUnits;
    }
}