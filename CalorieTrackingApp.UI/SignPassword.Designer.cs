namespace CalorieTrackingApp.UI
{
    partial class SignPassword
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
            grpPassword = new GroupBox();
            lblPassStatus = new Label();
            prbPassStr = new ProgressBar();
            txtSignUpPassRepeat = new TextBox();
            label3 = new Label();
            txtSignUpPass1 = new TextBox();
            label2 = new Label();
            btnPassReset = new Button();
            grpPassword.SuspendLayout();
            SuspendLayout();
            // 
            // grpPassword
            // 
            grpPassword.Controls.Add(lblPassStatus);
            grpPassword.Controls.Add(prbPassStr);
            grpPassword.Controls.Add(txtSignUpPassRepeat);
            grpPassword.Controls.Add(label3);
            grpPassword.Controls.Add(txtSignUpPass1);
            grpPassword.Controls.Add(label2);
            grpPassword.Location = new Point(16, 14);
            grpPassword.Name = "grpPassword";
            grpPassword.Size = new Size(347, 193);
            grpPassword.TabIndex = 26;
            grpPassword.TabStop = false;
            // 
            // lblPassStatus
            // 
            lblPassStatus.AutoSize = true;
            lblPassStatus.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassStatus.Location = new Point(8, 153);
            lblPassStatus.Name = "lblPassStatus";
            lblPassStatus.Size = new Size(14, 20);
            lblPassStatus.TabIndex = 20;
            lblPassStatus.Text = "-";
            // 
            // prbPassStr
            // 
            prbPassStr.Location = new Point(7, 127);
            prbPassStr.Name = "prbPassStr";
            prbPassStr.Size = new Size(319, 18);
            prbPassStr.TabIndex = 19;
            // 
            // txtSignUpPassRepeat
            // 
            txtSignUpPassRepeat.Location = new Point(6, 89);
            txtSignUpPassRepeat.Name = "txtSignUpPassRepeat";
            txtSignUpPassRepeat.Size = new Size(320, 23);
            txtSignUpPassRepeat.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 17;
            label3.Text = "Şifre Tekrarı:";
            // 
            // txtSignUpPass1
            // 
            txtSignUpPass1.Location = new Point(6, 34);
            txtSignUpPass1.Name = "txtSignUpPass1";
            txtSignUpPass1.Size = new Size(320, 23);
            txtSignUpPass1.TabIndex = 1;
            txtSignUpPass1.TextChanged += txtSignUpPass1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 16);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 15;
            label2.Text = "Şifre:";
            // 
            // btnPassReset
            // 
            btnPassReset.Location = new Point(173, 213);
            btnPassReset.Name = "btnPassReset";
            btnPassReset.Size = new Size(190, 32);
            btnPassReset.TabIndex = 3;
            btnPassReset.Text = "ŞİFREYİ SIFIRLA";
            btnPassReset.UseVisualStyleBackColor = true;
            btnPassReset.Click += btnPassReset_Click;
            // 
            // SignPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 259);
            Controls.Add(btnPassReset);
            Controls.Add(grpPassword);
            Name = "SignPassword";
            Text = "SignPassword";
            Load += SignPassword_Load;
            grpPassword.ResumeLayout(false);
            grpPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPassword;
        private Label lblPassStatus;
        private ProgressBar prbPassStr;
        private TextBox txtSignUpPassRepeat;
        private Label label3;
        private TextBox txtSignUpPass1;
        private Label label2;
        private Button btnPassReset;
    }
}