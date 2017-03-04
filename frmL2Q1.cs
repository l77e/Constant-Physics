using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstantPhysics
{
    public partial class frmL2Q1 : Form
    {
        private User theUser;
        private int localTime;
        public frmL2Q1(ref User tempTheUserFrmL2Q1)
        {
            InitializeComponent();
            theUser = tempTheUserFrmL2Q1;
            localTime = theUser.Time;
        }

        private void frmL2Q1_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score:" + theUser.Score;
            txtL2Q1.Text = ConstantPhysics.Properties.Resources.L2Q1;
        }
        private void ScoreAdder()
        {
            int points = localTime + 10;
            theUser.Score += points;
            MessageBox.Show("You have scored " + points + " points!" + "\n Total Time taken: " + (theUser.Time - localTime)+" seconds", "Correct");
        }
        private void Question_Tick(object sender, EventArgs e)
        {
            if (theUser.Time != 0)
            {
                if (localTime != 1)
                {
                    localTime -= 1;
                    lblTime.Text = "Time:" + localTime;
                }
                else
                {
                    localTime = 0;
                    Timer.Enabled = false;
                    MessageBox.Show("Sorry, You're out of time.");
                    nextQuestion();
                }
            }
        }
        private void nextQuestion()
        {
            Form frmL2Q2 = new frmL2Q2(ref theUser);
            frmL2Q2.Show();
            this.Close();
        }

        private void cbbFirstL2Q1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSecondL2Q1.Enabled = true;
            cbbSecondL2Q1.Focus();
        }

        private void cbbSecondL2Q1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbThirdL2Q1.Enabled = true;
            cbbThirdL2Q1.Focus();
        }

        private void cbbThirdL2Q1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSolve.Enabled = true;
            btnSolve.Focus();
        }
        private void errorMessage()
        {
            MessageBox.Show("The Correct answer was Real, Diminished and Inverted Imange", "Sorry, You're answer was incorrect", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            nextQuestion();
        }
        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (cbbFirstL2Q1.Text == "Real")
            {
                if (cbbSecondL2Q1.Text == "Magnified")
                {
                    if (cbbThirdL2Q1.Text == "Inverted Image")
                    {
                        ScoreAdder();
                        nextQuestion();
                    }
                    else errorMessage();
                }
                else errorMessage();
            }
            else
                errorMessage();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            nextQuestion();
        }
    }
}
