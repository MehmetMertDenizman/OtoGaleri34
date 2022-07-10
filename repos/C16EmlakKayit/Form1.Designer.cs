namespace C16EmlakKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonForgot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(185, 169);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(171, 106);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.PlaceholderText = "ID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(171, 140);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PlaceholderText = "PW";
            this.textBoxPW.Size = new System.Drawing.Size(100, 23);
            this.textBoxPW.TabIndex = 3;
            this.textBoxPW.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "PW:";
            // 
            // buttonForgot
            // 
            this.buttonForgot.Location = new System.Drawing.Point(286, 169);
            this.buttonForgot.Name = "buttonForgot";
            this.buttonForgot.Size = new System.Drawing.Size(75, 23);
            this.buttonForgot.TabIndex = 5;
            this.buttonForgot.Text = "Forgot PW";
            this.buttonForgot.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonForgot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonLogin;
        private TextBox textBoxID;
        private TextBox textBoxPW;
        private Label label2;
        private Button buttonForgot;
    }
}