namespace InventoryManagementSystem
{
    partial class Stores
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
            this.findProductId = new System.Windows.Forms.TextBox();
            this.findProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.manualSubstractBtn = new System.Windows.Forms.Button();
            this.manualProductId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.manualQty = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.manualAddBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reqQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.postRequest = new System.Windows.Forms.Button();
            this.reqProdId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // findProductId
            // 
            this.findProductId.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findProductId.Location = new System.Drawing.Point(168, 130);
            this.findProductId.Name = "findProductId";
            this.findProductId.Size = new System.Drawing.Size(155, 21);
            this.findProductId.TabIndex = 10;
            this.findProductId.TextChanged += new System.EventHandler(this.findProductId_TextChanged);
            // 
            // findProductName
            // 
            this.findProductName.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findProductName.Location = new System.Drawing.Point(168, 80);
            this.findProductName.Name = "findProductName";
            this.findProductName.Size = new System.Drawing.Size(155, 21);
            this.findProductName.TabIndex = 9;
            this.findProductName.TextChanged += new System.EventHandler(this.findProductName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Find Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "OR";
            // 
            // manualSubstractBtn
            // 
            this.manualSubstractBtn.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualSubstractBtn.Location = new System.Drawing.Point(248, 390);
            this.manualSubstractBtn.Name = "manualSubstractBtn";
            this.manualSubstractBtn.Size = new System.Drawing.Size(75, 23);
            this.manualSubstractBtn.TabIndex = 25;
            this.manualSubstractBtn.Text = "Remove";
            this.manualSubstractBtn.UseVisualStyleBackColor = true;
            this.manualSubstractBtn.Click += new System.EventHandler(this.manualSubstractBtn_Click);
            // 
            // manualProductId
            // 
            this.manualProductId.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualProductId.Location = new System.Drawing.Point(168, 304);
            this.manualProductId.Name = "manualProductId";
            this.manualProductId.Size = new System.Drawing.Size(155, 21);
            this.manualProductId.TabIndex = 24;
            this.manualProductId.TextChanged += new System.EventHandler(this.manualProductId_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(63, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Product Id:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(36, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 19);
            this.label15.TabIndex = 20;
            this.label15.Text = "Manual Quantity Edit";
            // 
            // manualQty
            // 
            this.manualQty.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualQty.Location = new System.Drawing.Point(168, 353);
            this.manualQty.Name = "manualQty";
            this.manualQty.Size = new System.Drawing.Size(155, 21);
            this.manualQty.TabIndex = 28;
            this.manualQty.TextChanged += new System.EventHandler(this.manualQty_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(63, 357);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "Quantity:";
            // 
            // manualAddBtn
            // 
            this.manualAddBtn.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualAddBtn.Location = new System.Drawing.Point(168, 390);
            this.manualAddBtn.Name = "manualAddBtn";
            this.manualAddBtn.Size = new System.Drawing.Size(75, 23);
            this.manualAddBtn.TabIndex = 30;
            this.manualAddBtn.Text = "Add";
            this.manualAddBtn.UseVisualStyleBackColor = true;
            this.manualAddBtn.Click += new System.EventHandler(this.manualAddBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 678);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reqQty
            // 
            this.reqQty.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqQty.Location = new System.Drawing.Point(168, 555);
            this.reqQty.Name = "reqQty";
            this.reqQty.Size = new System.Drawing.Size(155, 21);
            this.reqQty.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Quantity:";
            // 
            // postRequest
            // 
            this.postRequest.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postRequest.Location = new System.Drawing.Point(207, 592);
            this.postRequest.Name = "postRequest";
            this.postRequest.Size = new System.Drawing.Size(116, 23);
            this.postRequest.TabIndex = 37;
            this.postRequest.Text = "Post Request";
            this.postRequest.UseVisualStyleBackColor = true;
            this.postRequest.Click += new System.EventHandler(this.postRequest_Click);
            // 
            // reqProdId
            // 
            this.reqProdId.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqProdId.Location = new System.Drawing.Point(168, 506);
            this.reqProdId.Name = "reqProdId";
            this.reqProdId.Size = new System.Drawing.Size(155, 21);
            this.reqProdId.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Product Id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Create Purchase Request";
            // 
            // Stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.reqQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postRequest);
            this.Controls.Add(this.reqProdId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.manualAddBtn);
            this.Controls.Add(this.manualQty);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.manualSubstractBtn);
            this.Controls.Add(this.manualProductId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.findProductId);
            this.Controls.Add(this.findProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Stores";
            this.Size = new System.Drawing.Size(1165, 742);
            this.Load += new System.EventHandler(this.Stores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox findProductId;
        private System.Windows.Forms.TextBox findProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button manualSubstractBtn;
        private System.Windows.Forms.TextBox manualProductId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox manualQty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button manualAddBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox reqQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button postRequest;
        private System.Windows.Forms.TextBox reqProdId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}
