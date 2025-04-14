using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    public class BankAccount
    {
        // sets up enumeration
        public enum TransactionStatus
        {
            Ok,
            Overdrawn,
            InsufficientFunds,
            DepositTooLarge
        }

        
        private decimal _balance;

        
        public string AccountNumber { get; }

        
        public List<decimal> BalanceHistory { get; private set; }

        // constructor
        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            _balance = initialBalance;
            BalanceHistory = new List<decimal> { _balance };
        }

        // deposit method
        public TransactionStatus Deposit(decimal amount)
        {
            if (amount > 10000)
                return TransactionStatus.DepositTooLarge;

            _balance += amount;
            BalanceHistory.Add(_balance);
            return TransactionStatus.Ok;
        }

        // withdraw method
        public TransactionStatus Withdraw(decimal amount)
        {
            decimal projectedBalance = _balance - amount;

            if (projectedBalance >= 0)
            {
                _balance = projectedBalance;
                BalanceHistory.Add(_balance);
                return TransactionStatus.Ok;
            }
            else if (projectedBalance >= -100)
            {
                _balance = projectedBalance - 35.75m; // Overdraft fee for fun (actually not fun for the payer)
                BalanceHistory.Add(_balance);
                return TransactionStatus.Overdrawn;
            }
            else
            {
                return TransactionStatus.InsufficientFunds;
            }
        }

        
        public decimal GetAccountBalance()
        {
            return _balance;
        }

        
        public TransactionStatus GetAccountStatus()
        {
            return _balance < 0 ? TransactionStatus.Overdrawn : TransactionStatus.Ok;
        }
    }
}