namespace JCGkaiseki_GUI
{
    partial class Form5
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Arch_textBox = new System.Windows.Forms.TextBox();
            this.Maisuu1_textBox = new System.Windows.Forms.TextBox();
            this.Hash1_textBox = new System.Windows.Forms.TextBox();
            this.CardName1_textBox = new System.Windows.Forms.TextBox();
            this.CLASS_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CardName2_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Hash2_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Maisuu2_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "クラス名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "アーキタイプ名";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "枚数1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "HASH値 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "カード名 1";
            // 
            // Arch_textBox
            // 
            this.Arch_textBox.Location = new System.Drawing.Point(109, 260);
            this.Arch_textBox.Name = "Arch_textBox";
            this.Arch_textBox.Size = new System.Drawing.Size(100, 19);
            this.Arch_textBox.TabIndex = 2;
            this.Arch_textBox.TextChanged += new System.EventHandler(this.Arch_textBox_TextChanged);
            // 
            // Maisuu1_textBox
            // 
            this.Maisuu1_textBox.Location = new System.Drawing.Point(109, 125);
            this.Maisuu1_textBox.Name = "Maisuu1_textBox";
            this.Maisuu1_textBox.Size = new System.Drawing.Size(100, 19);
            this.Maisuu1_textBox.TabIndex = 3;
            this.Maisuu1_textBox.TextChanged += new System.EventHandler(this.Maisuu1_textBox_TextChanged);
            // 
            // Hash1_textBox
            // 
            this.Hash1_textBox.Location = new System.Drawing.Point(109, 93);
            this.Hash1_textBox.Name = "Hash1_textBox";
            this.Hash1_textBox.Size = new System.Drawing.Size(100, 19);
            this.Hash1_textBox.TabIndex = 4;
            // 
            // CardName1_textBox
            // 
            this.CardName1_textBox.Location = new System.Drawing.Point(109, 56);
            this.CardName1_textBox.Name = "CardName1_textBox";
            this.CardName1_textBox.Size = new System.Drawing.Size(100, 19);
            this.CardName1_textBox.TabIndex = 5;
            // 
            // CLASS_textBox
            // 
            this.CLASS_textBox.Location = new System.Drawing.Point(109, 22);
            this.CLASS_textBox.Name = "CLASS_textBox";
            this.CLASS_textBox.Size = new System.Drawing.Size(100, 19);
            this.CLASS_textBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "カード名 2";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CardName2_textBox
            // 
            this.CardName2_textBox.Location = new System.Drawing.Point(109, 156);
            this.CardName2_textBox.Name = "CardName2_textBox";
            this.CardName2_textBox.Size = new System.Drawing.Size(100, 19);
            this.CardName2_textBox.TabIndex = 5;
            this.CardName2_textBox.TextChanged += new System.EventHandler(this.CardName2_textBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "HASH値 2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Hash2_textBox
            // 
            this.Hash2_textBox.Location = new System.Drawing.Point(109, 191);
            this.Hash2_textBox.Name = "Hash2_textBox";
            this.Hash2_textBox.Size = new System.Drawing.Size(100, 19);
            this.Hash2_textBox.TabIndex = 4;
            this.Hash2_textBox.TextChanged += new System.EventHandler(this.Hash2_textBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "書込";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "枚数2";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // Maisuu2_textBox
            // 
            this.Maisuu2_textBox.Location = new System.Drawing.Point(109, 228);
            this.Maisuu2_textBox.Name = "Maisuu2_textBox";
            this.Maisuu2_textBox.Size = new System.Drawing.Size(100, 19);
            this.Maisuu2_textBox.TabIndex = 3;
            this.Maisuu2_textBox.TextChanged += new System.EventHandler(this.Maisuu1_textBox_TextChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Arch_textBox);
            this.Controls.Add(this.Maisuu2_textBox);
            this.Controls.Add(this.Maisuu1_textBox);
            this.Controls.Add(this.Hash2_textBox);
            this.Controls.Add(this.Hash1_textBox);
            this.Controls.Add(this.CardName2_textBox);
            this.Controls.Add(this.CardName1_textBox);
            this.Controls.Add(this.CLASS_textBox);
            this.Name = "Form5";
            this.Text = "ANDフィルタ";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Arch_textBox;
        private System.Windows.Forms.TextBox Maisuu1_textBox;
        private System.Windows.Forms.TextBox Hash1_textBox;
        private System.Windows.Forms.TextBox CardName1_textBox;
        private System.Windows.Forms.TextBox CLASS_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CardName2_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Hash2_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Maisuu2_textBox;
    }
}