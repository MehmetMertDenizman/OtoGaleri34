namespace C12VeriTabaniReal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSur = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCity = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSchool = new System.Windows.Forms.ColumnHeader();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSur,
            this.columnHeaderCity,
            this.columnHeaderSchool});
            this.listView1.Location = new System.Drawing.Point(32, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(358, 254);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            // 
            // columnHeaderSur
            // 
            this.columnHeaderSur.Text = "Surname";
            // 
            // columnHeaderCity
            // 
            this.columnHeaderCity.Text = "City";
            // 
            // columnHeaderSchool
            // 
            this.columnHeaderSchool.Text = "School";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(471, 371);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderSur;
        private ColumnHeader columnHeaderCity;
        private ColumnHeader columnHeaderSchool;
        private Button buttonShow;
    }
}