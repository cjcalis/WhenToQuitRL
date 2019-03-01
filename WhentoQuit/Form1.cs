using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhentoQuit
{
    public partial class Form1 : Form
    {      
              
        public Form1()
        {
            InitializeComponent();
                        
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lblLeft.Text = txtStart.Text;
        }

        private int losses = 0;
        public int curr = 3;
        
        public void lblLoss_Click(object sender, EventArgs e)
        {            
            losses++;
            lblLosses.Text = losses.ToString();

            curr--;
            lblLeft.Text = curr.ToString();
        }

        private int wins = 0;
        private int streak = 0;

        public void lblWin_Click(object sender, EventArgs e)
        {    
            
            wins++;
            lblWins.Text = wins.ToString();
            curr++;
            streak++;
            if(streak == 2)
            {
                lblLeft.Text = curr.ToString();
            }

            
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblClose_MouseDown(object sender, MouseEventArgs e)
        {
            lblClose.BackColor = System.Drawing.Color.Tomato;
        }

        private void lblClose_MouseUp(object sender, MouseEventArgs e)
        {
            lblClose.BackColor = System.Drawing.Color.Red;
        }
    }
}
