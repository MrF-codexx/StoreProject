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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StoreProject
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
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
                grid_filter.DataSource = dt;
            }

        }
        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rb_date_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_date.Checked)
            {
                cb_filter.Items.Clear();
                cb_filter.Items.Add("Oldest to Newest");
                cb_filter.Items.Add("Newest to Oldest");
                cb_filter.SelectedIndex = 0;
            }
        }

        private void rb_price_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_price.Checked)
            {
                cb_filter.Items.Clear();
                cb_filter.Items.Add("Lowest to Highest");
                cb_filter.Items.Add("Highest to Lowest");
                cb_filter.SelectedIndex = 0;
            }
        }

        private void f_btn_filter_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Orders";

            if (rb_date.Checked && cb_filter.SelectedIndex != -1)
            {
                if (cb_filter.SelectedItem.ToString() == "Newest to Oldest")
                    query += " ORDER BY OrderDate DESC";
                else if (cb_filter.SelectedItem.ToString() == "Oldest to Newest")
                    query += " ORDER BY OrderDate ASC";
            }
            else if (rb_price.Checked && cb_filter.SelectedIndex != -1)
            {
                if (cb_filter.SelectedItem.ToString() == "Highest to Lowest")
                    query += " ORDER BY TotalPrice DESC";
                else if (cb_filter.SelectedItem.ToString() == "Lowest to Highest")
                    query += " ORDER BY TotalPrice ASC";
            }
            using (SqlConnection conn = new SqlConnection(Constants.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                grid_filter.DataSource = dt;
            }
        }
    }
}
