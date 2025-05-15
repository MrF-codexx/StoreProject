using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreProject
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                string query = "SELECT * FROM Customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                grid_customers.DataSource = dt;
            }
        }

        private void grid_customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row clicks
            DataGridViewRow row = grid_customers.Rows[e.RowIndex];
            U_txt_cname.Text = row.Cells["CustomerName"].Value.ToString();
            U_txt_num.Text = row.Cells["PhoneNumber"].Value.ToString();
            U_txt_location.Text = row.Cells["C_Location"].Value.ToString();
        }

        private void U_btn_update_Click(object sender, EventArgs e)
        {
            if (grid_customers.CurrentRow != null)
            {
                int customerId = Convert.ToInt32(grid_customers.CurrentRow.Cells["CustomerID"].Value);
                string name = U_txt_cname.Text.Trim();
                string phone = U_txt_num.Text.Trim();
                string location = U_txt_location.Text.Trim();

                using (SqlConnection connection = new SqlConnection(Constants.connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Customers SET CustomerName = @name, PhoneNumber = @phone, C_Location = @location WHERE CustomerID = @id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@id", customerId);
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show($"{rows} record(s) updated successfully.");
                    LoadCustomers(); 
                }
            }
        }
    }
}
