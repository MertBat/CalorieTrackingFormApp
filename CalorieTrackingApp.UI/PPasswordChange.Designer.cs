namespace CalorieTrackingApp.UI
{
    partial class PPasswordChange
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
            btnSave = new Button();
            btnBack = new Button();
            txtPass = new TextBox();
            txtNewPass = new TextBox();
            txtNewPass2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pbpass = new PictureBox();
            pbNewPass = new PictureBox();
            pbNewPass2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPass2).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(191, 226);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(74, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Değiştir";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(36, 226);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(74, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(36, 38);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(229, 27);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(36, 104);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(229, 27);
            txtNewPass.TabIndex = 3;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass2
            // 
            txtNewPass2.Location = new Point(36, 168);
            txtNewPass2.Name = "txtNewPass2";
            txtNewPass2.Size = new Size(229, 27);
            txtNewPass2.TabIndex = 4;
            txtNewPass2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 5;
            label1.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 81);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 6;
            label2.Text = "Değiştirilecek şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 145);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 7;
            label3.Text = "şifre tekrar";
            // 
            // pbpass
            // 
            pbpass.BackColor = Color.White;
            pbpass.BackgroundImageLayout = ImageLayout.None;
            pbpass.Image = Properties.Resources.eye;
            pbpass.Location = new Point(243, 42);
            pbpass.Name = "pbpass";
            pbpass.Size = new Size(18, 20);
            pbpass.SizeMode = PictureBoxSizeMode.StretchImage;
            pbpass.TabIndex = 8;
            pbpass.TabStop = false;
            pbpass.MouseDown += pbpass_MouseDown;
            pbpass.MouseUp += pbpass_MouseUp;
            // 
            // pbNewPass
            // 
            pbNewPass.BackColor = Color.White;
            pbNewPass.BackgroundImageLayout = ImageLayout.None;
            pbNewPass.Image = Properties.Resources.eye;
            pbNewPass.Location = new Point(243, 108);
            pbNewPass.Name = "pbNewPass";
            pbNewPass.Size = new Size(18, 20);
            pbNewPass.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNewPass.TabIndex = 9;
            pbNewPass.TabStop = false;
            pbNewPass.MouseDown += pbNewPass_MouseDown;
            pbNewPass.MouseUp += pbNewPass_MouseUp;
            // 
            // pbNewPass2
            // 
            pbNewPass2.BackColor = Color.White;
            pbNewPass2.BackgroundImageLayout = ImageLayout.None;
            pbNewPass2.Image = Properties.Resources.eye;
            pbNewPass2.Location = new Point(243, 172);
            pbNewPass2.Name = "pbNewPass2";
            pbNewPass2.Size = new Size(18, 20);
            pbNewPass2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNewPass2.TabIndex = 10;
            pbNewPass2.TabStop = false;
            pbNewPass2.MouseDown += pbNewPass2_MouseDown;
            pbNewPass2.MouseUp += pbNewPass2_MouseUp;
            // 
            // PPasswordChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 272);
            ControlBox = false;
            Controls.Add(pbNewPass2);
            Controls.Add(pbNewPass);
            Controls.Add(pbpass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPass2);
            Controls.Add(txtNewPass);
            Controls.Add(txtPass);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PPasswordChange";
            Text = "Şifre Değiştir";
            Load += PPasswordChange_Load;
            ((System.ComponentModel.ISupportInitialize)pbpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPass2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnBack;
        private TextBox txtPass;
        private TextBox txtNewPass;
        private TextBox txtNewPass2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pbpass;
        private PictureBox pbNewPass;
        private PictureBox pbNewPass2;
    }
}