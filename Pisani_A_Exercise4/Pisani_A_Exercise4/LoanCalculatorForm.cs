using System;
using System.Windows.Forms;

namespace Pisani_A_Exercise4
{
    public partial class LoanCalculatorForm : Form
    {
        public LoanCalculatorForm()
        {
            InitializeComponent();
        }

        // Declare variables globally, outside of the validation blocks
        double purchasePrice, downPayment, annualInterestRate;
        int loanTerm;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clears text boxes
            txtMonthlyPayment.Text = "";
            txtAmountToFinance.Text = "";

            // Validates required fields
            if (string.IsNullOrEmpty(txtPurchasePrice.Text) || !double.TryParse(txtPurchasePrice.Text, out purchasePrice) || purchasePrice <= 0)
            {
                MessageBox.Show("Please enter a valid purchase price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtDownPayment.Text) || !double.TryParse(txtDownPayment.Text, out downPayment) || downPayment < 0)
            {
                MessageBox.Show("Please enter a valid down payment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtInterestRate.Text) || !double.TryParse(txtInterestRate.Text, out annualInterestRate) || annualInterestRate <= 0)
            {
                MessageBox.Show("Please enter a valid interest rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtLoanTerm.Text) || !int.TryParse(txtLoanTerm.Text, out loanTerm) || loanTerm <= 0)
            {
                MessageBox.Show("Please enter a valid loan term in months.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate amount to finance (Purchase Price - Down Payment)
            double loanAmount = purchasePrice - downPayment;
            txtAmountToFinance.Text = loanAmount.ToString("C");

            // Convert the annual interest rate to a monthly interest rate
            double monthlyInterestRate = annualInterestRate / 100 / 12;

            // Calculate the monthly payment
            double monthlyPayment;
            if (monthlyInterestRate == 0)
            {
                // No interest calculation
                monthlyPayment = loanAmount / loanTerm;
            }
            else
            {
                // Standard calculation
                monthlyPayment = loanAmount * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, loanTerm)) /
                                 (Math.Pow(1 + monthlyInterestRate, loanTerm) - 1);
            }

            // Display the result as currency
            txtMonthlyPayment.Text = monthlyPayment.ToString("C");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

    }
}