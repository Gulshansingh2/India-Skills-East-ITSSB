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
    public partial class Register : Form
    {
        MarathonSkills2015Entities mse;
        DateTime dt1;

        public Register()
        {
            InitializeComponent();
            mse = new MarathonSkills2015Entities();

            this.Text = "Marathon Skills 2015 - Register";

            // start the timer for no. of days left
            timer1.Start();
            // event date
            dt1 = new DateTime(2018, 9, 5);

            genderCmb.Items.Add("Male");
            genderCmb.Items.Add("Female");


            List<Country> country = mse.Countries.AsEnumerable().Where(a => a.CountryName!=null).ToList();
            for (int i = 0; i < country.Count; i++)
            {
                ctryCmb.Items.Add(country[i].CountryName);
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

        private void button3_Click(object sender, EventArgs e)
        {
            User user = mse.Users.Where(a => a.Email == emailTxt.Text).FirstOrDefault();
            if (user == null)
            {
                if (!pwdTxt.Equals(pwdAgainTxt))
                {
                    User user1 = new User();
                    user1.LastName = lNameTxt.Text;
                    user1.Password = pwdAgainTxt.Text;
                    user1.RoleId = "R";
                    user1.FirstName = fNameTxt.Text;
                    user1.Email = emailTxt.Text;

                    Runner runner = new Runner();
                    runner.Email = emailTxt.Text;
                    runner.Gender = genderCmb.SelectedItem.ToString();
                    runner.DateOfBirth = dateTimePicker1.Value;
                    string cntry = ctryCmb.SelectedItem.ToString(); 

                    Country ctry = mse.Countries.Where(a => a.CountryName == cntry).FirstOrDefault();

                    runner.CountryCode = ctry.CountryCode;

                    mse.Users.Add(user1);
                    mse.Runners.Add(runner);
                    mse.SaveChanges();

                    this.Hide();
                    new ThnaxRegister().Show(); 
                        
                }
                else
                {
                    MessageBox.Show("Plz enter same passwords in both the fields");
                }
                
            }
            else
            {
                MessageBox.Show("User already exists");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
