namespace Battle_Manage
{
    partial class DetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
            this.OKbutton = new System.Windows.Forms.Button();
            this.ResultListview = new System.Windows.Forms.ListView();
            this.Mydeck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opendeck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WinLose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstWinPer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MyDeck_groupBox = new System.Windows.Forms.GroupBox();
            this.NC_pictureBox = new System.Windows.Forms.PictureBox();
            this.B_pictureBox = new System.Windows.Forms.PictureBox();
            this.E_pictureBox = new System.Windows.Forms.PictureBox();
            this.L_pictureBox = new System.Windows.Forms.PictureBox();
            this.NM_pictureBox = new System.Windows.Forms.PictureBox();
            this.W_pictureBox = new System.Windows.Forms.PictureBox();
            this.D_pictureBox = new System.Windows.Forms.PictureBox();
            this.V_pictureBox = new System.Windows.Forms.PictureBox();
            this.OpenDeck_groupBox = new System.Windows.Forms.GroupBox();
            this.NC_pictureBox_open = new System.Windows.Forms.PictureBox();
            this.B_pictureBox_open = new System.Windows.Forms.PictureBox();
            this.E_pictureBox_open = new System.Windows.Forms.PictureBox();
            this.NM_pictureBox_open = new System.Windows.Forms.PictureBox();
            this.D_pictureBox_open = new System.Windows.Forms.PictureBox();
            this.V_pictureBox_open = new System.Windows.Forms.PictureBox();
            this.L_pictureBox_open = new System.Windows.Forms.PictureBox();
            this.W_pictureBox_open = new System.Windows.Forms.PictureBox();
            this.MyTYPE_listBox = new System.Windows.Forms.ListBox();
            this.OpenType_listBox = new System.Windows.Forms.ListBox();
            this.MyDeck_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NC_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_pictureBox)).BeginInit();
            this.OpenDeck_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NC_pictureBox_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_pictureBox_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_pictureBox_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_pictureBox_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_pictureBox_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_pictureBox_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_pictureBox_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_pictureBox_open)).BeginInit();
            this.SuspendLayout();
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(449, 218);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(59, 36);
            this.OKbutton.TabIndex = 5;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // ResultListview
            // 
            this.ResultListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mydeck,
            this.Opendeck,
            this.WinLose,
            this.FirstWinPer});
            this.ResultListview.HideSelection = false;
            this.ResultListview.Location = new System.Drawing.Point(23, 286);
            this.ResultListview.Name = "ResultListview";
            this.ResultListview.Size = new System.Drawing.Size(485, 195);
            this.ResultListview.TabIndex = 6;
            this.ResultListview.UseCompatibleStateImageBehavior = false;
            this.ResultListview.View = System.Windows.Forms.View.Details;
            this.ResultListview.SelectedIndexChanged += new System.EventHandler(this.ResultListview_SelectedIndexChanged);
            // 
            // Mydeck
            // 
            this.Mydeck.Text = "使用デッキ";
            this.Mydeck.Width = 150;
            // 
            // Opendeck
            // 
            this.Opendeck.Text = "相手デッキ";
            this.Opendeck.Width = 150;
            // 
            // WinLose
            // 
            this.WinLose.Text = "勝敗";
            // 
            // FirstWinPer
            // 
            this.FirstWinPer.Text = "勝った時の先攻率";
            this.FirstWinPer.Width = 115;
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
            this.MyDeck_groupBox.Location = new System.Drawing.Point(23, 24);
            this.MyDeck_groupBox.Name = "MyDeck_groupBox";
            this.MyDeck_groupBox.Size = new System.Drawing.Size(218, 107);
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
            // OpenDeck_groupBox
            // 
            this.OpenDeck_groupBox.Controls.Add(this.NC_pictureBox_open);
            this.OpenDeck_groupBox.Controls.Add(this.B_pictureBox_open);
            this.OpenDeck_groupBox.Controls.Add(this.E_pictureBox_open);
            this.OpenDeck_groupBox.Controls.Add(this.NM_pictureBox_open);
            this.OpenDeck_groupBox.Controls.Add(this.D_pictureBox_open);
            this.OpenDeck_groupBox.Controls.Add(this.V_pictureBox_open);
            this.OpenDeck_groupBox.Controls.Add(this.L_pictureBox_open);
            this.OpenDeck_groupBox.Controls.Add(this.W_pictureBox_open);
            this.OpenDeck_groupBox.Location = new System.Drawing.Point(25, 146);
            this.OpenDeck_groupBox.Name = "OpenDeck_groupBox";
            this.OpenDeck_groupBox.Size = new System.Drawing.Size(216, 108);
            this.OpenDeck_groupBox.TabIndex = 39;
            this.OpenDeck_groupBox.TabStop = false;
            this.OpenDeck_groupBox.Text = "相手デッキ(クラス)";
            // 
            // NC_pictureBox_open
            // 
            this.NC_pictureBox_open.Image = ((System.Drawing.Image)(resources.GetObject("NC_pictureBox_open.Image")));
            this.NC_pictureBox_open.Location = new System.Drawing.Point(2, 58);
            this.NC_pictureBox_open.Name = "NC_pictureBox_open";
            this.NC_pictureBox_open.Size = new System.Drawing.Size(50, 41);
            this.NC_pictureBox_open.TabIndex = 34;
            this.NC_pictureBox_open.TabStop = false;
            this.NC_pictureBox_open.Click += new System.EventHandler(this.NC_pictureBox_open_Click);
            // 
            // B_pictureBox_open
            // 
            this.B_pictureBox_open.Image = ((System.Drawing.Image)(resources.GetObject("B_pictureBox_open.Image")));
            this.B_pictureBox_open.Location = new System.Drawing.Point(102, 58);
            this.B_pictureBox_open.Name = "B_pictureBox_open";
            this.B_pictureBox_open.Size = new System.Drawing.Size(50, 41);
            this.B_pictureBox_open.TabIndex = 36;
            this.B_pictureBox_open.TabStop = false;
            this.B_pictureBox_open.Click += new System.EventHandler(this.B_pictureBox_open_Click);
            // 
            // E_pictureBox_open
            // 
            this.E_pictureBox_open.Image = ((System.Drawing.Image)(resources.GetObject("E_pictureBox_open.Image")));
            this.E_pictureBox_open.Location = new System.Drawing.Point(2, 18);
            this.E_pictureBox_open.Name = "E_pictureBox_open";
            this.E_pictureBox_open.Size = new System.Drawing.Size(50, 41);
            this.E_pictureBox_open.TabIndex = 29;
            this.E_pictureBox_open.TabStop = false;
            this.E_pictureBox_open.Click += new System.EventHandler(this.E_pictureBox_open_Click);
            // 
            // NM_pictureBox_open
            // 
            this.NM_pictureBox_open.Image = ((System.Drawing.Image)(resources.GetObject("NM_pictureBox_open.Image")));
            this.NM_pictureBox_open.Location = new System.Drawing.Point(152, 58);
            this.NM_pictureBox_open.Name = "NM_pictureBox_open";
            this.NM_pictureBox_open.Size = new System.Drawing.Size(50, 41);
            this.NM_pictureBox_open.TabIndex = 35;
            this.NM_pictureBox_open.TabStop = false;
            this.NM_pictureBox_open.Click += new System.EventHandler(this.NM_pictureBox_open_Click);
            // 
            // D_pictureBox_open
            // 
            this.D_pictureBox_open.Image = ((System.Drawing.Image)(resources.GetObject("D_pictureBox_open.Image")));
            this.D_pictureBox_open.Location = new System.Drawing.Point(152, 18);
            this.D_pictureBox_open.Name = "D_pictureBox_open";
            this.D_pictureBox_open.Size = new System.Drawing.Size(50, 41);
            this.D_pictureBox_open.TabIndex = 33;
            this.D_pictureBox_open.TabStop = false;
            this.D_pictureBox_open.Click += new System.EventHandler(this.D_pictureBox_open_Click);
            // 
            // V_pictureBox_open
            // 
            this.V_pictureBox_open.Image = ((System.Drawing.Image)(resources.GetObject("V_pictureBox_open.Image")));
            this.V_pictureBox_open.Location = new System.Drawing.Point(52, 58);
            this.V_pictureBox_open.Name = "V_pictureBox_open";
            this.V_pictureBox_open.Size = new System.Drawing.Size(50, 41);
            this.V_pictureBox_open.TabIndex = 32;
            this.V_pictureBox_open.TabStop = false;
            this.V_pictureBox_open.Click += new System.EventHandler(this.V_pictureBox_open_Click);
            // 
            // L_pictureBox_open
            // 
            this.L_pictureBox_open.Image = ((System.Drawing.Image)(resources.GetObject("L_pictureBox_open.Image")));
            this.L_pictureBox_open.Location = new System.Drawing.Point(52, 18);
            this.L_pictureBox_open.Name = "L_pictureBox_open";
            this.L_pictureBox_open.Size = new System.Drawing.Size(50, 41);
            this.L_pictureBox_open.TabIndex = 30;
            this.L_pictureBox_open.TabStop = false;
            this.L_pictureBox_open.Click += new System.EventHandler(this.L_pictureBox_open_Click);
            // 
            // W_pictureBox_open
            // 
            this.W_pictureBox_open.Image = ((System.Drawing.Image)(resources.GetObject("W_pictureBox_open.Image")));
            this.W_pictureBox_open.Location = new System.Drawing.Point(102, 18);
            this.W_pictureBox_open.Name = "W_pictureBox_open";
            this.W_pictureBox_open.Size = new System.Drawing.Size(50, 41);
            this.W_pictureBox_open.TabIndex = 31;
            this.W_pictureBox_open.TabStop = false;
            this.W_pictureBox_open.Click += new System.EventHandler(this.W_pictureBox_open_Click);
            // 
            // MyTYPE_listBox
            // 
            this.MyTYPE_listBox.FormattingEnabled = true;
            this.MyTYPE_listBox.HorizontalScrollbar = true;
            this.MyTYPE_listBox.ItemHeight = 12;
            this.MyTYPE_listBox.Location = new System.Drawing.Point(247, 31);
            this.MyTYPE_listBox.Name = "MyTYPE_listBox";
            this.MyTYPE_listBox.Size = new System.Drawing.Size(196, 100);
            this.MyTYPE_listBox.TabIndex = 40;
            this.MyTYPE_listBox.SelectedIndexChanged += new System.EventHandler(this.MyTYPE_listBox_SelectedIndexChanged);
            // 
            // OpenType_listBox
            // 
            this.OpenType_listBox.FormattingEnabled = true;
            this.OpenType_listBox.HorizontalScrollbar = true;
            this.OpenType_listBox.ItemHeight = 12;
            this.OpenType_listBox.Location = new System.Drawing.Point(247, 154);
            this.OpenType_listBox.Name = "OpenType_listBox";
            this.OpenType_listBox.Size = new System.Drawing.Size(196, 100);
            this.OpenType_listBox.TabIndex = 41;
            this.OpenType_listBox.SelectedIndexChanged += new System.EventHandler(this.OpenType_listBox_SelectedIndexChanged);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 493);
            this.Controls.Add(this.OpenType_listBox);
            this.Controls.Add(this.MyTYPE_listBox);
            this.Controls.Add(this.OpenDeck_groupBox);
            this.Controls.Add(this.MyDeck_groupBox);
            this.Controls.Add(this.ResultListview);
            this.Controls.Add(this.OKbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DetailForm";
            this.Text = "戦績確認";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MyDeck_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NC_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_pictureBox)).EndInit();
            this.OpenDeck_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NC_pictureBox_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_pictureBox_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_pictureBox_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_pictureBox_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_pictureBox_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_pictureBox_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_pictureBox_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_pictureBox_open)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.ListView ResultListview;
        private System.Windows.Forms.ColumnHeader Mydeck;
        private System.Windows.Forms.ColumnHeader Opendeck;
        private System.Windows.Forms.ColumnHeader WinLose;
        private System.Windows.Forms.ColumnHeader FirstWinPer;
        private System.Windows.Forms.GroupBox MyDeck_groupBox;
        private System.Windows.Forms.PictureBox NC_pictureBox;
        private System.Windows.Forms.PictureBox B_pictureBox;
        private System.Windows.Forms.PictureBox E_pictureBox;
        private System.Windows.Forms.PictureBox L_pictureBox;
        private System.Windows.Forms.PictureBox NM_pictureBox;
        private System.Windows.Forms.PictureBox W_pictureBox;
        private System.Windows.Forms.PictureBox D_pictureBox;
        private System.Windows.Forms.PictureBox V_pictureBox;
        private System.Windows.Forms.GroupBox OpenDeck_groupBox;
        private System.Windows.Forms.PictureBox NC_pictureBox_open;
        private System.Windows.Forms.PictureBox B_pictureBox_open;
        private System.Windows.Forms.PictureBox E_pictureBox_open;
        private System.Windows.Forms.PictureBox NM_pictureBox_open;
        private System.Windows.Forms.PictureBox D_pictureBox_open;
        private System.Windows.Forms.PictureBox V_pictureBox_open;
        private System.Windows.Forms.PictureBox L_pictureBox_open;
        private System.Windows.Forms.PictureBox W_pictureBox_open;
        private System.Windows.Forms.ListBox MyTYPE_listBox;
        private System.Windows.Forms.ListBox OpenType_listBox;
    }
}