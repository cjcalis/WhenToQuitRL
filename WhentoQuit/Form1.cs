using System;
using System.Windows.Forms;

/// <summary>
/// The idea is to allow the user to input a set of starting lives that decrease with each loss
/// and increase based upon a winning streak that the user chooses.
/// </summary>

namespace WhentoQuit
{ 
    public partial class whenToQuit : Form, IDisposable
    {
        int wins;
        int losses;
        int left;
        int streak;
        int currWinStreak;
        int currLossStreak;

        public whenToQuit()
        {
            InitializeComponent();
            
            left = 0;
            streak = 0;
            currWinStreak = 0;
            currLossStreak = 0;
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
            ///<remarks>
            /// Adds 1 to Loss Record.
            /// </remarks>
            losses++;
            lblRecord.Text = wins.ToString() + " : " + losses.ToString();

            lblLivesLeft.Text = (--left).ToString();

            currWinStreak = 0;
            currLossStreak++;

            lblCurrStreak.Text = Convert.ToString(currLossStreak) + " game LOSING streak.";

            if (lblLivesLeft.Text == "-1")
            {
                panel2.Visible = true;
            }
        }
        /// <summary>
        /// Click handler that updates the value and UI for wins and also updates
        /// label text for Lives Left.
        /// </summary>
        private void LblWinClick(object sender, EventArgs e)
        {
            wins++;
            lblRecord.Text = wins.ToString() + " : " + losses.ToString();

            ///<remarks>
            ///Only updates the value of Lives Left if Win has been clicked
            ///the number of times established with Streak
            ///</remarks>
            currLossStreak = 0;
            currWinStreak++;

            lblCurrStreak.Text = Convert.ToString(currWinStreak) + " game WINNING streak.";

            if(currWinStreak % int.Parse(txtStreak.Text) == 0)
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
        /// <summary>
        /// Notifies the user that they are about to click the Win Button
        /// </summary>
        private void LblLossMouseUp(object sender, MouseEventArgs e)
        {
            lblLoss.BackColor = System.Drawing.Color.Red;
        }

        private void BtnRestartClick(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            txtStart.Text = "";
            txtStreak.Text = "";
            streak = 0;            
        }
    }
}
