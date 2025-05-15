namespace StoreProject
{
    partial class Form1
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
            label1 = new Label();
            txt_num = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_cname = new TextBox();
            label4 = new Label();
            txt_location = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cb_category = new ComboBox();
            cb_product = new ComboBox();
            num_quantity = new NumericUpDown();
            txt_totalprice = new TextBox();
            grid_orders = new DataGridView();
            btn_delete = new Button();
            btn_insert = new Button();
            btn_search = new Button();
            btn_update = new Button();
            label11 = new Label();
            btn_filter = new Button();
            ((System.ComponentModel.ISupportInitialize)num_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_orders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(1, 124);
            label1.Name = "label1";
            label1.Size = new Size(196, 35);
            label1.TabIndex = 0;
            label1.Text = "Phone Number :";
            // 
            // txt_num
            // 
            txt_num.Font = new Font("Segoe UI", 15F);
            txt_num.Location = new Point(203, 118);
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(169, 41);
            txt_num.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(124, 22);
            label2.Name = "label2";
            label2.Size = new Size(181, 35);
            label2.TabIndex = 0;
            label2.Text = "Customer Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(103, 74);
            label3.Name = "label3";
            label3.Size = new Size(94, 35);
            label3.TabIndex = 0;
            label3.Text = "Name :";
            // 
            // txt_cname
            // 
            txt_cname.Font = new Font("Segoe UI", 15F);
            txt_cname.Location = new Point(203, 71);
            txt_cname.Name = "txt_cname";
            txt_cname.Size = new Size(169, 41);
            txt_cname.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(75, 174);
            label4.Name = "label4";
            label4.Size = new Size(122, 35);
            label4.TabIndex = 0;
            label4.Text = "Location :";
            // 
            // txt_location
            // 
            txt_location.Font = new Font("Segoe UI", 15F);
            txt_location.Location = new Point(203, 168);
            txt_location.Name = "txt_location";
            txt_location.Size = new Size(169, 41);
            txt_location.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(27, 272);
            label5.Name = "label5";
            label5.Size = new Size(115, 35);
            label5.TabIndex = 0;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(3, 466);
            label6.Name = "label6";
            label6.Size = new Size(141, 35);
            label6.TabIndex = 0;
            label6.Text = "Total Price :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(23, 403);
            label7.Name = "label7";
            label7.Size = new Size(121, 35);
            label7.TabIndex = 0;
            label7.Text = "Quantity :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(112, 237);
            label8.Name = "label8";
            label8.Size = new Size(161, 35);
            label8.TabIndex = 0;
            label8.Text = "Product Data";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(1, 209);
            label9.Name = "label9";
            label9.Size = new Size(372, 35);
            label9.TabIndex = 0;
            label9.Text = "=====================";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(241, 272);
            label10.Name = "label10";
            label10.Size = new Size(109, 35);
            label10.TabIndex = 0;
            label10.Text = "Product ";
            // 
            // cb_category
            // 
            cb_category.Font = new Font("Segoe UI", 15F);
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(8, 310);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(151, 43);
            cb_category.TabIndex = 2;
            cb_category.SelectedIndexChanged += cb_category_SelectedIndexChanged;
            // 
            // cb_product
            // 
            cb_product.Font = new Font("Segoe UI", 15F);
            cb_product.FormattingEnabled = true;
            cb_product.Location = new Point(222, 310);
            cb_product.Name = "cb_product";
            cb_product.Size = new Size(151, 43);
            cb_product.TabIndex = 2;
            cb_product.SelectedIndexChanged += cb_product_SelectedIndexChanged;
            // 
            // num_quantity
            // 
            num_quantity.Font = new Font("Segoe UI", 15F);
            num_quantity.Location = new Point(150, 401);
            num_quantity.Name = "num_quantity";
            num_quantity.Size = new Size(150, 41);
            num_quantity.TabIndex = 3;
            num_quantity.ValueChanged += num_quantity_ValueChanged;
            // 
            // txt_totalprice
            // 
            txt_totalprice.Font = new Font("Segoe UI", 15F);
            txt_totalprice.Location = new Point(150, 466);
            txt_totalprice.Name = "txt_totalprice";
            txt_totalprice.ReadOnly = true;
            txt_totalprice.Size = new Size(155, 41);
            txt_totalprice.TabIndex = 1;
            // 
            // grid_orders
            // 
            grid_orders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_orders.Location = new Point(542, 46);
            grid_orders.Name = "grid_orders";
            grid_orders.ReadOnly = true;
            grid_orders.RowHeadersWidth = 51;
            grid_orders.Size = new Size(593, 463);
            grid_orders.TabIndex = 4;
            grid_orders.RowEnter += grid_orders_RowEnter;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Font = new Font("Segoe UI", 15F);
            btn_delete.ForeColor = SystemColors.ButtonHighlight;
            btn_delete.Location = new Point(203, 515);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(202, 63);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Delete an Order";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.ForestGreen;
            btn_insert.Font = new Font("Segoe UI", 15F);
            btn_insert.ForeColor = SystemColors.ButtonHighlight;
            btn_insert.Location = new Point(3, 515);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(194, 63);
            btn_insert.TabIndex = 6;
            btn_insert.Text = "Insert an Order";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.DarkCyan;
            btn_search.Font = new Font("Segoe UI", 15F);
            btn_search.ForeColor = SystemColors.ButtonHighlight;
            btn_search.Location = new Point(684, 515);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(99, 63);
            btn_search.TabIndex = 6;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_Search_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.DarkCyan;
            btn_update.Font = new Font("Segoe UI", 15F);
            btn_update.ForeColor = SystemColors.ButtonHighlight;
            btn_update.Location = new Point(890, 515);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(104, 63);
            btn_update.TabIndex = 6;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(744, 8);
            label11.Name = "label11";
            label11.Size = new Size(135, 35);
            label11.TabIndex = 0;
            label11.Text = "Orders List";
            // 
            // btn_filter
            // 
            btn_filter.BackColor = Color.DarkCyan;
            btn_filter.Font = new Font("Segoe UI", 15F);
            btn_filter.ForeColor = SystemColors.ButtonHighlight;
            btn_filter.Location = new Point(785, 515);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(99, 63);
            btn_filter.TabIndex = 7;
            btn_filter.Text = "Filter";
            btn_filter.UseVisualStyleBackColor = false;
            btn_filter.Click += btn_filter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 590);
            Controls.Add(btn_filter);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_search);
            Controls.Add(btn_insert);
            Controls.Add(grid_orders);
            Controls.Add(num_quantity);
            Controls.Add(cb_product);
            Controls.Add(cb_category);
            Controls.Add(txt_cname);
            Controls.Add(txt_totalprice);
            Controls.Add(txt_location);
            Controls.Add(txt_num);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)num_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_orders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_num;
        private Label label2;
        private Label label3;
        private TextBox txt_cname;
        private Label label4;
        private TextBox txt_location;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cb_category;
        private ComboBox cb_product;
        private NumericUpDown num_quantity;
        private TextBox txt_totalprice;
        private DataGridView grid_orders;
        private Button btn_delete;
        private Button btn_insert;
        private Button btn_search;
        private Button btn_update;
        private Label label11;
        private Button btn_filter;
    }
}
