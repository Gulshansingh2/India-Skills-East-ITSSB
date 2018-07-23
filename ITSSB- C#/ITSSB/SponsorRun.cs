using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSSB
{
    public partial class SponsorRun : Form
    {
        DateTime dt1;
        MarathonSkills2015Entities mse;
        public SponsorRun()
        {
            InitializeComponent();

            //DB connect
            mse = new MarathonSkills2015Entities();

            // start the timer for no. of days left
            timer1.Start();
            // event date
            dt1 = new DateTime(2018, 9, 5);
            //Title text
            this.Text = "Marathon Skills 2015 - Sponsor a runner";

            donateTxt.Text = "0";

            List<User> runnerDetails = mse.Users.AsEnumerable().Where(a => a.RoleId == "R").ToList();
            for (int i = 0; i < runnerDetails.Count; i++)
            {
                comboBox1.Items.Add(runnerDetails[i].LastName + ", " + runnerDetails[i].LastName);
            }

        }

        private void SponsorRun_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //current datetime
            DateTime dt2 = DateTime.Now;
            //difference between the dates
            String diff = (dt1 - dt2).ToString();
            String[] dateTimeArr = diff.Split('.');
            string days = dateTimeArr[0]; //no. of days

            String[] hoursMinsArr = dateTimeArr[1].Split(':');
            string hours = hoursMinsArr[0]; // no. of hours
            string mins = hoursMinsArr[1]; //no. of minutes

            //set label text to difference
            label17.Text = days + " days " + hours + " hours " + mins + " minutes until the race starts! ";

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int donate = int.Parse(donateTxt.Text);
            donate = donate - 10;

            if (donate >= 0)
            {
                donateTxt.Text = Convert.ToString(donate);
                label14.Text = Convert.ToString("$ " + donate);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            int donate = int.Parse(donateTxt.Text);
            donate = donate + 10;
            
            donateTxt.Text = Convert.ToString(donate);
            label14.Text = Convert.ToString("$ "+donate);

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            string spName = nameTxt.Text;
            //Sponsorship sp1 = mse.Sponsorships.Where(a => a.Sponsorship)
            Sponsorship sp = new Sponsorship();
            sp.SponsorName = spName;
            sp.Amount = Convert.ToDecimal(donateTxt.Text);
            sp.RegistrationId = 80;

            mse.Sponsorships.Add(sp);
            mse.SaveChanges();

            MessageBox.Show("Thankyou, payment was succesful");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
