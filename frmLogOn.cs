using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace ConstantPhysics
{
    public partial class frmLogOn : Form
    {
        private User theUser = new User();
        private AllUser userData = new AllUser();
        private int avatarNum = 0;
        public frmLogOn()
        {
            Thread time = new Thread(new ThreadStart(Splash));
            time.Start();
            InitializeComponent();
            Thread.Sleep(3000);
            time.Abort();
        }

        public void Splash()
        {
            Application.Run(new frmSplash());
        }

        private void frmLogOn_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogOn_Click(object sender, EventArgs e)
        {
            //Load the list object 
            DataSave.LoadObject(ref userData);
            
            //Ensure The Account Exists
            if (userData.UserExists(txtUsrNamInpt.Text) == true)
            {
                //Get the account
                theUser = userData.GetUser(txtUsrNamInpt.Text);
                if (txtPassInpt.Text == theUser.Password)
                {
                    theUser.Level = 0;
                    theUser.Score = 0;
                    Form Main = new frmMain(ref theUser);
                    Main.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Sorry, " + theUser.Username + ", your password is incorrect, retype it and try again.","Careful Now!"); }
            }
            else { MessageBox.Show("Username is invalid or non-existant, please retype it or create an account.", "(╯°□°）╯ ︵ ┻━┻"); }
        }

        private void btnAccCreate_Click(object sender, EventArgs e)
        {
            DataSave.LoadObject(ref userData);
            theUser.Username = txtUsrCreate.Text;
            theUser.Password = txtPassCreate.Text;
            string verifyPass = txtPassVerify.Text;
            //Sets Avatar
            theUser.Avatar = avatarNum;
            //unapropriate password check
            bool hasUpperCase = !theUser.Password.ToLower().Equals(theUser.Password);
            int passLen = theUser.Password.Length;
            if (passLen <= 8 || hasUpperCase == false)
            {
                MessageBox.Show("Password is too short or doesn't contain an uppercase letter.");
                theUser.Username = theUser.Password = verifyPass = "";
            }
            else
            {
                //Following checks if passwords match
                if (theUser.Password == verifyPass)
                {
                    if (theUser.Password != "" || verifyPass != "")
                    {
                        //If user exists: add to AllUser and save
                        if (userData.UserExists(theUser.Username) == false)
                        {
                            
                            userData.AddUser(ref theUser);
                            DataSave.SaveObject(userData);
                            Form frmMain = new frmMain(ref theUser);
                            frmMain.Show();
                            this.Hide();
                        }
                        else MessageBox.Show("The User already exists");
                    }
                    else
                    {
                        MessageBox.Show("You have not entered a password");
                    }
                }
                else
                {
                    MessageBox.Show("The passwords you have entered do not match", "Retype Passwords");
                }

            }
        }

        private void txtUsrCreate_TextChanged(object sender, EventArgs e)
        {

        }

        private void avatar1_Click(object sender, EventArgs e)
        {
            avatarNum = 1;
            if (avatarNum == 1)
            {
                avatar1.Image = ConstantPhysics.Properties.Resources.weirdIssacYankavic;
                avatar2_MouseLeave(e,e);
                avatar3_MouseLeave(e, e);
                avatar1.BorderStyle = BorderStyle.None;
                avatar3.BorderStyle = BorderStyle.None;
                avatar1.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void avatar2_Click(object sender, EventArgs e)
        {
            avatarNum = 2;
            if (avatarNum == 2)
            {
                avatar2.Image = ConstantPhysics.Properties.Resources.shodinger;
                avatar1_MouseLeave(e, e);
                avatar3_MouseLeave(e, e);
                avatar1.BorderStyle = BorderStyle.None;
                avatar3.BorderStyle = BorderStyle.None;
                avatar2.BorderStyle = BorderStyle.FixedSingle;
            }
            }

        private void avatar3_Click(object sender, EventArgs e)
        {
            avatarNum = 3;

            if (avatarNum == 3) { avatar3.Image = ConstantPhysics.Properties.Resources.billNyeTheFightingGuy;
                avatar2_MouseLeave(e, e);
                avatar1_MouseLeave(e, e);
                avatar1.BorderStyle = BorderStyle.None;
                avatar2.BorderStyle = BorderStyle.None;
                avatar3.BorderStyle = BorderStyle.FixedSingle;

            }
        }

        private void avatar1_MouseEnter(object sender, EventArgs e)
        {
            avatar1.Image = ConstantPhysics.Properties.Resources.weirdIssacYankavic;
        }

        private void avatar1_MouseLeave(object sender, EventArgs e)
        {
            if(!(avatarNum == 1))
            avatar1.Image = ConstantPhysics.Properties.Resources.realexpertmask;
        }

        private void avatar2_MouseEnter(object sender, EventArgs e)
        {
            
                avatar2.Image = ConstantPhysics.Properties.Resources.shodinger;
        }

        private void avatar2_MouseLeave(object sender, EventArgs e)
        {
            if (!(avatarNum == 2))
                avatar2.Image = ConstantPhysics.Properties.Resources.expertmask;
        }

        private void avatar3_MouseEnter(object sender, EventArgs e)
        {
            avatar3.Image = ConstantPhysics.Properties.Resources.billNyeTheFightingGuy;
        }

        private void avatar3_MouseLeave(object sender, EventArgs e)
        {
            if (!(avatarNum == 3))
                avatar3.Image = ConstantPhysics.Properties.Resources.beginnermask;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new FrmHelp().Show();
        }
    }
}


