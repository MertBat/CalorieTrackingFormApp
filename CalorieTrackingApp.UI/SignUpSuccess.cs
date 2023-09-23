using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class SignUpSuccess : Form
    {
        public SignUpSuccess()
        {
            InitializeComponent();
        }



        Account account;
        UserDetail userDetail;
        public SignUpSuccess(Account _account, UserDetail _userDetail)
        {

            account = _account;
            userDetail = _userDetail;
            InitializeComponent();
        }


        private void SignUpSuccess_Load(object sender, EventArgs e)
        {
            lblBMI.Text = SignUpFillForm.bmi.ToString();
            lblTargetCalorie.Text = userDetail.TargetWeight.ToString();
            lblRemainingOnTarget.Text = (userDetail.LastWeight - userDetail.TargetWeight).ToString();
            lblStandartCalorie.Text = Math.Round(SignUpFillForm.gunlukKaloriIhtiyaci, 2).ToString();
            lblTargetCalorie.Text = Math.Round(SignUpFillForm.kiloVermeKalorisi, 2).ToString();
            lblTargetWater.Text = userDetail.TargetWaterIntake.ToString();
            lblTargetCalorieDifference.Text = "-500kcal";
            pbUserPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserPhoto.Image = ByteArrayToImage(userDetail.Picture);
            lblUserName.Text = account.Name;

        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new System.IO.MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnLoginScreen_Click(object sender, EventArgs e)
        {


            this.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
