using IronBarCode;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsAppPOS
{
    public partial class frmProduct : Form
    {

        public frmProduct()
        {
            InitializeComponent();
            Reset();
        }

        string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=;";
        int idNum = 0;
        public void Reset()
        {
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtPrice.Enabled = false;
            cmbCategory.Enabled = false;
            cmbCategory.SelectedIndex = 0;
        }
        public void Clear()
        {
            //txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cmbCategory.SelectedIndex = 0;
        }
        public void InputEnable()
        {
            txtProductId.Enabled = false;
            txtProductName.Enabled = true;
            txtPrice.Enabled = true;
            cmbCategory.Enabled = true;
            cmbCategory.SelectedIndex = 0;
        }

        public int GetTableRowCount()
        {
            string query = "SELECT COUNT(*) FROM products";
            int rowCount = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error occurred: {ex.Message}");
                    }
                }
            }
            return rowCount;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD")
            {
                idNum = GetTableRowCount() +1;
                txtProductId.Text = txtProductId.Text = "2026-000" + idNum.ToString();
                btnAdd.Text = "SAVE";
                InputEnable();
            }
            else if (btnAdd.Text == "SAVE")
            {
                string id = txtProductId.Text;
                string name = txtProductName.Text;
                string price = txtPrice.Text;
                string category = cmbCategory.Text;
                using(MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string sqlQuery = "INSERT INTO products(@ProductName,@Description,@Category,@UnitPrice,@StockQuantity,@Barcode)";
                        using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.ToString());
                            cmd.Parameters.AddWithValue("@Description", rtbDesc.Text.ToString());
                            cmd.Parameters.AddWithValue("@Category", rtbDesc.Text.ToString());
                            cmd.Parameters.AddWithValue("@UnitPrice", rtbDesc.Text.ToString());
                            cmd.Parameters.AddWithValue("@StockQuantity", rtbDesc.Text.ToString());
                            cmd.Parameters.AddWithValue("@Barcode", rtbDesc.Text.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Products error occured: {+ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    
                }




                //dgvProducts.Rows.Add(id, name, price, category);




                btnAdd.Text = "ADD";
                Clear();
                Reset();
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "EDIT")
            {
                if (dgvProducts.SelectedRows.Count > 0)
                {
                    btnEdit.Text = "UPDATE";
                    InputEnable();
                    txtProductId.Text = dgvProducts.SelectedRows[0].Cells["ID"].Value.ToString();
                    txtProductName.Text = dgvProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();
                    rtbDesc.Text = dgvProducts.SelectedRows[0].Cells["Description"].Value.ToString();
                    cmbCategory.Text = dgvProducts.SelectedRows[0].Cells["Category"].Value.ToString();
                    txtPrice.Text = dgvProducts.SelectedRows[0].Cells["UnitPrice"].Value.ToString();
                    txtStockQuantity.Text = dgvProducts.SelectedRows[0].Cells["StockQuantity"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please select data on the list.");
                }
            }
            else if (btnEdit.Text == "UPDATE")
            {
                for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
                {
                    if (dgvProducts.Rows[i].Cells["ID"].Value.ToString() == txtProductId.Text)
                    {
                        dgvProducts.Rows[i].Cells["ID"].Value = txtProductId.Text;
                        dgvProducts.Rows[i].Cells["ProductName"].Value = txtProductName.Text;
                        dgvProducts.Rows[i].Cells["Description"].Value = txtPrice.Text;
                        dgvProducts.Rows[i].Cells["Category"].Value = cmbCategory.Text;
                        dgvProducts.Rows[i].Cells["UnitPrice"].Value = txtPrice.Text;
                        dgvProducts.Rows[i].Cells["StockQuantity"].Value = txtStockQuantity.Text;

                        MessageBox.Show("SUCCESSFULLY UPDATED");
                    }
                }
                btnEdit.Text = "EDIT";
                Clear();
                Reset();
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            dgvProducts.Rows.Add(001, "Coke", "Coke", "Drinks", 25, 100);
            dgvProducts.Rows.Add(002, "Sprite", "Sprite", "Drinks", 25, 50);
            dgvProducts.Rows.Add(003, "Royal", "Royal", "Drinks", 25, 70);
            dgvProducts.Rows.Add(004, "RC", "RC", "Drinks", 25, 55);
            dgvProducts.Rows.Add(005, "C2","C2", "Drinks", 25, 75);
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
               MessageBox.Show("Please select row to delete","No selection",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
                
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete the selected row(s)?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvProducts.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvProducts.Rows.Remove(row);
                        MessageBox.Show("Selected row(s) deleted successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
