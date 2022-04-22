namespace CalcPer
{
    partial class Starting
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
            this.FirstButton = new System.Windows.Forms.RadioButton();
            this.SecondButton = new System.Windows.Forms.RadioButton();
            this.FirstSecond = new System.Windows.Forms.GroupBox();
            this.Num_Box = new System.Windows.Forms.ComboBox();
            this.Num_Guide = new System.Windows.Forms.Label();
            this.Tern_Guide = new System.Windows.Forms.Label();
            this.Tern_Box = new System.Windows.Forms.ComboBox();
            this.Redraw_Guide = new System.Windows.Forms.Label();
            this.Redraw_Box = new System.Windows.Forms.ComboBox();
            this.Redraw2_Guide = new System.Windows.Forms.Label();
            this.Redraw2_Box = new System.Windows.Forms.ComboBox();
            this.Ret_Label = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FirstSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstButton
            // 
            this.FirstButton.AutoSize = true;
            this.FirstButton.Location = new System.Drawing.Point(6, 25);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(47, 16);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.TabStop = true;
            this.FirstButton.Text = "先攻";
            this.FirstButton.UseVisualStyleBackColor = true;
            // 
            // SecondButton
            // 
            this.SecondButton.AutoSize = true;
            this.SecondButton.Location = new System.Drawing.Point(126, 25);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(47, 16);
            this.SecondButton.TabIndex = 0;
            this.SecondButton.TabStop = true;
            this.SecondButton.Text = "後攻";
            this.SecondButton.UseVisualStyleBackColor = true;
            // 
            // FirstSecond
            // 
            this.FirstSecond.Controls.Add(this.SecondButton);
            this.FirstSecond.Controls.Add(this.FirstButton);
            this.FirstSecond.Location = new System.Drawing.Point(53, 16);
            this.FirstSecond.Name = "FirstSecond";
            this.FirstSecond.Size = new System.Drawing.Size(228, 49);
            this.FirstSecond.TabIndex = 1;
            this.FirstSecond.TabStop = false;
            this.FirstSecond.Text = "先攻/後攻";
            // 
            // Num_Box
            // 
            this.Num_Box.FormattingEnabled = true;
            this.Num_Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Num_Box.Location = new System.Drawing.Point(235, 93);
            this.Num_Box.Name = "Num_Box";
            this.Num_Box.Size = new System.Drawing.Size(32, 20);
            this.Num_Box.TabIndex = 2;
            // 
            // Num_Guide
            // 
            this.Num_Guide.AutoSize = true;
            this.Num_Guide.Location = new System.Drawing.Point(51, 93);
            this.Num_Guide.Name = "Num_Guide";
            this.Num_Guide.Size = new System.Drawing.Size(80, 12);
            this.Num_Guide.TabIndex = 3;
            this.Num_Guide.Text = "デッキ投入枚数";
            // 
            // Tern_Guide
            // 
            this.Tern_Guide.AutoSize = true;
            this.Tern_Guide.Location = new System.Drawing.Point(51, 122);
            this.Tern_Guide.Name = "Tern_Guide";
            this.Tern_Guide.Size = new System.Drawing.Size(44, 12);
            this.Tern_Guide.TabIndex = 3;
            this.Tern_Guide.Text = "ターン数";
            // 
            // Tern_Box
            // 
            this.Tern_Box.FormattingEnabled = true;
            this.Tern_Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Tern_Box.Location = new System.Drawing.Point(235, 119);
            this.Tern_Box.Name = "Tern_Box";
            this.Tern_Box.Size = new System.Drawing.Size(32, 20);
            this.Tern_Box.TabIndex = 2;
            // 
            // Redraw_Guide
            // 
            this.Redraw_Guide.AutoSize = true;
            this.Redraw_Guide.Location = new System.Drawing.Point(51, 147);
            this.Redraw_Guide.Name = "Redraw_Guide";
            this.Redraw_Guide.Size = new System.Drawing.Size(71, 12);
            this.Redraw_Guide.TabIndex = 3;
            this.Redraw_Guide.Text = "引き直し枚数";
            // 
            // Redraw_Box
            // 
            this.Redraw_Box.FormattingEnabled = true;
            this.Redraw_Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Redraw_Box.Location = new System.Drawing.Point(235, 147);
            this.Redraw_Box.Name = "Redraw_Box";
            this.Redraw_Box.Size = new System.Drawing.Size(32, 20);
            this.Redraw_Box.TabIndex = 2;
            // 
            // Redraw2_Guide
            // 
            this.Redraw2_Guide.AutoSize = true;
            this.Redraw2_Guide.Location = new System.Drawing.Point(51, 176);
            this.Redraw2_Guide.Name = "Redraw2_Guide";
            this.Redraw2_Guide.Size = new System.Drawing.Size(160, 12);
            this.Redraw2_Guide.TabIndex = 3;
            this.Redraw2_Guide.Text = "引き直しで対象カードを戻した数";
            // 
            // Redraw2_Box
            // 
            this.Redraw2_Box.FormattingEnabled = true;
            this.Redraw2_Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Redraw2_Box.Location = new System.Drawing.Point(235, 173);
            this.Redraw2_Box.Name = "Redraw2_Box";
            this.Redraw2_Box.Size = new System.Drawing.Size(32, 20);
            this.Redraw2_Box.TabIndex = 2;
            // 
            // Ret_Label
            // 
            this.Ret_Label.AutoSize = true;
            this.Ret_Label.Location = new System.Drawing.Point(51, 243);
            this.Ret_Label.Name = "Ret_Label";
            this.Ret_Label.Size = new System.Drawing.Size(53, 12);
            this.Ret_Label.TabIndex = 3;
            this.Ret_Label.Text = "計算結果";
            this.Ret_Label.Click += new System.EventHandler(this.Result_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(111, 240);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(100, 19);
            this.ResultBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "計算開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Starting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.Ret_Label);
            this.Controls.Add(this.Redraw2_Guide);
            this.Controls.Add(this.Redraw_Guide);
            this.Controls.Add(this.Tern_Guide);
            this.Controls.Add(this.Num_Guide);
            this.Controls.Add(this.Redraw2_Box);
            this.Controls.Add(this.Redraw_Box);
            this.Controls.Add(this.Tern_Box);
            this.Controls.Add(this.Num_Box);
            this.Controls.Add(this.FirstSecond);
            this.Name = "Starting";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Starting_Load);
            this.FirstSecond.ResumeLayout(false);
            this.FirstSecond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton FirstButton;
        private System.Windows.Forms.RadioButton SecondButton;
        private System.Windows.Forms.GroupBox FirstSecond;
        private System.Windows.Forms.ComboBox Num_Box;
        private System.Windows.Forms.Label Num_Guide;
        private System.Windows.Forms.Label Tern_Guide;
        private System.Windows.Forms.ComboBox Tern_Box;
        private System.Windows.Forms.Label Redraw_Guide;
        private System.Windows.Forms.ComboBox Redraw_Box;
        private System.Windows.Forms.Label Redraw2_Guide;
        private System.Windows.Forms.ComboBox Redraw2_Box;
        private System.Windows.Forms.Label Ret_Label;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button button1;
    }
}