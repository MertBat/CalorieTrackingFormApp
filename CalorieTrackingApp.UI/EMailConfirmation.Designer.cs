namespace CalorieTrackingApp.UI
{
    partial class EMailConfirmation
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
            btnMail = new Button();
            txtMail = new TextBox();
            label7 = new Label();
            grpUserInformation = new GroupBox();
            lblSecretQuestion = new Label();
            lblUserName = new Label();
            label9 = new Label();
            label5 = new Label();
            txtAnswer = new TextBox();
            lblSecretQues = new Label();
            btnQuestion = new Button();
            grpUserInformation.SuspendLayout();
            SuspendLayout();
            // 
            // btnMail
            // 
            btnMail.Location = new Point(203, 79);
            btnMail.Name = "btnMail";
            btnMail.Size = new Size(105, 33);
            btnMail.TabIndex = 27;
            btnMail.Text = "Sorgula";
            btnMail.UseVisualStyleBackColor = true;
            btnMail.Click += btnMail_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(12, 50);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(296, 23);
            txtMail.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 22);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 25;
            label7.Text = "E-Mail:";
            // 
            // grpUserInformation
            // 
            grpUserInformation.Controls.Add(lblSecretQuestion);
            grpUserInformation.Controls.Add(lblUserName);
            grpUserInformation.Controls.Add(label9);
            grpUserInformation.Controls.Add(label5);
            grpUserInformation.Location = new Point(12, 128);
            grpUserInformation.Name = "grpUserInformation";
            grpUserInformation.Size = new Size(296, 142);
            grpUserInformation.TabIndex = 28;
            grpUserInformation.TabStop = false;
            // 
            // lblSecretQuestion
            // 
            lblSecretQuestion.AutoSize = true;
            lblSecretQuestion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecretQuestion.Location = new Point(7, 95);
            lblSecretQuestion.Name = "lblSecretQuestion";
            lblSecretQuestion.Size = new Size(260, 19);
            lblSecretQuestion.TabIndex = 26;
            lblSecretQuestion.Text = "Gizli Soru Sorusu Buraya Gelecek";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(6, 34);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(107, 19);
            lblUserName.TabIndex = 28;
            lblUserName.Text = "Kullanıcı Adı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ImageAlign = ContentAlignment.BottomLeft;
            label9.Location = new Point(6, 19);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 27;
            label9.Text = "Kullanıcı Adı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 80);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 24;
            label5.Text = "Gizli Soru:";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(109, 284);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(199, 23);
            txtAnswer.TabIndex = 29;
            // 
            // lblSecretQues
            // 
            lblSecretQues.AutoSize = true;
            lblSecretQues.Location = new Point(12, 287);
            lblSecretQues.Name = "lblSecretQues";
            lblSecretQues.Size = new Size(91, 15);
            lblSecretQues.TabIndex = 30;
            lblSecretQues.Text = "Gizli Soru Yanıtı:";
            // 
            // btnQuestion
            // 
            btnQuestion.Location = new Point(203, 313);
            btnQuestion.Name = "btnQuestion";
            btnQuestion.Size = new Size(105, 33);
            btnQuestion.TabIndex = 27;
            btnQuestion.Text = "Sorgula";
            btnQuestion.UseVisualStyleBackColor = true;
            btnQuestion.Click += btnQuestion_Click;
            // 
            // EMailConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 124);
            Controls.Add(lblSecretQues);
            Controls.Add(txtAnswer);
            Controls.Add(grpUserInformation);
            Controls.Add(btnQuestion);
            Controls.Add(btnMail);
            Controls.Add(txtMail);
            Controls.Add(label7);
            Name = "EMailConfirmation";
            Text = "EMailConfirmation";
            Load += EMailConfirmation_Load;
            grpUserInformation.ResumeLayout(false);
            grpUserInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMail;
        private TextBox txtMail;
        private Label label7;
        private GroupBox grpUserInformation;
        private Label lblSecretQuestion;
        private Label lblUserName;
        private Label label9;
        private Label label5;
        private TextBox txtAnswer;
        private Label lblSecretQues;
        private Button btnQuestion;
    }
}