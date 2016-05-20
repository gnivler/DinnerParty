namespace DogRaceLab {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.raceTrackPicture = new System.Windows.Forms.PictureBox();
            this.dog1Picture = new System.Windows.Forms.PictureBox();
            this.dog2Picture = new System.Windows.Forms.PictureBox();
            this.dog3Picture = new System.Windows.Forms.PictureBox();
            this.dog4Picture = new System.Windows.Forms.PictureBox();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.halRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.halBetLabel = new System.Windows.Forms.Label();
            this.bettorNameLabel = new System.Windows.Forms.Label();
            this.betUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.betButton = new System.Windows.Forms.Button();
            this.dogUpDown = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrackPicture
            // 
            this.raceTrackPicture.Image = global::DogRaceLab.Properties.Resources.racetrack;
            this.raceTrackPicture.Location = new System.Drawing.Point(0, 0);
            this.raceTrackPicture.Name = "raceTrackPicture";
            this.raceTrackPicture.Size = new System.Drawing.Size(600, 200);
            this.raceTrackPicture.TabIndex = 0;
            this.raceTrackPicture.TabStop = false;
            // 
            // dog1Picture
            // 
            this.dog1Picture.Image = global::DogRaceLab.Properties.Resources.dog;
            this.dog1Picture.Location = new System.Drawing.Point(0, 12);
            this.dog1Picture.Name = "dog1Picture";
            this.dog1Picture.Size = new System.Drawing.Size(75, 20);
            this.dog1Picture.TabIndex = 1;
            this.dog1Picture.TabStop = false;
            // 
            // dog2Picture
            // 
            this.dog2Picture.Image = global::DogRaceLab.Properties.Resources.dog;
            this.dog2Picture.Location = new System.Drawing.Point(0, 59);
            this.dog2Picture.Name = "dog2Picture";
            this.dog2Picture.Size = new System.Drawing.Size(75, 20);
            this.dog2Picture.TabIndex = 2;
            this.dog2Picture.TabStop = false;
            // 
            // dog3Picture
            // 
            this.dog3Picture.Image = global::DogRaceLab.Properties.Resources.dog;
            this.dog3Picture.Location = new System.Drawing.Point(0, 112);
            this.dog3Picture.Name = "dog3Picture";
            this.dog3Picture.Size = new System.Drawing.Size(75, 20);
            this.dog3Picture.TabIndex = 3;
            this.dog3Picture.TabStop = false;
            // 
            // dog4Picture
            // 
            this.dog4Picture.Image = global::DogRaceLab.Properties.Resources.dog;
            this.dog4Picture.Location = new System.Drawing.Point(0, 167);
            this.dog4Picture.Name = "dog4Picture";
            this.dog4Picture.Size = new System.Drawing.Size(75, 20);
            this.dog4Picture.TabIndex = 4;
            this.dog4Picture.TabStop = false;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(258, 231);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(89, 13);
            this.minimumBetLabel.TabIndex = 6;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(12, 281);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 7;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(12, 302);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 8;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // halRadioButton
            // 
            this.halRadioButton.AutoSize = true;
            this.halRadioButton.Location = new System.Drawing.Point(12, 325);
            this.halRadioButton.Name = "halRadioButton";
            this.halRadioButton.Size = new System.Drawing.Size(98, 17);
            this.halRadioButton.TabIndex = 9;
            this.halRadioButton.Text = "halRadioButton";
            this.halRadioButton.UseVisualStyleBackColor = true;
            this.halRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bets Placed";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(128, 281);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(130, 15);
            this.joeBetLabel.TabIndex = 11;
            this.joeBetLabel.Text = "joeBetLabel";
            this.joeBetLabel.Click += new System.EventHandler(this.joeBetLabel_Click);
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(128, 303);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(130, 15);
            this.bobBetLabel.TabIndex = 12;
            this.bobBetLabel.Text = "bobBetLabel";
            this.bobBetLabel.Click += new System.EventHandler(this.bobBetLabel_Click);
            // 
            // halBetLabel
            // 
            this.halBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.halBetLabel.Location = new System.Drawing.Point(128, 325);
            this.halBetLabel.Name = "halBetLabel";
            this.halBetLabel.Size = new System.Drawing.Size(130, 15);
            this.halBetLabel.TabIndex = 13;
            this.halBetLabel.Text = "halBetLabel";
            this.halBetLabel.Click += new System.EventHandler(this.halBetLabel_Click);
            // 
            // bettorNameLabel
            // 
            this.bettorNameLabel.Location = new System.Drawing.Point(298, 267);
            this.bettorNameLabel.Name = "bettorNameLabel";
            this.bettorNameLabel.Size = new System.Drawing.Size(40, 13);
            this.bettorNameLabel.TabIndex = 14;
            this.bettorNameLabel.Text = "bettor";
            // 
            // betUpDown
            // 
            this.betUpDown.Location = new System.Drawing.Point(383, 294);
            this.betUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betUpDown.Name = "betUpDown";
            this.betUpDown.Size = new System.Drawing.Size(40, 20);
            this.betUpDown.TabIndex = 15;
            this.betUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bet Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Bet On Dog #";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(488, 242);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(100, 100);
            this.raceButton.TabIndex = 22;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(348, 262);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 23;
            this.betButton.Text = "Place Bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // dogUpDown
            // 
            this.dogUpDown.Location = new System.Drawing.Point(383, 322);
            this.dogUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogUpDown.Name = "dogUpDown";
            this.dogUpDown.Size = new System.Drawing.Size(40, 20);
            this.dogUpDown.TabIndex = 24;
            this.dogUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Everyone - Place Your Bets!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "(click to clear)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 354);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dogUpDown);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.raceButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.betUpDown);
            this.Controls.Add(this.bettorNameLabel);
            this.Controls.Add(this.halBetLabel);
            this.Controls.Add(this.bobBetLabel);
            this.Controls.Add(this.joeBetLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.halRadioButton);
            this.Controls.Add(this.bobRadioButton);
            this.Controls.Add(this.joeRadioButton);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dog4Picture);
            this.Controls.Add(this.dog3Picture);
            this.Controls.Add(this.dog2Picture);
            this.Controls.Add(this.dog1Picture);
            this.Controls.Add(this.raceTrackPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A Day At The Races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrackPicture;
        private System.Windows.Forms.PictureBox dog1Picture;
        private System.Windows.Forms.PictureBox dog2Picture;
        private System.Windows.Forms.PictureBox dog3Picture;
        private System.Windows.Forms.PictureBox dog4Picture;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton halRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label halBetLabel;
        private System.Windows.Forms.Label bettorNameLabel;
        private System.Windows.Forms.NumericUpDown betUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.NumericUpDown dogUpDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

