namespace Assignment_DAMAU.GUI
{
    partial class ThongKe
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(999, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 42);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(1150, 13);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 42);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cartesianChart1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1291, 603);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê số lượng hoá đơn theo tháng";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cartesianChart1.Location = new System.Drawing.Point(3, 44);
            this.cartesianChart1.MatchAxesScreenDataRatio = false;
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1285, 556);
            this.cartesianChart1.TabIndex = 0;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 734);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnThoat);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}