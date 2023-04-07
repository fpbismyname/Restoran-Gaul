namespace Restoran_Gaul
{
    partial class OrderPage
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
            this.daftar_menu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.daftar_siap_order = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.food_picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_menu = new System.Windows.Forms.ComboBox();
            this.qty_style = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add_order = new System.Windows.Forms.Button();
            this.delete_order = new System.Windows.Forms.Button();
            this.order_menu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.total_order = new System.Windows.Forms.Label();
            this.total_carbo = new System.Windows.Forms.Label();
            this.total_protein = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.daftar_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftar_siap_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // daftar_menu
            // 
            this.daftar_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daftar_menu.Location = new System.Drawing.Point(27, 166);
            this.daftar_menu.Name = "daftar_menu";
            this.daftar_menu.Size = new System.Drawing.Size(488, 234);
            this.daftar_menu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Golden Smile", 14F);
            this.label2.Location = new System.Drawing.Point(22, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daftar menu";
            // 
            // daftar_siap_order
            // 
            this.daftar_siap_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daftar_siap_order.Location = new System.Drawing.Point(562, 166);
            this.daftar_siap_order.Name = "daftar_siap_order";
            this.daftar_siap_order.Size = new System.Drawing.Size(488, 234);
            this.daftar_siap_order.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Golden Smile", 14F);
            this.label3.Location = new System.Drawing.Point(557, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Daftar order";
            // 
            // food_picture
            // 
            this.food_picture.Location = new System.Drawing.Point(27, 429);
            this.food_picture.Name = "food_picture";
            this.food_picture.Size = new System.Drawing.Size(135, 133);
            this.food_picture.TabIndex = 2;
            this.food_picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label1.Location = new System.Drawing.Point(186, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Menu";
            // 
            // list_menu
            // 
            this.list_menu.Enabled = false;
            this.list_menu.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.list_menu.FormattingEnabled = true;
            this.list_menu.Location = new System.Drawing.Point(293, 429);
            this.list_menu.Name = "list_menu";
            this.list_menu.Size = new System.Drawing.Size(222, 31);
            this.list_menu.TabIndex = 4;
            // 
            // qty_style
            // 
            this.qty_style.Enabled = false;
            this.qty_style.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.qty_style.Location = new System.Drawing.Point(293, 477);
            this.qty_style.Name = "qty_style";
            this.qty_style.Size = new System.Drawing.Size(79, 28);
            this.qty_style.TabIndex = 5;
            this.qty_style.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label4.Location = new System.Drawing.Point(186, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qty";
            // 
            // add_order
            // 
            this.add_order.Enabled = false;
            this.add_order.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.add_order.Location = new System.Drawing.Point(293, 529);
            this.add_order.Name = "add_order";
            this.add_order.Size = new System.Drawing.Size(79, 33);
            this.add_order.TabIndex = 6;
            this.add_order.Text = "Add";
            this.add_order.UseVisualStyleBackColor = true;
            this.add_order.Click += new System.EventHandler(this.add_order_Click);
            // 
            // delete_order
            // 
            this.delete_order.Enabled = false;
            this.delete_order.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.delete_order.Location = new System.Drawing.Point(416, 529);
            this.delete_order.Name = "delete_order";
            this.delete_order.Size = new System.Drawing.Size(99, 33);
            this.delete_order.TabIndex = 6;
            this.delete_order.Text = "Delete";
            this.delete_order.UseVisualStyleBackColor = true;
            this.delete_order.Click += new System.EventHandler(this.delete_order_Click);
            // 
            // order_menu
            // 
            this.order_menu.Enabled = false;
            this.order_menu.Font = new System.Drawing.Font("Sitka Text", 18F);
            this.order_menu.Location = new System.Drawing.Point(639, 429);
            this.order_menu.Name = "order_menu";
            this.order_menu.Size = new System.Drawing.Size(137, 133);
            this.order_menu.TabIndex = 6;
            this.order_menu.Text = "Order Menu";
            this.order_menu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Golden Smile", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 49);
            this.label5.TabIndex = 1;
            this.label5.Text = "Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label6.Location = new System.Drawing.Point(813, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Carbo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label7.Location = new System.Drawing.Point(813, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Protein : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label8.Location = new System.Drawing.Point(813, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total : Rp.";
            // 
            // total_order
            // 
            this.total_order.AutoSize = true;
            this.total_order.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.total_order.Location = new System.Drawing.Point(898, 534);
            this.total_order.Name = "total_order";
            this.total_order.Size = new System.Drawing.Size(16, 23);
            this.total_order.TabIndex = 3;
            this.total_order.Text = "-";
            // 
            // total_carbo
            // 
            this.total_carbo.AutoSize = true;
            this.total_carbo.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.total_carbo.Location = new System.Drawing.Point(875, 482);
            this.total_carbo.Name = "total_carbo";
            this.total_carbo.Size = new System.Drawing.Size(16, 23);
            this.total_carbo.TabIndex = 3;
            this.total_carbo.Text = "-";
            // 
            // total_protein
            // 
            this.total_protein.AutoSize = true;
            this.total_protein.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.total_protein.Location = new System.Drawing.Point(887, 432);
            this.total_protein.Name = "total_protein";
            this.total_protein.Size = new System.Drawing.Size(16, 23);
            this.total_protein.TabIndex = 3;
            this.total_protein.Text = "-";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.button1.Location = new System.Drawing.Point(504, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.Location = new System.Drawing.Point(471, 147);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(44, 13);
            this.refresh.TabIndex = 8;
            this.refresh.TabStop = true;
            this.refresh.Text = "Refresh";
            this.refresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refresh_LinkClicked);
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.total_protein);
            this.Controls.Add(this.order_menu);
            this.Controls.Add(this.delete_order);
            this.Controls.Add(this.add_order);
            this.Controls.Add(this.qty_style);
            this.Controls.Add(this.list_menu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.total_carbo);
            this.Controls.Add(this.total_order);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.food_picture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.daftar_siap_order);
            this.Controls.Add(this.daftar_menu);
            this.Name = "OrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderPage";
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daftar_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftar_siap_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView daftar_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView daftar_siap_order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox food_picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox list_menu;
        private System.Windows.Forms.TextBox qty_style;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_order;
        private System.Windows.Forms.Button delete_order;
        private System.Windows.Forms.Button order_menu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label total_order;
        private System.Windows.Forms.Label total_carbo;
        private System.Windows.Forms.Label total_protein;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel refresh;
    }
}