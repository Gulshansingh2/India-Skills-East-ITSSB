﻿using System;
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
    public partial class KnowMore : Form
    {
        //variables
        DateTime dt1;

        public KnowMore()
        {
            InitializeComponent();

            // start the timer for no. of days left
            timer2.Start();
            // event date
            dt1 = new DateTime(2018, 9, 5);
            //Title text
            this.Text = "Marathon Skills 2015 - Know More";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PieChart().Show();
        }
    }
}
