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
    public partial class Login : Form
    {
        MarathonSkills2015Entities mse;
        DateTime dt1;

        public Login()
        {
            InitializeComponent();
            mse = new MarathonSkills2015Entities();

            this.Text = "Marathon Skills 2015 - Login";

            // start the timer for no. of days left
            timer2.Start();
            // event date
            dt1 = new DateTime(2018, 9, 5);



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = mse.Users.Where(a => a.Email == uNameTxt.Text).FirstOrDefault();
            if(user.Password == pwdTxt.Text)
            {
                this.Hide();
                RunnerMenu form1 = new RunnerMenu();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Details");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
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
            label11.Text = days + " days " + hours + " hours " + mins + " minutes until the race starts! ";
        }
    }
}
