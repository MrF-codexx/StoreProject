namespace StoreProject
{
    partial class FilterForm
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
            rb_price = new RadioButton();
            rb_date = new RadioButton();
            cb_filter = new ComboBox();
            f_btn_filter = new Button();
            grid_filter = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grid_filter).BeginInit();
            SuspendLayout();
            // 
            // rb_price
            // 
            rb_price.AutoSize = true;
            rb_price.Font = new Font("Segoe UI", 15F);
            rb_price.Location = new Point(226, 12);
            rb_price.Name = "rb_price";
            rb_price.Size = new Size(184, 39);
            rb_price.TabIndex = 0;
            rb_price.TabStop = true;
            rb_price.Text = "Filter By Price";
            rb_price.UseVisualStyleBackColor = true;
            rb_price.CheckedChanged += rb_price_CheckedChanged;
            // 
            // rb_date
            // 
            rb_date.AutoSize = true;
            rb_date.Font = new Font("Segoe UI", 15F);
            rb_date.Location = new Point(12, 12);
            rb_date.Name = "rb_date";
            rb_date.Size = new Size(182, 39);
            rb_date.TabIndex = 0;
            rb_date.TabStop = true;
            rb_date.Text = "Filter By Date";
            rb_date.UseVisualStyleBackColor = true;
            rb_date.CheckedChanged += rb_date_CheckedChanged;
            // 
            // cb_filter
            // 
            cb_filter.Font = new Font("Segoe UI", 15F);
            cb_filter.FormattingEnabled = true;
            cb_filter.Location = new Point(12, 57);
            cb_filter.Name = "cb_filter";
            cb_filter.Size = new Size(398, 43);
            cb_filter.TabIndex = 1;
            cb_filter.SelectedIndexChanged += cb_filter_SelectedIndexChanged;
            // 
            // f_btn_filter
            // 
            f_btn_filter.BackColor = Color.DarkCyan;
            f_btn_filter.Font = new Font("Segoe UI", 15F);
            f_btn_filter.ForeColor = SystemColors.ButtonHighlight;
            f_btn_filter.Location = new Point(416, 56);
            f_btn_filter.Name = "f_btn_filter";
            f_btn_filter.Size = new Size(159, 43);
            f_btn_filter.TabIndex = 8;
            f_btn_filter.Text = "Apply Filter";
            f_btn_filter.UseVisualStyleBackColor = false;
            f_btn_filter.Click += f_btn_filter_Click;
            // 
            // grid_filter
            // 
            grid_filter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_filter.Location = new Point(12, 106);
            grid_filter.Name = "grid_filter";
            grid_filter.ReadOnly = true;
            grid_filter.RowHeadersWidth = 51;
            grid_filter.Size = new Size(675, 404);
            grid_filter.TabIndex = 9;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 522);
            Controls.Add(grid_filter);
            Controls.Add(f_btn_filter);
            Controls.Add(cb_filter);
            Controls.Add(rb_date);
            Controls.Add(rb_price);
            Name = "FilterForm";
            Text = "FilterForm";
            ((System.ComponentModel.ISupportInitialize)grid_filter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rb_price;
        private RadioButton rb_date;
        private ComboBox cb_filter;
        private Button f_btn_filter;
        private DataGridView grid_filter;
    }
}