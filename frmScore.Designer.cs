namespace ConstantPhysics
{
    partial class frmScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScore = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnLevelChange = new System.Windows.Forms.Button();
            this.lsbUsrRank = new System.Windows.Forms.ListBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pbbAvatar = new System.Windows.Forms.PictureBox();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(132, 37);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(231, 33);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "The user\'s score";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(0, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(72, 68);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(78, 0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(72, 68);
            this.btnMainMenu.TabIndex = 8;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnLevelChange
            // 
            this.btnLevelChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLevelChange.BackColor = System.Drawing.Color.White;
            this.btnLevelChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLevelChange.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnLevelChange.FlatAppearance.BorderSize = 2;
            this.btnLevelChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelChange.Location = new System.Drawing.Point(631, 381);
            this.btnLevelChange.Name = "btnLevelChange";
            this.btnLevelChange.Size = new System.Drawing.Size(141, 68);
            this.btnLevelChange.TabIndex = 10;
            this.btnLevelChange.Text = "Go to Level";
            this.btnLevelChange.UseVisualStyleBackColor = false;
            this.btnLevelChange.Visible = false;
            this.btnLevelChange.Click += new System.EventHandler(this.btnLevelChange_Click);
            // 
            // lsbUsrRank
            // 
            this.lsbUsrRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbUsrRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbUsrRank.FormattingEnabled = true;
            this.lsbUsrRank.ItemHeight = 24;
            this.lsbUsrRank.Location = new System.Drawing.Point(48, 107);
            this.lsbUsrRank.Name = "lsbUsrRank";
            this.lsbUsrRank.Size = new System.Drawing.Size(573, 218);
            this.lsbUsrRank.TabIndex = 11;
            this.lsbUsrRank.SelectedIndexChanged += new System.EventHandler(this.lsbUsrRank_SelectedIndexChanged);
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.Controls.Add(this.btnMainMenu);
            this.pnlControls.Controls.Add(this.btnLogOut);
            this.pnlControls.Location = new System.Drawing.Point(471, 381);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlControls.Size = new System.Drawing.Size(154, 76);
            this.pnlControls.TabIndex = 12;
            // 
            // pbbAvatar
            // 
            this.pbbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbbAvatar.Image = global::ConstantPhysics.Properties.Resources.mainLogo;
            this.pbbAvatar.InitialImage = global::ConstantPhysics.Properties.Resources.mainLogo;
            this.pbbAvatar.Location = new System.Drawing.Point(48, 37);
            this.pbbAvatar.Name = "pbbAvatar";
            this.pbbAvatar.Size = new System.Drawing.Size(78, 50);
            this.pbbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbAvatar.TabIndex = 13;
            this.pbbAvatar.TabStop = false;
            // 
            // frmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pbbAvatar);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.lsbUsrRank);
            this.Controls.Add(this.btnLevelChange);
            this.Controls.Add(this.lblScore);
            this.Name = "frmScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constant Physics";
            this.Load += new System.EventHandler(this.frmScore_Load);
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnLevelChange;
        private System.Windows.Forms.ListBox lsbUsrRank;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.PictureBox pbbAvatar;
    }
}