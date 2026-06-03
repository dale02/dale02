namespace WinFormsAppPOS
{
    partial class frmProduct
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            unitPrice = new DataGridViewTextBoxColumn();
            stockQuantity = new DataGridViewTextBoxColumn();
            barcode = new DataGridViewTextBoxColumn();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtProductId = new TextBox();
            cmbCategory = new ComboBox();
            label5 = new Label();
            rtbDesc = new RichTextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            txtStockQuantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 22);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Product id :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Product Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(473, 23);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 54);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Category :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(728, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(728, 47);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 22);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(728, 72);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 22);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(728, 95);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 25);
            btnClear.TabIndex = 7;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = SystemColors.Control;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { id, ProductName, description, category, unitPrice, stockQuantity, barcode });
            dgvProducts.Location = new Point(40, 168);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(763, 217);
            dgvProducts.TabIndex = 8;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 50;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 155;
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.Width = 125;
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.Width = 127;
            // 
            // unitPrice
            // 
            unitPrice.HeaderText = "UnitPrice";
            unitPrice.Name = "unitPrice";
            // 
            // stockQuantity
            // 
            stockQuantity.HeaderText = "StockQuantity";
            stockQuantity.Name = "stockQuantity";
            // 
            // barcode
            // 
            barcode.HeaderText = "Barcode";
            barcode.Name = "barcode";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(168, 51);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(267, 23);
            txtProductName.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(522, 20);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(174, 23);
            txtPrice.TabIndex = 11;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(168, 19);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(267, 23);
            txtProductId.TabIndex = 9;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "-Select Category-", "Drinks", "Bread & Pastry", "Snacks", "Vegetables" });
            cmbCategory.Location = new Point(522, 51);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(174, 23);
            cmbCategory.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 95);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 13;
            label5.Text = "Product Description :";
            // 
            // rtbDesc
            // 
            rtbDesc.Location = new Point(168, 83);
            rtbDesc.Name = "rtbDesc";
            rtbDesc.Size = new Size(267, 37);
            rtbDesc.TabIndex = 14;
            rtbDesc.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(456, 105);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 15;
            label6.Text = "Barcode :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Location = new Point(522, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 41);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 134);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 17;
            label7.Text = "Stock Quantity :";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(168, 131);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(101, 23);
            txtStockQuantity.TabIndex = 18;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(845, 396);
            Controls.Add(txtStockQuantity);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(rtbDesc);
            Controls.Add(label5);
            Controls.Add(cmbCategory);
            Controls.Add(dgvProducts);
            Controls.Add(txtPrice);
            Controls.Add(txtProductId);
            Controls.Add(txtProductName);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Maintenance";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtProductId;
        private ComboBox cmbCategory;
        private Label label5;
        private RichTextBox rtbDesc;
        private Label label6;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn unitPrice;
        private DataGridViewTextBoxColumn stockQuantity;
        private DataGridViewTextBoxColumn barcode;
        private Label label7;
        private TextBox txtStockQuantity;
    }
}