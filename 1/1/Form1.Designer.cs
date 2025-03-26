namespace _1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelEpsilon = new System.Windows.Forms.Label();
            this.textBoxEpsilon = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelSinResult = new System.Windows.Forms.Label();
            this.labelSumResult = new System.Windows.Forms.Label();
            this.labelTermsCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(20, 20);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(118, 13);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "Введите X (аргумент):";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(150, 17);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 0;
            // 
            // labelEpsilon
            // 
            this.labelEpsilon.AutoSize = true;
            this.labelEpsilon.Location = new System.Drawing.Point(20, 50);
            this.labelEpsilon.Name = "labelEpsilon";
            this.labelEpsilon.Size = new System.Drawing.Size(115, 13);
            this.labelEpsilon.TabIndex = 3;
            this.labelEpsilon.Text = "Введите точность (ε):";
            // 
            // textBoxEpsilon
            // 
            this.textBoxEpsilon.Location = new System.Drawing.Point(150, 47);
            this.textBoxEpsilon.Name = "textBoxEpsilon";
            this.textBoxEpsilon.Size = new System.Drawing.Size(100, 20);
            this.textBoxEpsilon.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Enabled = false;
            this.buttonCalculate.Location = new System.Drawing.Point(150, 80);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelSinResult
            // 
            this.labelSinResult.AutoSize = true;
            this.labelSinResult.Location = new System.Drawing.Point(20, 120);
            this.labelSinResult.Name = "labelSinResult";
            this.labelSinResult.Size = new System.Drawing.Size(45, 13);
            this.labelSinResult.TabIndex = 2;
            this.labelSinResult.Text = "Sin(x) = ";
            // 
            // labelSumResult
            // 
            this.labelSumResult.AutoSize = true;
            this.labelSumResult.Location = new System.Drawing.Point(20, 150);
            this.labelSumResult.Name = "labelSumResult";
            this.labelSumResult.Size = new System.Drawing.Size(80, 13);
            this.labelSumResult.TabIndex = 1;
            this.labelSumResult.Text = "Сумма ряда = ";
            // 
            // labelTermsCount
            // 
            this.labelTermsCount.AutoSize = true;
            this.labelTermsCount.Location = new System.Drawing.Point(20, 180);
            this.labelTermsCount.Name = "labelTermsCount";
            this.labelTermsCount.Size = new System.Drawing.Size(143, 13);
            this.labelTermsCount.TabIndex = 0;
            this.labelTermsCount.Text = "Количество членов ряда = ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_1.Properties.Resources.image_fotor_20250324115517;
            this.pictureBox1.Location = new System.Drawing.Point(275, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 119);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 251);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTermsCount);
            this.Controls.Add(this.labelSumResult);
            this.Controls.Add(this.labelSinResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxEpsilon);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelEpsilon);
            this.Controls.Add(this.labelX);
            this.Name = "Form1";
            this.Text = "Вычисление Sin(x) рядом";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelEpsilon;
        private System.Windows.Forms.TextBox textBoxEpsilon;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelSinResult;
        private System.Windows.Forms.Label labelSumResult;
        private System.Windows.Forms.Label labelTermsCount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}