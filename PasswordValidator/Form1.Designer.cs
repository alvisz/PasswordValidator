using System.Drawing;

namespace Homework1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.password = new System.Windows.Forms.TextBox();
            this.cPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.valueLabel1 = new System.Windows.Forms.Label();
            this.hashLabel1 = new System.Windows.Forms.Label();
            this.charCountLabel1 = new System.Windows.Forms.Label();
            this.letterCountLabel1 = new System.Windows.Forms.Label();
            this.digitCountLabel1 = new System.Windows.Forms.Label();
            this.valueLabel2 = new System.Windows.Forms.Label();
            this.hashLabel2 = new System.Windows.Forms.Label();
            this.charCountLabel2 = new System.Windows.Forms.Label();
            this.letterCountLabel2 = new System.Windows.Forms.Label();
            this.digitCountLabel2 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(76, 98);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(217, 26);
            this.password.TabIndex = 0;
            // 
            // cPassword
            // 
            this.cPassword.Location = new System.Drawing.Point(350, 98);
            this.cPassword.Name = "cPassword";
            this.cPassword.Size = new System.Drawing.Size(217, 26);
            this.cPassword.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // valueLabel1
            // 
            this.valueLabel1.AutoSize = true;
            this.valueLabel1.Location = new System.Drawing.Point(72, 144);
            this.valueLabel1.Name = "valueLabel1";
            this.valueLabel1.Size = new System.Drawing.Size(0, 20);
            this.valueLabel1.TabIndex = 3;
            // 
            // hashLabel1
            // 
            this.hashLabel1.AutoSize = true;
            this.hashLabel1.Location = new System.Drawing.Point(72, 178);
            this.hashLabel1.Name = "hashLabel1";
            this.hashLabel1.Size = new System.Drawing.Size(0, 20);
            this.hashLabel1.TabIndex = 4;
            // 
            // charCountLabel1
            // 
            this.charCountLabel1.AutoSize = true;
            this.charCountLabel1.Location = new System.Drawing.Point(72, 212);
            this.charCountLabel1.Name = "charCountLabel1";
            this.charCountLabel1.Size = new System.Drawing.Size(0, 20);
            this.charCountLabel1.TabIndex = 5;
            // 
            // letterCountLabel1
            // 
            this.letterCountLabel1.AutoSize = true;
            this.letterCountLabel1.Location = new System.Drawing.Point(72, 246);
            this.letterCountLabel1.Name = "letterCountLabel1";
            this.letterCountLabel1.Size = new System.Drawing.Size(0, 20);
            this.letterCountLabel1.TabIndex = 6;
            // 
            // digitCountLabel1
            // 
            this.digitCountLabel1.AutoSize = true;
            this.digitCountLabel1.Location = new System.Drawing.Point(72, 280);
            this.digitCountLabel1.Name = "digitCountLabel1";
            this.digitCountLabel1.Size = new System.Drawing.Size(0, 20);
            this.digitCountLabel1.TabIndex = 7;
            // 
            // valueLabel2
            // 
            this.valueLabel2.AutoSize = true;
            this.valueLabel2.Location = new System.Drawing.Point(346, 144);
            this.valueLabel2.Name = "valueLabel2";
            this.valueLabel2.Size = new System.Drawing.Size(0, 20);
            this.valueLabel2.TabIndex = 8;
            // 
            // hashLabel2
            // 
            this.hashLabel2.AutoSize = true;
            this.hashLabel2.Location = new System.Drawing.Point(346, 178);
            this.hashLabel2.Name = "hashLabel2";
            this.hashLabel2.Size = new System.Drawing.Size(0, 20);
            this.hashLabel2.TabIndex = 9;
            // 
            // charCountLabel2
            // 
            this.charCountLabel2.AutoSize = true;
            this.charCountLabel2.Location = new System.Drawing.Point(346, 212);
            this.charCountLabel2.Name = "charCountLabel2";
            this.charCountLabel2.Size = new System.Drawing.Size(0, 20);
            this.charCountLabel2.TabIndex = 10;
            // 
            // letterCountLabel2
            // 
            this.letterCountLabel2.AutoSize = true;
            this.letterCountLabel2.Location = new System.Drawing.Point(346, 246);
            this.letterCountLabel2.Name = "letterCountLabel2";
            this.letterCountLabel2.Size = new System.Drawing.Size(0, 20);
            this.letterCountLabel2.TabIndex = 11;
            // 
            // digitCountLabel2
            // 
            this.digitCountLabel2.AutoSize = true;
            this.digitCountLabel2.Location = new System.Drawing.Point(346, 280);
            this.digitCountLabel2.Name = "digitCountLabel2";
            this.digitCountLabel2.Size = new System.Drawing.Size(0, 20);
            this.digitCountLabel2.TabIndex = 12;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(76, 328);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 20);
            this.warningLabel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter new password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Confirm new password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.digitCountLabel2);
            this.Controls.Add(this.letterCountLabel2);
            this.Controls.Add(this.charCountLabel2);
            this.Controls.Add(this.hashLabel2);
            this.Controls.Add(this.valueLabel2);
            this.Controls.Add(this.digitCountLabel1);
            this.Controls.Add(this.letterCountLabel1);
            this.Controls.Add(this.charCountLabel1);
            this.Controls.Add(this.hashLabel1);
            this.Controls.Add(this.valueLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cPassword);
            this.Controls.Add(this.password);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox cPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label valueLabel1;
        private System.Windows.Forms.Label hashLabel1;
        private System.Windows.Forms.Label charCountLabel1;
        private System.Windows.Forms.Label letterCountLabel1;
        private System.Windows.Forms.Label digitCountLabel1;
        private System.Windows.Forms.Label valueLabel2;
        private System.Windows.Forms.Label hashLabel2;
        private System.Windows.Forms.Label charCountLabel2;
        private System.Windows.Forms.Label letterCountLabel2;
        private System.Windows.Forms.Label digitCountLabel2;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

