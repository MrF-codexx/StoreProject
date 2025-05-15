namespace StoreProject
{
    partial class UpdateForm
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
            U_txt_cname = new TextBox();
            U_txt_location = new TextBox();
            U_txt_num = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            grid_customers = new DataGridView();
            label5 = new Label();
            U_btn_update = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_customers).BeginInit();
            SuspendLayout();
            // 
            // U_txt_cname
            // 
            U_txt_cname.Font = new Font("Segoe UI", 15F);
            U_txt_cname.Location = new Point(212, 84);
            U_txt_cname.Name = "U_txt_cname";
            U_txt_cname.Size = new Size(169, 41);
            U_txt_cname.TabIndex = 6;
            // 
            // U_txt_location
            // 
            U_txt_location.Font = new Font("Segoe UI", 15F);
            U_txt_location.Location = new Point(212, 181);
            U_txt_location.Name = "U_txt_location";
            U_txt_location.Size = new Size(169, 41);
            U_txt_location.TabIndex = 7;
            // 
            // U_txt_num
            // 
            U_txt_num.Font = new Font("Segoe UI", 15F);
            U_txt_num.Location = new Point(212, 131);
            U_txt_num.Name = "U_txt_num";
            U_txt_num.Size = new Size(169, 41);
            U_txt_num.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(133, 35);
            label2.Name = "label2";
            label2.Size = new Size(181, 35);
            label2.TabIndex = 2;
            label2.Text = "Customer Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(112, 87);
            label3.Name = "label3";
            label3.Size = new Size(94, 35);
            label3.TabIndex = 3;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(84, 187);
            label4.Name = "label4";
            label4.Size = new Size(122, 35);
            label4.TabIndex = 4;
            label4.Text = "Location :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(10, 137);
            label1.Name = "label1";
            label1.Size = new Size(196, 35);
            label1.TabIndex = 5;
            label1.Text = "Phone Number :";
            // 
            // grid_customers
            // 
            grid_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_customers.Location = new Point(446, 50);
            grid_customers.Name = "grid_customers";
            grid_customers.ReadOnly = true;
            grid_customers.RowHeadersWidth = 51;
            grid_customers.Size = new Size(594, 368);
            grid_customers.TabIndex = 9;
            grid_customers.CellClick += grid_customers_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(615, 12);
            label5.Name = "label5";
            label5.Size = new Size(177, 35);
            label5.TabIndex = 2;
            label5.Text = "Customers List";
            // 
            // U_btn_update
            // 
            U_btn_update.BackColor = Color.DarkCyan;
            U_btn_update.Font = new Font("Segoe UI", 15F);
            U_btn_update.ForeColor = SystemColors.ButtonHighlight;
            U_btn_update.Location = new Point(133, 276);
            U_btn_update.Name = "U_btn_update";
            U_btn_update.Size = new Size(217, 63);
            U_btn_update.TabIndex = 10;
            U_btn_update.Text = "Update";
            U_btn_update.UseVisualStyleBackColor = false;
            U_btn_update.Click += U_btn_update_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 450);
            Controls.Add(U_btn_update);
            Controls.Add(grid_customers);
            Controls.Add(U_txt_cname);
            Controls.Add(U_txt_location);
            Controls.Add(U_txt_num);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "UpdateForm";
            Text = "UpdateForm";
            ((System.ComponentModel.ISupportInitialize)grid_customers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox U_txt_cname;
        private TextBox U_txt_location;
        private TextBox U_txt_num;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private DataGridView grid_customers;
        private Label label5;
        private Button U_btn_update;
    }
}