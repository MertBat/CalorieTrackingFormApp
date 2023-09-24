namespace CalorieTrackingApp.UI
{
    partial class AddWaterIntake
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnRemove = new Button();
            btnKaydet = new Button();
            label4 = new Label();
            nudAlinanSu = new NumericUpDown();
            label3 = new Label();
            rb1000 = new RadioButton();
            rb500 = new RadioButton();
            rb250 = new RadioButton();
            groupBox6 = new GroupBox();
            lblGunlukSuIcilen = new Label();
            label6 = new Label();
            lblYuzdeSu = new Label();
            label43 = new Label();
            lblGunlukSuHedefKalan = new Label();
            label41 = new Label();
            lblGunlukSuHedef = new Label();
            label39 = new Label();
            waterIntake_progressBar = new ProgressBar();
            label2 = new Label();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAlinanSu).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(578, 667);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRemove);
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(nudAlinanSu);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(rb1000);
            groupBox2.Controls.Add(rb500);
            groupBox2.Controls.Add(rb250);
            groupBox2.Location = new Point(10, 453);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(557, 208);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Su Alımı Ekle";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(33, 144);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(146, 39);
            btnRemove.TabIndex = 49;
            btnRemove.Text = "Sil";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(389, 144);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(146, 39);
            btnKaydet.TabIndex = 48;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 151);
            label4.Name = "label4";
            label4.Size = new Size(20, 24);
            label4.TabIndex = 47;
            label4.Text = "L";
            // 
            // nudAlinanSu
            // 
            nudAlinanSu.DecimalPlaces = 2;
            nudAlinanSu.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            nudAlinanSu.Location = new Point(207, 144);
            nudAlinanSu.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudAlinanSu.Name = "nudAlinanSu";
            nudAlinanSu.Size = new Size(120, 33);
            nudAlinanSu.TabIndex = 46;
            nudAlinanSu.ValueChanged += nudAlinanSu_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(251, 99);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 45;
            label3.Text = "Veya";
            // 
            // rb1000
            // 
            rb1000.AutoSize = true;
            rb1000.Location = new Point(403, 49);
            rb1000.Name = "rb1000";
            rb1000.Size = new Size(57, 28);
            rb1000.TabIndex = 2;
            rb1000.TabStop = true;
            rb1000.Text = "1Lt";
            rb1000.UseVisualStyleBackColor = true;
            // 
            // rb500
            // 
            rb500.AutoSize = true;
            rb500.Location = new Point(223, 49);
            rb500.Name = "rb500";
            rb500.Size = new Size(90, 28);
            rb500.TabIndex = 1;
            rb500.TabStop = true;
            rb500.Text = "500ml";
            rb500.UseVisualStyleBackColor = true;
            // 
            // rb250
            // 
            rb250.AutoSize = true;
            rb250.Location = new Point(44, 49);
            rb250.Name = "rb250";
            rb250.Size = new Size(90, 28);
            rb250.TabIndex = 0;
            rb250.TabStop = true;
            rb250.Text = "250ml";
            rb250.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblGunlukSuIcilen);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(lblYuzdeSu);
            groupBox6.Controls.Add(label43);
            groupBox6.Controls.Add(lblGunlukSuHedefKalan);
            groupBox6.Controls.Add(label41);
            groupBox6.Controls.Add(lblGunlukSuHedef);
            groupBox6.Controls.Add(label39);
            groupBox6.Controls.Add(waterIntake_progressBar);
            groupBox6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(10, 143);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(557, 304);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Su Alım İstatistikleri";
            // 
            // lblGunlukSuIcilen
            // 
            lblGunlukSuIcilen.AutoSize = true;
            lblGunlukSuIcilen.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblGunlukSuIcilen.Location = new Point(94, 129);
            lblGunlukSuIcilen.Name = "lblGunlukSuIcilen";
            lblGunlukSuIcilen.Size = new Size(66, 28);
            lblGunlukSuIcilen.TabIndex = 49;
            lblGunlukSuIcilen.Text = "2.2LT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 133);
            label6.Name = "label6";
            label6.Size = new Size(62, 22);
            label6.TabIndex = 48;
            label6.Text = "İçilen:";
            // 
            // lblYuzdeSu
            // 
            lblYuzdeSu.AutoSize = true;
            lblYuzdeSu.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblYuzdeSu.Location = new Point(256, 234);
            lblYuzdeSu.Name = "lblYuzdeSu";
            lblYuzdeSu.Size = new Size(46, 28);
            lblYuzdeSu.TabIndex = 47;
            lblYuzdeSu.Text = "%0";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(403, 76);
            label43.Name = "label43";
            label43.Size = new Size(124, 21);
            label43.TabIndex = 46;
            label43.Text = "daha içmelisin.";
            // 
            // lblGunlukSuHedefKalan
            // 
            lblGunlukSuHedefKalan.AutoSize = true;
            lblGunlukSuHedefKalan.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblGunlukSuHedefKalan.Location = new Point(317, 68);
            lblGunlukSuHedefKalan.Name = "lblGunlukSuHedefKalan";
            lblGunlukSuHedefKalan.Size = new Size(66, 28);
            lblGunlukSuHedefKalan.TabIndex = 45;
            lblGunlukSuHedefKalan.Text = "2.2LT";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(44, 75);
            label41.Name = "label41";
            label41.Size = new Size(269, 21);
            label41.TabIndex = 44;
            label41.Text = "Bugünkü su hedefine ulaşmak için";
            // 
            // lblGunlukSuHedef
            // 
            lblGunlukSuHedef.AutoSize = true;
            lblGunlukSuHedef.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblGunlukSuHedef.Location = new Point(454, 129);
            lblGunlukSuHedef.Name = "lblGunlukSuHedef";
            lblGunlukSuHedef.Size = new Size(66, 28);
            lblGunlukSuHedef.TabIndex = 43;
            lblGunlukSuHedef.Text = "2.2LT";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label39.Location = new Point(389, 133);
            label39.Name = "label39";
            label39.Size = new Size(71, 22);
            label39.TabIndex = 31;
            label39.Text = "Hedef:";
            // 
            // waterIntake_progressBar
            // 
            waterIntake_progressBar.Location = new Point(29, 164);
            waterIntake_progressBar.Name = "waterIntake_progressBar";
            waterIntake_progressBar.Size = new Size(485, 66);
            waterIntake_progressBar.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 96);
            label2.Name = "label2";
            label2.Size = new Size(59, 24);
            label2.TabIndex = 8;
            label2.Text = "Tarih:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(157, 29);
            label1.Name = "label1";
            label1.Size = new Size(252, 39);
            label1.TabIndex = 7;
            label1.Text = "Su Alımı Kaydet";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(148, 91);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(326, 33);
            dtpDate.TabIndex = 6;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // AddWaterIntake
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 685);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AddWaterIntake";
            Text = "AddWaterIntake";
            Load += AddWaterIntake_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAlinanSu).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDate;
        private GroupBox groupBox6;
        private Label lblYuzdeSu;
        private Label label43;
        private Label lblGunlukSuHedefKalan;
        private Label label41;
        private Label lblGunlukSuHedef;
        private Label label39;
        private ProgressBar waterIntake_progressBar;
        private GroupBox groupBox2;
        private Button btnKaydet;
        private Label label4;
        private NumericUpDown nudAlinanSu;
        private Label label3;
        private RadioButton rb1000;
        private RadioButton rb500;
        private RadioButton rb250;
        private Label lblGunlukSuIcilen;
        private Label label6;
        private Button btnRemove;
    }
}