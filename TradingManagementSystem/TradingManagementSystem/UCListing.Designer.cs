namespace TradingManagementSystem
{
    partial class UCListing
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
            this.giaBanLabel = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.giaMuaMoiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // giaBanLabel
            // 
            this.giaBanLabel.AutoSize = true;
            this.giaBanLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.giaBanLabel.ForeColor = System.Drawing.Color.Black;
            this.giaBanLabel.Location = new System.Drawing.Point(256, 67);
            this.giaBanLabel.Name = "giaBanLabel";
            this.giaBanLabel.Size = new System.Drawing.Size(70, 23);
            this.giaBanLabel.TabIndex = 5;
            this.giaBanLabel.Text = "giá bán";
            this.giaBanLabel.Click += new System.EventHandler(this.giaBanLabel_Click);
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.BackColor = System.Drawing.Color.White;
            this.ProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductName.ForeColor = System.Drawing.Color.Black;
            this.ProductName.Location = new System.Drawing.Point(167, 17);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(23, 28);
            this.ProductName.TabIndex = 4;
            this.ProductName.Text = "x";
            this.ProductName.Click += new System.EventHandler(this.ProductName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // giaMuaMoiLabel
            // 
            this.giaMuaMoiLabel.AutoSize = true;
            this.giaMuaMoiLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
            this.giaMuaMoiLabel.ForeColor = System.Drawing.Color.Black;
            this.giaMuaMoiLabel.Location = new System.Drawing.Point(256, 97);
            this.giaMuaMoiLabel.Name = "giaMuaMoiLabel";
            this.giaMuaMoiLabel.Size = new System.Drawing.Size(112, 23);
            this.giaMuaMoiLabel.TabIndex = 6;
            this.giaMuaMoiLabel.Text = "giá mua mới";
            this.giaMuaMoiLabel.Click += new System.EventHandler(this.giaMuaMoiLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Giá bán:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(153, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá mua mới:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UCListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giaMuaMoiLabel);
            this.Controls.Add(this.giaBanLabel);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCListing";
            this.Size = new System.Drawing.Size(535, 147);
            this.Load += new System.EventHandler(this.UCListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label ProductName;
        public Label giaBanLabel;
        public PictureBox pictureBox1;
        public Label giaMuaMoiLabel;
        private Label label1;
        private Label label3;
    }
}
