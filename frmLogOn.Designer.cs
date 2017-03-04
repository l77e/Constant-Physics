namespace ConstantPhysics
{
    partial class frmLogOn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogOn));
            this.lblLog = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogOn = new System.Windows.Forms.Button();
            this.txtUsrNamInpt = new System.Windows.Forms.TextBox();
            this.txtPassInpt = new System.Windows.Forms.TextBox();
            this.lblTitleAccCreate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPasswordHelp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAccCreate = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.HelpProvider();
            this.avatar3 = new System.Windows.Forms.PictureBox();
            this.avatar2 = new System.Windows.Forms.PictureBox();
            this.avatar1 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtUsrCreate = new System.Windows.Forms.TextBox();
            this.txtPassCreate = new System.Windows.Forms.TextBox();
            this.txtPassVerify = new System.Windows.Forms.TextBox();
            this.lblAvaterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(12, 50);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(141, 42);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Log On";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(17, 117);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(17, 159);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // btnLogOn
            // 
            this.btnLogOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogOn.FlatAppearance.BorderSize = 5;
            this.btnLogOn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOn.Location = new System.Drawing.Point(19, 403);
            this.btnLogOn.Name = "btnLogOn";
            this.btnLogOn.Size = new System.Drawing.Size(107, 34);
            this.btnLogOn.TabIndex = 3;
            this.btnLogOn.Text = "Log On";
            this.btnLogOn.UseVisualStyleBackColor = true;
            this.btnLogOn.Click += new System.EventHandler(this.btnLogOn_Click);
            // 
            // txtUsrNamInpt
            // 
            this.txtUsrNamInpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsrNamInpt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsrNamInpt.Location = new System.Drawing.Point(102, 117);
            this.txtUsrNamInpt.Name = "txtUsrNamInpt";
            this.txtUsrNamInpt.Size = new System.Drawing.Size(100, 20);
            this.txtUsrNamInpt.TabIndex = 4;
            // 
            // txtPassInpt
            // 
            this.txtPassInpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassInpt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassInpt.Location = new System.Drawing.Point(102, 159);
            this.txtPassInpt.MaxLength = 16;
            this.txtPassInpt.Name = "txtPassInpt";
            this.txtPassInpt.PasswordChar = '*';
            this.txtPassInpt.Size = new System.Drawing.Size(100, 20);
            this.txtPassInpt.TabIndex = 5;
            // 
            // lblTitleAccCreate
            // 
            this.lblTitleAccCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleAccCreate.AutoSize = true;
            this.lblTitleAccCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAccCreate.Location = new System.Drawing.Point(307, 50);
            this.lblTitleAccCreate.Name = "lblTitleAccCreate";
            this.lblTitleAccCreate.Size = new System.Drawing.Size(276, 42);
            this.lblTitleAccCreate.TabIndex = 6;
            this.lblTitleAccCreate.Text = "Create Account";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // lblPasswordHelp
            // 
            this.lblPasswordHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPasswordHelp.AutoSize = true;
            this.lblPasswordHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordHelp.ForeColor = System.Drawing.Color.Silver;
            this.lblPasswordHelp.Location = new System.Drawing.Point(506, 159);
            this.lblPasswordHelp.Name = "lblPasswordHelp";
            this.lblPasswordHelp.Size = new System.Drawing.Size(216, 26);
            this.lblPasswordHelp.TabIndex = 11;
            this.lblPasswordHelp.Text = "Please create a password that is over \r\n8 charcters long and contains 1 capital l" +
    "etter";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "Retype\r\nPassword";
            // 
            // btnAccCreate
            // 
            this.btnAccCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAccCreate.FlatAppearance.BorderSize = 5;
            this.btnAccCreate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccCreate.Location = new System.Drawing.Point(314, 403);
            this.btnAccCreate.Name = "btnAccCreate";
            this.btnAccCreate.Size = new System.Drawing.Size(161, 34);
            this.btnAccCreate.TabIndex = 14;
            this.btnAccCreate.Text = "Create Account";
            this.btnAccCreate.UseVisualStyleBackColor = true;
            this.btnAccCreate.Click += new System.EventHandler(this.btnAccCreate_Click);
            // 
            // help
            // 
            this.help.HelpNamespace = "";
            // 
            // avatar3
            // 
            this.avatar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatar3.Image = global::ConstantPhysics.Properties.Resources.beginnermask;
            this.avatar3.InitialImage = global::ConstantPhysics.Properties.Resources.billNyeTheFightingGuy;
            this.avatar3.Location = new System.Drawing.Point(546, 275);
            this.avatar3.Name = "avatar3";
            this.help.SetShowHelp(this.avatar3, true);
            this.avatar3.Size = new System.Drawing.Size(110, 99);
            this.avatar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar3.TabIndex = 20;
            this.avatar3.TabStop = false;
            this.avatar3.Click += new System.EventHandler(this.avatar3_Click);
            this.avatar3.MouseEnter += new System.EventHandler(this.avatar3_MouseEnter);
            this.avatar3.MouseLeave += new System.EventHandler(this.avatar3_MouseLeave);
            // 
            // avatar2
            // 
            this.avatar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatar2.Image = global::ConstantPhysics.Properties.Resources.expertmask;
            this.avatar2.InitialImage = global::ConstantPhysics.Properties.Resources.expertmask;
            this.avatar2.Location = new System.Drawing.Point(430, 275);
            this.avatar2.Name = "avatar2";
            this.help.SetShowHelp(this.avatar2, true);
            this.avatar2.Size = new System.Drawing.Size(110, 99);
            this.avatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar2.TabIndex = 19;
            this.avatar2.TabStop = false;
            this.avatar2.Click += new System.EventHandler(this.avatar2_Click);
            this.avatar2.MouseEnter += new System.EventHandler(this.avatar2_MouseEnter);
            this.avatar2.MouseLeave += new System.EventHandler(this.avatar2_MouseLeave);
            // 
            // avatar1
            // 
            this.avatar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.avatar1.Image = global::ConstantPhysics.Properties.Resources.realexpertmask;
            this.avatar1.InitialImage = ((System.Drawing.Image)(resources.GetObject("avatar1.InitialImage")));
            this.avatar1.Location = new System.Drawing.Point(313, 275);
            this.avatar1.Name = "avatar1";
            this.help.SetShowHelp(this.avatar1, true);
            this.avatar1.Size = new System.Drawing.Size(111, 99);
            this.avatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar1.TabIndex = 18;
            this.avatar1.TabStop = false;
            this.avatar1.Click += new System.EventHandler(this.avatar1_Click);
            this.avatar1.MouseEnter += new System.EventHandler(this.avatar1_MouseEnter);
            this.avatar1.MouseLeave += new System.EventHandler(this.avatar1_MouseLeave);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.DimGray;
            this.btnHelp.Location = new System.Drawing.Point(750, 12);
            this.btnHelp.Name = "btnHelp";
            this.help.SetShowHelp(this.btnHelp, true);
            this.btnHelp.Size = new System.Drawing.Size(35, 35);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // txtUsrCreate
            // 
            this.txtUsrCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsrCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsrCreate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsrCreate.Location = new System.Drawing.Point(400, 117);
            this.txtUsrCreate.Name = "txtUsrCreate";
            this.txtUsrCreate.Size = new System.Drawing.Size(100, 20);
            this.txtUsrCreate.TabIndex = 15;
            // 
            // txtPassCreate
            // 
            this.txtPassCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassCreate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassCreate.Location = new System.Drawing.Point(400, 159);
            this.txtPassCreate.Name = "txtPassCreate";
            this.txtPassCreate.PasswordChar = '*';
            this.txtPassCreate.Size = new System.Drawing.Size(100, 20);
            this.txtPassCreate.TabIndex = 16;
            // 
            // txtPassVerify
            // 
            this.txtPassVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassVerify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassVerify.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassVerify.Location = new System.Drawing.Point(400, 196);
            this.txtPassVerify.Name = "txtPassVerify";
            this.txtPassVerify.PasswordChar = '*';
            this.txtPassVerify.Size = new System.Drawing.Size(100, 20);
            this.txtPassVerify.TabIndex = 17;
            // 
            // lblAvaterLabel
            // 
            this.lblAvaterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvaterLabel.AutoSize = true;
            this.lblAvaterLabel.Location = new System.Drawing.Point(310, 259);
            this.lblAvaterLabel.Name = "lblAvaterLabel";
            this.lblAvaterLabel.Size = new System.Drawing.Size(164, 13);
            this.lblAvaterLabel.TabIndex = 21;
            this.lblAvaterLabel.Text = "Please Click On An Avatar Below";
            // 
            // frmLogOn
            // 
            this.AcceptButton = this.btnLogOn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblAvaterLabel);
            this.Controls.Add(this.avatar3);
            this.Controls.Add(this.avatar2);
            this.Controls.Add(this.avatar1);
            this.Controls.Add(this.txtPassVerify);
            this.Controls.Add(this.txtPassCreate);
            this.Controls.Add(this.txtUsrCreate);
            this.Controls.Add(this.btnAccCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPasswordHelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitleAccCreate);
            this.Controls.Add(this.txtPassInpt);
            this.Controls.Add(this.txtUsrNamInpt);
            this.Controls.Add(this.btnLogOn);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLog);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.HelpButton = true;
            this.help.SetHelpKeyword(this, "Help Me");
            this.help.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.help.SetHelpString(this, "Help");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogOn";
            this.help.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constant Physics";
            this.Load += new System.EventHandler(this.frmLogOn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogOn;
        private System.Windows.Forms.TextBox txtUsrNamInpt;
        private System.Windows.Forms.TextBox txtPassInpt;
        private System.Windows.Forms.Label lblTitleAccCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPasswordHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccCreate;
        private System.Windows.Forms.HelpProvider help;
        public System.Windows.Forms.TextBox txtUsrCreate;
        public System.Windows.Forms.TextBox txtPassCreate;
        public System.Windows.Forms.TextBox txtPassVerify;
        private System.Windows.Forms.PictureBox avatar1;
        private System.Windows.Forms.PictureBox avatar2;
        private System.Windows.Forms.PictureBox avatar3;
        private System.Windows.Forms.Label lblAvaterLabel;
        private System.Windows.Forms.Button btnHelp;
    }
}

