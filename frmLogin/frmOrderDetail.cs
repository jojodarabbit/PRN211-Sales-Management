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
    public partial class frmOrderDetail : Form
    {
        public bool ViewOrInsert { get; set; }
        public IOrderDetailRepository orderDetailRepository { get; set; }
        public IOrderRepository orderRepository { get; set; }
        public IProductRepository productRepository = new ProductRepository();
        public MemberObject memberInfor { get; set; }
        public OrderDetailObject Infor { get; set; }

        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {

            //btnSave.DialogResult = DialogResult.OK;
            if (ViewOrInsert)
            {
                var orderId = orderDetailRepository.GetListOrderDetails().Count();
                while (orderDetailRepository.GetOrderDetailById(orderId) != null)
                {
                    orderId++;
                }
                txtOrderId.Text = orderId.ToString();
                txtOrderId.Enabled = false;
                txtUnitPrice.Enabled = false;
                txtDiscount.Enabled = false;
                var products = productRepository.GetListProducts();
                foreach (var item in products)
                {
                    cbProductID.Items.Add(item);
                }
                txtDiscount.Text = "0";
                cbProductID.DisplayMember = "ProductName";
                cbProductID.ValueMember = "ProductID";
            }
            else
            {
                btnSave.Hide();
                btnExit.Location = new Point(164, 346);
                txtOrderId.Enabled = false;
                cbProductID.Enabled = false;
                txtDiscount.Enabled = false;
                txtQuantity.Enabled = false;
                txtUnitPrice.Enabled = false;
                var products = productRepository.GetListProducts();
                foreach (var item in products)
                {
                    cbProductID.Items.Add(item);
                }
                for (int i = 0; i < cbProductID.Items.Count; i++)
                {
                    if (Infor.ProductID == ((ProductObject)cbProductID.Items[i]).ProductID)
                    {
                        cbProductID.SelectedIndex = i;
                    }
                }
                cbProductID.DisplayMember = "ProductName";
                cbProductID.ValueMember = "ProductID";
                if (Infor != null)
                {
                    txtOrderId.Text = Infor.OrderID.ToString();
                    //cbProductID.Text = Infor.ProductID.ToString();
                    txtQuantity.Text = Infor.Quantity.ToString();
                    txtUnitPrice.Text = Infor.UnitPrice.ToString();
                    txtDiscount.Text = Infor.Discount.ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text == "" || cbProductID.Text== "")
                {
                    int check = int.Parse(txtQuantity.Text);
                    MessageBox.Show("Please fill in all fields before Submitting");
                    if (check < 0)
                    {
                        MessageBox.Show("Quantity must greater than 0.");
                    }
                }
                else
                {

                    if (memberInfor != null)
                    {
                        var order = new OrderObject
                        {
                            OrderID = int.Parse(txtOrderId.Text),
                            MemberID = memberInfor.MemberID,
                            OrderDate = DateTime.Today,
                            RequiredDate = DateTime.Today.AddDays(2),
                            ShippedDate = DateTime.Today.AddDays(4),
                            Freight = decimal.Parse(txtUnitPrice.Text)
                        };
                        var orderDetail = new OrderDetailObject
                        {
                            OrderID = int.Parse(txtOrderId.Text),
                            ProductID = Convert.ToInt32(((ProductObject)cbProductID.SelectedItem).ProductID),
                            UnitPrice = decimal.Parse(txtUnitPrice.Text),
                            Quantity = int.Parse(txtQuantity.Text),
                            Discount = float.Parse(txtDiscount.Text)
                        };
                        var product = productRepository.GetProductById(orderDetail.ProductID);
                        product.UnitsInStock -= orderDetail.Quantity;
                        orderRepository.AddOrder(order);
                        orderDetailRepository.AddOrderDetail(orderDetail);
                        productRepository.UpdateProduct(product);
                        Close();
                    }
                    else
                    {
                        var orderDetail = new OrderDetailObject
                        {
                            OrderID = int.Parse(txtOrderId.Text),
                            ProductID = Convert.ToInt32(((ProductObject)cbProductID.SelectedItem).ProductID),
                            UnitPrice = decimal.Parse(txtUnitPrice.Text),
                            Quantity = int.Parse(txtQuantity.Text),
                            Discount = float.Parse(txtDiscount.Text)
                        };
                        orderDetailRepository.AddOrderDetail(orderDetail);
                        var product = productRepository.GetProductById(orderDetail.ProductID);
                        product.UnitsInStock -= orderDetail.Quantity;
                        productRepository.UpdateProduct(product);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add a new order - Order Detail");
            }
        }

        private void cbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(((ProductObject)cbProductID.SelectedItem).ProductID);
            var product = productRepository.GetProductById(productId);
            if (product != null)
            {
                txtUnitPrice.Text = product.UnitPrice.ToString();
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Length != 0)
            {
                int quantity = int.Parse(txtQuantity.Text);
                var product = productRepository
                    .GetProductById(Convert.ToInt32(((ProductObject)cbProductID.SelectedItem).ProductID));
                int unitsInStock = product.UnitsInStock;
                if (quantity > unitsInStock)
                {
                    MessageBox.Show("The quantity in stock is doesn't enough.");
                    txtQuantity.Focus();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
