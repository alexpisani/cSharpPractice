using System;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class Form1 : Form
    {
        private BankAccount myAccount;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myAccount = new BankAccount("000302019", 1362.59m);
            txtAccountNumber.Text = myAccount.AccountNumber;
            txtBalance.Text = myAccount.GetAccountBalance().ToString("C");
            txtTransactionStatus.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            BankAccount.TransactionStatus result;

            if (rdoDeposit.Checked)
            {
                result = myAccount.Deposit(amount);
            }
            else if (rdoWithdraw.Checked)
            {
                result = myAccount.Withdraw(amount);
            }
            else
            {
                MessageBox.Show("Select Deposit or Withdraw.");
                return;
            }

            txtBalance.Text = myAccount.GetAccountBalance().ToString("C");

            switch (result)
            {
                case BankAccount.TransactionStatus.Ok:
                    txtTransactionStatus.Text = "Transaction Successful.";
                    break;
                case BankAccount.TransactionStatus.Overdrawn:
                    txtTransactionStatus.Text = "Your account is overdrawn. Please make a deposit.";
                    break;
                case BankAccount.TransactionStatus.InsufficientFunds:
                    txtTransactionStatus.Text = "Your account has insufficient funds for this transaction.";
                    break;
                case BankAccount.TransactionStatus.DepositTooLarge:
                    txtTransactionStatus.Text = "The transaction amount is too large and cannot be submitted.";
                    break;
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            var status = myAccount.GetAccountStatus();

            string msg = status == BankAccount.TransactionStatus.Ok ?
                "Your account is in good standing." :
                "Your account is overdrawn.";

            MessageBox.Show(msg, "Account Status");
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
            var history = myAccount.BalanceHistory;
            for (int i = history.Count - 1; i >= 0; i--)
            {
                lstHistory.Items.Add(history[i].ToString("C"));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

