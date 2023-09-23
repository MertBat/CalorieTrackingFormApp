namespace CalorieTrackingApp.UI
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
            btnSend.Location = new Point(289, 54);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(50, 24);
            btnSend.TabIndex = 14;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.BorderStyle = BorderStyle.FixedSingle;
            lblSecond.Location = new Point(187, 139);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(2, 17);
            lblSecond.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 139);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 12;
            label3.Text = "Dogrulama İçin Kalan Saniye:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 56);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 11;
            label2.Text = "Kod:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(195, 84);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 32);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "ÇIKIŞ YAP";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirmation
            // 
            btnConfirmation.Location = new Point(93, 84);
            btnConfirmation.Name = "btnConfirmation";
            btnConfirmation.Size = new Size(96, 32);
            btnConfirmation.TabIndex = 10;
            btnConfirmation.Text = "DOĞRULA";
            btnConfirmation.UseVisualStyleBackColor = true;
            btnConfirmation.Click += btnConfirmation_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(96, 55);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(187, 23);
            txtCode.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(253, 21);
            label1.TabIndex = 7;
            label1.Text = "Maile Gelen Kodu Doğrulayınız!";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // RegisterMailCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 173);
            Controls.Add(btnSend);
            Controls.Add(lblSecond);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmation);
            Controls.Add(txtCode);
            Controls.Add(label1);
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