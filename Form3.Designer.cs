namespace SimpleBank
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.checkingTxt = new System.Windows.Forms.TextBox();
            this.savingsTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddFunds = new System.Windows.Forms.Button();
            this.TransferFunds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // checkingTxt
            // 
            this.checkingTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.checkingTxt.Location = new System.Drawing.Point(99, 52);
            this.checkingTxt.Name = "checkingTxt";
            this.checkingTxt.ReadOnly = true;
            this.checkingTxt.Size = new System.Drawing.Size(100, 20);
            this.checkingTxt.TabIndex = 1;
            this.checkingTxt.TextChanged += new System.EventHandler(this.checkingTxt_TextChanged);
            // 
            // savingsTxt
            // 
            this.savingsTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.savingsTxt.Location = new System.Drawing.Point(99, 100);
            this.savingsTxt.Name = "savingsTxt";
            this.savingsTxt.ReadOnly = true;
            this.savingsTxt.Size = new System.Drawing.Size(100, 20);
            this.savingsTxt.TabIndex = 2;
            this.savingsTxt.TextChanged += new System.EventHandler(this.savingsTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Checking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Savings";
            // 
            // AddFunds
            // 
            this.AddFunds.Location = new System.Drawing.Point(232, 50);
            this.AddFunds.Name = "AddFunds";
            this.AddFunds.Size = new System.Drawing.Size(96, 23);
            this.AddFunds.TabIndex = 5;
            this.AddFunds.Text = "Add Funds";
            this.AddFunds.UseVisualStyleBackColor = true;
            this.AddFunds.Click += new System.EventHandler(this.AddFunds_Click);
            // 
            // TransferFunds
            // 
            this.TransferFunds.Location = new System.Drawing.Point(232, 98);
            this.TransferFunds.Name = "TransferFunds";
            this.TransferFunds.Size = new System.Drawing.Size(96, 23);
            this.TransferFunds.TabIndex = 6;
            this.TransferFunds.Text = "Transfer Funds";
            this.TransferFunds.UseVisualStyleBackColor = true;
            this.TransferFunds.Click += new System.EventHandler(this.TransferFunds_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 152);
            this.Controls.Add(this.TransferFunds);
            this.Controls.Add(this.AddFunds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.savingsTxt);
            this.Controls.Add(this.checkingTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Bank App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox checkingTxt;
        private System.Windows.Forms.TextBox savingsTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddFunds;
        private System.Windows.Forms.Button TransferFunds;
    }
}