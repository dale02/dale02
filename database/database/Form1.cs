using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "INSERT INTO Products (ProductName, Description, UnitPrice, StockQuantity)" +
                    "VALUES (@ProductName, @Description, @UnitPrice, @StockQuantity)";

                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@UnitPrice", txtUnitPrice.Text);
                        cmd.Parameters.AddWithValue("@StockQuantity", txtStockQuantity.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Product registered successfully!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        conn.Dispose();
                        this.Close();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nRegistration ERROR");
                }
            }
        

    }
    }
}
