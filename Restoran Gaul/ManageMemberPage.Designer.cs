namespace Restoran_Gaul
{
    partial class ManageMemberPage
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
            this.list_member = new System.Windows.Forms.DataGridView();
            this.search_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.member_id = new System.Windows.Forms.TextBox();
            this.name_member = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email_member = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.no_hp_member = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_member)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Golden Smile", 24F);
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Manage member";
            // 
            // list_member
            // 
            this.list_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_member.Location = new System.Drawing.Point(12, 88);
            this.list_member.Name = "list_member";
            this.list_member.Size = new System.Drawing.Size(776, 236);
            this.list_member.TabIndex = 1;
            this.list_member.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_member_CellContentClick);
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.search_box.Location = new System.Drawing.Point(13, 346);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(143, 28);
            this.search_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label2.Location = new System.Drawing.Point(449, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Member Id";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.button1.Location = new System.Drawing.Point(162, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(9, 54);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 23);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kembali";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // member_id
            // 
            this.member_id.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.member_id.Location = new System.Drawing.Point(552, 346);
            this.member_id.Name = "member_id";
            this.member_id.Size = new System.Drawing.Size(198, 28);
            this.member_id.TabIndex = 2;
            this.member_id.TextChanged += new System.EventHandler(this.member_id_TextChanged);
            // 
            // name_member
            // 
            this.name_member.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.name_member.Location = new System.Drawing.Point(552, 392);
            this.name_member.Name = "name_member";
            this.name_member.Size = new System.Drawing.Size(198, 28);
            this.name_member.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label3.Location = new System.Drawing.Point(449, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // email_member
            // 
            this.email_member.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.email_member.Location = new System.Drawing.Point(552, 438);
            this.email_member.Name = "email_member";
            this.email_member.Size = new System.Drawing.Size(198, 28);
            this.email_member.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label4.Location = new System.Drawing.Point(449, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // no_hp_member
            // 
            this.no_hp_member.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.no_hp_member.Location = new System.Drawing.Point(552, 484);
            this.no_hp_member.Name = "no_hp_member";
            this.no_hp_member.Size = new System.Drawing.Size(198, 28);
            this.no_hp_member.TabIndex = 2;
            this.no_hp_member.TextChanged += new System.EventHandler(this.no_hp_member_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label5.Location = new System.Drawing.Point(449, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Handphone";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.button2.Location = new System.Drawing.Point(235, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.button3.Location = new System.Drawing.Point(340, 548);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.button4.Location = new System.Drawing.Point(445, 548);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ManageMemberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.no_hp_member);
            this.Controls.Add(this.email_member);
            this.Controls.Add(this.name_member);
            this.Controls.Add(this.member_id);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.list_member);
            this.Controls.Add(this.label1);
            this.Name = "ManageMemberPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMemberPage";
            this.Load += new System.EventHandler(this.ManageMemberPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_member)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView list_member;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox member_id;
        private System.Windows.Forms.TextBox name_member;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email_member;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox no_hp_member;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}