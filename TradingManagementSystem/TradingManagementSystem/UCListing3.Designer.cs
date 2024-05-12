namespace TradingManagementSystem
{
    partial class UCListing3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.giaMuaMoiLabel2 = new System.Windows.Forms.Label();
            this.giaBanLabel2 = new System.Windows.Forms.Label();
            this.ProductName3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(162, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Giá mua mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(162, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Giá bán:";
            // 
            // giaMuaMoiLabel2
            // 
            this.giaMuaMoiLabel2.AutoSize = true;
            this.giaMuaMoiLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
            this.giaMuaMoiLabel2.ForeColor = System.Drawing.Color.Black;
            this.giaMuaMoiLabel2.Location = new System.Drawing.Point(265, 97);
            this.giaMuaMoiLabel2.Name = "giaMuaMoiLabel2";
            this.giaMuaMoiLabel2.Size = new System.Drawing.Size(112, 23);
            this.giaMuaMoiLabel2.TabIndex = 20;
            this.giaMuaMoiLabel2.Text = "giá mua mới";
            // 
            // giaBanLabel2
            // 
            this.giaBanLabel2.AutoSize = true;
            this.giaBanLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.giaBanLabel2.ForeColor = System.Drawing.Color.Black;
            this.giaBanLabel2.Location = new System.Drawing.Point(265, 67);
            this.giaBanLabel2.Name = "giaBanLabel2";
            this.giaBanLabel2.Size = new System.Drawing.Size(70, 23);
            this.giaBanLabel2.TabIndex = 19;
            this.giaBanLabel2.Text = "giá bán";
            // 
            // ProductName3
            // 
            this.ProductName3.AutoSize = true;
            this.ProductName3.BackColor = System.Drawing.Color.Transparent;
            this.ProductName3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductName3.ForeColor = System.Drawing.Color.Black;
            this.ProductName3.Location = new System.Drawing.Point(176, 17);
            this.ProductName3.Name = "ProductName3";
            this.ProductName3.Size = new System.Drawing.Size(23, 28);
            this.ProductName3.TabIndex = 18;
            this.ProductName3.Text = "x";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // UCListing3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giaMuaMoiLabel2);
            this.Controls.Add(this.giaBanLabel2);
            this.Controls.Add(this.ProductName3);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCListing3";
            this.Size = new System.Drawing.Size(531, 142);
            this.Load += new System.EventHandler(this.UCListing3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label1;
        public Label giaMuaMoiLabel2;
        public Label giaBanLabel2;
        public Label ProductName3;
        public PictureBox pictureBox1;
    }
}
