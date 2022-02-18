namespace RyanLateFeeCalculator
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.btnNewRelease = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnKidMovies = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(81, 28);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(377, 25);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome To Ryan\'s Late Fee Calculator";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNewRelease
            // 
            this.btnNewRelease.Location = new System.Drawing.Point(198, 75);
            this.btnNewRelease.Name = "btnNewRelease";
            this.btnNewRelease.Size = new System.Drawing.Size(151, 33);
            this.btnNewRelease.TabIndex = 1;
            this.btnNewRelease.Text = "&New Releases";
            this.btnNewRelease.UseVisualStyleBackColor = true;
            this.btnNewRelease.Click += new System.EventHandler(this.btnNewRelease_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.Location = new System.Drawing.Point(198, 132);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(151, 33);
            this.btnLibrary.TabIndex = 2;
            this.btnLibrary.Text = "&Library Movies";
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // btnKidMovies
            // 
            this.btnKidMovies.Location = new System.Drawing.Point(198, 188);
            this.btnKidMovies.Name = "btnKidMovies";
            this.btnKidMovies.Size = new System.Drawing.Size(151, 33);
            this.btnKidMovies.TabIndex = 3;
            this.btnKidMovies.Text = "&Kid Movies";
            this.btnKidMovies.UseVisualStyleBackColor = true;
            this.btnKidMovies.Click += new System.EventHandler(this.btnKidMovies_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(198, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(540, 330);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKidMovies);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.btnNewRelease);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ryan\'s Late Fee Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private Button btnNewRelease;
        private Button btnLibrary;
        private Button btnKidMovies;
        private Button btnExit;
    }
}