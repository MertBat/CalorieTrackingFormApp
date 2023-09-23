﻿namespace CalorieTrackingApp.UI
{
    partial class AddFoodToSystem
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
            listBox1 = new ListBox();
            label4 = new Label();
            textBox1 = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnNewFoodSave = new Button();
            label1 = new Label();
            txtFoodName = new TextBox();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label5 = new Label();
            numericUpDown4 = new NumericUpDown();
            nudCalorieValue = new NumericUpDown();
            nudProtein = new NumericUpDown();
            label6 = new Label();
            nudFat = new NumericUpDown();
            label7 = new Label();
            nudCarb = new NumericUpDown();
            label9 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCalorieValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProtein).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCarb).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(18, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 565);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yemek Listesi";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(14, 74);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(415, 484);
            listBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 38);
            label4.Name = "label4";
            label4.Size = new Size(159, 24);
            label4.TabIndex = 9;
            label4.Text = "Yemek Arama";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 33);
            textBox1.TabIndex = 8;
            textBox1.Text = "Aranacak Yemek Gir";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Leave += textBox1_Leave;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(257, 601);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 47);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(59, 601);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 47);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNewFoodSave
            // 
            btnNewFoodSave.Location = new Point(680, 604);
            btnNewFoodSave.Name = "btnNewFoodSave";
            btnNewFoodSave.Size = new Size(216, 47);
            btnNewFoodSave.TabIndex = 13;
            btnNewFoodSave.Text = "Sisteme Kaydet";
            btnNewFoodSave.UseVisualStyleBackColor = true;
            btnNewFoodSave.Click += btnNewFoodSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 177);
            label1.Name = "label1";
            label1.Size = new Size(128, 24);
            label1.TabIndex = 2;
            label1.Text = "Yemek Adı:";
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(70, 211);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(413, 33);
            txtFoodName.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(171, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(372, 101);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(111, 21);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Fotoğraf Ekle";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 270);
            label2.Name = "label2";
            label2.Size = new Size(187, 24);
            label2.TabIndex = 6;
            label2.Text = "Standart Porsiyon:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(32226, 32607);
            numericUpDown1.Margin = new Padding(1949, 906, 1949, 906);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45125, 33);
            numericUpDown1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 333);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 10;
            label3.Text = "Kalori:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(2222, 1715);
            numericUpDown2.Margin = new Padding(45, 34, 45, 34);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(1037, 33);
            numericUpDown2.TabIndex = 11;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(2222, 2109);
            numericUpDown3.Margin = new Padding(77, 54, 77, 54);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(1037, 33);
            numericUpDown3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 431);
            label5.Name = "label5";
            label5.Size = new Size(79, 24);
            label5.TabIndex = 13;
            label5.Text = "Protein";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(679, 2710);
            numericUpDown4.Margin = new Padding(132, 86, 132, 86);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(917, 33);
            numericUpDown4.TabIndex = 14;
            // 
            // nudCalorieValue
            // 
            nudCalorieValue.Location = new Point(223, 362);
            nudCalorieValue.Margin = new Padding(5);
            nudCalorieValue.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudCalorieValue.Name = "nudCalorieValue";
            nudCalorieValue.Size = new Size(120, 33);
            nudCalorieValue.TabIndex = 16;
            // 
            // nudProtein
            // 
            nudProtein.DecimalPlaces = 2;
            nudProtein.Location = new Point(53, 463);
            nudProtein.Margin = new Padding(9, 8, 9, 8);
            nudProtein.Name = "nudProtein";
            nudProtein.Size = new Size(118, 33);
            nudProtein.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 431);
            label6.Name = "label6";
            label6.Size = new Size(51, 24);
            label6.TabIndex = 18;
            label6.Text = "Yağ";
            // 
            // nudFat
            // 
            nudFat.DecimalPlaces = 2;
            nudFat.Location = new Point(225, 463);
            nudFat.Margin = new Padding(15, 13, 15, 13);
            nudFat.Name = "nudFat";
            nudFat.Size = new Size(136, 33);
            nudFat.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 431);
            label7.Name = "label7";
            label7.Size = new Size(140, 24);
            label7.TabIndex = 20;
            label7.Text = "Karbonhidrat";
            // 
            // nudCarb
            // 
            nudCarb.DecimalPlaces = 2;
            nudCarb.Location = new Point(407, 463);
            nudCarb.Margin = new Padding(26, 21, 26, 21);
            nudCarb.Name = "nudCarb";
            nudCarb.Size = new Size(122, 33);
            nudCarb.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(248, 270);
            label9.Name = "label9";
            label9.Size = new Size(111, 24);
            label9.TabIndex = 24;
            label9.Text = "100 Gram";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(nudCarb);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(nudFat);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(nudProtein);
            groupBox2.Controls.Add(nudCalorieValue);
            groupBox2.Controls.Add(numericUpDown4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(linkLabel1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(txtFoodName);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(486, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(593, 577);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yeni Yemek Ekle";
            // 
            // AddFoodToSystem
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 662);
            Controls.Add(btnNewFoodSave);
            Controls.Add(groupBox2);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AddFoodToSystem";
            Text = "AddFoodToSystem";
            Load += AddFoodToSystem_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCalorieValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProtein).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCarb).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private Label label4;
        private TextBox textBox1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnNewFoodSave;
        private Label label1;
        private TextBox txtFoodName;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown nudCalorieValue;
        private NumericUpDown nudProtein;
        private Label label6;
        private NumericUpDown nudFat;
        private Label label7;
        private NumericUpDown nudCarb;
        private Label label9;
        private GroupBox groupBox2;
    }
}