namespace SalesWinApp
{
    partial class frmOrderDetailAction
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
            this.lbOrderId = new System.Windows.Forms.Label();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.txtRequiredDate = new System.Windows.Forms.MaskedTextBox();
            this.txtShippedDate = new System.Windows.Forms.MaskedTextBox();
            this.cbMemberID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(69, 53);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(66, 20);
            this.lbOrderId.TabIndex = 0;
            this.lbOrderId.Text = "Order ID";
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(69, 92);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(84, 20);
            this.lbMemberId.TabIndex = 0;
            this.lbMemberId.Text = "Member ID";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(69, 133);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(79, 20);
            this.lbOrderDate.TabIndex = 0;
            this.lbOrderDate.Text = "OrderDate";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(69, 221);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(105, 20);
            this.lbRequiredDate.TabIndex = 0;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(69, 179);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(100, 20);
            this.lbShippedDate.TabIndex = 0;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(69, 259);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(55, 20);
            this.lbFreight.TabIndex = 0;
            this.lbFreight.Text = "Freight";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(185, 50);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(178, 27);
            this.txtOrderId.TabIndex = 1;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(185, 256);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(178, 27);
            this.txtFreight.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(335, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(185, 130);
            this.txtOrderDate.Mask = "00/00/0000";
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(178, 27);
            this.txtOrderDate.TabIndex = 3;
            this.txtOrderDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(185, 218);
            this.txtRequiredDate.Mask = "00/00/0000";
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(178, 27);
            this.txtRequiredDate.TabIndex = 4;
            this.txtRequiredDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(185, 176);
            this.txtShippedDate.Mask = "00/00/0000";
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(178, 27);
            this.txtShippedDate.TabIndex = 5;
            this.txtShippedDate.ValidatingType = typeof(System.DateTime);
            // 
            // cbMemberID
            // 
            this.cbMemberID.FormattingEnabled = true;
            this.cbMemberID.Location = new System.Drawing.Point(185, 96);
            this.cbMemberID.Name = "cbMemberID";
            this.cbMemberID.Size = new System.Drawing.Size(178, 28);
            this.cbMemberID.TabIndex = 9;
            // 
            // frmOrderDetailAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 384);
            this.Controls.Add(this.cbMemberID);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbMemberId);
            this.Controls.Add(this.lbOrderId);
            this.Name = "frmOrderDetailAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderDetailAction";
            this.Load += new System.EventHandler(this.frmOrderDetailAction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbOrderId;
        private Label lbMemberId;
        private Label lbOrderDate;
        private Label lbRequiredDate;
        private Label lbShippedDate;
        private Label lbFreight;
        private TextBox txtOrderId;
        private TextBox txtFreight;
        private Button btnSave;
        private Button btnCancel;
        private MaskedTextBox txtOrderDate;
        private MaskedTextBox txtRequiredDate;
        private MaskedTextBox txtShippedDate;
        private ComboBox cbMemberID;
    }
}