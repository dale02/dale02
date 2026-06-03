using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppPOS
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex != 0)
            {
                
                if(string.IsNullOrWhiteSpace(txtFullname.Text))
                {
                    MessageBox.Show("Fill up required field.");
                    txtFullname.Focus();
                }
                else if(string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Fill up required field.");
                    txtUsername.Focus();
                }
                else if(txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Password not Match.");
                    txtPassword.Focus();
                }
                else
                {
                    string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=;";
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string sqlQuery = "INSERT INTO Users (Username, Password, FullName, Role)" +
                            "VALUES (@Username, @Password, @FullName, @Role)";

                            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                                cmd.Parameters.AddWithValue("@FullName", txtFullname.Text);
                                cmd.Parameters.AddWithValue("@Role", cmbRole.Text);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("User registered successfully!","Register",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                conn.Dispose();
                                this.Close();
                                frmLogin login = new frmLogin();
                                login.Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nRegistration ERROR");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Role", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
