using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SalesWinApp
{
    public partial class frmOrderDetailAction : Form
    {
        public IOrderRepository orderRepository { get; set; }
        public IMemberRepository memberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public OrderObject OrderInfor { get; set; }
        public frmOrderDetailAction()
        {
            InitializeComponent();
        }

        private void frmOrderDetailAction_Load(object sender, EventArgs e)
        {
            memberRepository = new MemberRepository();
            var memberIds = memberRepository.GetListMember();
            foreach (var item in memberIds)
            {
                cbMemberID.Items.Add(item);
            }
            cbMemberID.DisplayMember = "Email";
            cbMemberID.ValueMember = "MemberID";
            //btnSave.DialogResult = DialogResult.OK;
            //btnCancel.DialogResult = DialogResult.Cancel;
            txtOrderId.Enabled = false;
            if (InsertOrUpdate)
            {
                txtOrderId.Text = OrderInfor.OrderID.ToString();
                //txtMemberId.Text = OrderInfor.MemberID.ToString();
                for (int i=0;i<cbMemberID.Items.Count;i++)
                {
                    if(OrderInfor.MemberID ==((MemberObject)cbMemberID.Items[i]).MemberID)
                    {
                        cbMemberID.SelectedIndex = i;
                    }
                }
                txtOrderDate.Text = OrderInfor.OrderDate.Date.ToShortDateString();
                txtRequiredDate.Text = OrderInfor.RequiredDate.Date.ToShortDateString();
                txtShippedDate.Text = OrderInfor.ShippedDate.Date.ToShortDateString();
                txtFreight.Text = OrderInfor.Freight.ToString();
            }
            else
            {
                txtOrderDate.Text = DateTime.Today.ToString();
                txtRequiredDate.Text = DateTime.Today.AddDays(4).ToString();
                txtShippedDate.Text = DateTime.Today.AddDays(2).ToString();
                var orderId = orderRepository.GetListOrders().Count() + 1;
                while (orderRepository.GetOrderById(orderId) != null)
                {
                    orderId++;
                }
                txtOrderId.Text = orderId.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Parse(txtOrderDate.Text) > DateTime.Parse(txtRequiredDate.Text)
                    || DateTime.Parse(txtOrderDate.Text) > DateTime.Parse(txtShippedDate.Text)
                    || DateTime.Parse(txtShippedDate.Text) > DateTime.Parse(txtRequiredDate.Text))
                {
                    MessageBox.Show("Input date again!");
                }
                else
                {
                    if (txtOrderDate.Text != "" && txtFreight.Text != "" &&
                        txtRequiredDate.Text != "" && txtShippedDate.Text != "" &&
                        cbMemberID.Text != "")
                    {
                        var order = new OrderObject
                        {
                            OrderID = int.Parse(txtOrderId.Text),
                            MemberID = ((MemberObject)cbMemberID.SelectedItem).MemberID,
                            OrderDate = DateTime.Parse(txtOrderDate.Text),
                            RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                            ShippedDate = DateTime.Parse(txtShippedDate.Text),
                            Freight = decimal.Parse(txtFreight.Text),
                        };

                        if (InsertOrUpdate)
                        {
                            orderRepository.UpdateOrder(order);
                            Close();
                        }
                        else
                        {
                            orderRepository.AddOrder(order);
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all fields before Submitting");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate ? "Update an order" : "Add a new order");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
