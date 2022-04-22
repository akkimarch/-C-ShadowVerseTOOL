namespace Battle_Manage
{
    partial class AddDeckType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDeckType));
            this.Addbutton = new System.Windows.Forms.Button();
            this.Delbutton = new System.Windows.Forms.Button();
            this.DeckTypelistBox = new System.Windows.Forms.ListBox();
            this.AddType_Textbox = new System.Windows.Forms.TextBox();
            this.MyDeck_groupBox = new System.Windows.Forms.GroupBox();
            this.NC_pictureBox = new System.Windows.Forms.PictureBox();
            this.B_pictureBox = new System.Windows.Forms.PictureBox();
            this.E_pictureBox = new System.Windows.Forms.PictureBox();
            this.L_pictureBox = new System.Windows.Forms.PictureBox();
            this.NM_pictureBox = new System.Windows.Forms.PictureBox();
            this.W_pictureBox = new System.Windows.Forms.PictureBox();
            this.D_pictureBox = new System.Windows.Forms.PictureBox();
            this.V_pictureBox = new System.Windows.Forms.PictureBox();
            this.DelType_label = new System.Windows.Forms.Label();
            this.MyDeck_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NC_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(283, 139);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 0;
            this.Addbutton.Text = "追加";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Delbutton
            // 
            this.Delbutton.Location = new System.Drawing.Point(283, 206);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(75, 23);
            this.Delbutton.TabIndex = 1;
            this.Delbutton.Text = "削除";
            this.Delbutton.UseVisualStyleBackColor = true;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // DeckTypelistBox
            // 
            this.DeckTypelistBox.FormattingEnabled = true;
            this.DeckTypelistBox.ItemHeight = 12;
            this.DeckTypelistBox.Location = new System.Drawing.Point(30, 141);
            this.DeckTypelistBox.Name = "DeckTypelistBox";
            this.DeckTypelistBox.Size = new System.Drawing.Size(120, 160);
            this.DeckTypelistBox.TabIndex = 3;
            this.DeckTypelistBox.SelectedIndexChanged += new System.EventHandler(this.DeckTypelistBox_SelectedIndexChanged);
            // 
            // AddType_Textbox
            // 
            this.AddType_Textbox.Location = new System.Drawing.Point(156, 141);
            this.AddType_Textbox.Name = "AddType_Textbox";
            this.AddType_Textbox.Size = new System.Drawing.Size(121, 19);
            this.AddType_Textbox.TabIndex = 4;
            // 
            // MyDeck_groupBox
            // 
            this.MyDeck_groupBox.Controls.Add(this.NC_pictureBox);
            this.MyDeck_groupBox.Controls.Add(this.B_pictureBox);
            this.MyDeck_groupBox.Controls.Add(this.E_pictureBox);
            this.MyDeck_groupBox.Controls.Add(this.L_pictureBox);
            this.MyDeck_groupBox.Controls.Add(this.NM_pictureBox);
            this.MyDeck_groupBox.Controls.Add(this.W_pictureBox);
            this.MyDeck_groupBox.Controls.Add(this.D_pictureBox);
            this.MyDeck_groupBox.Controls.Add(this.V_pictureBox);
            this.MyDeck_groupBox.Location = new System.Drawing.Point(30, 12);
            this.MyDeck_groupBox.Name = "MyDeck_groupBox";
            this.MyDeck_groupBox.Size = new System.Drawing.Size(232, 107);
            this.MyDeck_groupBox.TabIndex = 38;
            this.MyDeck_groupBox.TabStop = false;
            this.MyDeck_groupBox.Text = "使用デッキ(クラス)";
            // 
            // NC_pictureBox
            // 
            this.NC_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("NC_pictureBox.Image")));
            this.NC_pictureBox.Location = new System.Drawing.Point(2, 60);
            this.NC_pictureBox.Name = "NC_pictureBox";
            this.NC_pictureBox.Size = new System.Drawing.Size(50, 41);
            this.NC_pictureBox.TabIndex = 34;
            this.NC_pictureBox.TabStop = false;
            this.NC_pictureBox.Click += new System.EventHandler(this.NC_pictureBox_Click);
            // 
            // B_pictureBox
            // 
            this.B_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("B_pictureBox.Image")));
            this.B_pictureBox.Location = new System.Drawing.Point(102, 60);
            this.B_pictureBox.Name = "B_pictureBox";
            this.B_pictureBox.Size = new System.Drawing.Size(50, 41);
            this.B_pictureBox.TabIndex = 36;
            this.B_pictureBox.TabStop = false;
            this.B_pictureBox.Click += new System.EventHandler(this.B_pictureBox_Click);
            // 
            // E_pictureBox
            // 
            this.E_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("E_pictureBox.Image")));
            this.E_pictureBox.Location = new System.Drawing.Point(2, 18);
            this.E_pictureBox.Name = "E_pictureBox";
            this.E_pictureBox.Size = new System.Drawing.Size(50, 41);
            this.E_pictureBox.TabIndex = 29;
            this.E_pictureBox.TabStop = false;
            this.E_pictureBox.Click += new System.EventHandler(this.E_pictureBox_Click);
            // 
            // L_pictureBox
            // 
            this.L_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("L_pictureBox.Image")));
            this.L_pictureBox.Location = new System.Drawing.Point(52, 18);
            this.L_pictureBox.Name = "L_pictureBox";
            this.L_pictureBox.Size = new System.Drawing.Size(50, 41);
            this.L_pictureBox.TabIndex = 30;
            this.L_pictureBox.TabStop = false;
            this.L_pictureBox.Click += new System.EventHandler(this.L_pictureBox_Click);
            // 
            // NM_pictureBox
            // 
            this.NM_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("NM_pictureBox.Image")));
            this.NM_pictureBox.Location = new System.Drawing.Point(152, 60);
            this.NM_pictureBox.Name = "NM_pictureBox";
            this.NM_pictureBox.Size = new System.Drawing.Size(50, 41);
            this.NM_pictureBox.TabIndex = 35;
            this.NM_pictureBox.TabStop = false;
            this.NM_pictureBox.Click += new System.EventHandler(this.NM_pictureBox_Click);
            // 
            // W_pictureBox
            // 
            this.W_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("W_pictureBox.Image")));
            this.W_pictureBox.Location = new System.Drawing.Point(102, 18);
            this.W_pictureBox.Name = "W_pictureBox";
            this.W_pictureBox.Size = new System.Drawing.Size(50, 41);
            this.W_pictureBox.TabIndex = 31;
            this.W_pictureBox.TabStop = false;
            this.W_pictureBox.Click += new System.EventHandler(this.W_pictureBox_Click);
            // 
            // D_pictureBox
            // 
            this.D_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("D_pictureBox.Image")));
            this.D_pictureBox.Location = new System.Drawing.Point(152, 18);
            this.D_pictureBox.Name = "D_pictureBox";
            this.D_pictureBox.Size = new System.Drawing.Size(50, 41);
            this.D_pictureBox.TabIndex = 33;
            this.D_pictureBox.TabStop = false;
            this.D_pictureBox.Click += new System.EventHandler(this.D_pictureBox_Click);
            // 
            // V_pictureBox
            // 
            this.V_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("V_pictureBox.Image")));
            this.V_pictureBox.Location = new System.Drawing.Point(52, 60);
            this.V_pictureBox.Name = "V_pictureBox";
            this.V_pictureBox.Size = new System.Drawing.Size(50, 41);
            this.V_pictureBox.TabIndex = 32;
            this.V_pictureBox.TabStop = false;
            this.V_pictureBox.Click += new System.EventHandler(this.V_pictureBox_Click);
            // 
            // DelType_label
            // 
            this.DelType_label.AutoSize = true;
            this.DelType_label.Location = new System.Drawing.Point(156, 211);
            this.DelType_label.Name = "DelType_label";
            this.DelType_label.Size = new System.Drawing.Size(0, 12);
            this.DelType_label.TabIndex = 39;
            // 
            // AddDeckType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 313);
            this.Controls.Add(this.DelType_label);
            this.Controls.Add(this.MyDeck_groupBox);
            this.Controls.Add(this.AddType_Textbox);
            this.Controls.Add(this.DeckTypelistBox);
            this.Controls.Add(this.Delbutton);
            this.Controls.Add(this.Addbutton);
            this.Name = "AddDeckType";
            this.Text = "アーキタイプを編集";
            this.MyDeck_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NC_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Delbutton;
        private System.Windows.Forms.ListBox DeckTypelistBox;
        private System.Windows.Forms.TextBox AddType_Textbox;
        private System.Windows.Forms.GroupBox MyDeck_groupBox;
        private System.Windows.Forms.PictureBox NC_pictureBox;
        private System.Windows.Forms.PictureBox B_pictureBox;
        private System.Windows.Forms.PictureBox E_pictureBox;
        private System.Windows.Forms.PictureBox L_pictureBox;
        private System.Windows.Forms.PictureBox NM_pictureBox;
        private System.Windows.Forms.PictureBox W_pictureBox;
        private System.Windows.Forms.PictureBox D_pictureBox;
        private System.Windows.Forms.PictureBox V_pictureBox;
        private System.Windows.Forms.Label DelType_label;
    }
}