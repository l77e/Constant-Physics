namespace ConstantPhysics
{
    partial class frmL2Q1
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
            this.txtL2Q1 = new System.Windows.Forms.RichTextBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pbbL2Q1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbbFirstL2Q1 = new System.Windows.Forms.ComboBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.cbbSecondL2Q1 = new System.Windows.Forms.ComboBox();
            this.cbbThirdL2Q1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbbL2Q1)).BeginInit();
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
            // txtL2Q1
            // 
            this.txtL2Q1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtL2Q1.BackColor = System.Drawing.Color.White;
            this.txtL2Q1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtL2Q1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL2Q1.Location = new System.Drawing.Point(16, 46);
            this.txtL2Q1.Margin = new System.Windows.Forms.Padding(0);
            this.txtL2Q1.Name = "txtL2Q1";
            this.txtL2Q1.ReadOnly = true;
            this.txtL2Q1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtL2Q1.Size = new System.Drawing.Size(759, 66);
            this.txtL2Q1.TabIndex = 20;
            this.txtL2Q1.Text = "The Question";
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
            this.btnSolve.Enabled = false;
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
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 288);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(239, 20);
            this.lblInstructions.TabIndex = 15;
            this.lblInstructions.Text = "Select answers from dropdowns:";
            // 
            // pbbL2Q1
            // 
            this.pbbL2Q1.Image = global::ConstantPhysics.Properties.Resources.convexLens;
            this.pbbL2Q1.InitialImage = global::ConstantPhysics.Properties.Resources.mainLogo;
            this.pbbL2Q1.Location = new System.Drawing.Point(194, 115);
            this.pbbL2Q1.Name = "pbbL2Q1";
            this.pbbL2Q1.Size = new System.Drawing.Size(375, 160);
            this.pbbL2Q1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbL2Q1.TabIndex = 14;
            this.pbbL2Q1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 24);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Level Two: Question One";
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // cbbFirstL2Q1
            // 
            this.cbbFirstL2Q1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbFirstL2Q1.BackColor = System.Drawing.SystemColors.Control;
            this.cbbFirstL2Q1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbFirstL2Q1.FormattingEnabled = true;
            this.cbbFirstL2Q1.Items.AddRange(new object[] {
            "Real",
            "Virtual"});
            this.cbbFirstL2Q1.Location = new System.Drawing.Point(194, 324);
            this.cbbFirstL2Q1.Name = "cbbFirstL2Q1";
            this.cbbFirstL2Q1.Size = new System.Drawing.Size(121, 21);
            this.cbbFirstL2Q1.TabIndex = 24;
            this.cbbFirstL2Q1.SelectedIndexChanged += new System.EventHandler(this.cbbFirstL2Q1_SelectedIndexChanged);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Question_Tick);
            // 
            // cbbSecondL2Q1
            // 
            this.cbbSecondL2Q1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbSecondL2Q1.BackColor = System.Drawing.SystemColors.Control;
            this.cbbSecondL2Q1.Enabled = false;
            this.cbbSecondL2Q1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSecondL2Q1.FormattingEnabled = true;
            this.cbbSecondL2Q1.Items.AddRange(new object[] {
            "Object Sized",
            "Magnified",
            "Diminished"});
            this.cbbSecondL2Q1.Location = new System.Drawing.Point(321, 324);
            this.cbbSecondL2Q1.Name = "cbbSecondL2Q1";
            this.cbbSecondL2Q1.Size = new System.Drawing.Size(121, 21);
            this.cbbSecondL2Q1.TabIndex = 25;
            this.cbbSecondL2Q1.SelectedIndexChanged += new System.EventHandler(this.cbbSecondL2Q1_SelectedIndexChanged);
            // 
            // cbbThirdL2Q1
            // 
            this.cbbThirdL2Q1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbThirdL2Q1.BackColor = System.Drawing.SystemColors.Control;
            this.cbbThirdL2Q1.Enabled = false;
            this.cbbThirdL2Q1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbThirdL2Q1.FormattingEnabled = true;
            this.cbbThirdL2Q1.Items.AddRange(new object[] {
            "Erect Image",
            "Inverted Image"});
            this.cbbThirdL2Q1.Location = new System.Drawing.Point(448, 324);
            this.cbbThirdL2Q1.Name = "cbbThirdL2Q1";
            this.cbbThirdL2Q1.Size = new System.Drawing.Size(121, 21);
            this.cbbThirdL2Q1.TabIndex = 26;
            this.cbbThirdL2Q1.SelectedIndexChanged += new System.EventHandler(this.cbbThirdL2Q1_SelectedIndexChanged);
            // 
            // frmL2Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cbbThirdL2Q1);
            this.Controls.Add(this.cbbSecondL2Q1);
            this.Controls.Add(this.cbbFirstL2Q1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtL2Q1);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.pbbL2Q1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmL2Q1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constant Physics";
            this.Load += new System.EventHandler(this.frmL2Q1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbbL2Q1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RichTextBox txtL2Q1;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox pbbL2Q1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbbFirstL2Q1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ComboBox cbbSecondL2Q1;
        private System.Windows.Forms.ComboBox cbbThirdL2Q1;
    }
}