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
    public partial class frmScore : Form
    {
        private User theUser;
        private AllUser users = new AllUser();
        public frmScore(ref User frmScoreTheUser)
        {
            InitializeComponent();
            theUser = frmScoreTheUser;
        }

        private void frmScore_Load(object sender, EventArgs e)
        {
            DataSave.LoadObject(ref users);
            theUser.OverallScore += theUser.Score;
            users.UpdateUser(ref theUser);
            DataSave.SaveObject(users);
            DataSave.LoadObject(ref users);

            string levelOnly =" ";
            if (theUser.Level == 1)
            {
                levelOnly = "(level one)";
                btnLevelChange.Visible = true;
                btnLevelChange.Text = "Go to Level Two";
            }
            else if (theUser.Level == 2)
            {
                levelOnly = "(level two)";
                btnLevelChange.Visible = true;
                btnLevelChange.Text = "Go to Level One";
            }
            else
            {
                pnlControls.Location = new Point(620, 380);
            }
            switch (theUser.Avatar)
            {
                case 1: pbbAvatar.Image = ConstantPhysics.Properties.Resources.weirdIssacYankavic; break;
                case 2: pbbAvatar.Image = ConstantPhysics.Properties.Resources.shodinger; break;
                case 3: pbbAvatar.Image = ConstantPhysics.Properties.Resources.billNyeTheFightingGuy; break;
                default: pbbAvatar.Image = ConstantPhysics.Properties.Resources.mainLogo; break;
            }
            lblScore.Text = "Well done, your final Score was: " + theUser.Score +" "+ levelOnly;

            //User ranks
            users.SortByScore();
            lsbUsrRank.Items.Insert(0, "Rank \t User \t Overall Score");
            users.userList.Reverse();

            for(int i = 0; i < users.userList.Count; i++)
            {
                lsbUsrRank.Items.Add((i+1)+"\t"+users.userList[i].Username+"\t"+users.userList[i].OverallScore);
            }


        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Form MainMenu= new frmMain(ref theUser);
            MainMenu.Show();
            this.Close();
        }

        private void btnLevelChange_Click(object sender, EventArgs e)
        {
            if (theUser.Level == 1)
            {
                // Level number 3 means level one has been played and level two will now be played
                theUser.Level = 3;
                Form frmL2Q1 = new frmL2Q1(ref theUser);
                frmL2Q1.Show();
                this.Close();
            }
            else if (theUser.Level == 2)
            {
                // Level number 4 means level two has been played and level one will now be played
                theUser.Level = 4;
                Form frmL1Q1 = new frmL1Q1(ref theUser);
                frmL1Q1.Show();
                this.Close();
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form login = new frmLogOn();
            login.Show();
            this.Close();
        }

        private void lsbUsrRank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
