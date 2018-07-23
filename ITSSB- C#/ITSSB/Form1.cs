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
    public partial class Form1 : Form
    {
        //variables
        DateTime dt1;

        public Form1()
        {
            InitializeComponent();

            // start the timer for no. of days left
            timer1.Start();
            // event date
            dt1 = new DateTime(2018, 9, 5);
            //Title text
            this.Text = "Marathon Skills 2015";

            label3.SetBounds((this.Size.Width) / 3 - 20, label3.Location.Y, label3.Size.Width, label3.Size.Height);
            //sponserRunner1.Hide();

         
        }

      
        //this will shoot every 1 second
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
            label2.Text = days + " days " + hours + " hours " + mins + " minutes until the race starts! ";


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
       }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sponserRunner1_Load(object sender, EventArgs e)
        {

        }

        private void sponserRunner1_Load_1(object sender, EventArgs e)
        {

        }

        private void sponserRunner1_Load_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SponsorRun spRunner = new SponsorRun();
            spRunner.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            RunnerCheck form1 = new RunnerCheck();
            form1.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            KnowMore form1 = new KnowMore();
            form1.Show();
        }
    }
}
