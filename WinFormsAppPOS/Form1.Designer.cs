namespace WinFormsAppPOS
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlMenu = new Panel();
            btnSettings = new Button();
            btnReports = new Button();
            btnTransaction = new Button();
            btnMaintenance = new Button();
            pictureBox1 = new PictureBox();
            pnlMaintenance = new Panel();
            btnUser = new Button();
            btnCustomer = new Button();
            btnCategory = new Button();
            btnProducts = new Button();
            pnlSales = new Panel();
            btnSales = new Button();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMaintenance.SuspendLayout();
            pnlSales.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(0, 192, 192);
            pnlMenu.Controls.Add(btnSettings);
            pnlMenu.Controls.Add(btnReports);
            pnlMenu.Controls.Add(btnTransaction);
            pnlMenu.Controls.Add(btnMaintenance);
            pnlMenu.Location = new Point(0, 86);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(121, 365);
            pnlMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(6, 299);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(99, 36);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(6, 106);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(99, 36);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnTransaction
            // 
            btnTransaction.Location = new Point(6, 64);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(99, 36);
            btnTransaction.TabIndex = 1;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = true;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnMaintenance
            // 
            btnMaintenance.Location = new Point(6, 22);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(99, 36);
            btnMaintenance.TabIndex = 0;
            btnMaintenance.Text = "Maintenance";
            btnMaintenance.UseVisualStyleBackColor = true;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pnlMaintenance
            // 
            pnlMaintenance.BackColor = Color.Transparent;
            pnlMaintenance.Controls.Add(btnUser);
            pnlMaintenance.Controls.Add(btnCustomer);
            pnlMaintenance.Controls.Add(btnCategory);
            pnlMaintenance.Controls.Add(btnProducts);
            pnlMaintenance.Location = new Point(134, 55);
            pnlMaintenance.Name = "pnlMaintenance";
            pnlMaintenance.Size = new Size(658, 343);
            pnlMaintenance.TabIndex = 3;
            pnlMaintenance.Visible = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.PaleTurquoise;
            btnUser.Location = new Point(353, 206);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(163, 82);
            btnUser.TabIndex = 3;
            btnUser.Text = "USER";
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.PaleTurquoise;
            btnCustomer.Location = new Point(152, 206);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(163, 82);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "CUSTOMER";
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.PaleTurquoise;
            btnCategory.Location = new Point(353, 75);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(163, 82);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "CATEGORY";
            btnCategory.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.PaleTurquoise;
            btnProducts.Location = new Point(152, 74);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(163, 82);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // pnlSales
            // 
            pnlSales.BackColor = Color.Transparent;
            pnlSales.Controls.Add(btnSales);
            pnlSales.Location = new Point(126, 68);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(672, 303);
            pnlSales.TabIndex = 4;
            pnlSales.Visible = false;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.PaleTurquoise;
            btnSales.Location = new Point(220, 86);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(163, 82);
            btnSales.TabIndex = 0;
            btnSales.Text = "SALES";
            btnSales.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(228, 14);
            label1.Name = "label1";
            label1.Size = new Size(395, 31);
            label1.TabIndex = 5;
            label1.Text = "POINT OF SALES MAINTENANCE";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 450);
            Controls.Add(pnlSales);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pnlMenu);
            Controls.Add(pnlMaintenance);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POS Main";
            TransparencyKey = Color.Gray;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMaintenance.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Button btnTransaction;
        private Button btnMaintenance;
        private PictureBox pictureBox1;
        private Button btnReports;
        private Button btnSettings;
        private Panel pnlMaintenance;
        private Button btnCustomer;
        private Button btnCategory;
        private Button btnProducts;
        private Button btnUser;
        private Panel pnlSales;
        private Button btnSales;
        private Label label1;
    }
}
