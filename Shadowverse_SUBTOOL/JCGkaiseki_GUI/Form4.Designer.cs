namespace JCGkaiseki_GUI
{
    partial class Form4
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
            this.CLASS_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CardName_textBox = new System.Windows.Forms.TextBox();
            this.Hash_textBox = new System.Windows.Forms.TextBox();
            this.Maisuu_textBox = new System.Windows.Forms.TextBox();
            this.Arch_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CLASS_textBox
            // 
            this.CLASS_textBox.Location = new System.Drawing.Point(114, 38);
            this.CLASS_textBox.Name = "CLASS_textBox";
            this.CLASS_textBox.Size = new System.Drawing.Size(100, 19);
            this.CLASS_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "カード名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "HASH値";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "枚数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "アーキタイプ名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "クラス名";
            // 
            // CardName_textBox
            // 
            this.CardName_textBox.Location = new System.Drawing.Point(114, 72);
            this.CardName_textBox.Name = "CardName_textBox";
            this.CardName_textBox.Size = new System.Drawing.Size(100, 19);
            this.CardName_textBox.TabIndex = 1;
            // 
            // Hash_textBox
            // 
            this.Hash_textBox.Location = new System.Drawing.Point(114, 109);
            this.Hash_textBox.Name = "Hash_textBox";
            this.Hash_textBox.Size = new System.Drawing.Size(100, 19);
            this.Hash_textBox.TabIndex = 2;
            // 
            // Maisuu_textBox
            // 
            this.Maisuu_textBox.Location = new System.Drawing.Point(114, 149);
            this.Maisuu_textBox.Name = "Maisuu_textBox";
            this.Maisuu_textBox.Size = new System.Drawing.Size(100, 19);
            this.Maisuu_textBox.TabIndex = 3;
            // 
            // Arch_textBox
            // 
            this.Arch_textBox.Location = new System.Drawing.Point(114, 189);
            this.Arch_textBox.Name = "Arch_textBox";
            this.Arch_textBox.Size = new System.Drawing.Size(100, 19);
            this.Arch_textBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "書込";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Arch_textBox);
            this.Controls.Add(this.Maisuu_textBox);
            this.Controls.Add(this.Hash_textBox);
            this.Controls.Add(this.CardName_textBox);
            this.Controls.Add(this.CLASS_textBox);
            this.Name = "Form4";
            this.Text = "単体フィルタ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CLASS_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CardName_textBox;
        private System.Windows.Forms.TextBox Hash_textBox;
        private System.Windows.Forms.TextBox Maisuu_textBox;
        private System.Windows.Forms.TextBox Arch_textBox;
        private System.Windows.Forms.Button button1;
    }
}