namespace StoreProject
{
    partial class Search
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
            s_grid_orders = new DataGridView();
            label5 = new Label();
            label3 = new Label();
            S_cb_product = new ComboBox();
            btn_search = new Button();
            ((System.ComponentModel.ISupportInitialize)s_grid_orders).BeginInit();
            SuspendLayout();
            // 
            // s_grid_orders
            // 
            s_grid_orders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            s_grid_orders.Location = new Point(30, 105);
            s_grid_orders.Name = "s_grid_orders";
            s_grid_orders.ReadOnly = true;
            s_grid_orders.RowHeadersWidth = 51;
            s_grid_orders.Size = new Size(1117, 417);
            s_grid_orders.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(488, 67);
            label5.Name = "label5";
            label5.Size = new Size(135, 35);
            label5.TabIndex = 10;
            label5.Text = "Orders List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(30, 9);
            label3.Name = "label3";
            label3.Size = new Size(242, 35);
            label3.TabIndex = 12;
            label3.Text = "Search for a Product";
            // 
            // S_cb_product
            // 
            S_cb_product.Font = new Font("Segoe UI", 15F);
            S_cb_product.FormattingEnabled = true;
            S_cb_product.Location = new Point(278, 6);
            S_cb_product.Name = "S_cb_product";
            S_cb_product.Size = new Size(207, 43);
            S_cb_product.TabIndex = 13;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.DarkCyan;
            btn_search.Font = new Font("Segoe UI", 15F);
            btn_search.ForeColor = SystemColors.ButtonHighlight;
            btn_search.Location = new Point(491, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(100, 48);
            btn_search.TabIndex = 14;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 527);
            Controls.Add(btn_search);
            Controls.Add(S_cb_product);
            Controls.Add(label3);
            Controls.Add(s_grid_orders);
            Controls.Add(label5);
            Name = "Search";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)s_grid_orders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView s_grid_orders;
        private Label label5;
        private Label label3;
        private ComboBox S_cb_product;
        private Button btn_search;
    }
}