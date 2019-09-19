namespace InventoryManagementSystem
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.storeLowQty = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.unapprovedPurchaseOrders = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.unapprovedDispatchOrders = new System.Windows.Forms.Label();
            this.undispatchedOrders = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uncommitedRecieving = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Low Quantity Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.storeLowQty);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(100, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 200);
            this.panel1.TabIndex = 10;
            // 
            // storeLowQty
            // 
            this.storeLowQty.AutoSize = true;
            this.storeLowQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLowQty.Location = new System.Drawing.Point(154, 59);
            this.storeLowQty.Name = "storeLowQty";
            this.storeLowQty.Size = new System.Drawing.Size(69, 73);
            this.storeLowQty.TabIndex = 13;
            this.storeLowQty.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(160, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Stores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.unapprovedPurchaseOrders);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(548, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 200);
            this.panel2.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(94, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Unapproved Purchase Orders";
            // 
            // unapprovedPurchaseOrders
            // 
            this.unapprovedPurchaseOrders.AutoSize = true;
            this.unapprovedPurchaseOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unapprovedPurchaseOrders.Location = new System.Drawing.Point(158, 59);
            this.unapprovedPurchaseOrders.Name = "unapprovedPurchaseOrders";
            this.unapprovedPurchaseOrders.Size = new System.Drawing.Size(69, 73);
            this.unapprovedPurchaseOrders.TabIndex = 15;
            this.unapprovedPurchaseOrders.Text = "0";
            this.unapprovedPurchaseOrders.Click += new System.EventHandler(this.label14_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(149, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Purchasing";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.unapprovedDispatchOrders);
            this.panel3.Controls.Add(this.undispatchedOrders);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Location = new System.Drawing.Point(100, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 200);
            this.panel3.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(275, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(210, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Unapproved Dispatch Orders";
            // 
            // unapprovedDispatchOrders
            // 
            this.unapprovedDispatchOrders.AutoSize = true;
            this.unapprovedDispatchOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unapprovedDispatchOrders.Location = new System.Drawing.Point(333, 62);
            this.unapprovedDispatchOrders.Name = "unapprovedDispatchOrders";
            this.unapprovedDispatchOrders.Size = new System.Drawing.Size(69, 73);
            this.unapprovedDispatchOrders.TabIndex = 15;
            this.unapprovedDispatchOrders.Text = "0";
            // 
            // undispatchedOrders
            // 
            this.undispatchedOrders.AutoSize = true;
            this.undispatchedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undispatchedOrders.Location = new System.Drawing.Point(83, 62);
            this.undispatchedOrders.Name = "undispatchedOrders";
            this.undispatchedOrders.Size = new System.Drawing.Size(69, 73);
            this.undispatchedOrders.TabIndex = 13;
            this.undispatchedOrders.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(213, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 20);
            this.label19.TabIndex = 12;
            this.label19.Text = "Dispatch";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(49, 161);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 16);
            this.label20.TabIndex = 3;
            this.label20.Text = "Undispatched Orders";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCoral;
            this.panel4.Controls.Add(this.uncommitedRecieving);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(663, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 200);
            this.panel4.TabIndex = 14;
            // 
            // uncommitedRecieving
            // 
            this.uncommitedRecieving.AutoSize = true;
            this.uncommitedRecieving.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uncommitedRecieving.Location = new System.Drawing.Point(106, 59);
            this.uncommitedRecieving.Name = "uncommitedRecieving";
            this.uncommitedRecieving.Size = new System.Drawing.Size(69, 73);
            this.uncommitedRecieving.TabIndex = 13;
            this.uncommitedRecieving.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Recieving";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Uncommited Orders";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1165, 742);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label storeLowQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label unapprovedPurchaseOrders;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label unapprovedDispatchOrders;
        private System.Windows.Forms.Label undispatchedOrders;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label uncommitedRecieving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
