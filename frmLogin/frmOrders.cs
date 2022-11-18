using BusinessObject;
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

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource source;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            txtOrderId.Enabled = false;
            LoadOrderList();
            dtpStartDate.Value = orderRepository.GetOrderById(1).OrderDate.Date;
            dtpStartDate.MinDate = orderRepository.GetOrderById(1).OrderDate.Date;
            dtpEndDate.MinDate = dtpStartDate.MinDate;
            dtpEndDate.Value = dtpStartDate.Value;
        }

        private void dgvOrderData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetailAction frm = new frmOrderDetailAction
            {
                Text = "Update an order",
                orderRepository = orderRepository,
                InsertOrUpdate = true,
                OrderInfor = GetOrderObject()
            };
            /*if (frm.ShowDialog() == DialogResult.OK)
            {*/
            frm.ShowDialog();
            LoadOrderList();
            //}
        }

        public void LoadOrderList()
        {
            var orders = orderRepository.GetListOrders();
            try
            {
                source = new BindingSource();
                source.DataSource = orders;

                txtOrderId.DataBindings.Clear();
                txtMemberId.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderId.DataBindings.Add("Text", source, "OrderID");
                txtMemberId.DataBindings.Add("Text", source, "MemberID");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");

                dgvOrderData.DataSource = null;
                dgvOrderData.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order list.");
            }
        }

        public OrderObject GetOrderObject()
        {
            OrderObject order = null;
            try
            {
                order = new OrderObject
                {
                    OrderID = int.Parse(txtOrderId.Text),
                    MemberID = int.Parse(txtMemberId.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order Object");
            }
            return order;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrderDetailAction frm = new frmOrderDetailAction
            {
                Text = "Add a new order",
                orderRepository = orderRepository,
                InsertOrUpdate = false
            };
            // if (frm.ShowDialog() == DialogResult.OK)
            //{
            frm.ShowDialog();
                frmOrderDetail frmDetail = new frmOrderDetail
                {
                    Text = "Create Order Detail",
                    ViewOrInsert = true,
                    orderDetailRepository = orderDetailRepository,
                    orderRepository = orderRepository
                };
                frmDetail.ShowDialog();
                LoadOrderList();
                source.Position = source.Count - 1;
           // }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                var orderDetail = orderDetailRepository.GetOrderDetailById(order.OrderID);
                DialogResult dialog = MessageBox.Show("Do you really want to delete this order?", "Manage Order - Delete An Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    orderDetailRepository.DeleteOrderDetail(orderDetail.OrderID);
                    orderRepository.DeleteOrder(order.OrderID);
                    LoadOrderList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete an order.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var orders = orderRepository.GetListOrders();
            try
            {
                if (dtpStartDate.Value.Date > dtpEndDate.Value.Date)
                {
                    MessageBox.Show("Start date must before or equal end date.");
                }
                else
                {
                    var orderSearch = new List<OrderObject>();
                    source = new BindingSource();
                    foreach (var item in orders)
                    {
                        if (item.OrderDate.Date >= dtpStartDate.Value && item.OrderDate.Date <= dtpEndDate.Value)
                        {
                            orderSearch.Add(item);
                        }
                    }
                    orderSearch = orderSearch.OrderByDescending(o => o.OrderDate.Date).ToList();
                    source.DataSource = orderSearch;

                    dgvOrderData.DataSource = null;
                    dgvOrderData.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search an order.");
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(txtOrderId.Text);
            frmOrderDetail frm = new frmOrderDetail
            {
                Text = $"Order Detail",
                ViewOrInsert = false,
                Infor = orderDetailRepository.GetOrderDetailById(orderId)
            };
            frm.ShowDialog();
        }
    }
}
