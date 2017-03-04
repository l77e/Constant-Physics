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
    public partial class frmL1Q1 : Form
    {
        private User theUser;
        private Random n = new Random();
        int angle;
        int velocity;
        int localTime;
        public frmL1Q1(ref User tempUserFrmL1Q1)
        {
            InitializeComponent();
            theUser = tempUserFrmL1Q1;
            localTime = theUser.Time;
        }
        
        private void frmL1Q1_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score:" + theUser.Score;
            angle = n.Next(3, 89);
            velocity = n.Next(1, 1000);
            txtL1Q1.Text = "A ball is projected at " + angle + " degrees at " + velocity + "m/s, what was the distance horizontaly?";
            lblAngle.Text = angle + "°";
            lblVelocity.Text = velocity + "ms-1";
        }
        public static double SetSigFigs(double d, int digits)
        {
            if (d == 0)
                return 0;

            decimal scale = (decimal)Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1);

            return (double)(scale * Math.Round((decimal)d / scale, digits));
        }
        //Comverts degrees to radian and vice versa as c# doesn't support degree trigonomity
        private double DegreeToRadian(double tempAngle)
        {
            return Math.PI * tempAngle / 180.0;
        }
        private double RadianToDegree(double tempAngle)
        {
            return tempAngle * (180.0 / Math.PI);
        }
        //End of convertion methods
        private void btnSolve_Click(object sender, EventArgs e)
        {
            int points = 10 + localTime;
            try
            {
                //Calculates answer to L1Q1 (3 significant figures)
                double radian = DegreeToRadian(angle);
                double sinVert = Math.Sin(radian);
                double startVelocityVert = velocity * sinVert;
                double time = startVelocityVert / 9.81;
                double totalTime = time * 2;
                double answerL1Q1 = (velocity * Math.Cos(radian)) * (totalTime);
                answerL1Q1 = SetSigFigs(answerL1Q1, 3);
                //Displays ans delete later
                if (Convert.ToInt32(mtbAnsInpt.Text) == Convert.ToInt32(answerL1Q1))
                {
                    theUser.Score += points;
                    MessageBox.Show("The answer was " + answerL1Q1 + "m. You have scored " + points + " points", "Well Done! You are correct", MessageBoxButtons.OK);
                    nextQuestion();
                }
                else
                {
                    MessageBox.Show("The Correct answer was " + answerL1Q1 + "m.", "Sorry", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation); nextQuestion();
                }
            }
            catch { MessageBox.Show("Please Enter Text", "",MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
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
            Form frmL1Q2 = new frmL1Q2(ref theUser);
            frmL1Q2.Show();
            this.Close();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            nextQuestion();
        }

        private void txtL1Q1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
