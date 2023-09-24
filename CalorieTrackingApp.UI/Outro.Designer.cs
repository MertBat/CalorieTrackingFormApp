namespace CalorieTrackingApp.UI
{
    partial class Outro
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
            pictureBox2 = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.witch_hat;
            pictureBox2.Location = new Point(846, 425);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Chiller", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SandyBrown;
            label4.Location = new Point(567, 449);
            label4.Name = "label4";
            label4.Size = new Size(438, 76);
            label4.TabIndex = 16;
            label4.Text = " CalorieWiz    ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.giphy;
            pictureBox1.Location = new Point(204, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(636, 636);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Outro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1208, 792);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Outro";
            Text = "Outro";
            Load += Outro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label4;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}