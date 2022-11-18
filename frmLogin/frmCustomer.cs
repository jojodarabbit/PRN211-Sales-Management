using BusinessObject;
using DataAccess.Repository;
using frmLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmCustomer : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public MemberObject MemberInfor { get; set; }
        BindingSource source;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            lbTitle.Text = $"Member #{MemberInfor.MemberID}";

            txtMemberId.Text = MemberInfor.MemberID.ToString();
            txtCompanyName.Text = MemberInfor.CompanyName;
            txtEmail.Text = MemberInfor.Email;
            txtCity.Text = MemberInfor.City;
            txtCountry.Text = MemberInfor.Country;
            txtPassword.Text = MemberInfor.Password;

            txtMemberId.Enabled = false;
            txtCompanyName.Enabled = false;
            txtEmail.Enabled = false;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            txtPassword.Enabled = false;

            LoadOrderList();
        }
        private void dgvOrderData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = Convert.ToInt32(dgvOrderData.CurrentRow.Cells[0].Value.ToString());
            frmOrderDetail frm = new frmOrderDetail
            {
                Text = $"Order Member #{1} Detail.",
                ViewOrInsert = false,
                Infor = orderDetailRepository.GetOrderDetailById(orderId)
            };
            frm.ShowDialog();
        }

        public void LoadOrderList()
        {
            var orders = orderRepository.GetListOrderByMemID(MemberInfor.MemberID);
            try
            {
                source = new BindingSource();
                source.DataSource = orders;

                dgvOrderData.DataSource = null;
                dgvOrderData.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order List By ID.");
            }
        }

        private void btnRequestOrder_Click(object sender, EventArgs e)
        {
            frmOrderDetail frm = new frmOrderDetail
            {
                Text = "Request an order",
                memberInfor = MemberInfor,
                orderRepository = orderRepository,
                orderDetailRepository = orderDetailRepository,
                ViewOrInsert = true
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetail frm = new frmMemberDetail
            {
                Text = "Update Personal Information",
                InsertOrUpdate = true,
                MemberInfor = MemberInfor,
                memberRepository = memberRepository
            };
            /* if (frm.ShowDialog() == DialogResult.OK)
             {*/
            frm.ShowDialog();
            MemberInfor = memberRepository.GetMemberByID(MemberInfor.MemberID);
            txtMemberId.Text = MemberInfor.MemberID.ToString();
            txtCompanyName.Text = MemberInfor.CompanyName;
            txtEmail.Text = MemberInfor.Email;
            txtCity.Text = MemberInfor.City;
            txtCountry.Text = MemberInfor.Country;
            txtPassword.Text = MemberInfor.Password;
            //}
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            frmLogin1 frmlogin = new frmLogin1();
            frmlogin.ShowDialog();
        }
    }
}
