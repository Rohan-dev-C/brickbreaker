
namespace BrickBreaker
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.YOUWIN = new System.Windows.Forms.Label();
            this.lostlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1246, 732);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Location = new System.Drawing.Point(-6, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(72, 34);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score";
            // 
            // YOUWIN
            // 
            this.YOUWIN.AutoSize = true;
            this.YOUWIN.Font = new System.Drawing.Font("Comic Sans MS", 160F);
            this.YOUWIN.Location = new System.Drawing.Point(44, 210);
            this.YOUWIN.Name = "YOUWIN";
            this.YOUWIN.Size = new System.Drawing.Size(1164, 298);
            this.YOUWIN.TabIndex = 2;
            this.YOUWIN.Text = "YOU WIN";
            // 
            // lostlabel
            // 
            this.lostlabel.AutoSize = true;
            this.lostlabel.Font = new System.Drawing.Font("Comic Sans MS", 160F);
            this.lostlabel.Location = new System.Drawing.Point(21, 136);
            this.lostlabel.Name = "lostlabel";
            this.lostlabel.Size = new System.Drawing.Size(1225, 298);
            this.lostlabel.TabIndex = 3;
            this.lostlabel.Text = "YOU LOSE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 732);
            this.Controls.Add(this.lostlabel);
            this.Controls.Add(this.YOUWIN);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label YOUWIN;
        private System.Windows.Forms.Label lostlabel;
    }
}

