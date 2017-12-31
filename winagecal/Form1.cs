using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winagecal
{
    public partial class Form1 : Form
    {
        int bd, bm, by, cm, cd, cy;
        int ad = 30, am = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutme(object sender, EventArgs e)
        {
            aboutbox ab = new aboutbox();
            ab.ShowDialog(this);
        }

        private void gettoday(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;

            current_year.Text = date.Year.ToString();
            current_month.Text = date.Month.ToString();
            current_day.Text = date.Day.ToString();
        }

        private void reset(object sender, EventArgs e)
        {
            result_show.Text = "";
            birth_day.Text = "1";
            birth_month.Text = "6";
            birth_year.Text = "1994";
            current_day.Text = "14";
            current_month.Text = "4";
            current_year.Text = "2015";
        }

        private void calculate(object sender, EventArgs e)
        {
            int D, M, Y;

            try
            {
                bd = Int32.Parse(birth_day.Text);
                bm = Int32.Parse(birth_month.Text);
                by = Int32.Parse(birth_year.Text);
                cd = Int32.Parse(current_day.Text);
                cm = Int32.Parse(current_month.Text);
                cy = Int32.Parse(current_year.Text);

                if (bd >= 0 && bd <= 31 && bm >= 0 && bm <= 12 && by <= cy && cd <= 31 && cd >= 0 && cm >= 0 && cm <= 12)
                {
                    //Date of age
                    if (cd < bd)
                        D = cd + ad - bd;
                    else
                        D = cd - bd;
                    //Month of age
                    if (cd < bd)
                        bm = bm + 1;
                    if (cm < bm)
                        M = cm + am - bm;
                    else
                        M = cm - bm;
                    //Year of age
                    if (cm < bm)
                        by = by + 1;
                    Y = cy - by;

                    if (Y < 0)
                        result_show.Text = "There is something problem. Check input value again.";
                    else
                        result_show.Text = Y + " Years, " + M + " Months, " + D + " Days";
                }
                else
                    result_show.Text = "Input is incorrect";
            }
            catch (Exception ex) { result_show.Text = ex.Message.ToString(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
