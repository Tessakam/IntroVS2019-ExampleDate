using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            // variabele maken van huidige dag
            DateTime today = DateTime.Now;
            // resultaat tonen in label
            lblOutput.Text = today.ToString();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int year = today.Year;
            lblOutput.Text = year.ToString();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int month = today.Month;
            lblOutput.Text = month.ToString();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            string month = today.ToString("MMMM");
            lblOutput.Text = month;
            // M = enkel cijfer
            // MM = 2 cijfers (7 wordt 07)
            // MMM = 3 letterige afkorting van de maand
            // MMMM = volledige naam van de maand
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            string month = today.ToString("MMM");
            lblOutput.Text = month;
        }

        private void btnWeekday_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            lblOutput.Text = today.DayOfWeek.ToString();
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePickerBirthday.Value;
            TimeSpan age = DateTime.Now - birthday;
            lblOutput.Text = (age.TotalDays / 365).ToString();
        }

        private void lblBirthday_Click(object sender, EventArgs e)
        {

        }

        private void lblMonth_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
