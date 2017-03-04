namespace ConstantPhysics
{
    partial class frmL1Q1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.txtL1Q1 = new System.Windows.Forms.RichTextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pbbL1Q1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.mtbAnsInpt = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbbL1Q1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Level One: Question One";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(13, 348);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(281, 20);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Type the Answer (3 significant figures):";
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(653, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // btnSolve
            // 
            this.btnSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSolve.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(636, 393);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(72, 68);
            this.btnSolve.TabIndex = 6;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSkip.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(714, 393);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(72, 68);
            this.btnSkip.TabIndex = 7;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // txtL1Q1
            // 
            this.txtL1Q1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtL1Q1.BackColor = System.Drawing.Color.White;
            this.txtL1Q1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtL1Q1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL1Q1.Location = new System.Drawing.Point(278, 76);
            this.txtL1Q1.Margin = new System.Windows.Forms.Padding(0);
            this.txtL1Q1.Name = "txtL1Q1";
            this.txtL1Q1.ReadOnly = true;
            this.txtL1Q1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtL1Q1.Size = new System.Drawing.Size(495, 96);
            this.txtL1Q1.TabIndex = 8;
            this.txtL1Q1.Text = "The Question";
            this.txtL1Q1.TextChanged += new System.EventHandler(this.txtL1Q1_TextChanged);
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngle.Location = new System.Drawing.Point(49, 276);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(50, 20);
            this.lblAngle.TabIndex = 9;
            this.lblAngle.Text = "Angle";
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocity.Location = new System.Drawing.Point(23, 152);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(64, 20);
            this.lblVelocity.TabIndex = 10;
            this.lblVelocity.Text = "Velocity";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Question_Tick);
            // 
            // pbbL1Q1
            // 
            this.pbbL1Q1.Image = global::ConstantPhysics.Properties.Resources.angle;
            this.pbbL1Q1.Location = new System.Drawing.Point(17, 76);
            this.pbbL1Q1.Name = "pbbL1Q1";
            this.pbbL1Q1.Size = new System.Drawing.Size(258, 235);
            this.pbbL1Q1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbL1Q1.TabIndex = 2;
            this.pbbL1Q1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(529, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 20);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time:";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(237, 400);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(38, 13);
            this.lblUnit.TabIndex = 12;
            this.lblUnit.Text = "metres";
            // 
            // mtbAnsInpt
            // 
            this.mtbAnsInpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbAnsInpt.Location = new System.Drawing.Point(101, 397);
            this.mtbAnsInpt.Name = "mtbAnsInpt";
            this.mtbAnsInpt.Size = new System.Drawing.Size(130, 20);
            this.mtbAnsInpt.TabIndex = 13;
            // 
            // frmL1Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.mtbAnsInpt);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblVelocity);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.txtL1Q1);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.pbbL1Q1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmL1Q1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constant Physics";
            this.Load += new System.EventHandler(this.frmL1Q1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbbL1Q1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbbL1Q1;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.RichTextBox txtL1Q1;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblVelocity;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.MaskedTextBox mtbAnsInpt;
    }
}