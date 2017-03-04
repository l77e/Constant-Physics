namespace ConstantPhysics
{
    partial class frmMain
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
            this.lblTitleMain = new System.Windows.Forms.Label();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.lblSelectLevel = new System.Windows.Forms.Label();
            this.cbbQuestionTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDropDownInstructions = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleMain
            // 
            this.lblTitleMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleMain.AutoSize = true;
            this.lblTitleMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMain.Location = new System.Drawing.Point(297, 118);
            this.lblTitleMain.Name = "lblTitleMain";
            this.lblTitleMain.Size = new System.Drawing.Size(174, 37);
            this.lblTitleMain.TabIndex = 0;
            this.lblTitleMain.Text = "Main Menu";
            // 
            // cbbLevel
            // 
            this.cbbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLevel.BackColor = System.Drawing.SystemColors.Control;
            this.cbbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            "Level One",
            "Level Two"});
            this.cbbLevel.Location = new System.Drawing.Point(344, 222);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(150, 21);
            this.cbbLevel.TabIndex = 1;
            this.cbbLevel.SelectedIndexChanged += new System.EventHandler(this.cbbLevel_SelectedIndexChanged);
            this.cbbLevel.SelectedValueChanged += new System.EventHandler(this.cbbLevel_SelectedValueChanged);
            // 
            // lblSelectLevel
            // 
            this.lblSelectLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectLevel.AutoSize = true;
            this.lblSelectLevel.Location = new System.Drawing.Point(260, 230);
            this.lblSelectLevel.Name = "lblSelectLevel";
            this.lblSelectLevel.Size = new System.Drawing.Size(66, 13);
            this.lblSelectLevel.TabIndex = 2;
            this.lblSelectLevel.Text = "Select Level";
            // 
            // cbbQuestionTime
            // 
            this.cbbQuestionTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbQuestionTime.BackColor = System.Drawing.SystemColors.Control;
            this.cbbQuestionTime.Enabled = false;
            this.cbbQuestionTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbQuestionTime.FormattingEnabled = true;
            this.cbbQuestionTime.Items.AddRange(new object[] {
            "Expert",
            "Novice",
            "Beginner",
            "No Limit"});
            this.cbbQuestionTime.Location = new System.Drawing.Point(344, 263);
            this.cbbQuestionTime.MaxDropDownItems = 4;
            this.cbbQuestionTime.Name = "cbbQuestionTime";
            this.cbbQuestionTime.Size = new System.Drawing.Size(150, 21);
            this.cbbQuestionTime.TabIndex = 3;
            this.cbbQuestionTime.SelectedIndexChanged += new System.EventHandler(this.cbbQuestionTime_SelectedIndexChanged);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(251, 266);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Question Time";
            // 
            // lblDropDownInstructions
            // 
            this.lblDropDownInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDropDownInstructions.AutoSize = true;
            this.lblDropDownInstructions.Location = new System.Drawing.Point(285, 167);
            this.lblDropDownInstructions.Name = "lblDropDownInstructions";
            this.lblDropDownInstructions.Size = new System.Drawing.Size(199, 26);
            this.lblDropDownInstructions.TabIndex = 6;
            this.lblDropDownInstructions.Text = "Click the arrow on the drop downs below\r\nto select a difficulty level and time.";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(13, 13);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(118, 25);
            this.lblGreeting.TabIndex = 7;
            this.lblGreeting.Text = "Hello, User";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(700, 381);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 68);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lblDropDownInstructions);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cbbQuestionTime);
            this.Controls.Add(this.lblSelectLevel);
            this.Controls.Add(this.cbbLevel);
            this.Controls.Add(this.lblTitleMain);
            this.HelpButton = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constant Physics";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMain;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.Label lblSelectLevel;
        private System.Windows.Forms.ComboBox cbbQuestionTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDropDownInstructions;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnStart;
    }
}