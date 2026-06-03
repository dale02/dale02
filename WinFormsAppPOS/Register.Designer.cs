namespace WinFormsAppPOS
{
    partial class frmRegister
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
            txtUsername = new TextBox();
            txtFullname = new TextBox();
            btnCancel = new Button();
            btnRegister = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(117, 122);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(174, 23);
            txtUsername.TabIndex = 24;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(117, 43);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(174, 23);
            txtFullname.TabIndex = 23;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(185, 240);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(70, 240);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 161);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 16;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 130);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 15;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 51);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 14;
            label2.Text = "Fullname:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(117, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(174, 23);
            txtPassword.TabIndex = 25;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(117, 196);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(174, 23);
            txtConfirm.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 199);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 26;
            label5.Text = "Confirm Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 91);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 28;
            label6.Text = "Role:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "--Select Role--", "Admin", "Cashier" });
            cmbRole.Location = new Point(119, 82);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(172, 23);
            cmbRole.TabIndex = 29;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(309, 280);
            Controls.Add(cmbRole);
            Controls.Add(label6);
            Controls.Add(txtConfirm);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullname);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += frmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtFullname;
        private Button btnCancel;
        private Button btnRegister;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Label label5;
        private Label label6;
        private ComboBox cmbRole;
    }
}