using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace StoreProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadData();
            LoadCategories();
            string selectedCategory = cb_category.SelectedValue.ToString();
            LoadProductsByCategory(selectedCategory);
        }
        int current_Id = -1;
        void resetForm()
        {
            txt_cname.Clear();
            txt_num.Clear();
            txt_location.Clear();
            cb_product.SelectedIndex = 0;
            num_quantity.Value = 0;
            txt_totalprice.Clear();
        }
        void loadData()
        {
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                string query = "Select * from Orders";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                grid_orders.DataSource = dt;
            }

        }

        void LoadCategories()
        {
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                string query = "SELECT DISTINCT Category FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cb_category.DataSource = dt;
                cb_category.DisplayMember = "Category";
                cb_category.ValueMember = "Category";
            }

        }


        private void btn_insert_Click(object sender, EventArgs e)
        {
            string name = txt_cname.Text.Trim();
            string phone = txt_num.Text.Trim();
            string location = txt_location.Text.Trim();
            string productName = cb_product.Text;
            int quantity = Convert.ToInt32(num_quantity.Value);

            
                // Replace the phone validation regex with one that allows an optional space after the country code
                if (!Regex.IsMatch(phone, @"^\+\d{1,4}\s?\d{6,16}$"))
                {
                    MessageBox.Show("Enter a valid phone number.");
                    return;
                }
            

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(location)
                || string.IsNullOrEmpty(productName) || quantity <= 0)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                using SqlConnection connection = new SqlConnection(Constants.connectionString);
                connection.Open();

                // 1. Check if customer exists
                int customerId;
                string checkCustomer = "SELECT CustomerID FROM Customers WHERE CustomerName = @Name AND PhoneNumber = @Phone";
                using SqlCommand cmd = new SqlCommand(checkCustomer, connection);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    customerId = Convert.ToInt32(result);
                }
                else
                {
                    // Insert customer
                    string insertCustomer = "INSERT INTO Customers (CustomerName, PhoneNumber, C_Location)  OUTPUT INSERTED.CustomerID VALUES (@Name, @Phone, @Location)";
                    using SqlCommand cmdInsert = new SqlCommand(insertCustomer, connection);
                    cmdInsert.Parameters.AddWithValue("@Name", name);
                    cmdInsert.Parameters.AddWithValue("@Phone", phone);
                    cmdInsert.Parameters.AddWithValue("@Location", location);
                    // ExecuteScalar() is used to get the new CustomerID after insertion
                    customerId = (int)cmdInsert.ExecuteScalar();
                }

                // 2. Get Product ID and Price
                int productId;
                decimal price;
                string getProduct = "SELECT ProductID, price FROM Products WHERE ProductName = @ProductName";
                using SqlCommand cmdProduct = new SqlCommand(getProduct, connection);
                cmdProduct.Parameters.AddWithValue("@ProductName", productName);
                // Using SqlDataReader to read multiple fields (ProductID and Price) from one row
                using SqlDataReader reader = cmdProduct.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("Product not found.");
                    return;
                }
                productId = reader.GetInt32(0);
                price = reader.GetDecimal(1);
                reader.Close();

                // 3. Insert Order
                decimal totalPrice = price * quantity;
                string insertOrder = "INSERT INTO Orders (CustomerID, ProductID, OrderDate, Quantity, TotalPrice) VALUES (@CustomerID, @ProductID, GETDATE(), @Quantity, @TotalPrice)";
                using SqlCommand cmdOrder = new SqlCommand(insertOrder, connection);
                cmdOrder.Parameters.AddWithValue("@CustomerID", customerId);
                cmdOrder.Parameters.AddWithValue("@ProductID", productId);
                cmdOrder.Parameters.AddWithValue("@Quantity", quantity);
                cmdOrder.Parameters.AddWithValue("@TotalPrice", totalPrice);
                int rows = cmdOrder.ExecuteNonQuery();

                MessageBox.Show($"{rows} order(s) inserted.");

                txt_totalprice.Text = totalPrice.ToString();
                resetForm();
                loadData();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void LoadProductsByCategory(string category)
        {
            using SqlConnection connection = new SqlConnection(Constants.connectionString);
            string query = "SELECT ProductID, ProductName FROM Products WHERE Category = @Category";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Category", category);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cb_product.DataSource = dt;
            cb_product.DisplayMember = "ProductName";
            cb_product.ValueMember = "ProductID";
            connection.Close();
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cb_category.SelectedValue.ToString();

            LoadProductsByCategory(selectedCategory);

        }
        private void UpdateTotalPrice(string productName, int quantity)
        {

            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                string query = "SELECT Price FROM Products WHERE ProductName = @ProductName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", productName);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar(); // Get single value (price)

                    if (result != null)
                    {
                        decimal price = Convert.ToDecimal(result);
                        decimal totalPrice = price * quantity; // Calculate total price
                        txt_totalprice.Text = totalPrice.ToString("F2"); // Display total price with two decimal places
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating total price: " + ex.Message);
                }
            }
        }

        private void num_quantity_ValueChanged(object sender, EventArgs e)
        {
            string selectedProduct = cb_product.Text;
            int quantity = (int)num_quantity.Value;
            UpdateTotalPrice(selectedProduct, quantity);
        }

        private void cb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = cb_product.Text;
            int quantity = (int)num_quantity.Value;
            UpdateTotalPrice(selectedProduct, quantity);
        }

        private void grid_orders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = grid_orders.Rows[e.RowIndex];
            current_Id = Convert.ToInt32(row.Cells["OrderID"].Value);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("are u sure u want to delete this Order", "Confirmation",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    string connectionString = Constants.connectionString;
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string query = $"DELETE FROM Orders WHERE OrderID={current_Id}";
                    SqlCommand command = new SqlCommand(query, connection);
                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show($"{rows} Orders have been deleted");
                    loadData();


                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search();
            searchForm.ShowDialog();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm();
            filterForm.ShowDialog();
        }
    }
}



