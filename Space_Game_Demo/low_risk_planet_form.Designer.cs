﻿
namespace Space_Game_Demo
{
    partial class low_risk_planet_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(low_risk_planet_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBeginGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mineButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResourceMined = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBeginGame
            // 
            this.btnBeginGame.BackColor = System.Drawing.Color.Black;
            this.btnBeginGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginGame.ForeColor = System.Drawing.Color.Lime;
            this.btnBeginGame.Location = new System.Drawing.Point(55, 14);
            this.btnBeginGame.Name = "btnBeginGame";
            this.btnBeginGame.Size = new System.Drawing.Size(287, 64);
            this.btnBeginGame.TabIndex = 4;
            this.btnBeginGame.Text = "Ship Equipment";
            this.btnBeginGame.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resources Mined:";
            // 
            // mineButton
            // 
            this.mineButton.BackColor = System.Drawing.Color.Black;
            this.mineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mineButton.ForeColor = System.Drawing.Color.Lime;
            this.mineButton.Location = new System.Drawing.Point(248, 485);
            this.mineButton.Name = "mineButton";
            this.mineButton.Size = new System.Drawing.Size(197, 64);
            this.mineButton.TabIndex = 7;
            this.mineButton.Text = "Mine";
            this.mineButton.UseVisualStyleBackColor = false;
            this.mineButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(449, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(188, 199);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(449, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 64);
            this.button3.TabIndex = 10;
            this.button3.Text = "Purchase";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(396, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Parts Available:";
            // 
            // lblResourceMined
            // 
            this.lblResourceMined.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResourceMined.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResourceMined.Enabled = false;
            this.lblResourceMined.ForeColor = System.Drawing.Color.Lime;
            this.lblResourceMined.Location = new System.Drawing.Point(408, 422);
            this.lblResourceMined.Name = "lblResourceMined";
            this.lblResourceMined.Size = new System.Drawing.Size(180, 45);
            this.lblResourceMined.TabIndex = 15;
            this.lblResourceMined.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // low_risk_planet_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 621);
            this.Controls.Add(this.lblResourceMined);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.mineButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBeginGame);
            this.Controls.Add(this.pictureBox1);
            this.Name = "low_risk_planet_form";
            this.Text = "low_risk_planet_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBeginGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mineButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResourceMined;
    }
}