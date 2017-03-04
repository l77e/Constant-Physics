using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ConstantPhysics
{
    public partial class frmL1Q3 : Form
    {
        private User theUser;
        private int localTime;
        private int newtonLaw;
        private int topValue = 0;
        private int middleValue = 0;
        private int bottomValue = 0;
        public frmL1Q3(ref User theUserFrmL1Q3)
        {
            InitializeComponent();
            theUser = theUserFrmL1Q3;
            localTime = theUser.Time;
        }

        private void frmL1Q3_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score:" + theUser.Score;
            //Change to GetQuestion()
            string questionText = ConstantPhysics.Properties.Resources.L1Q3;
            txtL1Q3.Text = questionText + RandomNewtonLaw();
            //Randomise radiobutton responses
            SetRandonDefintion();
            rbnTop.Focus();
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
            Form scoreBoard = new frmScore(ref theUser);
            scoreBoard.Show();
            this.Close();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            nextQuestion();
        }
        //private string GetQuestion()
        //{
        //    String line = "";
        //    try
        //    {
        //        //Pass the file path and file name to the StreamReader constructor
        //        StreamReader sr = new StreamReader();

        //        //Read the first line of text
        //        line = sr.ReadLine();

        //        //Continue to read until you reach end of file
        //        while (line != null)
        //        {
        //            line = sr.ReadLine();
        //        }
                
        //        //close the file
        //        sr.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Error: " + e.Message);
        //    }
        //    finally
        //    {
                
        //    }
        //    return line;
        //}
        private string RandomNewtonLaw()
        {
            Random n = new Random();
            int law = n.Next(1, 4);
            string lawString = "Newton's ";
            switch (law)
            {
                case 1: lawString += "first "; break;
                case 2: lawString += "second "; break;
                case 3: lawString += "third "; break;
                default: lawString += "first "; break;
            };
            lawString += "law of motion.";
            newtonLaw = law;
            return lawString;
        }
        private void SetRandonDefintion()
        {
            //Sets radio buttons to random random definition orders
            Random n = new Random();
            switch (n.Next(0,4))
            {
                case 1: rbnTop.Text = ConstantPhysics.Properties.Resources.NewtonLawOne;
                        topValue = 1;
                    rbnMiddle.Text = ConstantPhysics.Properties.Resources.NewtonLawTwo;
                    middleValue = 2;
                    rbnBottom.Text = ConstantPhysics.Properties.Resources.NewtonLawThree;
                    bottomValue = 3; break;
                case 2:
                    rbnTop.Text = ConstantPhysics.Properties.Resources.NewtonLawTwo;
                    topValue = 2;
                    rbnMiddle.Text = ConstantPhysics.Properties.Resources.NewtonLawOne;
                    middleValue = 1;
                    rbnBottom.Text = ConstantPhysics.Properties.Resources.NewtonLawThree;
                    bottomValue = 3; break;
                case 3:
                    rbnTop.Text = ConstantPhysics.Properties.Resources.NewtonLawThree;
                   topValue = 3;
                    rbnMiddle.Text = ConstantPhysics.Properties.Resources.NewtonLawOne;
                   middleValue = 1;
                    rbnBottom.Text = ConstantPhysics.Properties.Resources.NewtonLawTwo;
                    bottomValue = 2; break;
               default:
                    rbnTop.Text = ConstantPhysics.Properties.Resources.NewtonLawThree;
                    topValue = 3;
                    rbnMiddle.Text = ConstantPhysics.Properties.Resources.NewtonLawTwo;
                    middleValue = 2;
                    rbnBottom.Text = ConstantPhysics.Properties.Resources.NewtonLawOne;
                    bottomValue = 1; break;
            }
        }
        private void ScoreAdder()
        {
            int points = localTime + 10;
            theUser.Score += points;
            MessageBox.Show("You have scored " + points + " points!"  +"\n Total Time taken: " + (theUser.Time - localTime), "Correct");
        }

        private void btnSkip_Click_1(object sender, EventArgs e)
        {
            nextQuestion();
        }
        
        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (rbnTop.Checked == true && newtonLaw == topValue)
            {
                ScoreAdder();
            }
            else if (rbnMiddle.Checked == true && newtonLaw == middleValue)
            {
                ScoreAdder();
            }
            else if (rbnBottom.Checked == true && newtonLaw == bottomValue)
            {
                ScoreAdder();
            }
            nextQuestion();

        }
    }
}
