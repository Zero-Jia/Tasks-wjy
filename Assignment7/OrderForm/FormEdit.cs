﻿using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm {
    public partial class FormEdit : Form {
        private OrderService orderService;
        public bool EditFlag { get; set; }

        public Order CurrentOrder { get; set; }
        public event Action<FormEdit> CloseEditFrom = (f => { });

        public FormEdit(Order order, bool editFlag, OrderService orderService)
        {
            InitializeComponent();

            // 从数据库加载客户和产品
            var customers = orderService.GetAllOrders()
                .Select(o => o.Customer)
                .Distinct()
                .ToList();

            bdsCustomers.DataSource = customers;

            // 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
            this.CurrentOrder = order;
            bdsOrders.DataSource = CurrentOrder;
            this.orderService = orderService;

            this.EditFlag = editFlag;
            txtOrderId.Enabled = !editFlag;
            if (!editFlag)
            {
                order.Customer = bdsCustomers.Current as Customer;
            }
        }

        private void btnAddDetail_Click(object sender, EventArgs e) {
            FormDetailEdit formDetailEdit = new FormDetailEdit(new OrderDetail());
            try {
                if (formDetailEdit.ShowDialog() == DialogResult.OK) {
                    int index = 0;
                    if (CurrentOrder.Details.Count != 0) {
                        index = CurrentOrder.Details.Max(i => i.Index) + 1;
                    }
                    formDetailEdit.Detail.Index = index;
                    CurrentOrder.AddDetail(formDetailEdit.Detail);
                    bdsDetails.ResetBindings(false);
                }
            } catch (Exception e2) {
                MessageBox.Show(e2.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            //TODO 加上订单合法性验证
            try {
                if (this.EditFlag) {
                    orderService.UpdateOrder(CurrentOrder);
                } else {
                    orderService.AddOrder(CurrentOrder);
                }
                CloseEditFrom(this);
            } catch (Exception e3) {
                MessageBox.Show(e3.Message);
            }

        }

        private void btnEditDetail_Click(object sender, EventArgs e) {
            EditDetail();
        }

        private void dgvDetail_DoubleClick(object sender, EventArgs e) {
            EditDetail();
        }

        private void EditDetail() {
            OrderDetail detail = bdsDetails.Current as OrderDetail;
            if (detail == null) {
                MessageBox.Show("请选择一个订单项进行修改");
                return;
            }
            FormDetailEdit formDetailEdit = new FormDetailEdit(detail);
            if (formDetailEdit.ShowDialog() == DialogResult.OK) {
                bdsDetails.ResetBindings(false);
            }
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e) {
            OrderDetail detail = bdsDetails.Current as OrderDetail;
            if (detail == null) {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            CurrentOrder.RemoveDetail(detail);
            bdsDetails.ResetBindings(false);
        }


    }
}
