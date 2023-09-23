namespace CalorieTrackingApp.UI
{
    partial class SignUpFillForm
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
            button1 = new Button();
            label6 = new Label();
            dpBirthdate = new DateTimePicker();
            groupBox2 = new GroupBox();
            rbWoman = new RadioButton();
            rbMan = new RadioButton();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lkChancePicture = new LinkLabel();
            label4 = new Label();
            groupBox1 = new GroupBox();
            cmbExercise = new ComboBox();
            label8 = new Label();
            btnSave = new Button();
            nudTargetWeight = new NumericUpDown();
            nudWeightEntry = new NumericUpDown();
            nudHeightEntry = new NumericUpDown();
            pbUserPhoto = new PictureBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTargetWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeightEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeightEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUserPhoto).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(488, 920);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(343, 75);
            button1.TabIndex = 38;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 520);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(223, 24);
            label6.TabIndex = 35;
            label6.Text = "Doğum Tarihinizi Girin:";
            // 
            // dpBirthdate
            // 
            dpBirthdate.Location = new Point(288, 520);
            dpBirthdate.Margin = new Padding(5);
            dpBirthdate.Name = "dpBirthdate";
            dpBirthdate.Size = new Size(244, 33);
            dpBirthdate.TabIndex = 34;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbWoman);
            groupBox2.Controls.Add(rbMan);
            groupBox2.Location = new Point(44, 402);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(430, 84);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cinsiyet";
            // 
            // rbWoman
            // 
            rbWoman.AutoSize = true;
            rbWoman.Location = new Point(273, 38);
            rbWoman.Margin = new Padding(5);
            rbWoman.Name = "rbWoman";
            rbWoman.Size = new Size(106, 28);
            rbWoman.TabIndex = 1;
            rbWoman.TabStop = true;
            rbWoman.Text = "Female";
            rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            rbMan.AutoSize = true;
            rbMan.Location = new Point(80, 38);
            rbMan.Margin = new Padding(5);
            rbMan.Name = "rbMan";
            rbMan.Size = new Size(80, 28);
            rbMan.TabIndex = 0;
            rbMan.TabStop = true;
            rbMan.Text = "Male";
            rbMan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 226);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 24);
            label5.TabIndex = 32;
            label5.Text = "Boyunuzu Girin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 339);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(215, 24);
            label3.TabIndex = 30;
            label3.Text = "Hedef Kilonuzu Girin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 281);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(216, 24);
            label2.TabIndex = 28;
            label2.Text = "Şuanki Kilonuzu Girin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 177);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 26;
            label1.Text = "Kullanıcı Adı";
            // 
            // lkChancePicture
            // 
            lkChancePicture.AutoSize = true;
            lkChancePicture.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lkChancePicture.Location = new Point(339, 88);
            lkChancePicture.Margin = new Padding(5, 0, 5, 0);
            lkChancePicture.Name = "lkChancePicture";
            lkChancePicture.Size = new Size(154, 21);
            lkChancePicture.TabIndex = 25;
            lkChancePicture.TabStop = true;
            lkChancePicture.Text = "Profil Resmi Değiştir";
            lkChancePicture.LinkClicked += lkChancePicture_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(689, -54);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(216, 24);
            label4.TabIndex = 23;
            label4.Text = "Fiziksel Bilgierinizi Girin";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cmbExercise);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(nudTargetWeight);
            groupBox1.Controls.Add(nudWeightEntry);
            groupBox1.Controls.Add(nudHeightEntry);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dpBirthdate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(lkChancePicture);
            groupBox1.Controls.Add(pbUserPhoto);
            groupBox1.Location = new Point(636, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(550, 839);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // cmbExercise
            // 
            cmbExercise.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExercise.Location = new Point(288, 589);
            cmbExercise.Name = "cmbExercise";
            cmbExercise.Size = new Size(244, 32);
            cmbExercise.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 589);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(254, 24);
            label8.TabIndex = 40;
            label8.Text = "Hareket Seviyenizi Seçin:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(173, 695);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(204, 79);
            btnSave.TabIndex = 39;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudTargetWeight
            // 
            nudTargetWeight.DecimalPlaces = 2;
            nudTargetWeight.Location = new Point(354, 337);
            nudTargetWeight.Margin = new Padding(9, 8, 9, 8);
            nudTargetWeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudTargetWeight.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            nudTargetWeight.Name = "nudTargetWeight";
            nudTargetWeight.Size = new Size(120, 33);
            nudTargetWeight.TabIndex = 38;
            nudTargetWeight.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // nudWeightEntry
            // 
            nudWeightEntry.DecimalPlaces = 2;
            nudWeightEntry.Location = new Point(354, 279);
            nudWeightEntry.Margin = new Padding(9, 8, 9, 8);
            nudWeightEntry.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudWeightEntry.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            nudWeightEntry.Name = "nudWeightEntry";
            nudWeightEntry.Size = new Size(120, 33);
            nudWeightEntry.TabIndex = 37;
            nudWeightEntry.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // nudHeightEntry
            // 
            nudHeightEntry.DecimalPlaces = 2;
            nudHeightEntry.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudHeightEntry.Location = new Point(354, 224);
            nudHeightEntry.Margin = new Padding(5);
            nudHeightEntry.Maximum = new decimal(new int[] { 25, 0, 0, 65536 });
            nudHeightEntry.Minimum = new decimal(new int[] { 12, 0, 0, 65536 });
            nudHeightEntry.Name = "nudHeightEntry";
            nudHeightEntry.Size = new Size(120, 33);
            nudHeightEntry.TabIndex = 36;
            nudHeightEntry.Value = new decimal(new int[] { 12, 0, 0, 65536 });
            // 
            // pbUserPhoto
            // 
            pbUserPhoto.Location = new Point(198, 37);
            pbUserPhoto.Margin = new Padding(5);
            pbUserPhoto.Name = "pbUserPhoto";
            pbUserPhoto.Size = new Size(133, 122);
            pbUserPhoto.TabIndex = 24;
            pbUserPhoto.TabStop = false;
            // 
            // SignUpFillForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bacgroundv1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1205, 869);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "SignUpFillForm";
            Text = "Form1";
            FormClosing += SignUpFillForm_FormClosing;
            Load += SignUpFillForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTargetWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeightEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeightEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUserPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private DateTimePicker dpBirthdate;
        private GroupBox groupBox2;
        private RadioButton rbWoman;
        private RadioButton rbMan;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel lkChancePicture;
        private Label label4;
        private GroupBox groupBox1;
        private PictureBox pbUserPhoto;
        private NumericUpDown nudHeightEntry;
        private Button btnSave;
        private NumericUpDown nudTargetWeight;
        private NumericUpDown nudWeightEntry;
        private ComboBox cmbExercise;
        private Label label8;
    }
}