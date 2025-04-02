namespace task6_1
{
    partial class OrderEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txtCustomerName = new TextBox();
            panel1 = new Panel();
            btnSave = new Button();
            btnAddDetail = new Button();
            numQuantity = new NumericUpDown();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            dgvEditDetails = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEditDetails).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 623F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtCustomerName, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 3);
            tableLayoutPanel1.Controls.Add(dgvEditDetails, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(924, 756);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(270, 63);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 0;
            label1.Text = "订单编辑";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(270, 214);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 1;
            label2.Text = "客户名称";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerName.Location = new Point(626, 211);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(295, 30);
            txtCustomerName.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnAddDetail);
            panel1.Controls.Add(numQuantity);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(txtPrice);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 607);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 146);
            panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(400, 76);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "保存订单";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAddDetail
            // 
            btnAddDetail.Location = new Point(400, 20);
            btnAddDetail.Name = "btnAddDetail";
            btnAddDetail.Size = new Size(112, 34);
            btnAddDetail.TabIndex = 3;
            btnAddDetail.Text = "添加明细";
            btnAddDetail.UseVisualStyleBackColor = true;
            btnAddDetail.Click += btnAddDetail_Click;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(280, 20);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(100, 30);
            numQuantity.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(20, 20);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "产品名称";
            txtProductName.Size = new Size(120, 30);
            txtProductName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(150, 20);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "价格";
            txtPrice.Size = new Size(120, 30);
            txtPrice.TabIndex = 1;
            // 
            // dgvEditDetails
            // 
            dgvEditDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditDetails.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvEditDetails.Dock = DockStyle.Fill;
            dgvEditDetails.Location = new Point(3, 305);
            dgvEditDetails.Name = "dgvEditDetails";
            dgvEditDetails.RowHeadersWidth = 62;
            dgvEditDetails.Size = new Size(617, 296);
            dgvEditDetails.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "productName";
            Column1.HeaderText = "产品名称";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "price";
            Column2.HeaderText = "单价";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "quantity";
            Column3.HeaderText = "数量";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // OrderEditForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 756);
            Controls.Add(tableLayoutPanel1);
            Name = "OrderEditForm";
            Text = "订单编辑";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEditDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox txtCustomerName;
        private DataGridView dgvEditDetails;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private TextBox txtProductName;
        private Button btnAddDetail;
        private NumericUpDown numQuantity;
        private TextBox txtPrice;
        private Button btnSave;
    }
}