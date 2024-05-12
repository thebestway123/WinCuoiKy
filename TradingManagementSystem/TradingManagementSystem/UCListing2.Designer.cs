namespace TradingManagementSystem
{
    partial class UCListing2
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
            this.ProductName2 = new System.Windows.Forms.Label();
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
            this.label3.TabIndex = 16;
            this.label3.Text = "Giá mua mới:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(162, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Giá bán:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // giaMuaMoiLabel2
            // 
            this.giaMuaMoiLabel2.AutoSize = true;
            this.giaMuaMoiLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
            this.giaMuaMoiLabel2.ForeColor = System.Drawing.Color.Black;
            this.giaMuaMoiLabel2.Location = new System.Drawing.Point(265, 97);
            this.giaMuaMoiLabel2.Name = "giaMuaMoiLabel2";
            this.giaMuaMoiLabel2.Size = new System.Drawing.Size(112, 23);
            this.giaMuaMoiLabel2.TabIndex = 13;
            this.giaMuaMoiLabel2.Text = "giá mua mới";
            this.giaMuaMoiLabel2.Click += new System.EventHandler(this.giaMuaMoiLabel2_Click);
            // 
            // giaBanLabel2
            // 
            this.giaBanLabel2.AutoSize = true;
            this.giaBanLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.giaBanLabel2.ForeColor = System.Drawing.Color.Black;
            this.giaBanLabel2.Location = new System.Drawing.Point(265, 67);
            this.giaBanLabel2.Name = "giaBanLabel2";
            this.giaBanLabel2.Size = new System.Drawing.Size(70, 23);
            this.giaBanLabel2.TabIndex = 12;
            this.giaBanLabel2.Text = "giá bán";
            this.giaBanLabel2.Click += new System.EventHandler(this.giaBanLabel2_Click);
            // 
            // ProductName2
            // 
            this.ProductName2.AutoSize = true;
            this.ProductName2.BackColor = System.Drawing.Color.Transparent;
            this.ProductName2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductName2.ForeColor = System.Drawing.Color.Black;
            this.ProductName2.Location = new System.Drawing.Point(176, 17);
            this.ProductName2.Name = "ProductName2";
            this.ProductName2.Size = new System.Drawing.Size(23, 28);
            this.ProductName2.TabIndex = 11;
            this.ProductName2.Text = "x";
            this.ProductName2.Click += new System.EventHandler(this.ProductName2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UCListing2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giaMuaMoiLabel2);
            this.Controls.Add(this.giaBanLabel2);
            this.Controls.Add(this.ProductName2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCListing2";
            this.Size = new System.Drawing.Size(533, 144);
            this.Load += new System.EventHandler(this.UCListing2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label1;
        public Label giaMuaMoiLabel2;
        public Label giaBanLabel2;
        public Label ProductName2;
        public PictureBox pictureBox1;
    }
}
