namespace CalorieTrackingApp.UI
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
            label1 = new Label();
            txtCode = new TextBox();
            btnConfirmation = new Button();
            label2 = new Label();
            label3 = new Label();
            lblSecond = new Label();
            btnCancel = new Button();
            btnSend = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 22);
            label1.Name = "label1";
            label1.Size = new Size(253, 21);
            label1.TabIndex = 0;
            label1.Text = "Maile Gelen Kodu Doğrulayınız!";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(94, 61);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(187, 23);
            txtCode.TabIndex = 1;
            // 
            // btnConfirmation
            // 
            btnConfirmation.Location = new Point(91, 90);
            btnConfirmation.Name = "btnConfirmation";
            btnConfirmation.Size = new Size(96, 32);
            btnConfirmation.TabIndex = 2;
            btnConfirmation.Text = "DOĞRULA";
            btnConfirmation.UseVisualStyleBackColor = true;
            btnConfirmation.Click += btnConfirmation_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 62);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 3;
            label2.Text = "Kod:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 4;
            label3.Text = "Dogrulama İçin Kalan Saniye:";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.BorderStyle = BorderStyle.FixedSingle;
            lblSecond.Location = new Point(185, 145);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(2, 17);
            lblSecond.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(193, 90);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 32);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "ÇIKIŞ YAP";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(287, 60);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(50, 24);
            btnSend.TabIndex = 6;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // SendCodeMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 179);
            Controls.Add(btnSend);
            Controls.Add(lblSecond);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmation);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Name = "SendCodeMail";
            Text = "SendCodeMail";
            Load += SendCodeMail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TextBox txtCode;
        private Button btnConfirmation;
        private Label label2;
        private Label label3;
        private Label lblSecond;
        private Button btnCancel;
        private Button btnSend;
    }
}