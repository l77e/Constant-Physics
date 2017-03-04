namespace ConstantPhysics
{
    partial class frmL1Q2
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
            this.txtL1Q2 = new System.Windows.Forms.RichTextBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblVoltage = new System.Windows.Forms.Label();
            this.lblResistance = new System.Windows.Forms.Label();
            this.txtDropZone = new System.Windows.Forms.TextBox();
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
            this.lblTime.TabIndex = 22;
            this.lblTime.Text = "Time:";
            // 
            // txtL1Q2
            // 
            this.txtL1Q2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtL1Q2.BackColor = System.Drawing.Color.White;
            this.txtL1Q2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtL1Q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL1Q2.Location = new System.Drawing.Point(10, 59);
            this.txtL1Q2.Margin = new System.Windows.Forms.Padding(0);
            this.txtL1Q2.Name = "txtL1Q2";
            this.txtL1Q2.ReadOnly = true;
            this.txtL1Q2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtL1Q2.Size = new System.Drawing.Size(398, 54);
            this.txtL1Q2.TabIndex = 19;
            this.txtL1Q2.Text = "The Question";
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
            this.btnSkip.TabIndex = 18;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click_1);
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
            this.btnSolve.TabIndex = 17;
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
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "Score:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 20);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Level One: Question Two";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Question_Tick);
            // 
            // lblVoltage
            // 
            this.lblVoltage.AllowDrop = true;
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltage.Location = new System.Drawing.Point(47, 236);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(121, 31);
            this.lblVoltage.TabIndex = 23;
            this.lblVoltage.Text = "kgmsA-1";
            this.lblVoltage.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblVoltage_DragEnter);
            this.lblVoltage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVoltage_MouseDown);
            // 
            // lblResistance
            // 
            this.lblResistance.AllowDrop = true;
            this.lblResistance.AutoSize = true;
            this.lblResistance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResistance.Location = new System.Drawing.Point(231, 281);
            this.lblResistance.Name = "lblResistance";
            this.lblResistance.Size = new System.Drawing.Size(160, 31);
            this.lblResistance.TabIndex = 24;
            this.lblResistance.Text = "kgm2s-3A-2";
            this.lblResistance.Click += new System.EventHandler(this.lblResistance_Click);
            this.lblResistance.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblResistance_DragEnter);
            this.lblResistance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblResistance_MouseDown);
            // 
            // txtDropZone
            // 
            this.txtDropZone.AllowDrop = true;
            this.txtDropZone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDropZone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDropZone.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDropZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDropZone.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtDropZone.Location = new System.Drawing.Point(430, 59);
            this.txtDropZone.Multiline = true;
            this.txtDropZone.Name = "txtDropZone";
            this.txtDropZone.Size = new System.Drawing.Size(247, 54);
            this.txtDropZone.TabIndex = 25;
            this.txtDropZone.Text = "Drag Answer Here";
            this.txtDropZone.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDropZone_DragDrop);
            this.txtDropZone.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDropZone_DragEnter);
            // 
            // frmL1Q2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtDropZone);
            this.Controls.Add(this.lblResistance);
            this.Controls.Add(this.lblVoltage);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtL1Q2);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "frmL1Q2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constant Physics";
            this.Load += new System.EventHandler(this.frmL1Q2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RichTextBox txtL1Q2;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.Label lblResistance;
        private System.Windows.Forms.TextBox txtDropZone;
    }
}