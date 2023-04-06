namespace Restoran_Gaul
{
    partial class AdminCenter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderPage = new System.Windows.Forms.Button();
            this.menuPage = new System.Windows.Forms.Button();
            this.memberPage = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Golden Smile", 32F);
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Navigation Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to admin navigation center. Manage your business now !";
            // 
            // orderPage
            // 
            this.orderPage.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.orderPage.Location = new System.Drawing.Point(308, 175);
            this.orderPage.Name = "orderPage";
            this.orderPage.Size = new System.Drawing.Size(158, 33);
            this.orderPage.TabIndex = 1;
            this.orderPage.Text = "Order";
            this.orderPage.UseVisualStyleBackColor = true;
            this.orderPage.Click += new System.EventHandler(this.orderPage_Click);
            // 
            // menuPage
            // 
            this.menuPage.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.menuPage.Location = new System.Drawing.Point(308, 223);
            this.menuPage.Name = "menuPage";
            this.menuPage.Size = new System.Drawing.Size(158, 33);
            this.menuPage.TabIndex = 2;
            this.menuPage.Text = "Manage Menu";
            this.menuPage.UseVisualStyleBackColor = true;
            this.menuPage.Click += new System.EventHandler(this.menuPage_Click);
            // 
            // memberPage
            // 
            this.memberPage.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.memberPage.Location = new System.Drawing.Point(308, 271);
            this.memberPage.Name = "memberPage";
            this.memberPage.Size = new System.Drawing.Size(158, 33);
            this.memberPage.TabIndex = 3;
            this.memberPage.Text = "Manage Member";
            this.memberPage.UseVisualStyleBackColor = true;
            this.memberPage.Click += new System.EventHandler(this.memberPage_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.Logout.Location = new System.Drawing.Point(12, 405);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(96, 33);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AdminCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.memberPage);
            this.Controls.Add(this.menuPage);
            this.Controls.Add(this.orderPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button orderPage;
        private System.Windows.Forms.Button menuPage;
        private System.Windows.Forms.Button memberPage;
        private System.Windows.Forms.Button Logout;
    }
}