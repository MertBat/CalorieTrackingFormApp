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
            btnSave.Location = new Point(286, 272);
            btnSave.Margin = new Padding(5, 3, 5, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "Değiştir";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(55, 272);
            btnBack.Margin = new Padding(5, 3, 5, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 35);
            btnBack.TabIndex = 1;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(55, 45);
            txtPass.Margin = new Padding(5, 3, 5, 3);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(342, 33);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(55, 125);
            txtNewPass.Margin = new Padding(5, 3, 5, 3);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(342, 33);
            txtNewPass.TabIndex = 3;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass2
            // 
            txtNewPass2.Location = new Point(55, 202);
            txtNewPass2.Margin = new Padding(5, 3, 5, 3);
            txtNewPass2.Name = "txtNewPass2";
            txtNewPass2.Size = new Size(342, 33);
            txtNewPass2.TabIndex = 4;
            txtNewPass2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 18);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
            label1.TabIndex = 5;
            label1.Text = "Eski Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 98);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 6;
            label2.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 174);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(169, 24);
            label3.TabIndex = 7;
            label3.Text = "Yeni Şifre Tekrar:";
            // 
            // pbpass
            // 
            pbpass.BackColor = Color.White;
            pbpass.BackgroundImageLayout = ImageLayout.None;
            pbpass.Image = Properties.Resources.eye;
            pbpass.Location = new Point(365, 51);
            pbpass.Margin = new Padding(5, 3, 5, 3);
            pbpass.Name = "pbpass";
            pbpass.Size = new Size(27, 24);
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
            pbNewPass.Location = new Point(365, 130);
            pbNewPass.Margin = new Padding(5, 3, 5, 3);
            pbNewPass.Name = "pbNewPass";
            pbNewPass.Size = new Size(27, 24);
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
            pbNewPass2.Location = new Point(365, 206);
            pbNewPass2.Margin = new Padding(5, 3, 5, 3);
            pbNewPass2.Name = "pbNewPass2";
            pbNewPass2.Size = new Size(27, 24);
            pbNewPass2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNewPass2.TabIndex = 10;
            pbNewPass2.TabStop = false;
            pbNewPass2.MouseDown += pbNewPass2_MouseDown;
            pbNewPass2.MouseUp += pbNewPass2_MouseUp;
            // 
            // PPasswordChange
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 326);
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
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 3, 5, 3);
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