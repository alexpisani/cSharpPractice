namespace ATMApp
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
            label4 = new Label();
            txtAccountNumber = new TextBox();
            txtBalance = new TextBox();
            txtTransactionStatus = new TextBox();
            txtAmount = new TextBox();
            rdoDeposit = new RadioButton();
            rdoWithdraw = new RadioButton();
            btnSubmit = new Button();
            btnStatus = new Button();
            btnHistory = new Button();
            btnClose = new Button();
            lstHistory = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 6);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Account Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 1;
            label2.Text = "Account Balance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 2;
            label3.Text = "Transaction Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 92);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Amount:";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(583, 6);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.ReadOnly = true;
            txtAccountNumber.Size = new Size(182, 27);
            txtAccountNumber.TabIndex = 4;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(164, 10);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(266, 27);
            txtBalance.TabIndex = 5;
            // 
            // txtTransactionStatus
            // 
            txtTransactionStatus.Location = new Point(164, 159);
            txtTransactionStatus.Multiline = true;
            txtTransactionStatus.Name = "txtTransactionStatus";
            txtTransactionStatus.ReadOnly = true;
            txtTransactionStatus.Size = new Size(266, 64);
            txtTransactionStatus.TabIndex = 6;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(164, 89);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(266, 27);
            txtAmount.TabIndex = 7;
            // 
            // rdoDeposit
            // 
            rdoDeposit.AutoSize = true;
            rdoDeposit.Checked = true;
            rdoDeposit.Location = new Point(12, 239);
            rdoDeposit.Name = "rdoDeposit";
            rdoDeposit.Size = new Size(82, 24);
            rdoDeposit.TabIndex = 8;
            rdoDeposit.TabStop = true;
            rdoDeposit.Text = "Deposit";
            rdoDeposit.UseVisualStyleBackColor = true;
            // 
            // rdoWithdraw
            // 
            rdoWithdraw.AutoSize = true;
            rdoWithdraw.Location = new Point(164, 239);
            rdoWithdraw.Name = "rdoWithdraw";
            rdoWithdraw.Size = new Size(94, 24);
            rdoWithdraw.TabIndex = 9;
            rdoWithdraw.TabStop = true;
            rdoWithdraw.Text = "Withdraw";
            rdoWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 287);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(164, 287);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(94, 29);
            btnStatus.TabIndex = 11;
            btnStatus.Text = "Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(336, 287);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(94, 29);
            btnHistory.TabIndex = 12;
            btnHistory.Text = "Get History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(671, 362);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.HorizontalScrollbar = true;
            lstHistory.Location = new Point(453, 92);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(312, 224);
            lstHistory.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 403);
            Controls.Add(lstHistory);
            Controls.Add(btnClose);
            Controls.Add(btnHistory);
            Controls.Add(btnStatus);
            Controls.Add(btnSubmit);
            Controls.Add(rdoWithdraw);
            Controls.Add(rdoDeposit);
            Controls.Add(txtAmount);
            Controls.Add(txtTransactionStatus);
            Controls.Add(txtBalance);
            Controls.Add(txtAccountNumber);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bank Account Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAccountNumber;
        private TextBox txtBalance;
        private TextBox txtTransactionStatus;
        private TextBox txtAmount;
        private RadioButton rdoDeposit;
        private RadioButton rdoWithdraw;
        private Button btnSubmit;
        private Button btnStatus;
        private Button btnHistory;
        private Button btnClose;
        private ListBox lstHistory;
    }
}
