﻿namespace CalorieTrackingApp.UI
{
    partial class RegisterMailCode
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
            components = new System.ComponentModel.Container();
            btnSend = new Button();
            lblSecond = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnConfirmation = new Button();
            txtCode = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(475, 107);
            btnSend.Margin = new Padding(5, 5, 5, 5);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(149, 34);
            btnSend.TabIndex = 14;
            btnSend.Text = "Gönder";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.BorderStyle = BorderStyle.FixedSingle;
            lblSecond.Location = new Point(418, 234);
            lblSecond.Margin = new Padding(5, 0, 5, 0);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(2, 26);
            lblSecond.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 234);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(308, 24);
            label3.TabIndex = 12;
            label3.Text = "Dogrulama İçin Kalan Saniye:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 108);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 11;
            label2.Text = "Kod:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(319, 154);
            btnCancel.Margin = new Padding(5, 5, 5, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 51);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "ÇIKIŞ YAP";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirmation
            // 
            btnConfirmation.Location = new Point(144, 154);
            btnConfirmation.Margin = new Padding(5, 5, 5, 5);
            btnConfirmation.Name = "btnConfirmation";
            btnConfirmation.Size = new Size(164, 51);
            btnConfirmation.TabIndex = 10;
            btnConfirmation.Text = "DOĞRULA";
            btnConfirmation.UseVisualStyleBackColor = true;
            btnConfirmation.Click += btnConfirmation_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(148, 107);
            txtCode.Margin = new Padding(5, 5, 5, 5);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(317, 33);
            txtCode.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(415, 32);
            label1.TabIndex = 7;
            label1.Text = "Maile Gelen Kodu Doğrulayınız";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // RegisterMailCode
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 321);
            Controls.Add(btnSend);
            Controls.Add(lblSecond);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmation);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "RegisterMailCode";
            Text = "RegisterMailCode";
            Load += RegisterMailCode_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label lblSecond;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnConfirmation;
        private TextBox txtCode;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}