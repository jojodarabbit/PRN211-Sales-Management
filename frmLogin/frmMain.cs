using frmLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnManageMember_Click(object sender, EventArgs e)
        {
            frmMembers frm = new frmMembers();
            btnManageMember.Enabled = false;
            frm.Show();
            frm.FormClosing += FrmMembers_FormClosing;
        }

        private void FrmMembers_FormClosing(object? sender, FormClosingEventArgs e)
        {
            btnManageMember.Enabled = true;
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            btnManageProduct.Enabled = false;
            frm.Show();
            frm.FormClosing += FrmProduct_FormClosing;
        }

        private void FrmProduct_FormClosing(object? sender, FormClosingEventArgs e)
        {
            btnManageProduct.Enabled = true;
        }

        private void btnReportSales_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders();
            btnReportSales.Enabled = false;
            frm.Show();
            frm.FormClosing += FrmRepost_FormClosing;
        }

        private void FrmRepost_FormClosing(object? sender, FormClosingEventArgs e)
        {
            btnReportSales.Enabled = true;
        }

        private void btnManageMember_MouseHover(object sender, EventArgs e)
        {
            lbStatusTrip.Text = "Managing Member...";
        }

        private void btnManageProduct_MouseHover(object sender, EventArgs e)
        {
            lbStatusTrip.Text = "Managing Product...";
        }

        private void btnReportSales_MouseHover(object sender, EventArgs e)
        {
            lbStatusTrip.Text = "Report Status Sales...";
        }

        private void btnReportSales_MouseLeave(object sender, EventArgs e)
        {
            lbStatusTrip.Text = "";
        }

        private void btnManageMember_MouseLeave(object sender, EventArgs e)
        {
            lbStatusTrip.Text = "";
        }

        private void btnManageProduct_MouseLeave(object sender, EventArgs e)
        {
            lbStatusTrip.Text = "";
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            lbStatusTrip.Text = "Exit the program.";
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            lbStatusTrip.Text = "";
        }

        private void mnuManageMember_Click(object sender, EventArgs e)
        {
            frmMembers frm = new frmMembers();
            btnManageMember.Enabled = false;
            frm.Show();
            frm.FormClosing += FrmMembers_FormClosing;
        }

        private void mnuManageProduct_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            btnManageProduct.Enabled = false;
            frm.Show();
            frm.FormClosing += FrmProduct_FormClosing;
        }

        private void mnuReportSales_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders();
            btnReportSales.Enabled = false;
            frm.Show();
            frm.FormClosing += FrmRepost_FormClosing;
        }

        private void mnuAboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the F-Store Manager Application for Admin to Manage Member, Order, and Product. \nThank You For Using It!", "FStore Manager Application - About Us", MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        private void mnuExit_Click(object sender, EventArgs e) => Close();

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Close();
            frmLogin1 frmlogin = new frmLogin1();
            frmlogin.ShowDialog();
        }
    }
}
