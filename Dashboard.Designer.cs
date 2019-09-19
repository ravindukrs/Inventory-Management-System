namespace InventoryManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            this.storeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dispatchBtn = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.suppliersBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.purchasingBtn = new System.Windows.Forms.Button();
            this.recievingBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.stores1 = new InventoryManagementSystem.Stores();
            this.users1 = new InventoryManagementSystem.Users();
            this.purchasing1 = new InventoryManagementSystem.Purchasing();
            this.recieving1 = new InventoryManagementSystem.Recieving();
            this.dispatch1 = new InventoryManagementSystem.Dispatch();
            this.home1 = new InventoryManagementSystem.Home();
            this.client1 = new InventoryManagementSystem.Client();
            this.supplier1 = new InventoryManagementSystem.Supplier();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 32);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(645, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Director of Health Services Office Hambantota - Inventory Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(8, 120);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(10);
            this.homeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeBtn.Size = new System.Drawing.Size(184, 52);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "     Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn);
            // 
            // storeBtn
            // 
            this.storeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.storeBtn.FlatAppearance.BorderSize = 0;
            this.storeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeBtn.ForeColor = System.Drawing.Color.White;
            this.storeBtn.Image = ((System.Drawing.Image)(resources.GetObject("storeBtn.Image")));
            this.storeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storeBtn.Location = new System.Drawing.Point(8, 178);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Padding = new System.Windows.Forms.Padding(10);
            this.storeBtn.Size = new System.Drawing.Size(184, 52);
            this.storeBtn.TabIndex = 1;
            this.storeBtn.Text = "     Store";
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.dispatchBtn);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.clientsBtn);
            this.panel1.Controls.Add(this.suppliersBtn);
            this.panel1.Controls.Add(this.userBtn);
            this.panel1.Controls.Add(this.purchasingBtn);
            this.panel1.Controls.Add(this.recievingBtn);
            this.panel1.Controls.Add(this.storeBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 749);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dispatchBtn
            // 
            this.dispatchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dispatchBtn.FlatAppearance.BorderSize = 0;
            this.dispatchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dispatchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispatchBtn.ForeColor = System.Drawing.Color.White;
            this.dispatchBtn.Image = ((System.Drawing.Image)(resources.GetObject("dispatchBtn.Image")));
            this.dispatchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dispatchBtn.Location = new System.Drawing.Point(12, 352);
            this.dispatchBtn.Name = "dispatchBtn";
            this.dispatchBtn.Padding = new System.Windows.Forms.Padding(10);
            this.dispatchBtn.Size = new System.Drawing.Size(184, 52);
            this.dispatchBtn.TabIndex = 10;
            this.dispatchBtn.Text = "         Dispatch";
            this.dispatchBtn.UseVisualStyleBackColor = true;
            this.dispatchBtn.Click += new System.EventHandler(this.dispatchBtn_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(8, 120);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 52);
            this.SidePanel.TabIndex = 2;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Location = new System.Drawing.Point(18, 674);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(172, 36);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.MediumOrchid;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(18, 621);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(172, 36);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // clientsBtn
            // 
            this.clientsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientsBtn.FlatAppearance.BorderSize = 0;
            this.clientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsBtn.ForeColor = System.Drawing.Color.White;
            this.clientsBtn.Image = ((System.Drawing.Image)(resources.GetObject("clientsBtn.Image")));
            this.clientsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsBtn.Location = new System.Drawing.Point(11, 468);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Padding = new System.Windows.Forms.Padding(10);
            this.clientsBtn.Size = new System.Drawing.Size(184, 52);
            this.clientsBtn.TabIndex = 7;
            this.clientsBtn.Text = "       Clients";
            this.clientsBtn.UseVisualStyleBackColor = true;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // suppliersBtn
            // 
            this.suppliersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.suppliersBtn.FlatAppearance.BorderSize = 0;
            this.suppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersBtn.ForeColor = System.Drawing.Color.White;
            this.suppliersBtn.Image = ((System.Drawing.Image)(resources.GetObject("suppliersBtn.Image")));
            this.suppliersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suppliersBtn.Location = new System.Drawing.Point(12, 410);
            this.suppliersBtn.Name = "suppliersBtn";
            this.suppliersBtn.Padding = new System.Windows.Forms.Padding(10);
            this.suppliersBtn.Size = new System.Drawing.Size(184, 52);
            this.suppliersBtn.TabIndex = 6;
            this.suppliersBtn.Text = "           Suppliers";
            this.suppliersBtn.UseVisualStyleBackColor = true;
            this.suppliersBtn.Click += new System.EventHandler(this.suppliersBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBtn.Image")));
            this.userBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.Location = new System.Drawing.Point(14, 526);
            this.userBtn.Name = "userBtn";
            this.userBtn.Padding = new System.Windows.Forms.Padding(10);
            this.userBtn.Size = new System.Drawing.Size(184, 52);
            this.userBtn.TabIndex = 5;
            this.userBtn.Text = "     Users";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // purchasingBtn
            // 
            this.purchasingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchasingBtn.FlatAppearance.BorderSize = 0;
            this.purchasingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasingBtn.ForeColor = System.Drawing.Color.White;
            this.purchasingBtn.Image = ((System.Drawing.Image)(resources.GetObject("purchasingBtn.Image")));
            this.purchasingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchasingBtn.Location = new System.Drawing.Point(12, 294);
            this.purchasingBtn.Name = "purchasingBtn";
            this.purchasingBtn.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.purchasingBtn.Size = new System.Drawing.Size(194, 52);
            this.purchasingBtn.TabIndex = 4;
            this.purchasingBtn.Text = "          Purchasing";
            this.purchasingBtn.UseVisualStyleBackColor = true;
            this.purchasingBtn.Click += new System.EventHandler(this.purchasingBtn_Click);
            // 
            // recievingBtn
            // 
            this.recievingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recievingBtn.FlatAppearance.BorderSize = 0;
            this.recievingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recievingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recievingBtn.ForeColor = System.Drawing.Color.White;
            this.recievingBtn.Image = ((System.Drawing.Image)(resources.GetObject("recievingBtn.Image")));
            this.recievingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recievingBtn.Location = new System.Drawing.Point(11, 236);
            this.recievingBtn.Name = "recievingBtn";
            this.recievingBtn.Padding = new System.Windows.Forms.Padding(10);
            this.recievingBtn.Size = new System.Drawing.Size(184, 52);
            this.recievingBtn.TabIndex = 3;
            this.recievingBtn.Text = "           Recieving";
            this.recievingBtn.UseVisualStyleBackColor = true;
            this.recievingBtn.Click += new System.EventHandler(this.recievingBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(210, 749);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1156, 0);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(193, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 0);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(201, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 0);
            this.panel6.TabIndex = 4;
            // 
            // stores1
            // 
            this.stores1.BackColor = System.Drawing.Color.White;
            this.stores1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stores1.Location = new System.Drawing.Point(210, 33);
            this.stores1.Name = "stores1";
            this.stores1.Size = new System.Drawing.Size(1165, 742);
            this.stores1.TabIndex = 5;
            // 
            // users1
            // 
            this.users1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users1.Location = new System.Drawing.Point(210, 33);
            this.users1.Name = "users1";
            this.users1.Size = new System.Drawing.Size(1165, 742);
            this.users1.TabIndex = 6;
            // 
            // purchasing1
            // 
            this.purchasing1.BackColor = System.Drawing.Color.White;
            this.purchasing1.Location = new System.Drawing.Point(210, 33);
            this.purchasing1.Name = "purchasing1";
            this.purchasing1.Size = new System.Drawing.Size(1165, 742);
            this.purchasing1.TabIndex = 7;
            // 
            // recieving1
            // 
            this.recieving1.BackColor = System.Drawing.Color.White;
            this.recieving1.Location = new System.Drawing.Point(210, 33);
            this.recieving1.Name = "recieving1";
            this.recieving1.Size = new System.Drawing.Size(1165, 742);
            this.recieving1.TabIndex = 8;
            // 
            // dispatch1
            // 
            this.dispatch1.BackColor = System.Drawing.Color.White;
            this.dispatch1.Location = new System.Drawing.Point(210, 33);
            this.dispatch1.Name = "dispatch1";
            this.dispatch1.Size = new System.Drawing.Size(1165, 742);
            this.dispatch1.TabIndex = 9;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.Location = new System.Drawing.Point(210, 33);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1165, 742);
            this.home1.TabIndex = 10;
            // 
            // client1
            // 
            this.client1.BackColor = System.Drawing.Color.White;
            this.client1.Location = new System.Drawing.Point(210, 33);
            this.client1.Name = "client1";
            this.client1.Size = new System.Drawing.Size(1165, 742);
            this.client1.TabIndex = 11;
            // 
            // supplier1
            // 
            this.supplier1.BackColor = System.Drawing.Color.White;
            this.supplier1.Location = new System.Drawing.Point(211, 33);
            this.supplier1.Name = "supplier1";
            this.supplier1.Size = new System.Drawing.Size(1165, 742);
            this.supplier1.TabIndex = 12;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.supplier1);
            this.Controls.Add(this.client1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.dispatch1);
            this.Controls.Add(this.recieving1);
            this.Controls.Add(this.purchasing1);
            this.Controls.Add(this.users1);
            this.Controls.Add(this.stores1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button purchasingBtn;
        private System.Windows.Forms.Button recievingBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button suppliersBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Stores stores1;
        private Users users1;
        private Purchasing purchasing1;
        private Recieving recieving1;
        private System.Windows.Forms.Button dispatchBtn;
        private Dispatch dispatch1;
        private Home home1;
        private Client client1;
        private Supplier supplier1;
    }
}

