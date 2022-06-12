namespace C9Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelHour = new System.Windows.Forms.Label();
            this.buttonAlarmKur = new System.Windows.Forms.Button();
            this.labelMinute = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAlarmText = new System.Windows.Forms.Label();
            this.comboBoxHour = new System.Windows.Forms.ComboBox();
            this.comboBoxMinute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(249, 157);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(19, 13);
            this.labelHour.TabIndex = 1;
            this.labelHour.Text = "00";
            this.labelHour.Click += new System.EventHandler(this.labelZero_Click);
            // 
            // buttonAlarmKur
            // 
            this.buttonAlarmKur.Location = new System.Drawing.Point(241, 173);
            this.buttonAlarmKur.Name = "buttonAlarmKur";
            this.buttonAlarmKur.Size = new System.Drawing.Size(75, 23);
            this.buttonAlarmKur.TabIndex = 2;
            this.buttonAlarmKur.Text = "Alarm";
            this.buttonAlarmKur.UseVisualStyleBackColor = true;
            this.buttonAlarmKur.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(290, 157);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(19, 13);
            this.labelMinute.TabIndex = 3;
            this.labelMinute.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // labelAlarmText
            // 
            this.labelAlarmText.AutoSize = true;
            this.labelAlarmText.Location = new System.Drawing.Point(33, 65);
            this.labelAlarmText.Name = "labelAlarmText";
            this.labelAlarmText.Size = new System.Drawing.Size(60, 13);
            this.labelAlarmText.TabIndex = 6;
            this.labelAlarmText.Text = "Alarm Saati";
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.FormattingEnabled = true;
            this.comboBoxHour.Location = new System.Drawing.Point(119, 62);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHour.TabIndex = 7;
            this.comboBoxHour.SelectedIndexChanged += new System.EventHandler(this.comboBoxHour_SelectedIndexChanged);
            // 
            // comboBoxMinute
            // 
            this.comboBoxMinute.FormattingEnabled = true;
            this.comboBoxMinute.Location = new System.Drawing.Point(119, 89);
            this.comboBoxMinute.Name = "comboBoxMinute";
            this.comboBoxMinute.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMinute.TabIndex = 8;
            this.comboBoxMinute.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinute_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Alarm Dakika";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(345, 50);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(323, 340);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMinute);
            this.Controls.Add(this.comboBoxHour);
            this.Controls.Add(this.labelAlarmText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.buttonAlarmKur);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Button buttonAlarmKur;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAlarmText;
        private System.Windows.Forms.ComboBox comboBoxHour;
        private System.Windows.Forms.ComboBox comboBoxMinute;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}