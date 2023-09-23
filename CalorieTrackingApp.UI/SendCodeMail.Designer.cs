﻿namespace CalorieTrackingApp.UI
{
    partial class SendCodeMail
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
            timer1 = new System.Windows.Forms.Timer(components);
            txtCode = new TextBox();
            btnConfirmation = new Button();
            label3 = new Label();
            lblSecond = new Label();
            btnCancel = new Button();
            btnSend = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(211, 121);
            txtCode.Margin = new Padding(5);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(318, 33);
            txtCode.TabIndex = 1;
            // 
            // btnConfirmation
            // 
            btnConfirmation.Location = new Point(206, 167);
            btnConfirmation.Margin = new Padding(5);
            btnConfirmation.Name = "btnConfirmation";
            btnConfirmation.Size = new Size(165, 51);
            btnConfirmation.TabIndex = 2;
            btnConfirmation.Text = "DOĞRULA";
            btnConfirmation.UseVisualStyleBackColor = true;
            btnConfirmation.Click += btnConfirmation_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 255);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(308, 24);
            label3.TabIndex = 4;
            label3.Text = "Dogrulama İçin Kalan Saniye:";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.BorderStyle = BorderStyle.FixedSingle;
            lblSecond.Location = new Point(398, 255);
            lblSecond.Margin = new Padding(5, 0, 5, 0);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(2, 26);
            lblSecond.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(381, 167);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 51);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "ÇIKIŞ YAP";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(542, 119);
            btnSend.Margin = new Padding(5);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(133, 38);
            btnSend.TabIndex = 6;
            btnSend.Text = "Gönder";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 306);
            label4.Name = "label4";
            label4.Size = new Size(15, 21);
            label4.TabIndex = 16;
            label4.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 48);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(415, 32);
            label1.TabIndex = 17;
            label1.Text = "Maile Gelen Kodu Doğrulayınız";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(126, 119);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 33);
            label2.TabIndex = 18;
            label2.Text = "Kod:";
            // 
            // SendCodeMail
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 336);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(btnSend);
            Controls.Add(lblSecond);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmation);
            Controls.Add(txtCode);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "SendCodeMail";
            Text = "SendCodeMail";
            Load += SendCodeMail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TextBox txtCode;
        private Button btnConfirmation;
        private Label label3;
        private Label lblSecond;
        private Button btnCancel;
        private Button btnSend;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}