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
        int wins { get; set; }
        int losses { get; set; }
        int left { get; set; }
        int streak { get; set; }   

        public Form1()
        {
            InitializeComponent();

            left = 0;
            streak = 0;
        }
        /// <summary>
        /// Saves the users choice of starting lives and streak
        /// Also presents the win/loss UI
        /// </summary>       
        public void BtnSaveClick(object sender, EventArgs e)
        {            
            panel1.Visible = true;
            left = int.Parse(txtStart.Text);
            streak = int.Parse(txtStreak.Text);

            lblLivesLeft.Text = left.ToString();

        }
        /// <summary>
        /// Click handler that updates the value and UI for losses and also updates
        /// label text for Lives Left.
        /// </summary>        
        public void LblLossClick(object sender, EventArgs e)
        {            
            losses++;
            lblLosses.Text = losses.ToString();

            lblLivesLeft.Text = (--left).ToString();
                        
        }
        /// <summary>
        /// Click handler that updates the value and UI for wins and also updates
        /// label text for Lives Left.
        /// </summary>
        private void LblWinClick(object sender, EventArgs e)
        {
            wins++;
            lblWins.Text = wins.ToString();            
            ///<remarks>
            ///Only updates the value of Lives Left if Win has been clicked
            ///the number of times established with Streak
            ///</remarks>
            if (wins % streak == 0)
            {
                lblLivesLeft.Text = (++left).ToString();
            }            
        }
        /// <summary>
        /// Notifies the user that they are about to click the Win Button
        /// </summary>
        private void LblWinMouseDown(object sender, MouseEventArgs e)
        {
            lblWin.BackColor = System.Drawing.Color.Green;
        }

        private void LblWinMouseUp(object sender, MouseEventArgs e)
        {
            lblWin.BackColor = System.Drawing.Color.Lime;

        }
        /// <summary>
        /// Notifies the user that they are about to click the Loss Button
        /// </summary>
        private void LblLossMouseDown(object sender, MouseEventArgs e)
        {
            lblLoss.BackColor = System.Drawing.Color.DarkRed;
        }

        private void LblLossMouseUp(object sender, MouseEventArgs e)
        {
            lblLoss.BackColor = System.Drawing.Color.Red;
        }
        /// <summary>
        /// Closes the application
        /// </summary
        private void LblCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void LblCloseMouseEnter(object sender, EventArgs e)
        {
            lblClose.BackColor = System.Drawing.Color.Red;
            lblClose.ForeColor = System.Drawing.Color.White;
        }

        private void LblLeaveMouseEnter(object sender, EventArgs e)
        {
            lblClose.BackColor = System.Drawing.Color.DimGray;
            lblClose.ForeColor = System.Drawing.Color.Gray;
        }
    }
}
