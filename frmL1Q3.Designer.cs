namespace ConstantPhysics
{
    partial class frmL1Q3
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
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtL1Q3 = new System.Windows.Forms.RichTextBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.rbnTop = new System.Windows.Forms.RadioButton();
            this.gbxGroup = new System.Windows.Forms.GroupBox();
            this.rbnBottom = new System.Windows.Forms.RadioButton();
            this.rbnMiddle = new System.Windows.Forms.RadioButton();
            this.pbbL1Q3 = new System.Windows.Forms.PictureBox();
            this.gbxGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbbL1Q3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(526, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 20);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "Time:";
            // 
            // txtL1Q3
            // 
            this.txtL1Q3.BackColor = System.Drawing.Color.White;
            this.txtL1Q3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtL1Q3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL1Q3.Location = new System.Drawing.Point(14, 52);
            this.txtL1Q3.Margin = new System.Windows.Forms.Padding(0);
            this.txtL1Q3.Name = "txtL1Q3";
            this.txtL1Q3.ReadOnly = true;
            this.txtL1Q3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtL1Q3.Size = new System.Drawing.Size(346, 85);
            this.txtL1Q3.TabIndex = 18;
            this.txtL1Q3.Text = "The Question";
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSkip.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(711, 394);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(72, 68);
            this.btnSkip.TabIndex = 17;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSolve.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(633, 394);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(72, 68);
            this.btnSolve.TabIndex = 16;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(650, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 20);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "Score:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(10, 402);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(0, 20);
            this.lblInstructions.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 20);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Level One: Question Three";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Question_Tick);
            // 
            // rbnTop
            // 
            this.rbnTop.Location = new System.Drawing.Point(6, 28);
            this.rbnTop.Name = "rbnTop";
            this.rbnTop.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.rbnTop.Size = new System.Drawing.Size(386, 80);
            this.rbnTop.TabIndex = 22;
            this.rbnTop.TabStop = true;
            this.rbnTop.Text = "\"An object that..\"";
            this.rbnTop.UseVisualStyleBackColor = true;
            // 
            // gbxGroup
            // 
            this.gbxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGroup.Controls.Add(this.rbnBottom);
            this.gbxGroup.Controls.Add(this.rbnMiddle);
            this.gbxGroup.Controls.Add(this.rbnTop);
            this.gbxGroup.Location = new System.Drawing.Point(363, 52);
            this.gbxGroup.Name = "gbxGroup";
            this.gbxGroup.Size = new System.Drawing.Size(417, 323);
            this.gbxGroup.TabIndex = 23;
            this.gbxGroup.TabStop = false;
            this.gbxGroup.Text = "Newton\'s Laws of Motion";
            // 
            // rbnBottom
            // 
            this.rbnBottom.Location = new System.Drawing.Point(6, 195);
            this.rbnBottom.Name = "rbnBottom";
            this.rbnBottom.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.rbnBottom.Size = new System.Drawing.Size(386, 80);
            this.rbnBottom.TabIndex = 24;
            this.rbnBottom.TabStop = true;
            this.rbnBottom.Text = "\"An object that..\"";
            this.rbnBottom.UseVisualStyleBackColor = true;
            // 
            // rbnMiddle
            // 
            this.rbnMiddle.Location = new System.Drawing.Point(6, 109);
            this.rbnMiddle.Name = "rbnMiddle";
            this.rbnMiddle.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.rbnMiddle.Size = new System.Drawing.Size(386, 80);
            this.rbnMiddle.TabIndex = 23;
            this.rbnMiddle.TabStop = true;
            this.rbnMiddle.Text = "\"An object that..\"";
            this.rbnMiddle.UseVisualStyleBackColor = true;
            // 
            // pbbL1Q3
            // 
            this.pbbL1Q3.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pbbL1Q3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbbL1Q3.Image = global::ConstantPhysics.Properties.Resources.newtonBall;
            this.pbbL1Q3.InitialImage = global::ConstantPhysics.Properties.Resources.mainLogo;
            this.pbbL1Q3.Location = new System.Drawing.Point(12, 161);
            this.pbbL1Q3.Name = "pbbL1Q3";
            this.pbbL1Q3.Size = new System.Drawing.Size(343, 217);
            this.pbbL1Q3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbL1Q3.TabIndex = 24;
            this.pbbL1Q3.TabStop = false;
            // 
            // frmL1Q3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.pbbL1Q3);
            this.Controls.Add(this.gbxGroup);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtL1Q3);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmL1Q3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constant Physics";
            this.Load += new System.EventHandler(this.frmL1Q3_Load);
            this.gbxGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbbL1Q3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RichTextBox txtL1Q3;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.RadioButton rbnTop;
        private System.Windows.Forms.GroupBox gbxGroup;
        private System.Windows.Forms.RadioButton rbnBottom;
        private System.Windows.Forms.RadioButton rbnMiddle;
        private System.Windows.Forms.PictureBox pbbL1Q3;
    }
}