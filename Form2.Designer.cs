namespace PongProject
{
    partial class characterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(characterform));
            label1 = new Label();
            romerchar = new PictureBox();
            fuchschar = new PictureBox();
            basballchar = new PictureBox();
            pistolchar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)romerchar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fuchschar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)basballchar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pistolchar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(321, 71);
            label1.Name = "label1";
            label1.Size = new Size(421, 44);
            label1.TabIndex = 0;
            label1.Text = "Klicke ein Character";
            // 
            // romerchar
            // 
            romerchar.BackColor = Color.Transparent;
            romerchar.BackgroundImage = (Image)resources.GetObject("romerchar.BackgroundImage");
            romerchar.BackgroundImageLayout = ImageLayout.Stretch;
            romerchar.Location = new Point(162, 260);
            romerchar.Name = "romerchar";
            romerchar.Size = new Size(137, 80);
            romerchar.TabIndex = 1;
            romerchar.TabStop = false;
            romerchar.Click += romerchar_Click;
            // 
            // fuchschar
            // 
            fuchschar.BackColor = Color.Transparent;
            fuchschar.BackgroundImage = (Image)resources.GetObject("fuchschar.BackgroundImage");
            fuchschar.BackgroundImageLayout = ImageLayout.Stretch;
            fuchschar.Location = new Point(368, 260);
            fuchschar.Name = "fuchschar";
            fuchschar.Size = new Size(137, 80);
            fuchschar.TabIndex = 2;
            fuchschar.TabStop = false;
            fuchschar.Click += fuchschar_Click;
            // 
            // basballchar
            // 
            basballchar.BackColor = Color.Transparent;
            basballchar.BackgroundImage = (Image)resources.GetObject("basballchar.BackgroundImage");
            basballchar.BackgroundImageLayout = ImageLayout.Stretch;
            basballchar.Location = new Point(559, 260);
            basballchar.Name = "basballchar";
            basballchar.Size = new Size(137, 80);
            basballchar.TabIndex = 3;
            basballchar.TabStop = false;
            basballchar.Click += basballchar_Click;
            // 
            // pistolchar
            // 
            pistolchar.BackColor = Color.Transparent;
            pistolchar.BackgroundImage = (Image)resources.GetObject("pistolchar.BackgroundImage");
            pistolchar.BackgroundImageLayout = ImageLayout.Stretch;
            pistolchar.Location = new Point(725, 260);
            pistolchar.Name = "pistolchar";
            pistolchar.Size = new Size(137, 80);
            pistolchar.TabIndex = 4;
            pistolchar.TabStop = false;
            pistolchar.Click += pistolchar_Click;
            // 
            // characterform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1047, 617);
            Controls.Add(pistolchar);
            Controls.Add(basballchar);
            Controls.Add(fuchschar);
            Controls.Add(romerchar);
            Controls.Add(label1);
            Name = "characterform";
            Text = "Character Auswahl";
            ((System.ComponentModel.ISupportInitialize)romerchar).EndInit();
            ((System.ComponentModel.ISupportInitialize)fuchschar).EndInit();
            ((System.ComponentModel.ISupportInitialize)basballchar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pistolchar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox romerchar;
        private PictureBox fuchschar;
        private PictureBox basballchar;
        private PictureBox pistolchar;
    }
}