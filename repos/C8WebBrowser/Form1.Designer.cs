namespace C8WebBrowser
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtbxPW = new System.Windows.Forms.TextBox();
            this.lvlPW = new System.Windows.Forms.Label();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.LbLID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(126, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PARGA CORP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(140, 149);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(54, 28);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtbxPW
            // 
            this.txtbxPW.Location = new System.Drawing.Point(118, 124);
            this.txtbxPW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxPW.Name = "txtbxPW";
            this.txtbxPW.Size = new System.Drawing.Size(98, 20);
            this.txtbxPW.TabIndex = 9;
            this.txtbxPW.UseSystemPasswordChar = true;
            this.txtbxPW.TextChanged += new System.EventHandler(this.txtbxPW_TextChanged);
            // 
            // lvlPW
            // 
            this.lvlPW.AutoSize = true;
            this.lvlPW.Location = new System.Drawing.Point(80, 124);
            this.lvlPW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvlPW.Name = "lvlPW";
            this.lvlPW.Size = new System.Drawing.Size(28, 13);
            this.lvlPW.TabIndex = 8;
            this.lvlPW.Text = "PW:";
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(118, 97);
            this.txtbxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(98, 20);
            this.txtbxID.TabIndex = 7;
            this.txtbxID.TextChanged += new System.EventHandler(this.txtbxID_TextChanged);
            // 
            // LbLID
            // 
            this.LbLID.AutoSize = true;
            this.LbLID.Location = new System.Drawing.Point(80, 97);
            this.LbLID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbLID.Name = "LbLID";
            this.LbLID.Size = new System.Drawing.Size(21, 13);
            this.LbLID.TabIndex = 6;
            this.LbLID.Text = "ID:";
            this.LbLID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LbLID.Click += new System.EventHandler(this.LbLID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(678, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtbxPW);
            this.Controls.Add(this.lvlPW);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.LbLID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtbxPW;
        private System.Windows.Forms.Label lvlPW;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.Label LbLID;
    }
}

