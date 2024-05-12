namespace TradingManagementSystem
{
    partial class danhGiaListing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NhanXetLabel = new System.Windows.Forms.Label();
            this.TkDanhGia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NhanXetLabel
            // 
            this.NhanXetLabel.AutoSize = true;
            this.NhanXetLabel.ForeColor = System.Drawing.Color.Black;
            this.NhanXetLabel.Location = new System.Drawing.Point(34, 54);
            this.NhanXetLabel.Name = "NhanXetLabel";
            this.NhanXetLabel.Size = new System.Drawing.Size(94, 15);
            this.NhanXetLabel.TabIndex = 0;
            this.NhanXetLabel.Text = "Lời nhận xét abc";
            // 
            // TkDanhGia
            // 
            this.TkDanhGia.AutoSize = true;
            this.TkDanhGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TkDanhGia.ForeColor = System.Drawing.Color.Black;
            this.TkDanhGia.Location = new System.Drawing.Point(15, 9);
            this.TkDanhGia.Name = "TkDanhGia";
            this.TkDanhGia.Size = new System.Drawing.Size(50, 21);
            this.TkDanhGia.TabIndex = 18;
            this.TkDanhGia.Text = "tentk";
            // 
            // danhGiaListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TkDanhGia);
            this.Controls.Add(this.NhanXetLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "danhGiaListing";
            this.Size = new System.Drawing.Size(336, 96);
            this.Load += new System.EventHandler(this.danhGiaListing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NhanXetLabel;
        private Label TkDanhGia;
    }
}
