namespace snakeGame__2_8_2015_
{
    partial class frmGamePlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGamePlay));
            this.timer_SnakeMovement = new System.Windows.Forms.Timer(this.components);
            this.pbSpaceBar = new System.Windows.Forms.PictureBox();
            this.lblScoreTag = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpaceBar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_SnakeMovement
            // 
            this.timer_SnakeMovement.Enabled = true;
            this.timer_SnakeMovement.Interval = 150;
            this.timer_SnakeMovement.Tick += new System.EventHandler(this.timer_SnakeMovement_Tick);
            // 
            // pbSpaceBar
            // 
            this.pbSpaceBar.BackColor = System.Drawing.Color.Transparent;
            this.pbSpaceBar.Image = global::snakeGame__2_8_2015_.Properties.Resources.spaceBar;
            this.pbSpaceBar.Location = new System.Drawing.Point(186, 127);
            this.pbSpaceBar.Name = "pbSpaceBar";
            this.pbSpaceBar.Size = new System.Drawing.Size(556, 255);
            this.pbSpaceBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpaceBar.TabIndex = 0;
            this.pbSpaceBar.TabStop = false;
            // 
            // lblScoreTag
            // 
            this.lblScoreTag.AutoSize = true;
            this.lblScoreTag.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreTag.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTag.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblScoreTag.Location = new System.Drawing.Point(665, 9);
            this.lblScoreTag.Name = "lblScoreTag";
            this.lblScoreTag.Size = new System.Drawing.Size(128, 45);
            this.lblScoreTag.TabIndex = 1;
            this.lblScoreTag.Text = "Score :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(799, 14);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 40);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // frmGamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::snakeGame__2_8_2015_.Properties.Resources.gameBg;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreTag);
            this.Controls.Add(this.pbSpaceBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGamePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGamePlay";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGamePlay_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGamePlay_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpaceBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_SnakeMovement;
        private System.Windows.Forms.PictureBox pbSpaceBar;
        private System.Windows.Forms.Label lblScoreTag;
        private System.Windows.Forms.Label lblScore;
    }
}