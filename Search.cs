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

namespace StoreProject
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            loadProducts();
            loadData();
        }
        void loadData()
        {
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                string query = "Select * from Orders";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                s_grid_orders.DataSource = dt;
            }

        }
        void loadProducts()
        {
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                string query = "SELECT ProductID, ProductName FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                S_cb_product.DataSource = dt;
                S_cb_product.DisplayMember = "ProductName";
                S_cb_product.ValueMember = "ProductID";
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int selectedProductId = Convert.ToInt32(S_cb_product.SelectedValue);

            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                string query = "SELECT * FROM Orders WHERE ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProductID", selectedProductId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                s_grid_orders.DataSource = dt;
            }
        }
    }
}
