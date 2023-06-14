using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_GuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num;
        int attemptLimit = 6;
        int attempt;

        private void Form1_Load(object sender, EventArgs e)
        {
            int min = 1;
            int max = 20;
            Random rand = new Random();
            num = rand.Next(min, max);
            attempt = 0;
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            try 
            {
                if (attempt < attemptLimit)
                {
                    if (Convert.ToInt32(tb_guess.Text) == num)
                    {
                        lbl_hl.Text = "Congrats you win\nthe number was " + num;
                    }
                    else if (Convert.ToInt32(tb_guess.Text) < num)
                    {
                        attempt++;
                        lbl_hl.Text = "Higher";
                    }
                    else if (Convert.ToInt32(tb_guess.Text) > num)
                    {
                        attempt++;
                        lbl_hl.Text = "Lower";
                    }
                    else
                    {
                        lbl_hl.Text = "Error Code 2";
                    }
                    lbl_attempts.Text = attempt + "/" + attemptLimit;
                }
                else
                {
                    lbl_hl.Text = "Game over\nOut of attempts";
                }
                
            }
            catch
            {
                lbl_hl.Text = "Error Code 1";
            }
        }
    }
}
