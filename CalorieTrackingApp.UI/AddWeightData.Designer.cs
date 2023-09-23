namespace CalorieTrackingApp.UI
{
    partial class AddWeightData
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
            label3 = new Label();
            btnKaydet = new Button();
            label4 = new Label();
            nudGuncelKilo = new NumericUpDown();
            groupBox6 = new GroupBox();
            label8 = new Label();
            lblBaslangicKilo = new Label();
            label10 = new Label();
            lblDegisenKilo2 = new Label();
            lblDegisenKilo = new Label();
            label7 = new Label();
            lblHedefeKalanKilo2 = new Label();
            lblHedefeKalanKilo = new Label();
            label41 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuncelKilo).BeginInit();
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 643);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(nudGuncelKilo);
            groupBox2.Location = new Point(24, 412);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(557, 206);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kilo Verisi Ekle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 102);
            label3.Name = "label3";
            label3.Size = new Size(145, 24);
            label3.TabIndex = 53;
            label3.Text = "Güncel Kilon:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(373, 97);
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
            label4.Location = new Point(310, 102);
            label4.Name = "label4";
            label4.Size = new Size(35, 24);
            label4.TabIndex = 47;
            label4.Text = "kg";
            // 
            // nudGuncelKilo
            // 
            nudGuncelKilo.Location = new Point(184, 100);
            nudGuncelKilo.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudGuncelKilo.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            nudGuncelKilo.Name = "nudGuncelKilo";
            nudGuncelKilo.Size = new Size(120, 33);
            nudGuncelKilo.TabIndex = 46;
            nudGuncelKilo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(lblBaslangicKilo);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(lblDegisenKilo2);
            groupBox6.Controls.Add(lblDegisenKilo);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(lblHedefeKalanKilo2);
            groupBox6.Controls.Add(lblHedefeKalanKilo);
            groupBox6.Controls.Add(label41);
            groupBox6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(24, 157);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(557, 236);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Kilo İstatistikleri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(343, 64);
            label8.Name = "label8";
            label8.Size = new Size(31, 21);
            label8.TabIndex = 52;
            label8.Text = "idi.";
            // 
            // lblBaslangicKilo
            // 
            lblBaslangicKilo.AutoSize = true;
            lblBaslangicKilo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaslangicKilo.Location = new Point(269, 56);
            lblBaslangicKilo.Name = "lblBaslangicKilo";
            lblBaslangicKilo.Size = new Size(68, 28);
            lblBaslangicKilo.TabIndex = 51;
            lblBaslangicKilo.Text = "77kg";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(150, 63);
            label10.Name = "label10";
            label10.Size = new Size(122, 21);
            label10.TabIndex = 50;
            label10.Text = "Başlangıç kilon";
            // 
            // lblDegisenKilo2
            // 
            lblDegisenKilo2.AutoSize = true;
            lblDegisenKilo2.Location = new Point(343, 113);
            lblDegisenKilo2.Name = "lblDegisenKilo2";
            lblDegisenKilo2.Size = new Size(63, 21);
            lblDegisenKilo2.TabIndex = 49;
            lblDegisenKilo2.Text = "verdin.";
            // 
            // lblDegisenKilo
            // 
            lblDegisenKilo.AutoSize = true;
            lblDegisenKilo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDegisenKilo.Location = new Point(282, 106);
            lblDegisenKilo.Name = "lblDegisenKilo";
            lblDegisenKilo.Size = new Size(55, 28);
            lblDegisenKilo.TabIndex = 48;
            lblDegisenKilo.Text = "3kg";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(158, 114);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 47;
            label7.Text = "Şu ana kadar";
            // 
            // lblHedefeKalanKilo2
            // 
            lblHedefeKalanKilo2.AutoSize = true;
            lblHedefeKalanKilo2.Location = new Point(343, 163);
            lblHedefeKalanKilo2.Name = "lblHedefeKalanKilo2";
            lblHedefeKalanKilo2.Size = new Size(136, 21);
            lblHedefeKalanKilo2.TabIndex = 46;
            lblHedefeKalanKilo2.Text = "daha vermelisin.";
            // 
            // lblHedefeKalanKilo
            // 
            lblHedefeKalanKilo.AutoSize = true;
            lblHedefeKalanKilo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHedefeKalanKilo.Location = new Point(282, 156);
            lblHedefeKalanKilo.Name = "lblHedefeKalanKilo";
            lblHedefeKalanKilo.Size = new Size(55, 28);
            lblHedefeKalanKilo.TabIndex = 45;
            lblHedefeKalanKilo.Text = "2kg";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(66, 163);
            label41.Name = "label41";
            label41.Size = new Size(206, 21);
            label41.TabIndex = 44;
            label41.Text = "Kilo hedefine ulaşmak için";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 101);
            label2.Name = "label2";
            label2.Size = new Size(59, 24);
            label2.TabIndex = 8;
            label2.Text = "Tarih:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(162, 29);
            label1.Name = "label1";
            label1.Size = new Size(279, 39);
            label1.TabIndex = 7;
            label1.Text = "Kilo Verisi Kaydet";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(162, 96);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(325, 33);
            dtpDate.TabIndex = 6;
            // 
            // AddWeightData
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 673);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AddWeightData";
            Text = "AddWeightData";
            Load += AddWeightData_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuncelKilo).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnKaydet;
        private Label label4;
        private NumericUpDown nudGuncelKilo;
        private GroupBox groupBox6;
        private Label lblHedefeKalanKilo2;
        private Label lblHedefeKalanKilo;
        private Label label41;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDate;
        private Label label3;
        private Label label8;
        private Label lblBaslangicKilo;
        private Label label10;
        private Label lblDegisenKilo2;
        private Label lblDegisenKilo;
        private Label label7;
    }
}