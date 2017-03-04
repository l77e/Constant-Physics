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
    public partial class frmMain : Form
    {
        private User theUser;

        public frmMain(ref User tempUserFrmMain)
        {
            InitializeComponent();
            theUser = tempUserFrmMain;
        }

        private void cbbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbQuestionTime.Focus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = "Welcome, " + theUser.Username;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //The time the user selects
            if (cbbQuestionTime.Text == "No Limit") theUser.Time = 0;
            else if (cbbQuestionTime.Text == "Expert") theUser.Time = 180;
            else if (cbbQuestionTime.Text == "Novice") theUser.Time = 240;
            else if (cbbQuestionTime.Text == "Beginner") theUser.Time = 300;
            else theUser.Time = 0;
            //The level that the user selected
            if (cbbLevel.Text == "Level One")
            {
                //Code sets level and checks if level one/two has been played
                if (theUser.Level == 0)
                {
                    theUser.Level = 1;
                }
                else if (theUser.Level == 1)
                {
                    theUser.Level = 1;
                }
                else { theUser.Level = 3; }
                Form frmL1Q1 = new frmL1Q1(ref theUser);
                frmL1Q1.Show();
                this.Close();
            }else
            {
                //Code checks if level one/two has been previosly played
                if (theUser.Level == 0)
                    theUser.Level = 2;
                else if(theUser.Level == 2)
                {
                    theUser.Level = 2;
                }
                else theUser.Level = 4;
                //goto level two
                Form frmL2Q1 = new frmL2Q1(ref theUser);
                frmL2Q1.Show();
                this.Close();
            }
            
        }

        private void cbbLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            //Enables cbbQuestion after the user selects level
            cbbQuestionTime.Enabled = true;
        }

        private void cbbQuestionTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStart.Focus();
        }
    }
}
