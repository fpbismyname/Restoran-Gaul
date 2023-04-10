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
            this.list_menu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nama_menu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jumlah_menu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.list_siap_order = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tambah_order = new System.Windows.Forms.Button();
            this.hapus_order = new System.Windows.Forms.Button();
            this.total_carbo = new System.Windows.Forms.Label();
            this.total_protein = new System.Windows.Forms.Label();
            this.total_menu = new System.Windows.Forms.Label();
            this.order_menu = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.list_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_siap_order)).BeginInit();
            this.SuspendLayout();
            // 
            // list_menu
            // 
            this.list_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_menu.Location = new System.Drawing.Point(12, 103);
            this.list_menu.Name = "list_menu";
            this.list_menu.Size = new System.Drawing.Size(776, 186);
            this.list_menu.TabIndex = 0;
            this.list_menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_menu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Golden Smile", 28F);
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Form Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label2.Location = new System.Drawing.Point(305, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu Name";
            // 
            // nama_menu
            // 
            this.nama_menu.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.nama_menu.Location = new System.Drawing.Point(431, 337);
            this.nama_menu.Name = "nama_menu";
            this.nama_menu.Size = new System.Drawing.Size(160, 28);
            this.nama_menu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label3.Location = new System.Drawing.Point(305, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Qty";
            // 
            // jumlah_menu
            // 
            this.jumlah_menu.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.jumlah_menu.Location = new System.Drawing.Point(431, 374);
            this.jumlah_menu.Name = "jumlah_menu";
            this.jumlah_menu.Size = new System.Drawing.Size(160, 28);
            this.jumlah_menu.TabIndex = 2;
            this.jumlah_menu.TextChanged += new System.EventHandler(this.jumlah_menu_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(156, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 122);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // list_siap_order
            // 
            this.list_siap_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_siap_order.Location = new System.Drawing.Point(12, 478);
            this.list_siap_order.Name = "list_siap_order";
            this.list_siap_order.Size = new System.Drawing.Size(776, 184);
            this.list_siap_order.TabIndex = 0;
            this.list_siap_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_siap_order_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label4.Location = new System.Drawing.Point(12, 683);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Carbo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label5.Location = new System.Drawing.Point(139, 683);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Protein :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label6.Location = new System.Drawing.Point(617, 683);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total :";
            // 
            // tambah_order
            // 
            this.tambah_order.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.tambah_order.Location = new System.Drawing.Point(359, 415);
            this.tambah_order.Name = "tambah_order";
            this.tambah_order.Size = new System.Drawing.Size(75, 32);
            this.tambah_order.TabIndex = 4;
            this.tambah_order.Text = "Add";
            this.tambah_order.UseVisualStyleBackColor = true;
            this.tambah_order.Click += new System.EventHandler(this.tambah_order_Click);
            // 
            // hapus_order
            // 
            this.hapus_order.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.hapus_order.Location = new System.Drawing.Point(475, 415);
            this.hapus_order.Name = "hapus_order";
            this.hapus_order.Size = new System.Drawing.Size(75, 32);
            this.hapus_order.TabIndex = 4;
            this.hapus_order.Text = "Delete";
            this.hapus_order.UseVisualStyleBackColor = true;
            // 
            // total_carbo
            // 
            this.total_carbo.AutoSize = true;
            this.total_carbo.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.total_carbo.Location = new System.Drawing.Point(79, 683);
            this.total_carbo.Name = "total_carbo";
            this.total_carbo.Size = new System.Drawing.Size(16, 23);
            this.total_carbo.TabIndex = 1;
            this.total_carbo.Text = "-";
            // 
            // total_protein
            // 
            this.total_protein.AutoSize = true;
            this.total_protein.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.total_protein.Location = new System.Drawing.Point(220, 683);
            this.total_protein.Name = "total_protein";
            this.total_protein.Size = new System.Drawing.Size(16, 23);
            this.total_protein.TabIndex = 1;
            this.total_protein.Text = "-";
            // 
            // total_menu
            // 
            this.total_menu.AutoSize = true;
            this.total_menu.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.total_menu.Location = new System.Drawing.Point(682, 683);
            this.total_menu.Name = "total_menu";
            this.total_menu.Size = new System.Drawing.Size(16, 23);
            this.total_menu.TabIndex = 1;
            this.total_menu.Text = "-";
            // 
            // order_menu
            // 
            this.order_menu.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.order_menu.Location = new System.Drawing.Point(363, 683);
            this.order_menu.Name = "order_menu";
            this.order_menu.Size = new System.Drawing.Size(75, 32);
            this.order_menu.TabIndex = 4;
            this.order_menu.Text = "Order";
            this.order_menu.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(355, 62);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 23);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kembali";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 729);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.hapus_order);
            this.Controls.Add(this.order_menu);
            this.Controls.Add(this.tambah_order);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.jumlah_menu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nama_menu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total_menu);
            this.Controls.Add(this.total_protein);
            this.Controls.Add(this.total_carbo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_siap_order);
            this.Controls.Add(this.list_menu);
            this.Name = "OrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderPage";
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_siap_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView list_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nama_menu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jumlah_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView list_siap_order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tambah_order;
        private System.Windows.Forms.Button hapus_order;
        private System.Windows.Forms.Label total_carbo;
        private System.Windows.Forms.Label total_protein;
        private System.Windows.Forms.Label total_menu;
        private System.Windows.Forms.Button order_menu;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}