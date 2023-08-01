namespace Profile_Adjustment_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NudStandard = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NudMin = new System.Windows.Forms.NumericUpDown();
            this.CbMiddle = new System.Windows.Forms.CheckBox();
            this.CbPrecision = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbDeviation = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.NudMax = new System.Windows.Forms.NumericUpDown();
            this.CbReverse = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.NudActual = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudStandard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbDeviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudActual)).BeginInit();
            this.SuspendLayout();
            // 
            // NudStandard
            // 
            this.NudStandard.Location = new System.Drawing.Point(12, 48);
            this.NudStandard.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NudStandard.Name = "NudStandard";
            this.NudStandard.Size = new System.Drawing.Size(151, 20);
            this.NudStandard.TabIndex = 0;
            this.NudStandard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudStandard.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudStandard.ValueChanged += new System.EventHandler(this.EnterData_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Standard value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Min value";
            // 
            // NudMin
            // 
            this.NudMin.Location = new System.Drawing.Point(12, 87);
            this.NudMin.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NudMin.Name = "NudMin";
            this.NudMin.Size = new System.Drawing.Size(72, 20);
            this.NudMin.TabIndex = 2;
            this.NudMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudMin.Value = new decimal(new int[] {
            995,
            0,
            0,
            0});
            this.NudMin.ValueChanged += new System.EventHandler(this.EnterData_Changed);
            // 
            // CbMiddle
            // 
            this.CbMiddle.AutoSize = true;
            this.CbMiddle.Location = new System.Drawing.Point(12, 179);
            this.CbMiddle.Name = "CbMiddle";
            this.CbMiddle.Size = new System.Drawing.Size(105, 17);
            this.CbMiddle.TabIndex = 7;
            this.CbMiddle.Text = "Middle the range";
            this.CbMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbMiddle.UseVisualStyleBackColor = true;
            this.CbMiddle.CheckedChanged += new System.EventHandler(this.EnterData_Changed);
            // 
            // CbPrecision
            // 
            this.CbPrecision.AutoSize = true;
            this.CbPrecision.Location = new System.Drawing.Point(12, 202);
            this.CbPrecision.Name = "CbPrecision";
            this.CbPrecision.Size = new System.Drawing.Size(135, 17);
            this.CbPrecision.TabIndex = 8;
            this.CbPrecision.Text = "Precision measurement";
            this.CbPrecision.UseVisualStyleBackColor = true;
            this.CbPrecision.CheckedChanged += new System.EventHandler(this.EnterData_Changed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(194, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // TbDeviation
            // 
            this.TbDeviation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDeviation.Location = new System.Drawing.Point(194, 29);
            this.TbDeviation.Maximum = 30;
            this.TbDeviation.Minimum = -30;
            this.TbDeviation.Name = "TbDeviation";
            this.TbDeviation.Size = new System.Drawing.Size(594, 45);
            this.TbDeviation.TabIndex = 20;
            this.TbDeviation.ValueChanged += new System.EventHandler(this.EnterData_Changed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Max value";
            // 
            // NudMax
            // 
            this.NudMax.Location = new System.Drawing.Point(91, 87);
            this.NudMax.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NudMax.Name = "NudMax";
            this.NudMax.Size = new System.Drawing.Size(72, 20);
            this.NudMax.TabIndex = 21;
            this.NudMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudMax.Value = new decimal(new int[] {
            1005,
            0,
            0,
            0});
            this.NudMax.ValueChanged += new System.EventHandler(this.EnterData_Changed);
            // 
            // CbReverse
            // 
            this.CbReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbReverse.AutoSize = true;
            this.CbReverse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CbReverse.Location = new System.Drawing.Point(722, 6);
            this.CbReverse.Name = "CbReverse";
            this.CbReverse.Size = new System.Drawing.Size(66, 17);
            this.CbReverse.TabIndex = 23;
            this.CbReverse.Text = "Reverse";
            this.CbReverse.UseVisualStyleBackColor = true;
            this.CbReverse.CheckedChanged += new System.EventHandler(this.EnterData_Changed);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Relative";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 129);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(151, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.EnterData_Changed);
            // 
            // NudActual
            // 
            this.NudActual.Location = new System.Drawing.Point(12, 129);
            this.NudActual.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NudActual.Name = "NudActual";
            this.NudActual.Size = new System.Drawing.Size(151, 20);
            this.NudActual.TabIndex = 0;
            this.NudActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudActual.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudActual.ValueChanged += new System.EventHandler(this.EnterData_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Actual value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbReverse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NudMax);
            this.Controls.Add(this.TbDeviation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CbPrecision);
            this.Controls.Add(this.CbMiddle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NudMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NudActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.NudStandard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudStandard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbDeviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudActual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NudStandard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudMin;
        private System.Windows.Forms.CheckBox CbMiddle;
        private System.Windows.Forms.CheckBox CbPrecision;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar TbDeviation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NudMax;
        private System.Windows.Forms.CheckBox CbReverse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown NudActual;
        private System.Windows.Forms.Label label5;
    }
}

