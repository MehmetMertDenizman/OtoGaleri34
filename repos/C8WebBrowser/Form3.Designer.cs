namespace C8WebBrowser
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.buttonRez = new System.Windows.Forms.Button();
            this.buttonRadio = new System.Windows.Forms.Button();
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRez
            // 
            this.buttonRez.Location = new System.Drawing.Point(62, 53);
            this.buttonRez.Name = "buttonRez";
            this.buttonRez.Size = new System.Drawing.Size(154, 92);
            this.buttonRez.TabIndex = 0;
            this.buttonRez.Text = "RESERVATION";
            this.buttonRez.UseVisualStyleBackColor = true;
            this.buttonRez.Click += new System.EventHandler(this.buttonRez_Click);
            // 
            // buttonRadio
            // 
            this.buttonRadio.Location = new System.Drawing.Point(292, 53);
            this.buttonRadio.Name = "buttonRadio";
            this.buttonRadio.Size = new System.Drawing.Size(158, 92);
            this.buttonRadio.TabIndex = 1;
            this.buttonRadio.Text = "RADIO";
            this.buttonRadio.UseVisualStyleBackColor = true;
            this.buttonRadio.Click += new System.EventHandler(this.buttonRadio_Click);
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.Controls.Add(this.button2);
            this.groupBoxRadio.Controls.Add(this.button1);
            this.groupBoxRadio.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBoxRadio.Location = new System.Drawing.Point(24, 190);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(764, 243);
            this.groupBoxRadio.TabIndex = 2;
            this.groupBoxRadio.TabStop = false;
            this.groupBoxRadio.Text = "groupBox1";
            this.groupBoxRadio.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 19);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(528, 218);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "RADIO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 92);
            this.button2.TabIndex = 3;
            this.button2.Text = "RADIO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxRadio);
            this.Controls.Add(this.buttonRadio);
            this.Controls.Add(this.buttonRez);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBoxRadio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRez;
        private System.Windows.Forms.Button buttonRadio;
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}