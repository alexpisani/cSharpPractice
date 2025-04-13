namespace Exercise1_Winform
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
            BtnCalculate = new Button();
            BtnExit = new Button();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            txtCostPerSqFt = new TextBox();
            lblLengthPrompt = new Label();
            lblWidthPrompt = new Label();
            lblCostPerSqFt = new Label();
            lblFloorArea = new Label();
            lblInstallationHours = new Label();
            lblMaterialCost = new Label();
            lblTotalCost = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(42, 367);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(229, 29);
            BtnCalculate.TabIndex = 0;
            BtnCalculate.Text = "Calculate Cost";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(341, 367);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(94, 29);
            BtnExit.TabIndex = 1;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(310, 36);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(125, 27);
            txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(310, 82);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 27);
            txtWidth.TabIndex = 3;
            // 
            // txtCostPerSqFt
            // 
            txtCostPerSqFt.Location = new Point(310, 129);
            txtCostPerSqFt.Name = "txtCostPerSqFt";
            txtCostPerSqFt.Size = new Size(125, 27);
            txtCostPerSqFt.TabIndex = 4;
            // 
            // lblLengthPrompt
            // 
            lblLengthPrompt.AutoSize = true;
            lblLengthPrompt.Location = new Point(42, 36);
            lblLengthPrompt.Name = "lblLengthPrompt";
            lblLengthPrompt.Size = new Size(95, 20);
            lblLengthPrompt.TabIndex = 5;
            lblLengthPrompt.Text = "Floor Length:";
            // 
            // lblWidthPrompt
            // 
            lblWidthPrompt.AutoSize = true;
            lblWidthPrompt.Location = new Point(42, 82);
            lblWidthPrompt.Name = "lblWidthPrompt";
            lblWidthPrompt.Size = new Size(90, 20);
            lblWidthPrompt.TabIndex = 6;
            lblWidthPrompt.Text = "Floor Width:";
            // 
            // lblCostPerSqFt
            // 
            lblCostPerSqFt.AutoSize = true;
            lblCostPerSqFt.Location = new Point(42, 129);
            lblCostPerSqFt.Name = "lblCostPerSqFt";
            lblCostPerSqFt.Size = new Size(104, 20);
            lblCostPerSqFt.TabIndex = 7;
            lblCostPerSqFt.Text = "Cost per Sq Ft:";
            // 
            // lblFloorArea
            // 
            lblFloorArea.AutoSize = true;
            lblFloorArea.Location = new Point(310, 213);
            lblFloorArea.Name = "lblFloorArea";
            lblFloorArea.Size = new Size(18, 20);
            lblFloorArea.TabIndex = 8;
            lblFloorArea.Text = "...";
            // 
            // lblInstallationHours
            // 
            lblInstallationHours.AutoSize = true;
            lblInstallationHours.Location = new Point(310, 245);
            lblInstallationHours.Name = "lblInstallationHours";
            lblInstallationHours.Size = new Size(18, 20);
            lblInstallationHours.TabIndex = 9;
            lblInstallationHours.Text = "...";
            // 
            // lblMaterialCost
            // 
            lblMaterialCost.AutoSize = true;
            lblMaterialCost.Location = new Point(310, 276);
            lblMaterialCost.Name = "lblMaterialCost";
            lblMaterialCost.Size = new Size(18, 20);
            lblMaterialCost.TabIndex = 10;
            lblMaterialCost.Text = "...";
            lblMaterialCost.Click += lblMaterialCost_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(310, 311);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(18, 20);
            lblTotalCost.TabIndex = 11;
            lblTotalCost.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 213);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 12;
            label1.Text = "Total Floor Size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 245);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 13;
            label2.Text = "Installation Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 276);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 14;
            label3.Text = "Material Cost:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 311);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 15;
            label4.Text = "Total Cost:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotalCost);
            Controls.Add(lblMaterialCost);
            Controls.Add(lblInstallationHours);
            Controls.Add(lblFloorArea);
            Controls.Add(lblCostPerSqFt);
            Controls.Add(lblWidthPrompt);
            Controls.Add(lblLengthPrompt);
            Controls.Add(txtCostPerSqFt);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(BtnExit);
            Controls.Add(BtnCalculate);
            Name = "Form1";
            Text = "Alex Pisani's Flooring Cost Estimator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalculate;
        private Button BtnExit;
        private TextBox txtLength;
        private TextBox txtWidth;
        private TextBox txtCostPerSqFt;
        private Label lblLengthPrompt;
        private Label lblWidthPrompt;
        private Label lblCostPerSqFt;
        private Label lblFloorArea;
        private Label lblInstallationHours;
        private Label lblMaterialCost;
        private Label lblTotalCost;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
