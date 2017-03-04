namespace ConstantPhysics
{
    partial class frmSplash
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
            this.ptbLoading = new System.Windows.Forms.PictureBox();
            this.pbrSplash = new System.Windows.Forms.ProgressBar();
            this.timeLoad = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLoading
            // 
            this.ptbLoading.Image = global::ConstantPhysics.Properties.Resources.chemistry_atom_proton_electron_animation_17;
            this.ptbLoading.Location = new System.Drawing.Point(45, 183);
            this.ptbLoading.Name = "ptbLoading";
            this.ptbLoading.Size = new System.Drawing.Size(77, 67);
            this.ptbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLoading.TabIndex = 0;
            this.ptbLoading.TabStop = false;
            // 
            // pbrSplash
            // 
            this.pbrSplash.Location = new System.Drawing.Point(204, 323);
            this.pbrSplash.Name = "pbrSplash";
            this.pbrSplash.Size = new System.Drawing.Size(388, 33);
            this.pbrSplash.TabIndex = 1;
            this.pbrSplash.UseWaitCursor = true;
            // 
            // timeLoad
            // 
            this.timeLoad.Enabled = true;
            this.timeLoad.Interval = 10;
            this.timeLoad.Tick += new System.EventHandler(this.timeLoad_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConstantPhysics.Properties.Resources.mainLogo;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pbrSplash);
            this.Controls.Add(this.ptbLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Constant Physics...";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLoading;
        private System.Windows.Forms.ProgressBar pbrSplash;
        private System.Windows.Forms.Timer timeLoad;
    }
}