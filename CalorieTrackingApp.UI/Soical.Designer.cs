namespace CalorieTrackingApp.UI
{
    partial class Soical
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
            topBar_groupBox = new GroupBox();
            pbProfilePictureTop = new PictureBox();
            lblProfileNameTop2 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblProfileNameTop1 = new LinkLabel();
            navigation_groupBox = new GroupBox();
            exit_navbar = new Button();
            button2 = new Button();
            LongReport_navbar = new Button();
            reports_navBtn = new Button();
            mainMenu_navBtn = new Button();
            groupBox1 = new GroupBox();
            txtPostDetail = new RichTextBox();
            lbCounter = new Label();
            btnPost = new Button();
            pbPostPicture = new PictureBox();
            flpPosts = new FlowLayoutPanel();
            topBar_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePictureTop).BeginInit();
            navigation_groupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPostPicture).BeginInit();
            SuspendLayout();
            // 
            // topBar_groupBox
            // 
            topBar_groupBox.Controls.Add(pbProfilePictureTop);
            topBar_groupBox.Controls.Add(lblProfileNameTop2);
            topBar_groupBox.Controls.Add(label2);
            topBar_groupBox.Controls.Add(label1);
            topBar_groupBox.Controls.Add(lblProfileNameTop1);
            topBar_groupBox.Location = new Point(148, 12);
            topBar_groupBox.Name = "topBar_groupBox";
            topBar_groupBox.Size = new Size(1127, 130);
            topBar_groupBox.TabIndex = 4;
            topBar_groupBox.TabStop = false;
            topBar_groupBox.Text = "TopBar";
            // 
            // pbProfilePictureTop
            // 
            pbProfilePictureTop.Location = new Point(808, 20);
            pbProfilePictureTop.Name = "pbProfilePictureTop";
            pbProfilePictureTop.Size = new Size(104, 104);
            pbProfilePictureTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfilePictureTop.TabIndex = 41;
            pbProfilePictureTop.TabStop = false;
            // 
            // lblProfileNameTop2
            // 
            lblProfileNameTop2.AutoSize = true;
            lblProfileNameTop2.Location = new Point(135, 88);
            lblProfileNameTop2.Name = "lblProfileNameTop2";
            lblProfileNameTop2.Size = new Size(17, 24);
            lblProfileNameTop2.TabIndex = 6;
            lblProfileNameTop2.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 88);
            label2.Name = "label2";
            label2.Size = new Size(132, 24);
            label2.TabIndex = 5;
            label2.Text = "Hoş geldiniz,";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(111, 39);
            label1.TabIndex = 4;
            label1.Text = "Sosyal";
            // 
            // lblProfileNameTop1
            // 
            lblProfileNameTop1.AutoSize = true;
            lblProfileNameTop1.LinkBehavior = LinkBehavior.HoverUnderline;
            lblProfileNameTop1.LinkColor = Color.FromArgb(0, 0, 64);
            lblProfileNameTop1.Location = new Point(918, 60);
            lblProfileNameTop1.Name = "lblProfileNameTop1";
            lblProfileNameTop1.Size = new Size(136, 24);
            lblProfileNameTop1.TabIndex = 3;
            lblProfileNameTop1.TabStop = true;
            lblProfileNameTop1.Text = "Kullanıcı Adı";
            lblProfileNameTop1.LinkClicked += lblProfileNameTop1_LinkClicked;
            // 
            // navigation_groupBox
            // 
            navigation_groupBox.Controls.Add(exit_navbar);
            navigation_groupBox.Controls.Add(button2);
            navigation_groupBox.Controls.Add(LongReport_navbar);
            navigation_groupBox.Controls.Add(reports_navBtn);
            navigation_groupBox.Controls.Add(mainMenu_navBtn);
            navigation_groupBox.Location = new Point(9, 14);
            navigation_groupBox.Margin = new Padding(5);
            navigation_groupBox.Name = "navigation_groupBox";
            navigation_groupBox.Padding = new Padding(5);
            navigation_groupBox.Size = new Size(131, 715);
            navigation_groupBox.TabIndex = 3;
            navigation_groupBox.TabStop = false;
            navigation_groupBox.Text = "NavBar";
            // 
            // exit_navbar
            // 
            exit_navbar.BackColor = SystemColors.ButtonFace;
            exit_navbar.Cursor = Cursors.Hand;
            exit_navbar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exit_navbar.ForeColor = SystemColors.ActiveCaptionText;
            exit_navbar.Location = new Point(9, 601);
            exit_navbar.Name = "exit_navbar";
            exit_navbar.Size = new Size(115, 106);
            exit_navbar.TabIndex = 4;
            exit_navbar.Text = "Çıkış Yap";
            exit_navbar.UseVisualStyleBackColor = false;
            exit_navbar.Click += exit_navbar_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(8, 382);
            button2.Name = "button2";
            button2.Size = new Size(115, 106);
            button2.TabIndex = 3;
            button2.Text = "Sosyal";
            button2.UseVisualStyleBackColor = false;
            // 
            // LongReport_navbar
            // 
            LongReport_navbar.BackColor = SystemColors.ButtonFace;
            LongReport_navbar.Cursor = Cursors.Hand;
            LongReport_navbar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LongReport_navbar.ForeColor = SystemColors.ActiveCaptionText;
            LongReport_navbar.Location = new Point(8, 271);
            LongReport_navbar.Name = "LongReport_navbar";
            LongReport_navbar.Size = new Size(115, 106);
            LongReport_navbar.TabIndex = 2;
            LongReport_navbar.Text = "Uzun Vade Raporlar";
            LongReport_navbar.UseVisualStyleBackColor = false;
            LongReport_navbar.Click += LongReport_navbar_Click;
            // 
            // reports_navBtn
            // 
            reports_navBtn.BackColor = SystemColors.ButtonFace;
            reports_navBtn.Cursor = Cursors.Hand;
            reports_navBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reports_navBtn.ForeColor = SystemColors.ActiveCaptionText;
            reports_navBtn.Location = new Point(8, 158);
            reports_navBtn.Name = "reports_navBtn";
            reports_navBtn.Size = new Size(115, 106);
            reports_navBtn.TabIndex = 1;
            reports_navBtn.Text = "Gün Raporu";
            reports_navBtn.UseVisualStyleBackColor = false;
            reports_navBtn.Click += reports_navBtn_Click;
            // 
            // mainMenu_navBtn
            // 
            mainMenu_navBtn.BackColor = SystemColors.ButtonFace;
            mainMenu_navBtn.Cursor = Cursors.Hand;
            mainMenu_navBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainMenu_navBtn.ForeColor = Color.Black;
            mainMenu_navBtn.Location = new Point(8, 46);
            mainMenu_navBtn.Name = "mainMenu_navBtn";
            mainMenu_navBtn.Size = new Size(115, 106);
            mainMenu_navBtn.TabIndex = 0;
            mainMenu_navBtn.Text = "Ana Menü";
            mainMenu_navBtn.UseVisualStyleBackColor = false;
            mainMenu_navBtn.UseWaitCursor = true;
            mainMenu_navBtn.Click += mainMenu_navBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPostDetail);
            groupBox1.Controls.Add(lbCounter);
            groupBox1.Controls.Add(btnPost);
            groupBox1.Controls.Add(pbPostPicture);
            groupBox1.Location = new Point(169, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 415);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Post";
            // 
            // txtPostDetail
            // 
            txtPostDetail.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPostDetail.Location = new Point(24, 212);
            txtPostDetail.MaxLength = 255;
            txtPostDetail.Name = "txtPostDetail";
            txtPostDetail.Size = new Size(368, 114);
            txtPostDetail.TabIndex = 1;
            txtPostDetail.Text = "";
            txtPostDetail.TextChanged += tbPostDetail_TextChanged;
            // 
            // lbCounter
            // 
            lbCounter.BackColor = Color.Transparent;
            lbCounter.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCounter.ForeColor = Color.Black;
            lbCounter.Location = new Point(328, 306);
            lbCounter.Name = "lbCounter";
            lbCounter.Size = new Size(64, 20);
            lbCounter.TabIndex = 3;
            lbCounter.Text = "0/255";
            lbCounter.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnPost
            // 
            btnPost.BackColor = Color.Transparent;
            btnPost.Location = new Point(140, 343);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(132, 52);
            btnPost.TabIndex = 2;
            btnPost.Text = "Paylaş";
            btnPost.UseVisualStyleBackColor = false;
            btnPost.Click += btnPost_Click;
            // 
            // pbPostPicture
            // 
            pbPostPicture.BorderStyle = BorderStyle.FixedSingle;
            pbPostPicture.Cursor = Cursors.Hand;
            pbPostPicture.Location = new Point(77, 53);
            pbPostPicture.Name = "pbPostPicture";
            pbPostPicture.Size = new Size(264, 153);
            pbPostPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPostPicture.TabIndex = 0;
            pbPostPicture.TabStop = false;
            pbPostPicture.Click += pbPostPicture_Click;
            // 
            // flpPosts
            // 
            flpPosts.AutoScroll = true;
            flpPosts.FlowDirection = FlowDirection.RightToLeft;
            flpPosts.Location = new Point(608, 159);
            flpPosts.Name = "flpPosts";
            flpPosts.Size = new Size(656, 570);
            flpPosts.TabIndex = 6;
            // 
            // Soical
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 739);
            Controls.Add(flpPosts);
            Controls.Add(groupBox1);
            Controls.Add(topBar_groupBox);
            Controls.Add(navigation_groupBox);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Soical";
            Text = "Soical";
            Load += Soical_Load;
            topBar_groupBox.ResumeLayout(false);
            topBar_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePictureTop).EndInit();
            navigation_groupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPostPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox topBar_groupBox;
        private PictureBox pbProfilePictureTop;
        private LinkLabel lblProfileNameTop1;
        private GroupBox navigation_groupBox;
        private Button exit_navbar;
        private Button button2;
        private Button LongReport_navbar;
        private Button reports_navBtn;
        private Button mainMenu_navBtn;
        private GroupBox groupBox1;
        private PictureBox pbPostPicture;
        private Button btnPost;
        private RichTextBox txtPostDetail;
        private FlowLayoutPanel flpPosts;
        private Label lbCounter;
        private Label label1;
        private Label lblProfileNameTop2;
        private Label label2;
    }
}