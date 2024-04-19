namespace FindPrimeNumbers.Forms
{
    partial class PrimeNumberCalculator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxClock1 = new System.Windows.Forms.TextBox();
            this.buttonStart1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrimeNumber3 = new System.Windows.Forms.TextBox();
            this.textBoxCycleNumber2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStop2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCycleDur1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCycleWait2 = new System.Windows.Forms.NumericUpDown();
            this.buttonSave3 = new System.Windows.Forms.Button();
            this.textBoxSaveLoc4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycleDur1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycleWait2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxClock1
            // 
            this.textBoxClock1.Location = new System.Drawing.Point(181, 49);
            this.textBoxClock1.Name = "textBoxClock1";
            this.textBoxClock1.ReadOnly = true;
            this.textBoxClock1.Size = new System.Drawing.Size(100, 20);
            this.textBoxClock1.TabIndex = 0;
            this.textBoxClock1.Text = "0";
            this.textBoxClock1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonStart1
            // 
            this.buttonStart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart1.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonStart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart1.Location = new System.Drawing.Point(713, 409);
            this.buttonStart1.Name = "buttonStart1";
            this.buttonStart1.Size = new System.Drawing.Size(75, 29);
            this.buttonStart1.TabIndex = 1;
            this.buttonStart1.Text = "Start";
            this.buttonStart1.UseVisualStyleBackColor = false;
            this.buttonStart1.Click += new System.EventHandler(this.buttonStart1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elapsed time (s)";
            // 
            // textBoxPrimeNumber3
            // 
            this.textBoxPrimeNumber3.Location = new System.Drawing.Point(181, 82);
            this.textBoxPrimeNumber3.Name = "textBoxPrimeNumber3";
            this.textBoxPrimeNumber3.ReadOnly = true;
            this.textBoxPrimeNumber3.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrimeNumber3.TabIndex = 4;
            this.textBoxPrimeNumber3.Text = "0";
            this.textBoxPrimeNumber3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCycleNumber2
            // 
            this.textBoxCycleNumber2.Location = new System.Drawing.Point(181, 15);
            this.textBoxCycleNumber2.Name = "textBoxCycleNumber2";
            this.textBoxCycleNumber2.ReadOnly = true;
            this.textBoxCycleNumber2.Size = new System.Drawing.Size(100, 20);
            this.textBoxCycleNumber2.TabIndex = 5;
            this.textBoxCycleNumber2.Text = "1";
            this.textBoxCycleNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current cycle";
            // 
            // buttonStop2
            // 
            this.buttonStop2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop2.BackColor = System.Drawing.Color.Moccasin;
            this.buttonStop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop2.Location = new System.Drawing.Point(600, 409);
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.Size = new System.Drawing.Size(75, 29);
            this.buttonStop2.TabIndex = 7;
            this.buttonStop2.Text = "Stop";
            this.buttonStop2.UseVisualStyleBackColor = false;
            this.buttonStop2.Click += new System.EventHandler(this.buttonStop2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Funded prime number";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Wait duration";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cycle duration";
            // 
            // numericUpDownCycleDur1
            // 
            this.numericUpDownCycleDur1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCycleDur1.Location = new System.Drawing.Point(686, 18);
            this.numericUpDownCycleDur1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownCycleDur1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCycleDur1.Name = "numericUpDownCycleDur1";
            this.numericUpDownCycleDur1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownCycleDur1.TabIndex = 13;
            this.numericUpDownCycleDur1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCycleDur1.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // numericUpDownCycleWait2
            // 
            this.numericUpDownCycleWait2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCycleWait2.Location = new System.Drawing.Point(686, 51);
            this.numericUpDownCycleWait2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownCycleWait2.Name = "numericUpDownCycleWait2";
            this.numericUpDownCycleWait2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownCycleWait2.TabIndex = 14;
            this.numericUpDownCycleWait2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCycleWait2.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // buttonSave3
            // 
            this.buttonSave3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave3.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonSave3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave3.Location = new System.Drawing.Point(12, 409);
            this.buttonSave3.Name = "buttonSave3";
            this.buttonSave3.Size = new System.Drawing.Size(123, 29);
            this.buttonSave3.TabIndex = 15;
            this.buttonSave3.Text = "Save localization";
            this.buttonSave3.UseVisualStyleBackColor = false;
            this.buttonSave3.Click += new System.EventHandler(this.buttonSave3_Click);
            // 
            // textBoxSaveLoc4
            // 
            this.textBoxSaveLoc4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaveLoc4.Location = new System.Drawing.Point(150, 414);
            this.textBoxSaveLoc4.Name = "textBoxSaveLoc4";
            this.textBoxSaveLoc4.ReadOnly = true;
            this.textBoxSaveLoc4.Size = new System.Drawing.Size(401, 20);
            this.textBoxSaveLoc4.TabIndex = 16;
            // 
            // PrimeNumberCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSaveLoc4);
            this.Controls.Add(this.buttonSave3);
            this.Controls.Add(this.numericUpDownCycleWait2);
            this.Controls.Add(this.numericUpDownCycleDur1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCycleNumber2);
            this.Controls.Add(this.textBoxPrimeNumber3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStart1);
            this.Controls.Add(this.textBoxClock1);
            this.Name = "PrimeNumberCalculator";
            this.Text = "PrimeNumberCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycleDur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycleWait2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxClock1;
        private System.Windows.Forms.Button buttonStart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrimeNumber3;
        private System.Windows.Forms.TextBox textBoxCycleNumber2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStop2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCycleDur1;
        private System.Windows.Forms.NumericUpDown numericUpDownCycleWait2;
        private System.Windows.Forms.Button buttonSave3;
        private System.Windows.Forms.TextBox textBoxSaveLoc4;
    }
}

