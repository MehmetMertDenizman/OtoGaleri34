namespace C12VeriTabaniThis
{
    partial class Form2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonForm3 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderBookName,
            this.columnHeaderAuthor,
            this.columnHeaderPublisher,
            this.columnHeaderPages});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(148, 174);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(436, 225);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderBookName
            // 
            this.columnHeaderBookName.Text = "Book Name";
            this.columnHeaderBookName.Width = 92;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            this.columnHeaderAuthor.Width = 75;
            // 
            // columnHeaderPublisher
            // 
            this.columnHeaderPublisher.Text = "Publisher";
            this.columnHeaderPublisher.Width = 94;
            // 
            // columnHeaderPages
            // 
            this.columnHeaderPages.Text = "Pages";
            this.columnHeaderPages.Width = 131;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(264, 129);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(426, 130);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(129, 132);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(100, 20);
            this.textBoxPages.TabIndex = 24;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(129, 102);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(100, 20);
            this.textBoxPublisher.TabIndex = 23;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(129, 76);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthor.TabIndex = 22;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(129, 47);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookName.TabIndex = 21;
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(60, 135);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(37, 13);
            this.labelPages.TabIndex = 20;
            this.labelPages.Text = "Pages";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(60, 109);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(50, 13);
            this.labelPublisher.TabIndex = 19;
            this.labelPublisher.Text = "Publisher";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(60, 81);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 18;
            this.labelAuthor.Text = "Author";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(60, 50);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(63, 13);
            this.labelBookName.TabIndex = 17;
            this.labelBookName.Text = "Book Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(60, 24);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 25;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(129, 21);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 26;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(345, 125);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonForm3
            // 
            this.buttonForm3.Location = new System.Drawing.Point(699, 50);
            this.buttonForm3.Name = "buttonForm3";
            this.buttonForm3.Size = new System.Drawing.Size(75, 23);
            this.buttonForm3.TabIndex = 28;
            this.buttonForm3.Text = "Secret";
            this.buttonForm3.UseVisualStyleBackColor = true;
            this.buttonForm3.Click += new System.EventHandler(this.buttonForm3_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(507, 130);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonForm3);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxPages);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderBookName;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.ColumnHeader columnHeaderPublisher;
        private System.Windows.Forms.ColumnHeader columnHeaderPages;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonForm3;
        private System.Windows.Forms.Button buttonUpdate;
    }
}