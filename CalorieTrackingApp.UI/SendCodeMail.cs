using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalorieTrackingApp.DATA.Entities;

namespace CalorieTrackingApp.UI
{
    public partial class SendCodeMail : Form
    {
        public SendCodeMail()
        {
            InitializeComponent();
        }

        Account account;
        public SendCodeMail(Account _account)
        {

            account = _account;
            InitializeComponent();
        }

        Random random;
        string code;
        int second;
        private void SendCodeMail_Load(object sender, EventArgs e)
        {
            random = new Random();
            second = 60;
            btnConfirmation.Enabled = false;

            for (int i = 0; i < 5; i++)
            {
                code += Convert.ToString(random.Next(0, 10));

            }

        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            
            if (txtCode.Text == code)
            {

                SignPassword signPass = new SignPassword(account);
                signPass.MdiParent = (MdiParent as MdiPassword);
                (MdiParent as MdiPassword).Size = new Size(signPass.Width, signPass.Height);
                signPass.FormBorderStyle = FormBorderStyle.None;
                signPass.Dock = DockStyle.Fill;
                signPass.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Yanlış Kod Tekrar Deneyiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second -= 1;
            lblSecond.Text = (second).ToString();

            if (second <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Zamanınız Doldu! Tekrar Gönderiniz");
                btnSend.Enabled = true;
                btnConfirmation.Enabled = false;
                second = 60;
                lblSecond.BackColor = SystemColors.Control;
                lblSecond.Text = (second).ToString();
            }
            else if (second == 15)
            {
                lblSecond.BackColor = Color.Red;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        { 
            (MdiParent as MdiPassword).Close();
        }



        private void SendCode()
        {

            try
            {
                string smtpServer = "smtp.office365.com"; //SMTP sunucusu adresi
                int port = 587; //SMTP sunucusu port numarası
                string senderEmail = "calorietracking@hotmail.com"; //Gönderen e-posta adresi
                string password = "Calorie01"; //Gönderen e-posta hesabının şifresi
                string recipientEmail = account.EMail.Trim(); //Alıcı e-posta adresi

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = "Doğrulama kodu"; //E-posta konusu
                mail.Body = @"
                (        )   (    (                 (                         )  (        )          
   (     (      )\ )  ( /(   )\ ) )\ )        *   ) )\ )    (        (     ( /(  )\ )  ( /(  (       
   )\    )\    (()/(  )\()) (()/((()/( (    ` )  /((()/(    )\       )\    )\())(()/(  )\()) )\ )    
 (((_)((((_)(   /(_))((_)\   /(_))/(_)))\    ( )(_))/(_))((((_)(   (((_) |((_)\  /(_))((_)\ (()/(    
 )\___ )\ _ )\ (_))    ((_) (_)) (_)) ((_)  (_(_())(_))   )\ _ )\  )\___ |_ ((_)(_))   _((_) /(_))_  
((/ __|(_)_\(_)| |    / _ \ | _ \|_ _|| __| |_   _|| _ \  (_)_\(_)((/ __|| |/ / |_ _| | \| |(_)) __| 
 | (__  / _ \  | |__ | (_) ||   / | | | _|    | |  |   /   / _ \   | (__   ' <   | |  | .` |  | (_ | 
  \___|/_/ \_\ |____| \___/ |_|_\|___||___|   |_|  |_|_\  /_/ \_\   \___| _|\_\ |___| |_|\_|   \___| 
                                                                                                     

Dogrulama Kodunuz: " + code; //E-posta içeriği

                SmtpClient smtpClient = new SmtpClient(smtpServer, port);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(senderEmail, password);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("E-posta gönderirken bir hata oluştu: " + ex.Message);
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            SendCode();
            timer1.Start();
            btnSend.Enabled = false;
            btnConfirmation.Enabled = true;

        }
    }
}
