using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WinFormsAppPOS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sqlQuery = "SELECT * FROM users WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ";

                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        //cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        //cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {


                            if (reader.Read())
                            {
                                MessageBox.Show("Login Successful!");

                                frmMain frm = new frmMain();
                                frm.Show();

                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password.");
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nlOGIN ERROR");
                }
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmReg = new frmRegister();
            frmReg.Show();
            this.Hide();
        }
    }
}
