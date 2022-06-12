namespace C11ZarVeBilgiYarış
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
            this.groupBoxYou = new System.Windows.Forms.GroupBox();
            this.labelDiceSum = new System.Windows.Forms.Label();
            this.labelDice2 = new System.Windows.Forms.Label();
            this.labelDice1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxAI = new System.Windows.Forms.GroupBox();
            this.labelDiceSumAI = new System.Windows.Forms.Label();
            this.labelDice4 = new System.Windows.Forms.Label();
            this.labelDice3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxYou.SuspendLayout();
            this.groupBoxAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxYou
            // 
            this.groupBoxYou.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBoxYou.Controls.Add(this.labelDiceSum);
            this.groupBoxYou.Controls.Add(this.labelDice2);
            this.groupBoxYou.Controls.Add(this.labelDice1);
            this.groupBoxYou.Controls.Add(this.label2);
            this.groupBoxYou.Controls.Add(this.label1);
            this.groupBoxYou.Controls.Add(this.buttonStart);
            this.groupBoxYou.Location = new System.Drawing.Point(22, 29);
            this.groupBoxYou.Name = "groupBoxYou";
            this.groupBoxYou.Size = new System.Drawing.Size(435, 274);
            this.groupBoxYou.TabIndex = 0;
            this.groupBoxYou.TabStop = false;
            this.groupBoxYou.Text = "You";
            this.groupBoxYou.Enter += new System.EventHandler(this.groupBoxYou_Enter);
            // 
            // labelDiceSum
            // 
            this.labelDiceSum.AutoSize = true;
            this.labelDiceSum.Location = new System.Drawing.Point(158, 132);
            this.labelDiceSum.Name = "labelDiceSum";
            this.labelDiceSum.Size = new System.Drawing.Size(13, 15);
            this.labelDiceSum.TabIndex = 5;
            this.labelDiceSum.Text = "0";
            // 
            // labelDice2
            // 
            this.labelDice2.AutoSize = true;
            this.labelDice2.Location = new System.Drawing.Point(88, 81);
            this.labelDice2.Name = "labelDice2";
            this.labelDice2.Size = new System.Drawing.Size(13, 15);
            this.labelDice2.TabIndex = 4;
            this.labelDice2.Text = "0";
            // 
            // labelDice1
            // 
            this.labelDice1.AutoSize = true;
            this.labelDice1.Location = new System.Drawing.Point(88, 40);
            this.labelDice1.Name = "labelDice1";
            this.labelDice1.Size = new System.Drawing.Size(13, 15);
            this.labelDice1.TabIndex = 3;
            this.labelDice1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "2.Dice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.Dice:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(168, 178);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxAI
            // 
            this.groupBoxAI.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBoxAI.Controls.Add(this.labelDiceSumAI);
            this.groupBoxAI.Controls.Add(this.labelDice4);
            this.groupBoxAI.Controls.Add(this.labelDice3);
            this.groupBoxAI.Controls.Add(this.label7);
            this.groupBoxAI.Controls.Add(this.label8);
            this.groupBoxAI.Controls.Add(this.button1);
            this.groupBoxAI.Location = new System.Drawing.Point(698, 29);
            this.groupBoxAI.Name = "groupBoxAI";
            this.groupBoxAI.Size = new System.Drawing.Size(435, 274);
            this.groupBoxAI.TabIndex = 1;
            this.groupBoxAI.TabStop = false;
            this.groupBoxAI.Text = "AI";
            // 
            // labelDiceSumAI
            // 
            this.labelDiceSumAI.AutoSize = true;
            this.labelDiceSumAI.Location = new System.Drawing.Point(211, 130);
            this.labelDiceSumAI.Name = "labelDiceSumAI";
            this.labelDiceSumAI.Size = new System.Drawing.Size(13, 15);
            this.labelDiceSumAI.TabIndex = 6;
            this.labelDiceSumAI.Text = "0";
            // 
            // labelDice4
            // 
            this.labelDice4.AutoSize = true;
            this.labelDice4.Location = new System.Drawing.Point(88, 81);
            this.labelDice4.Name = "labelDice4";
            this.labelDice4.Size = new System.Drawing.Size(13, 15);
            this.labelDice4.TabIndex = 4;
            this.labelDice4.Text = "0";
            // 
            // labelDice3
            // 
            this.labelDice3.AutoSize = true;
            this.labelDice3.Location = new System.Drawing.Point(88, 40);
            this.labelDice3.Name = "labelDice3";
            this.labelDice3.Size = new System.Drawing.Size(13, 15);
            this.labelDice3.TabIndex = 3;
            this.labelDice3.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "2.Dice:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "1.Dice:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1641, 628);
            this.Controls.Add(this.groupBoxAI);
            this.Controls.Add(this.groupBoxYou);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxYou.ResumeLayout(false);
            this.groupBoxYou.PerformLayout();
            this.groupBoxAI.ResumeLayout(false);
            this.groupBoxAI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxYou;
        private Label labelDiceSum;
        private Label labelDice2;
        private Label labelDice1;
        private Label label2;
        private Label label1;
        private Button buttonStart;
        private GroupBox groupBoxAI;
        private Label labelDiceSumAI;
        private Label labelDice4;
        private Label labelDice3;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}