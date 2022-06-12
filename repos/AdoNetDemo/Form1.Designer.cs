namespace AdoNetDemo
{
    partial class Form1
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.LbLName = new System.Windows.Forms.Label();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.LbLPrice = new System.Windows.Forms.Label();
            this.LbLStock = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.gBoxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(87, 29);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 82;
            this.dgwProducts.RowTemplate.Height = 33;
            this.dgwProducts.Size = new System.Drawing.Size(952, 237);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LbLName
            // 
            this.LbLName.AutoSize = true;
            this.LbLName.Location = new System.Drawing.Point(6, 33);
            this.LbLName.Name = "LbLName";
            this.LbLName.Size = new System.Drawing.Size(68, 25);
            this.LbLName.TabIndex = 1;
            this.LbLName.Text = "Name";
            this.LbLName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(82, 124);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(100, 31);
            this.tbxStock.TabIndex = 2;
            this.tbxStock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LbLPrice
            // 
            this.LbLPrice.AutoSize = true;
            this.LbLPrice.Location = new System.Drawing.Point(6, 78);
            this.LbLPrice.Name = "LbLPrice";
            this.LbLPrice.Size = new System.Drawing.Size(61, 25);
            this.LbLPrice.TabIndex = 3;
            this.LbLPrice.Text = "Price";
            this.LbLPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // LbLStock
            // 
            this.LbLStock.AutoSize = true;
            this.LbLStock.Location = new System.Drawing.Point(6, 124);
            this.LbLStock.Name = "LbLStock";
            this.LbLStock.Size = new System.Drawing.Size(66, 25);
            this.LbLStock.TabIndex = 4;
            this.LbLStock.Text = "Stock";
            this.LbLStock.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(82, 75);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 31);
            this.tbxPrice.TabIndex = 5;
            this.tbxPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(82, 33);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 31);
            this.tbxName.TabIndex = 6;
            this.tbxName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // gBoxAdd
            // 
            this.gBoxAdd.Controls.Add(this.btnAdd);
            this.gBoxAdd.Controls.Add(this.LbLName);
            this.gBoxAdd.Controls.Add(this.LbLStock);
            this.gBoxAdd.Controls.Add(this.tbxPrice);
            this.gBoxAdd.Controls.Add(this.tbxStock);
            this.gBoxAdd.Controls.Add(this.tbxName);
            this.gBoxAdd.Controls.Add(this.LbLPrice);
            this.gBoxAdd.Location = new System.Drawing.Point(87, 283);
            this.gBoxAdd.Name = "gBoxAdd";
            this.gBoxAdd.Size = new System.Drawing.Size(485, 194);
            this.gBoxAdd.TabIndex = 7;
            this.gBoxAdd.TabStop = false;
            this.gBoxAdd.Text = "Add a Product";
            this.gBoxAdd.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(229, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 61);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 564);
            this.Controls.Add(this.gBoxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gBoxAdd.ResumeLayout(false);
            this.gBoxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label LbLName;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.Label LbLPrice;
        private System.Windows.Forms.Label LbLStock;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.GroupBox gBoxAdd;
        private System.Windows.Forms.Button btnAdd;
    }
}

