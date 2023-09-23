using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DATA.Entities;
using CalorieTrackingApp.UI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class LongReports : Form
    {
        Account _account;
        FoodRepository foodrep;
        ConsumedFoodRepository consumedFoodrep;
        ConsumedWaterRepository consumedWaterRep;
        WeightHistoryRepository weightHistoryRep;
        public LongReports(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        private void LongReports_Load(object sender, EventArgs e)
        {
            BasicTools.TopDetailFiller(topBar_groupBox.Controls, _account.Id);
            dtpRapor.MaxDate = DateTime.Now.AddDays(-1);
            dtpRapor.MinDate = DateTime.Now.AddDays(-30);
            consumedFoodrep = new ConsumedFoodRepository();
            foodrep = new FoodRepository();
            consumedWaterRep = new ConsumedWaterRepository();
            weightHistoryRep = new WeightHistoryRepository();

        }
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            TimeSpan difference = DateTime.Now - dtpRapor.Value;
            int day = Convert.ToInt32(difference.TotalDays);
            FoodGraph(day);
            WaterGraph(day);
            Weight(day);
        }


        public List<int> ConsumeFoodList(int day)
        {
            List<ConsumedFood> consumedFoods = consumedFoodrep.GetAll().Where(c => c.AccountID == _account.Id && c.ConsumedDate > (DateTime.Now.AddDays(-day))).OrderBy(c => c.ConsumedDate).ToList();
            List<Food> foods = foodrep.GetAll();
            if (consumedFoods.Count == 0) { return null; }
            int dayStoring = consumedFoods[0].ConsumedDate.Day;
            List<int> calories = new List<int>();
            calories.Add(0);
            int counter = 0;

            foreach (ConsumedFood cons in consumedFoods)
            {
                if (dayStoring != cons.ConsumedDate.Day)
                {
                    dayStoring = cons.ConsumedDate.Day;
                    counter++;
                    calories.Add(0);
                }
                calories[counter] += (int)Math.Floor(foods.First(f => f.Id == cons.FoodID).PortionCalorie) * cons.ConsumedCount;
            }
            return calories;
        }


        public void FoodGraph(int day)
        {
            List<int> calories = ConsumeFoodList(day);
            if (calories == null) { return; }
            int width = 40;
            int k = 1;
            foreach (int i in calories)
            {

                int targetNumb = i * 200 / 4000;

                Label lbl = new Label();
                lbl.Size = new Size(10, targetNumb);
                lbl.BackColor = Color.LightGreen;
                lbl.Location = new Point(width, 90 + (150 - targetNumb));
                lbl.BringToFront();
                gbfoodGraph.Controls.Add(lbl);

                Label lbl2 = new Label();
                lbl2.Text = k.ToString();
                lbl2.Size = new Size(30, 15);
                Font newFont = new Font("Arial", 10, FontStyle.Regular);
                lbl2.Font = newFont;
                lbl2.Location = new Point(width - 15, 250);
                lbl2.BringToFront();
                gbfoodGraph.Controls.Add(lbl2);
                width += 35;
                k++;
            }
            label4.SendToBack();
        }

        public List<int> ConsumeWaterList(int day)
        {
            List<ConsumedWater> consumedWater = consumedWaterRep.GetAll().Where(c => c.AccountID == _account.Id && c.ConsumedTime > (DateTime.Now.AddDays(-day))).OrderBy(c => c.ConsumedTime).ToList();
            if (consumedWater.Count == 0) { return null; }
            List<int> miliLiters = new List<int>();
            int dayStoring = consumedWater[0].ConsumedTime.Day;
            miliLiters.Add(0);
            int counter = 0;

            foreach (ConsumedWater cons in consumedWater)
            {
                if (dayStoring != cons.ConsumedTime.Day)
                {
                    dayStoring = cons.ConsumedTime.Day;
                    counter++;
                    miliLiters.Add(0);
                }
                miliLiters[counter] += (int)(cons.Portion * 1000.0);
            }
            return miliLiters;
        }

        public void WaterGraph(int day)
        {
            List<int> miliLiters = ConsumeWaterList(day);
            if (miliLiters == null) { return; }
            int width = 40;
            int k = 1;
            foreach (int i in miliLiters)
            {

                int targetNumb = i * 200 / 4000;

                Label lbl = new Label();
                lbl.Size = new Size(4, targetNumb);
                lbl.BackColor = Color.Blue;
                lbl.Location = new Point(width, 125 + (150 - targetNumb));
                lbl.BringToFront();
                gbWaterGraph.Controls.Add(lbl);

                Label lbl2 = new Label();
                lbl2.Text = k.ToString();
                lbl2.Size = new Size(17, 15);
                Font newFont = new Font("Arial", 6, FontStyle.Regular);
                lbl2.Font = newFont;
                lbl2.Location = new Point(width - 3, 277);
                lbl2.BringToFront();
                gbWaterGraph.Controls.Add(lbl2);
                width += 15;
                k++;
            }
            label15.SendToBack();
        }

        public List<int> WeightValues(int day)
        {
            List<WeightHistory> weightHistories = weightHistoryRep.GetAll().Where(c => c.AccountID == _account.Id && c.WeightDate > (DateTime.Now.AddDays(-day))).OrderBy(c => c.WeightDate).ToList();
            if (weightHistories.Count == 0) { return null; }
            List<int> kgs = new List<int>();
            int dayStoring = 100;

            foreach (WeightHistory cons in weightHistories)
            {
                if (dayStoring != cons.WeightDate.Day)
                {
                    dayStoring = cons.WeightDate.Day;
                    kgs.Add((int)cons.Weight);
                }
            }
            return kgs;
        }

        public void Weight(int day)
        {
            List<int> kgs = WeightValues(day);
            if (kgs == null) { return; }
            int width = 42;
            int k = 1;
            foreach (int i in kgs)
            {

                int targetNumb = i * 200 / 200;

                Label lbl = new Label();
                lbl.Size = new Size(4, targetNumb);
                lbl.BackColor = Color.Gray;
                lbl.Location = new Point(width, 125 + (150 - targetNumb));
                lbl.BringToFront();
                gbWeight.Controls.Add(lbl);

                Label lbl2 = new Label();
                lbl2.Text = k.ToString();
                lbl2.Size = new Size(17, 15);
                Font newFont = new Font("Arial", 6, FontStyle.Regular);
                lbl2.Font = newFont;
                lbl2.Location = new Point(width - 3, 277);
                lbl2.BringToFront();
                gbWeight.Controls.Add(lbl2);
                width += 15;
                k++;
            }
            label29.SendToBack();
        }

        private void exit_navbar_Click(object sender, EventArgs e)
        {
            Navigations.GotoExit(_account, this);
        }

        private void reports_navBtn_Click(object sender, EventArgs e)
        {
            Navigations.GotoDailyReport(_account, this);
        }

        private void social_navbar_Click(object sender, EventArgs e)
        {
            Navigations.GotoSocial(_account, this);
        }

        private void mainMenu_navBtn_Click(object sender, EventArgs e)
        {
            Navigations.GotoMainMenu(_account, this);
        }

        private void lblProfileNameTop1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navigations.GotoProfile(_account, this);

        }
    }
}
