using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXBall_Game
{
    public partial class Form1 : Form
    {
        public int randVarA, randVarB, timeStart;

        private void timerClock_Tick(object sender, EventArgs e)
        {
            if (timeStart != 0)
            {
                timeStart--;
                lblTimer.Text = timeStart.ToString();
            }
            else //If Clock reaches 0, game should end.
            {
                timerClock.Stop();
                lblTimer.Text= "";
                lblSorF.Text = "Time's Up Loser!";
                btnStart.Enabled = true;
                btnSubmit.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerClock.Enabled = true;
            timerClock.Stop();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            btnStart.Enabled = true;
            if(Convert.ToInt32(txtInput.Text) == (randVarA * randVarB))
            {
                timerClock.Stop();
                lblSorF.Text = "Good job sucker!";
            }
            else
            {
                timerClock.Stop();
                lblSorF.Text = "Dafuq dude! Learn some math";
            }
            txtInput.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timeStart = 5;
            btnStart.Enabled = false;
            btnSubmit.Enabled = true;
            Random random = new Random();
            randVarA = random.Next(25);
            randVarB = random.Next(25);
            lblFirst.Text = randVarA.ToString();
            lblSecond.Text = randVarB.ToString();

            //Timer should start here
            timerClock.Start();

        }
    }
}
