using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// The idea is to allow the user to input a set of starting lives that decrease with each loss
/// and increase base upon a winning streak that the user chooses.
/// </summary>

namespace WhentoQuit
{    
    public partial class Form1 : Form, IDisposable
    {
        int wins = 0;
        int losses = 0;
        int left;

        public Form1()
        {
            InitializeComponent();

            left = 0;
        }
        /// <summary>
        /// Saves the users choice of starting lives and streak
        /// Also presents the win/loss UI
        /// </summary>       
        public void btnSave_Click(object sender, EventArgs e)
        {            
            panel1.Visible = true;
            left = int.Parse(txtStart.Text);    
        } 
        /// <summary>
        /// Decreases lives left by 1
        /// Adds 1 loss to the win:loss record
        /// </summary>        
        public void lblLoss_Click(object sender, EventArgs e)
        {            
            losses++;
            lblLosses.Text = losses.ToString();

            lblLeft.Text = (--left).ToString();
                        
        }               
        /// <summary>
        /// Increases lives left by 1
        /// Adds 1 loss to the win:loss record
        /// </summary>
        private void lblWin_Click(object sender, EventArgs e)
        {
            wins++;
            lblWins.Text = wins.ToString();

            lblLeft.Text = (++left).ToString();
        }
        /// <summary>
        /// Notifies the user that they are about to click the Win Button
        /// </summary>
        private void lblWin_MouseDown(object sender, MouseEventArgs e)
        {
            lblWin.BackColor = System.Drawing.Color.Green;
        }

        private void lblWin_MouseUp(object sender, MouseEventArgs e)
        {
            lblWin.BackColor = System.Drawing.Color.Lime;

        }
        /// <summary>
        /// Notifies the user that they are about to click the Loss Button
        /// </summary>
        private void lblLoss_MouseDown(object sender, MouseEventArgs e)
        {
            lblLoss.BackColor = System.Drawing.Color.DarkRed;
        }

        private void lblLoss_MouseUp(object sender, MouseEventArgs e)
        {
            lblLoss.BackColor = System.Drawing.Color.Red;
        }
        /// <summary>
        /// Closes the application
        /// </summary
        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
