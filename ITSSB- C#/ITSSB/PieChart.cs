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
    public partial class PieChart : Form
    {
        public PieChart()
        {
            InitializeComponent();
        }

        private void PieChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marathonSkills2015DataSet1.Sponsorship' table. You can move, or remove it, as needed.
            this.sponsorshipTableAdapter.Fill(this.marathonSkills2015DataSet1.Sponsorship);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
