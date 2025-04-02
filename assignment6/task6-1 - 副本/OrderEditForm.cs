using Order_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task6_1
{
    public partial class OrderEditForm : Form
    {
        private Order _order;
        private BindingSource detailsBindingSource = new BindingSource();

        public Order Order
        {
            get
            {
                _order.customer = txtCustomerName.Text;
                return _order;
            }
            set
            {
                _order = value;
                txtCustomerName.Text = _order.customer;
                detailsBindingSource.DataSource = _order.details;
            }
        }

        public OrderEditForm()
        {
            InitializeComponent();

            // 配置DataGridView
            dgvEditDetails.AutoGenerateColumns = false;
            dgvEditDetails.DataSource = detailsBindingSource;

            // 设置列的数据绑定
            Column1.DataPropertyName = "productName";
            Column2.DataPropertyName = "price";
            Column3.DataPropertyName = "quantity";
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("请输入产品名称");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("请输入有效的价格");
                return;
            }

            var newDetail = new OrderDetails
            {
                productName = txtProductName.Text,
                quantity = (int)numQuantity.Value,
                price = price
            };

            _order.details.Add(newDetail);
            detailsBindingSource.ResetBindings(false);

            // 清空输入
            txtProductName.Clear();
            txtPrice.Clear();
            numQuantity.Value = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("客户名称不能为空");
                return;
            }

            if (_order.details.Count == 0)
            {
                MessageBox.Show("请至少添加一个订单明细");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
