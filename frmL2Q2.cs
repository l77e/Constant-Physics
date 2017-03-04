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
    public partial class frmL2Q2 : Form
    {
        private User theUser;
        private int localTime;
       // private int numberOfCorrect;
        public frmL2Q2(ref User tempTheUserFrmL2Q2)
        {
            InitializeComponent();
            theUser = tempTheUserFrmL2Q2;
            localTime = theUser.Time;
        }

        private void frmL2Q2_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score:" + theUser.Score;
            txtL2Q2.Text = ConstantPhysics.Properties.Resources.L2Q2;
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
            Form frmL2Q3 = new frmL2Q3(ref theUser);
            frmL2Q3.Show();
            this.Close();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            int points = 0;
            int subject;
            string errors = "Things to learn: \n";
            for (int i = 0; i < clbEMWaves.CheckedItems.Count; i++)
            {
                subject = clbEMWaves.CheckedIndices[i];
                switch (subject)
                {
                    case 0: points += 10; break;
                    case 1: errors += "Red light has a wavelength of 700nm \n"; break;
                    case 2: errors += "EM waves are transverse \n"; break;
                    case 3: points += 10; break;
                    case 4: errors += "Electromagnetic waves travel at 3,000,000ms-1 \n"; break;
                }
            }

           
            MessageBox.Show("You've earned "+points+" points \n"+errors);
            theUser.Score += points;
            nextQuestion();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            nextQuestion();
        }
    }
}
