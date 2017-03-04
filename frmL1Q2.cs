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
    public partial class frmL1Q2 : Form
    {
        private User theUser;
        private int localTime;
        public frmL1Q2(ref User theUserFrmL1Q2)
        {
            InitializeComponent();
            theUser = theUserFrmL1Q2;
            localTime = theUser.Time;
        }

        private void frmL1Q2_Load(object sender, EventArgs e)
        {
            txtL1Q2.Text = "What is the base unit of resistance?";
            lblScore.Text = "Score: " + theUser.Score;
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
            Form frmL1Q3 = new frmL1Q3(ref theUser);
            frmL1Q3.Show();
            this.Close();
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            
        }
        private void lblResistance_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lblVoltage_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lblVoltage_MouseDown(object sender, MouseEventArgs e)
        {
            Label draggedLabel = (Label)sender;
            DoDragDrop(draggedLabel.Text, DragDropEffects.Copy);
        }

        private void lblResistance_Click(object sender, EventArgs e)
        {
           
        }

        private void txtDropZone_DragDrop(object sender, DragEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.Text = e.Data.GetData(typeof(string)).ToString();
        }

        private void lblResistance_MouseDown(object sender, MouseEventArgs e)
        {
            Label draggedLabel = (Label)sender;
            DoDragDrop(draggedLabel.Text, DragDropEffects.Copy);
        }

        private void txtDropZone_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            int points = 10 + localTime;
            if (txtDropZone.Text == "kgm2s-3A-2")
            {
                theUser.Score += points;
                MessageBox.Show("You have scored " + points + " points!", "Correct");
                nextQuestion();
            }
            else { 
                MessageBox.Show("Sorry, the correct base unit of resistance is kgm2s-3A-2", "Incorrect answer");
                nextQuestion();
            }
        }

        private void btnSkip_Click_1(object sender, EventArgs e)
        {
            nextQuestion();
        }
    }
}
