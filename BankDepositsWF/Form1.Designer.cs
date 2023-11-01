namespace BankDepositsWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxInitialAmount = new TextBox();
            textBoxInterestRate = new TextBox();
            numericUpDownYears = new NumericUpDown();
            buttonCalculate = new Button();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYears).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Начальная сумма:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Процентная ставка:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 2;
            label3.Text = "Срок вклада(годы):";
            // 
            // textBoxInitialAmount
            // 
            textBoxInitialAmount.Location = new Point(133, 13);
            textBoxInitialAmount.Name = "textBoxInitialAmount";
            textBoxInitialAmount.Size = new Size(100, 23);
            textBoxInitialAmount.TabIndex = 3;
            // 
            // textBoxInterestRate
            // 
            textBoxInterestRate.Location = new Point(133, 69);
            textBoxInterestRate.Name = "textBoxInterestRate";
            textBoxInterestRate.Size = new Size(100, 23);
            textBoxInterestRate.TabIndex = 4;
            // 
            // numericUpDownYears
            // 
            numericUpDownYears.Location = new Point(131, 119);
            numericUpDownYears.Name = "numericUpDownYears";
            numericUpDownYears.Size = new Size(120, 23);
            numericUpDownYears.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(130, 177);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(378, 77);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(38, 15);
            labelResult.TabIndex = 7;
            labelResult.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 249);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(numericUpDownYears);
            Controls.Add(textBoxInterestRate);
            Controls.Add(textBoxInitialAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownYears).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxInitialAmount;
        private TextBox textBoxInterestRate;
        private NumericUpDown numericUpDownYears;
        private Button buttonCalculate;
        private Label labelResult;
    }
}