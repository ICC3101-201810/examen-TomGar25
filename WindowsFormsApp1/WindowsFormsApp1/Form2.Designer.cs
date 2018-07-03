namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pacman = new System.Windows.Forms.PictureBox();
            this.ghostRed = new System.Windows.Forms.PictureBox();
            this.ghostPink = new System.Windows.Forms.PictureBox();
            this.Cherry = new System.Windows.Forms.PictureBox();
            this.Uva = new System.Windows.Forms.PictureBox();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.Lscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uva)).BeginInit();
            this.SuspendLayout();
            // 
            // pacman
            // 
            this.pacman.Image = ((System.Drawing.Image)(resources.GetObject("pacman.Image")));
            this.pacman.Location = new System.Drawing.Point(290, 150);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(20, 20);
            this.pacman.TabIndex = 0;
            this.pacman.TabStop = false;
            // 
            // ghostRed
            // 
            this.ghostRed.Image = ((System.Drawing.Image)(resources.GetObject("ghostRed.Image")));
            this.ghostRed.Location = new System.Drawing.Point(238, 213);
            this.ghostRed.Name = "ghostRed";
            this.ghostRed.Size = new System.Drawing.Size(20, 20);
            this.ghostRed.TabIndex = 1;
            this.ghostRed.TabStop = false;
            this.ghostRed.Click += new System.EventHandler(this.ghostRed_Click);
            // 
            // ghostPink
            // 
            this.ghostPink.Image = ((System.Drawing.Image)(resources.GetObject("ghostPink.Image")));
            this.ghostPink.Location = new System.Drawing.Point(296, 213);
            this.ghostPink.Name = "ghostPink";
            this.ghostPink.Size = new System.Drawing.Size(20, 20);
            this.ghostPink.TabIndex = 2;
            this.ghostPink.TabStop = false;
            // 
            // Cherry
            // 
            this.Cherry.Image = ((System.Drawing.Image)(resources.GetObject("Cherry.Image")));
            this.Cherry.Location = new System.Drawing.Point(26, 215);
            this.Cherry.Name = "Cherry";
            this.Cherry.Size = new System.Drawing.Size(20, 20);
            this.Cherry.TabIndex = 3;
            this.Cherry.TabStop = false;
            // 
            // Uva
            // 
            this.Uva.Image = ((System.Drawing.Image)(resources.GetObject("Uva.Image")));
            this.Uva.Location = new System.Drawing.Point(77, 215);
            this.Uva.Name = "Uva";
            this.Uva.Size = new System.Drawing.Size(20, 20);
            this.Uva.TabIndex = 4;
            this.Uva.TabStop = false;
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Interval = 20;
            this.Tiempo.Tick += new System.EventHandler(this.TimerGame);
            // 
            // Lscore
            // 
            this.Lscore.AutoSize = true;
            this.Lscore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lscore.Location = new System.Drawing.Point(74, 339);
            this.Lscore.Name = "Lscore";
            this.Lscore.Size = new System.Drawing.Size(0, 13);
            this.Lscore.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Lscore);
            this.Controls.Add(this.Uva);
            this.Controls.Add(this.Cherry);
            this.Controls.Add(this.ghostPink);
            this.Controls.Add(this.ghostRed);
            this.Controls.Add(this.pacman);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pacman;
        private System.Windows.Forms.PictureBox ghostRed;
        private System.Windows.Forms.PictureBox ghostPink;
        private System.Windows.Forms.PictureBox Cherry;
        private System.Windows.Forms.PictureBox Uva;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Label Lscore;
    }
}