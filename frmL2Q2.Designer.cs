namespace ConstantPhysics
{
    partial class frmL2Q2
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
            this.txtL2Q2 = new System.Windows.Forms.RichTextBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.clbEMWaves = new System.Windows.Forms.CheckedListBox();
            this.pbbL2Q2 = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbbL2Q2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(522, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 20);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "Time:";
            // 
            // txtL2Q2
            // 
            this.txtL2Q2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtL2Q2.BackColor = System.Drawing.Color.White;
            this.txtL2Q2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtL2Q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL2Q2.Location = new System.Drawing.Point(9, 37);
            this.txtL2Q2.Margin = new System.Windows.Forms.Padding(0);
            this.txtL2Q2.Name = "txtL2Q2";
            this.txtL2Q2.ReadOnly = true;
            this.txtL2Q2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtL2Q2.Size = new System.Drawing.Size(766, 90);
            this.txtL2Q2.TabIndex = 20;
            this.txtL2Q2.Text = "The Question";
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSkip.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(707, 388);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(72, 68);
            this.btnSkip.TabIndex = 19;
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
            this.btnSolve.Location = new System.Drawing.Point(629, 388);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(72, 68);
            this.btnSolve.TabIndex = 18;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(646, 4);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 20);
            this.lblScore.TabIndex = 16;
            this.lblScore.Text = "Score:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 20);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Level Two: Question Two";
            // 
            // clbEMWaves
            // 
            this.clbEMWaves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbEMWaves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbEMWaves.CheckOnClick = true;
            this.clbEMWaves.FormattingEnabled = true;
            this.clbEMWaves.Items.AddRange(new object[] {
            "All electromagnetic waves can be reflected",
            "Red light has a wave length of 200mm",
            "Electromagnetic waves are longitudinal",
            "Electromagnetic waves can travel in a vacuum",
            "The speed of light is 3,000,000 ms-1"});
            this.clbEMWaves.Location = new System.Drawing.Point(470, 190);
            this.clbEMWaves.Margin = new System.Windows.Forms.Padding(8);
            this.clbEMWaves.Name = "clbEMWaves";
            this.clbEMWaves.Size = new System.Drawing.Size(273, 90);
            this.clbEMWaves.TabIndex = 25;
            this.clbEMWaves.ThreeDCheckBoxes = true;
            // 
            // pbbL2Q2
            // 
            this.pbbL2Q2.BackColor = System.Drawing.Color.White;
            this.pbbL2Q2.Image = global::ConstantPhysics.Properties.Resources.emWave;
            this.pbbL2Q2.InitialImage = global::ConstantPhysics.Properties.Resources.mainLogo;
            this.pbbL2Q2.Location = new System.Drawing.Point(33, 156);
            this.pbbL2Q2.Name = "pbbL2Q2";
            this.pbbL2Q2.Size = new System.Drawing.Size(375, 160);
            this.pbbL2Q2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbL2Q2.TabIndex = 26;
            this.pbbL2Q2.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Question_Tick);
            // 
            // frmL2Q2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pbbL2Q2);
            this.Controls.Add(this.clbEMWaves);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtL2Q2);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmL2Q2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constant Physics";
            this.Load += new System.EventHandler(this.frmL2Q2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbbL2Q2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RichTextBox txtL2Q2;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckedListBox clbEMWaves;
        private System.Windows.Forms.PictureBox pbbL2Q2;
        private System.Windows.Forms.Timer Timer;
    }
}