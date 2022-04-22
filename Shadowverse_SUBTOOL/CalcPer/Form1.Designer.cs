namespace CalcPer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Starting = new System.Windows.Forms.Button();
            this.OnBattle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Starting
            // 
            this.Starting.Location = new System.Drawing.Point(53, 60);
            this.Starting.Name = "Starting";
            this.Starting.Size = new System.Drawing.Size(173, 55);
            this.Starting.TabIndex = 0;
            this.Starting.Text = "マリガン";
            this.Starting.UseVisualStyleBackColor = true;
            this.Starting.Click += new System.EventHandler(this.Starting_Click);
            // 
            // OnBattle
            // 
            this.OnBattle.Location = new System.Drawing.Point(53, 165);
            this.OnBattle.Name = "OnBattle";
            this.OnBattle.Size = new System.Drawing.Size(173, 55);
            this.OnBattle.TabIndex = 1;
            this.OnBattle.Text = "バトル内";
            this.OnBattle.UseVisualStyleBackColor = true;
            this.OnBattle.Click += new System.EventHandler(this.OnBattle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 267);
            this.Controls.Add(this.OnBattle);
            this.Controls.Add(this.Starting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Starting;
        private System.Windows.Forms.Button OnBattle;
    }
}

