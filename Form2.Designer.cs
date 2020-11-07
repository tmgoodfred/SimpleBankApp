namespace SimpleBank
{
    partial class Form2
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
            this.createUserTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createPassTxt = new System.Windows.Forms.MaskedTextBox();
            this.createPass2Txt = new System.Windows.Forms.MaskedTextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // createUserTxt
            // 
            this.createUserTxt.Location = new System.Drawing.Point(65, 38);
            this.createUserTxt.Name = "createUserTxt";
            this.createUserTxt.Size = new System.Drawing.Size(125, 20);
            this.createUserTxt.TabIndex = 1;
            this.createUserTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.createUserTxt.TextChanged += new System.EventHandler(this.createUserTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // createPassTxt
            // 
            this.createPassTxt.Location = new System.Drawing.Point(64, 84);
            this.createPassTxt.Name = "createPassTxt";
            this.createPassTxt.PasswordChar = '*';
            this.createPassTxt.Size = new System.Drawing.Size(126, 20);
            this.createPassTxt.TabIndex = 3;
            this.createPassTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.createPassTxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.createPassTxt_MaskInputRejected);
            // 
            // createPass2Txt
            // 
            this.createPass2Txt.Location = new System.Drawing.Point(65, 132);
            this.createPass2Txt.Name = "createPass2Txt";
            this.createPass2Txt.PasswordChar = '*';
            this.createPass2Txt.Size = new System.Drawing.Size(125, 20);
            this.createPass2Txt.TabIndex = 4;
            this.createPass2Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.createPass2Txt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.createPass2Txt_MaskInputRejected);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(147, 177);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(75, 23);
            this.createAccountButton.TabIndex = 5;
            this.createAccountButton.Text = "Create";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(42, 177);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Repeat Password";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.createPass2Txt);
            this.Controls.Add(this.createPassTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createUserTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Bank App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox createUserTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox createPassTxt;
        private System.Windows.Forms.MaskedTextBox createPass2Txt;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
    }
}