namespace SimpleBank
{
    partial class Form5
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
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkingLabel = new System.Windows.Forms.Label();
            this.savingLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savingRadio = new System.Windows.Forms.RadioButton();
            this.checkingRadio = new System.Windows.Forms.RadioButton();
            this.amount = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(237, 108);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(123, 108);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Which account would you like to move the money from?";
            // 
            // checkingLabel
            // 
            this.checkingLabel.AutoSize = true;
            this.checkingLabel.Location = new System.Drawing.Point(163, 49);
            this.checkingLabel.Name = "checkingLabel";
            this.checkingLabel.Size = new System.Drawing.Size(34, 13);
            this.checkingLabel.TabIndex = 3;
            this.checkingLabel.Text = "$0.00";
            // 
            // savingLabel
            // 
            this.savingLabel.AutoSize = true;
            this.savingLabel.Location = new System.Drawing.Point(163, 70);
            this.savingLabel.Name = "savingLabel";
            this.savingLabel.Size = new System.Drawing.Size(34, 13);
            this.savingLabel.TabIndex = 4;
            this.savingLabel.Text = "$0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savingRadio);
            this.groupBox1.Controls.Add(this.checkingRadio);
            this.groupBox1.Location = new System.Drawing.Point(52, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // savingRadio
            // 
            this.savingRadio.AutoSize = true;
            this.savingRadio.Location = new System.Drawing.Point(6, 32);
            this.savingRadio.Name = "savingRadio";
            this.savingRadio.Size = new System.Drawing.Size(63, 17);
            this.savingRadio.TabIndex = 1;
            this.savingRadio.TabStop = true;
            this.savingRadio.Text = "Savings";
            this.savingRadio.UseVisualStyleBackColor = true;
            // 
            // checkingRadio
            // 
            this.checkingRadio.AutoSize = true;
            this.checkingRadio.Location = new System.Drawing.Point(6, 11);
            this.checkingRadio.Name = "checkingRadio";
            this.checkingRadio.Size = new System.Drawing.Size(70, 17);
            this.checkingRadio.TabIndex = 0;
            this.checkingRadio.TabStop = true;
            this.checkingRadio.Text = "Checking";
            this.checkingRadio.UseVisualStyleBackColor = true;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(268, 63);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 6;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(272, 47);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(96, 13);
            this.amountLabel.TabIndex = 7;
            this.amountLabel.Text = "Amount to transfer:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 147);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.savingLabel);
            this.Controls.Add(this.checkingLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Name = "Form5";
            this.Text = "Form5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label checkingLabel;
        private System.Windows.Forms.Label savingLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton savingRadio;
        private System.Windows.Forms.RadioButton checkingRadio;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label amountLabel;
    }
}