namespace PongProject
{
    partial class Pong
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            player1 = new PictureBox();
            cpuplayer = new PictureBox();
            pongball = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            playerScoreLabel = new Label();
            cpuplayerscoreLabel = new Label();
            pongtimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpuplayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pongball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // player1
            // 
            player1.BackColor = Color.DarkOrange;
            player1.Location = new Point(12, 348);
            player1.Name = "player1";
            player1.Size = new Size(32, 231);
            player1.TabIndex = 0;
            player1.TabStop = false;
            // 
            // cpuplayer
            // 
            cpuplayer.BackColor = Color.Blue;
            cpuplayer.Location = new Point(1270, 348);
            cpuplayer.Name = "cpuplayer";
            cpuplayer.Size = new Size(32, 231);
            cpuplayer.TabIndex = 1;
            cpuplayer.TabStop = false;
            // 
            // pongball
            // 
            pongball.Location = new Point(642, 467);
            pongball.Name = "pongball";
            pongball.Size = new Size(24, 24);
            pongball.TabIndex = 2;
            pongball.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(614, 33);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(556, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 129);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // playerScoreLabel
            // 
            playerScoreLabel.BackColor = Color.Transparent;
            playerScoreLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            playerScoreLabel.ForeColor = Color.Cyan;
            playerScoreLabel.Location = new Point(480, 83);
            playerScoreLabel.Name = "playerScoreLabel";
            playerScoreLabel.Size = new Size(49, 56);
            playerScoreLabel.TabIndex = 5;
            playerScoreLabel.Text = "0";
            // 
            // cpuplayerscoreLabel
            // 
            cpuplayerscoreLabel.BackColor = Color.Transparent;
            cpuplayerscoreLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cpuplayerscoreLabel.ForeColor = Color.Cyan;
            cpuplayerscoreLabel.Location = new Point(803, 83);
            cpuplayerscoreLabel.Name = "cpuplayerscoreLabel";
            cpuplayerscoreLabel.Size = new Size(49, 56);
            cpuplayerscoreLabel.TabIndex = 6;
            cpuplayerscoreLabel.Text = "0";
            // 
            // pongtimer
            // 
            pongtimer.Enabled = true;
            pongtimer.Tick += pongtimer_Tick;
            // 
            // Pong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1314, 1121);
            Controls.Add(cpuplayerscoreLabel);
            Controls.Add(playerScoreLabel);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pongball);
            Controls.Add(cpuplayer);
            Controls.Add(player1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Pong";
            Text = "Pong";
            Load += Pong_Load;
            KeyDown += Pong_KeyDown;
            KeyUp += Pong_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpuplayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pongball).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player1;
        private PictureBox cpuplayer;
        private PictureBox pongball;
        private Label label1;
        private PictureBox pictureBox1;
        private Label playerScoreLabel;
        private Label cpuplayerscoreLabel;
        private System.Windows.Forms.Timer pongtimer;
    }
}