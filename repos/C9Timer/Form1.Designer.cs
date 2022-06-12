namespace C9Timer
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
            this.components = new System.ComponentModel.Container();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.timer12 = new System.Windows.Forms.Timer(this.components);
            this.buttonGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTimer
            // 
            this.buttonTimer.Location = new System.Drawing.Point(305, 207);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(143, 90);
            this.buttonTimer.TabIndex = 0;
            this.buttonTimer.Text = "Timer";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(416, 138);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(13, 13);
            this.labelTimer.TabIndex = 1;
            this.labelTimer.Text = "a";
            this.labelTimer.Click += new System.EventHandler(this.labelTimer_Click);
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(302, 138);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(13, 13);
            this.labelHour.TabIndex = 2;
            this.labelHour.Text = "a";
            this.labelHour.Click += new System.EventHandler(this.labelHour_Click);
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(362, 138);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(13, 13);
            this.labelMinute.TabIndex = 3;
            this.labelMinute.Text = "a";
            // 
            // timer12
            // 
            this.timer12.Interval = 1;
            this.timer12.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(23, 207);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(143, 90);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Timer timer12;
        private System.Windows.Forms.Button buttonGo;
    }
}

