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
    public partial class RegisterEvent : Form
    {
        DateTime dt1;
        MarathonSkills2015Entities mse;
        public RegisterEvent()
        {
            InitializeComponent();

            //DB connect
            mse = new MarathonSkills2015Entities();

            // start the timer for no. of days left
            timer1.Start();
            // event date
            dt1 = new DateTime(2018, 9, 5);
            //Title text
            this.Text = "Marathon Skills 2015 - Register for an event";


            List<Charity> charityNames = mse.Charities.AsEnumerable().Where(a => a.CharityName != null ).ToList();
            for (int i = 0; i < charityNames.Count; i++)
            {
                comboBox1.Items.Add(charityNames[i].CharityName);
            }


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
            int totCost = 0;
            if (ckb1.Checked)
                totCost += 145;
            if (ckb2.Checked)
                totCost += 75;
            if (ckb3.Checked)
                totCost += 20;

            if (radioButton1.Checked)
                totCost += 0;
            if (radioButton2.Checked)
                totCost += 20;
            if (radioButton3.Checked)
                totCost += 45;


            if (int.Parse(targetTxt.Text) > 0)
            {
                

            }
            else
            {
                MessageBox.Show("Target should be a valid positive number");
            }
            lblCost.Text = totCost.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void donateTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CVCTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void expYearTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void expMonthTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void creditCardTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cardNameTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nameTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void RegisterEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
