namespace Pisani_A_Exercise5
{
    partial class PlayfairCipher
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
            btnTranslate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtKeyword = new TextBox();
            txtText = new TextBox();
            txtResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(33, 270);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(94, 29);
            btnTranslate.TabIndex = 0;
            btnTranslate.Text = "Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(185, 270);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(571, 270);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Close";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(185, 12);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(480, 27);
            txtKeyword.TabIndex = 3;
            // 
            // txtText
            // 
            txtText.Location = new Point(185, 57);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(480, 67);
            txtText.TabIndex = 4;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(185, 149);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(480, 67);
            txtResult.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 12);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 6;
            label1.Text = "Secret Word:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 57);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 7;
            label2.Text = "Input Text:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 149);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 8;
            label3.Text = "Output Text:";
            // 
            // PlayfairCipher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 340);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(txtText);
            Controls.Add(txtKeyword);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnTranslate);
            Name = "PlayfairCipher";
            Text = "Code Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTranslate;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtKeyword;
        private TextBox txtText;
        private TextBox txtResult;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
