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
    /* CHEWY: Form1 is slightly generic. I would recommend declaritive class name that describes
     * what this class is so when its used in the code, its idetified easier.*/
    public partial class Form1 : Form, IDisposable
    {
        /* CHEWY: I would get in the habit of creating getters and setters for class field members 
            I'm also not sure if they are automatic in C#. Something to look into.
             */
        int wins { get; set; }
        int losses { get; set; }
        int left { get; set; }

        public Form1()
        {
            wins = 0;
            losses = 0;
            InitializeComponent();
            left = 0;
        }

        /// <summary>
        /// Saves the users choice of starting lives and streak
        /// Also presents the win/loss UI
        /// </summary>       
        /* CHEWY: Method names should be PascalCased also no underscores.: BtnSaveClick */
        public void BtnSaveClick(object sender, EventArgs e)
        {            
            panel1.Visible = true;
            left = int.Parse(txtStart.Text);    
        }
        
        /* Chewy: Updated summary to have a sentance structure. */
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
        /// Increases lives left by 1
        /// Adds 1 loss to the win:loss record
        /// </summary>
        private void LblWinClick(object sender, EventArgs e)
        {
            wins++;
            lblWins.Text = wins.ToString();
            lblLivesLeft.Text = (++left).ToString();
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
    }
}
