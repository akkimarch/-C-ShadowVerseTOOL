namespace Battle_Manage
{
    partial class PieChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Scope_Jump = new System.Windows.Forms.Button();
            this._3days = new System.Windows.Forms.RadioButton();
            this._7days = new System.Windows.Forms.RadioButton();
            this.Alldays = new System.Windows.Forms.RadioButton();
            this._1days = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(43, 40);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieLabelStyle=Disabled, PieStartAngle=270";
            series2.Legend = "Legend1";
            series2.LegendText = "#VALX #VAL%";
            series2.MarkerBorderWidth = 3;
            series2.MarkerSize = 1;
            series2.Name = "utiwake";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(444, 219);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "ScopeGlf";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Scope_Jump
            // 
            this.Scope_Jump.Location = new System.Drawing.Point(43, 278);
            this.Scope_Jump.Name = "Scope_Jump";
            this.Scope_Jump.Size = new System.Drawing.Size(75, 23);
            this.Scope_Jump.TabIndex = 6;
            this.Scope_Jump.Text = "戦績確認";
            this.Scope_Jump.UseVisualStyleBackColor = true;
            this.Scope_Jump.Click += new System.EventHandler(this.Scope_Jump_Click);
            // 
            // _3days
            // 
            this._3days.AutoSize = true;
            this._3days.Location = new System.Drawing.Point(422, 301);
            this._3days.Name = "_3days";
            this._3days.Size = new System.Drawing.Size(65, 16);
            this._3days.TabIndex = 7;
            this._3days.TabStop = true;
            this._3days.Text = "直近3日";
            this._3days.UseVisualStyleBackColor = true;
            this._3days.CheckedChanged += new System.EventHandler(this._3days_CheckedChanged);
            // 
            // _7days
            // 
            this._7days.AutoSize = true;
            this._7days.Location = new System.Drawing.Point(422, 323);
            this._7days.Name = "_7days";
            this._7days.Size = new System.Drawing.Size(65, 16);
            this._7days.TabIndex = 7;
            this._7days.TabStop = true;
            this._7days.Text = "直近7日";
            this._7days.UseVisualStyleBackColor = true;
            this._7days.CheckedChanged += new System.EventHandler(this._7days_CheckedChanged);
            // 
            // Alldays
            // 
            this.Alldays.AutoSize = true;
            this.Alldays.Location = new System.Drawing.Point(422, 345);
            this.Alldays.Name = "Alldays";
            this.Alldays.Size = new System.Drawing.Size(71, 16);
            this.Alldays.TabIndex = 7;
            this.Alldays.TabStop = true;
            this.Alldays.Text = "環境全日";
            this.Alldays.UseVisualStyleBackColor = true;
            this.Alldays.CheckedChanged += new System.EventHandler(this.Alldays_CheckedChanged);
            // 
            // _1days
            // 
            this._1days.AutoSize = true;
            this._1days.Location = new System.Drawing.Point(422, 278);
            this._1days.Name = "_1days";
            this._1days.Size = new System.Drawing.Size(65, 16);
            this._1days.TabIndex = 8;
            this._1days.TabStop = true;
            this._1days.Text = "直近1日";
            this._1days.UseVisualStyleBackColor = true;
            this._1days.CheckedChanged += new System.EventHandler(this._1days_CheckedChanged);
            // 
            // PieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 373);
            this.Controls.Add(this._1days);
            this.Controls.Add(this.Alldays);
            this.Controls.Add(this._7days);
            this.Controls.Add(this._3days);
            this.Controls.Add(this.Scope_Jump);
            this.Controls.Add(this.chart1);
            this.Name = "PieChart";
            this.Text = "環境";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Scope_Jump;
        private System.Windows.Forms.RadioButton _3days;
        private System.Windows.Forms.RadioButton _7days;
        private System.Windows.Forms.RadioButton Alldays;
        private System.Windows.Forms.RadioButton _1days;
    }
}