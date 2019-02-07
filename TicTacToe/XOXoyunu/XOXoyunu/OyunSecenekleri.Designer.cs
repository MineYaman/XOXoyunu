namespace XOXoyunu
{
    partial class OyunSecenekleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunSecenekleri));
            this.rdbtnOnePlayer = new System.Windows.Forms.RadioButton();
            this.rdbtnTwoPlayer = new System.Windows.Forms.RadioButton();
            this.rdbtnOnline = new System.Windows.Forms.RadioButton();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.txtPlayerOne = new System.Windows.Forms.TextBox();
            this.txtPlayerTwo = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtnOnePlayer
            // 
            this.rdbtnOnePlayer.AutoSize = true;
            this.rdbtnOnePlayer.BackColor = System.Drawing.Color.Thistle;
            this.rdbtnOnePlayer.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnOnePlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtnOnePlayer.Location = new System.Drawing.Point(88, 72);
            this.rdbtnOnePlayer.Name = "rdbtnOnePlayer";
            this.rdbtnOnePlayer.Size = new System.Drawing.Size(268, 42);
            this.rdbtnOnePlayer.TabIndex = 0;
            this.rdbtnOnePlayer.TabStop = true;
            this.rdbtnOnePlayer.Text = "ONE PLAYER";
            this.rdbtnOnePlayer.UseVisualStyleBackColor = false;
            this.rdbtnOnePlayer.CheckedChanged += new System.EventHandler(this.rdbtnOnePlayer_CheckedChanged);
            // 
            // rdbtnTwoPlayer
            // 
            this.rdbtnTwoPlayer.AutoSize = true;
            this.rdbtnTwoPlayer.BackColor = System.Drawing.Color.Thistle;
            this.rdbtnTwoPlayer.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTwoPlayer.Location = new System.Drawing.Point(88, 157);
            this.rdbtnTwoPlayer.Name = "rdbtnTwoPlayer";
            this.rdbtnTwoPlayer.Size = new System.Drawing.Size(275, 42);
            this.rdbtnTwoPlayer.TabIndex = 1;
            this.rdbtnTwoPlayer.TabStop = true;
            this.rdbtnTwoPlayer.Text = "TWO PLAYER";
            this.rdbtnTwoPlayer.UseVisualStyleBackColor = false;
            this.rdbtnTwoPlayer.CheckedChanged += new System.EventHandler(this.rdbtnTwoPlayer_CheckedChanged);
            // 
            // rdbtnOnline
            // 
            this.rdbtnOnline.AutoSize = true;
            this.rdbtnOnline.BackColor = System.Drawing.Color.Thistle;
            this.rdbtnOnline.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnOnline.Location = new System.Drawing.Point(88, 242);
            this.rdbtnOnline.Name = "rdbtnOnline";
            this.rdbtnOnline.Size = new System.Drawing.Size(176, 42);
            this.rdbtnOnline.TabIndex = 2;
            this.rdbtnOnline.TabStop = true;
            this.rdbtnOnline.Text = "ONLINE";
            this.rdbtnOnline.UseVisualStyleBackColor = false;
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPlayerOne.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.Location = new System.Drawing.Point(101, 344);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(284, 35);
            this.lblPlayerOne.TabIndex = 3;
            this.lblPlayerOne.Text = "PLAYER ONE NAME  :";
            this.lblPlayerOne.Visible = false;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPlayerTwo.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.Location = new System.Drawing.Point(95, 405);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(290, 35);
            this.lblPlayerTwo.TabIndex = 4;
            this.lblPlayerTwo.Text = "PLAYER TWO NAME :";
            this.lblPlayerTwo.Visible = false;
            // 
            // txtPlayerOne
            // 
            this.txtPlayerOne.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPlayerOne.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerOne.Location = new System.Drawing.Point(409, 343);
            this.txtPlayerOne.Name = "txtPlayerOne";
            this.txtPlayerOne.Size = new System.Drawing.Size(258, 36);
            this.txtPlayerOne.TabIndex = 5;
            this.txtPlayerOne.Visible = false;
            this.txtPlayerOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerTwo_KeyPress);
            // 
            // txtPlayerTwo
            // 
            this.txtPlayerTwo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPlayerTwo.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerTwo.Location = new System.Drawing.Point(409, 404);
            this.txtPlayerTwo.Name = "txtPlayerTwo";
            this.txtPlayerTwo.Size = new System.Drawing.Size(258, 36);
            this.txtPlayerTwo.TabIndex = 6;
            this.txtPlayerTwo.Visible = false;
            this.txtPlayerTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerTwo_KeyPress);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPlay.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Cyan;
            this.btnPlay.Location = new System.Drawing.Point(589, 507);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(197, 71);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // OyunSecenekleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(822, 635);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtPlayerTwo);
            this.Controls.Add(this.txtPlayerOne);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.rdbtnOnline);
            this.Controls.Add(this.rdbtnTwoPlayer);
            this.Controls.Add(this.rdbtnOnePlayer);
            this.MinimizeBox = false;
            this.Name = "OyunSecenekleri";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun Secenekleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnOnePlayer;
        private System.Windows.Forms.RadioButton rdbtnTwoPlayer;
        private System.Windows.Forms.RadioButton rdbtnOnline;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.TextBox txtPlayerOne;
        private System.Windows.Forms.TextBox txtPlayerTwo;
        private System.Windows.Forms.Button btnPlay;
    }
}