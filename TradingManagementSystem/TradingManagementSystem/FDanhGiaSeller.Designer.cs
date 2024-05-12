namespace TradingManagementSystem
{
    partial class FDanhGiaSeller
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
            this.DanhGiaNguoiBan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DanhGiaNguoiBan
            // 
            this.DanhGiaNguoiBan.AutoSize = true;
            this.DanhGiaNguoiBan.Location = new System.Drawing.Point(2, 9);
            this.DanhGiaNguoiBan.Name = "DanhGiaNguoiBan";
            this.DanhGiaNguoiBan.Size = new System.Drawing.Size(275, 20);
            this.DanhGiaNguoiBan.TabIndex = 14;
            this.DanhGiaNguoiBan.Text = "Hãy viết đánh giá của bạn về người bán:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 27);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "đánh giá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 29);
            this.button2.TabIndex = 22;
            this.button2.Text = "không đánh giá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FDanhGiaSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 158);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DanhGiaNguoiBan);
            this.Controls.Add(this.textBox1);
            this.MinimizeBox = false;
            this.Name = "FDanhGiaSeller";
            this.Text = "FDanhGiaSeller";
            this.Load += new System.EventHandler(this.FDanhGiaSeller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label DanhGiaNguoiBan;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}