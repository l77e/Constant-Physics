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
    public partial class frmL2Q3 : Form
    {
        private User theUser;
        private int localTime;
        public frmL2Q3(ref User tempTheUserFrmL2Q3)
        {
            InitializeComponent();
            theUser = tempTheUserFrmL2Q3;
            localTime = theUser.Time;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (txtAnsInput.Text == "hypermetropia")
            {
                ScoreAdder();
                nextQuestion();
            }
            else errorMessage();
        }

        private void frmL2Q3_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + theUser.Score;
            txtL2Q3.Text = ConstantPhysics.Properties.Resources.L2Q3;
        }

        private void txtL1Q1_TextChanged(object sender, EventArgs e)
        {

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
            Form score = new frmScore(ref theUser);
            score.Show();
            this.Close();
        }
        private void errorMessage()
        {
            MessageBox.Show("The Correct answer was hypermetropia", "Sorry, You're answer was incorrect", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            nextQuestion();
        }
        private void ScoreAdder()
        {
            int points = localTime + 10;
            theUser.Score += points;
            MessageBox.Show("You have scored " + points + " points!" + "\n Total Time taken: " + (theUser.Time - localTime) + " seconds", "Correct");
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            nextQuestion();
        }
    }
}
