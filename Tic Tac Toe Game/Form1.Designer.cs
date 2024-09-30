namespace Tic_Tac_Toe_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblLastWinner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.Poption3 = new System.Windows.Forms.PictureBox();
            this.Poption2 = new System.Windows.Forms.PictureBox();
            this.Poption1 = new System.Windows.Forms.PictureBox();
            this.Poption6 = new System.Windows.Forms.PictureBox();
            this.Poption5 = new System.Windows.Forms.PictureBox();
            this.Poption8 = new System.Windows.Forms.PictureBox();
            this.Poption9 = new System.Windows.Forms.PictureBox();
            this.Poption4 = new System.Windows.Forms.PictureBox();
            this.Poption7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(549, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 48);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(24, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 46);
            this.label2.TabIndex = 41;
            this.label2.Text = "Turn";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Yellow;
            this.lblWinner.Location = new System.Drawing.Point(24, 257);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(146, 46);
            this.lblWinner.TabIndex = 42;
            this.lblWinner.Text = "Winner";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Black;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.White;
            this.lblPlayer.Location = new System.Drawing.Point(24, 194);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(155, 46);
            this.lblPlayer.TabIndex = 43;
            this.lblPlayer.Text = "Player1";
            this.lblPlayer.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblLastWinner
            // 
            this.lblLastWinner.AutoSize = true;
            this.lblLastWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLastWinner.Location = new System.Drawing.Point(24, 320);
            this.lblLastWinner.Name = "lblLastWinner";
            this.lblLastWinner.Size = new System.Drawing.Size(223, 46);
            this.lblLastWinner.TabIndex = 44;
            this.lblLastWinner.Text = "In Progress";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 44);
            this.button1.TabIndex = 45;
            this.button1.Text = "Restart Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Tic_Tac_Toe_Game.Properties.Resources.Tic_tae_img;
            this.pictureBox10.Location = new System.Drawing.Point(250, 74);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(276, 364);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 46;
            this.pictureBox10.TabStop = false;
            // 
            // Poption3
            // 
            this.Poption3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poption3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poption3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Poption3.Location = new System.Drawing.Point(874, 85);
            this.Poption3.Name = "Poption3";
            this.Poption3.Size = new System.Drawing.Size(84, 92);
            this.Poption3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poption3.TabIndex = 39;
            this.Poption3.TabStop = false;
            this.Poption3.Tag = "0";
            this.Poption3.Click += new System.EventHandler(this.Poption3_Click);
            // 
            // Poption2
            // 
            this.Poption2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poption2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poption2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Poption2.Location = new System.Drawing.Point(694, 85);
            this.Poption2.Name = "Poption2";
            this.Poption2.Size = new System.Drawing.Size(84, 92);
            this.Poption2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poption2.TabIndex = 38;
            this.Poption2.TabStop = false;
            this.Poption2.Tag = "0";
            this.Poption2.Click += new System.EventHandler(this.Poption2_Click);
            // 
            // Poption1
            // 
            this.Poption1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poption1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poption1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Poption1.Location = new System.Drawing.Point(532, 85);
            this.Poption1.Name = "Poption1";
            this.Poption1.Size = new System.Drawing.Size(84, 92);
            this.Poption1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poption1.TabIndex = 37;
            this.Poption1.TabStop = false;
            this.Poption1.Tag = "0";
            this.Poption1.Click += new System.EventHandler(this.Poption1_Click);
            // 
            // Poption6
            // 
            this.Poption6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poption6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poption6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Poption6.Location = new System.Drawing.Point(874, 227);
            this.Poption6.Name = "Poption6";
            this.Poption6.Size = new System.Drawing.Size(84, 92);
            this.Poption6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poption6.TabIndex = 36;
            this.Poption6.TabStop = false;
            this.Poption6.Tag = "0";
            this.Poption6.Click += new System.EventHandler(this.Poption6_Click);
            // 
            // Poption5
            // 
            this.Poption5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poption5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poption5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Poption5.Location = new System.Drawing.Point(694, 227);
            this.Poption5.Name = "Poption5";
            this.Poption5.Size = new System.Drawing.Size(84, 92);
            this.Poption5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poption5.TabIndex = 35;
            this.Poption5.TabStop = false;
            this.Poption5.Tag = "0";
            this.Poption5.Click += new System.EventHandler(this.Poption5_Click);
            // 
            // Poption8
            // 
            this.Poption8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poption8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poption8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Poption8.Location = new System.Drawing.Point(694, 369);
            this.Poption8.Name = "Poption8";
            this.Poption8.Size = new System.Drawing.Size(84, 92);
            this.Poption8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poption8.TabIndex = 34;
            this.Poption8.TabStop = false;
            this.Poption8.Tag = "0";
            this.Poption8.Click += new System.EventHandler(this.Poption8_Click);
            // 
            // Poption9
            // 
            this.Poption9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poption9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poption9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Poption9.Location = new System.Drawing.Point(874, 369);
            this.Poption9.Name = "Poption9";
            this.Poption9.Size = new System.Drawing.Size(84, 92);
            this.Poption9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poption9.TabIndex = 33;
            this.Poption9.TabStop = false;
            this.Poption9.Tag = "0";
            this.Poption9.Click += new System.EventHandler(this.Poption9_Click);
            // 
            // Poption4
            // 
            this.Poption4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poption4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poption4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Poption4.Location = new System.Drawing.Point(532, 227);
            this.Poption4.Name = "Poption4";
            this.Poption4.Size = new System.Drawing.Size(84, 92);
            this.Poption4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poption4.TabIndex = 32;
            this.Poption4.TabStop = false;
            this.Poption4.Tag = "0";
            this.Poption4.Click += new System.EventHandler(this.Poption4_Click);
            // 
            // Poption7
            // 
            this.Poption7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poption7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poption7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Poption7.Location = new System.Drawing.Point(532, 369);
            this.Poption7.Name = "Poption7";
            this.Poption7.Size = new System.Drawing.Size(84, 92);
            this.Poption7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poption7.TabIndex = 31;
            this.Poption7.TabStop = false;
            this.Poption7.Tag = "0";
            this.Poption7.Click += new System.EventHandler(this.Poption7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1034, 503);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLastWinner);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Poption3);
            this.Controls.Add(this.Poption2);
            this.Controls.Add(this.Poption1);
            this.Controls.Add(this.Poption6);
            this.Controls.Add(this.Poption5);
            this.Controls.Add(this.Poption8);
            this.Controls.Add(this.Poption9);
            this.Controls.Add(this.Poption4);
            this.Controls.Add(this.Poption7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poption7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Poption6;
        private System.Windows.Forms.PictureBox Poption8;
        private System.Windows.Forms.PictureBox Poption9;
        private System.Windows.Forms.PictureBox Poption4;
        private System.Windows.Forms.PictureBox Poption7;
        private System.Windows.Forms.PictureBox Poption3;
        private System.Windows.Forms.PictureBox Poption2;
        private System.Windows.Forms.PictureBox Poption1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblLastWinner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox Poption5;
    }
}

