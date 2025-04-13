namespace Pisani_A_Exercise4
{
    partial class LoanCalculatorForm
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPurchasePrice = new TextBox();
            txtDownPayment = new TextBox();
            txtInterestRate = new TextBox();
            txtLoanTerm = new TextBox();
            txtAmountToFinance = new TextBox();
            txtMonthlyPayment = new TextBox();
            btnCalculate = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Purchase Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 132);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Down Payment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 221);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Interest Rate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 309);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Loan Term:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 38);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 4;
            label5.Text = "Amount Financed:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 132);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 5;
            label6.Text = "Monthly Payment:";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(140, 35);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(125, 27);
            txtPurchasePrice.TabIndex = 6;
            // 
            // txtDownPayment
            // 
            txtDownPayment.Location = new Point(140, 129);
            txtDownPayment.Name = "txtDownPayment";
            txtDownPayment.Size = new Size(125, 27);
            txtDownPayment.TabIndex = 7;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(140, 218);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(125, 27);
            txtInterestRate.TabIndex = 8;
            // 
            // txtLoanTerm
            // 
            txtLoanTerm.Location = new Point(140, 306);
            txtLoanTerm.Name = "txtLoanTerm";
            txtLoanTerm.Size = new Size(125, 27);
            txtLoanTerm.TabIndex = 9;
            // 
            // txtAmountToFinance
            // 
            txtAmountToFinance.Location = new Point(572, 35);
            txtAmountToFinance.Name = "txtAmountToFinance";
            txtAmountToFinance.ReadOnly = true;
            txtAmountToFinance.Size = new Size(125, 27);
            txtAmountToFinance.TabIndex = 10;
            // 
            // txtMonthlyPayment
            // 
            txtMonthlyPayment.Location = new Point(572, 129);
            txtMonthlyPayment.Name = "txtMonthlyPayment";
            txtMonthlyPayment.ReadOnly = true;
            txtMonthlyPayment.Size = new Size(125, 27);
            txtMonthlyPayment.TabIndex = 11;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(140, 389);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(572, 389);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // LoanCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnCalculate);
            Controls.Add(txtMonthlyPayment);
            Controls.Add(txtAmountToFinance);
            Controls.Add(txtLoanTerm);
            Controls.Add(txtInterestRate);
            Controls.Add(txtDownPayment);
            Controls.Add(txtPurchasePrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoanCalculatorForm";
            Text = "Alex's Monthly Payment Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPurchasePrice;
        private TextBox txtDownPayment;
        private TextBox txtInterestRate;
        private TextBox txtLoanTerm;
        private TextBox txtAmountToFinance;
        private TextBox txtMonthlyPayment;
        private Button btnCalculate;
        private Button btnClose;
    }
}
