namespace ADayAtTheRaces
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BettingParlorGroupBox = new System.Windows.Forms.GroupBox();
            this.dogNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.betBucksOnDogNumLabel = new System.Windows.Forms.Label();
            this.amountUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.betsButton = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.betsLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.Dog2PictureBox = new System.Windows.Forms.PictureBox();
            this.Dog3PictureBox = new System.Windows.Forms.PictureBox();
            this.Dog4PictureBox = new System.Windows.Forms.PictureBox();
            this.Dog1PictureBox = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.BettingParlorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BettingParlorGroupBox
            // 
            this.BettingParlorGroupBox.Controls.Add(this.dogNumUpDown);
            this.BettingParlorGroupBox.Controls.Add(this.betBucksOnDogNumLabel);
            this.BettingParlorGroupBox.Controls.Add(this.amountUpDown);
            this.BettingParlorGroupBox.Controls.Add(this.nameLabel);
            this.BettingParlorGroupBox.Controls.Add(this.betsButton);
            this.BettingParlorGroupBox.Controls.Add(this.alBetLabel);
            this.BettingParlorGroupBox.Controls.Add(this.bobBetLabel);
            this.BettingParlorGroupBox.Controls.Add(this.joeBetLabel);
            this.BettingParlorGroupBox.Controls.Add(this.raceButton);
            this.BettingParlorGroupBox.Controls.Add(this.betsLabel);
            this.BettingParlorGroupBox.Controls.Add(this.alRadioButton);
            this.BettingParlorGroupBox.Controls.Add(this.bobRadioButton);
            this.BettingParlorGroupBox.Controls.Add(this.joeRadioButton);
            this.BettingParlorGroupBox.Controls.Add(this.minimumBetLabel);
            this.BettingParlorGroupBox.Location = new System.Drawing.Point(13, 312);
            this.BettingParlorGroupBox.Name = "BettingParlorGroupBox";
            this.BettingParlorGroupBox.Size = new System.Drawing.Size(935, 240);
            this.BettingParlorGroupBox.TabIndex = 5;
            this.BettingParlorGroupBox.TabStop = false;
            this.BettingParlorGroupBox.Text = "Betting Parlor";
            // 
            // dogNumUpDown
            // 
            this.dogNumUpDown.Location = new System.Drawing.Point(382, 201);
            this.dogNumUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumUpDown.Name = "dogNumUpDown";
            this.dogNumUpDown.Size = new System.Drawing.Size(46, 20);
            this.dogNumUpDown.TabIndex = 13;
            this.dogNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betBucksOnDogNumLabel
            // 
            this.betBucksOnDogNumLabel.AutoSize = true;
            this.betBucksOnDogNumLabel.Location = new System.Drawing.Point(248, 203);
            this.betBucksOnDogNumLabel.Name = "betBucksOnDogNumLabel";
            this.betBucksOnDogNumLabel.Size = new System.Drawing.Size(110, 13);
            this.betBucksOnDogNumLabel.TabIndex = 12;
            this.betBucksOnDogNumLabel.Text = "bucks on dog number";
            // 
            // amountUpDown
            // 
            this.amountUpDown.Location = new System.Drawing.Point(176, 201);
            this.amountUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountUpDown.Name = "amountUpDown";
            this.amountUpDown.Size = new System.Drawing.Size(46, 20);
            this.amountUpDown.TabIndex = 11;
            this.amountUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountUpDown.ValueChanged += new System.EventHandler(this.amountUpDown_ValueChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(25, 203);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(24, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Joe";
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(71, 192);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(88, 34);
            this.betsButton.TabIndex = 9;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(251, 150);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(100, 23);
            this.alBetLabel.TabIndex = 8;
            this.alBetLabel.Text = "Al\'s Bet";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(251, 111);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(100, 23);
            this.bobBetLabel.TabIndex = 7;
            this.bobBetLabel.Text = "Bob\'s Bet";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(251, 71);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(100, 23);
            this.joeBetLabel.TabIndex = 6;
            this.joeBetLabel.Text = "Joe\'s Bet";
            // 
            // raceButton
            // 
            this.raceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceButton.Location = new System.Drawing.Point(626, 78);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(175, 82);
            this.raceButton.TabIndex = 5;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            // 
            // betsLabel
            // 
            this.betsLabel.AutoSize = true;
            this.betsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betsLabel.Location = new System.Drawing.Point(248, 34);
            this.betsLabel.Name = "betsLabel";
            this.betsLabel.Size = new System.Drawing.Size(35, 15);
            this.betsLabel.TabIndex = 4;
            this.betsLabel.Text = "Bets";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(10, 150);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(34, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "Al";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(10, 111);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(44, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(10, 71);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(7, 34);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(92, 15);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimum Bet";
            // 
            // Dog2PictureBox
            // 
            this.Dog2PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.pandaSliding;
            this.Dog2PictureBox.Location = new System.Drawing.Point(41, 98);
            this.Dog2PictureBox.Name = "Dog2PictureBox";
            this.Dog2PictureBox.Size = new System.Drawing.Size(100, 50);
            this.Dog2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog2PictureBox.TabIndex = 4;
            this.Dog2PictureBox.TabStop = false;
            // 
            // Dog3PictureBox
            // 
            this.Dog3PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.German_Shephard_Running;
            this.Dog3PictureBox.Location = new System.Drawing.Point(41, 174);
            this.Dog3PictureBox.Name = "Dog3PictureBox";
            this.Dog3PictureBox.Size = new System.Drawing.Size(100, 50);
            this.Dog3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog3PictureBox.TabIndex = 3;
            this.Dog3PictureBox.TabStop = false;
            // 
            // Dog4PictureBox
            // 
            this.Dog4PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.cheetah10_animated;
            this.Dog4PictureBox.Location = new System.Drawing.Point(41, 248);
            this.Dog4PictureBox.Name = "Dog4PictureBox";
            this.Dog4PictureBox.Size = new System.Drawing.Size(100, 50);
            this.Dog4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog4PictureBox.TabIndex = 2;
            this.Dog4PictureBox.TabStop = false;
            // 
            // Dog1PictureBox
            // 
            this.Dog1PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.dog_running;
            this.Dog1PictureBox.Location = new System.Drawing.Point(41, 21);
            this.Dog1PictureBox.Name = "Dog1PictureBox";
            this.Dog1PictureBox.Size = new System.Drawing.Size(100, 50);
            this.Dog1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog1PictureBox.TabIndex = 1;
            this.Dog1PictureBox.TabStop = false;
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = global::ADayAtTheRaces.Properties.Resources.TrackPic;
            this.racetrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(936, 300);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 564);
            this.Controls.Add(this.BettingParlorGroupBox);
            this.Controls.Add(this.Dog2PictureBox);
            this.Controls.Add(this.Dog3PictureBox);
            this.Controls.Add(this.Dog4PictureBox);
            this.Controls.Add(this.Dog1PictureBox);
            this.Controls.Add(this.racetrackPictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day At The Races";
            this.BettingParlorGroupBox.ResumeLayout(false);
            this.BettingParlorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.PictureBox Dog1PictureBox;
        private System.Windows.Forms.PictureBox Dog4PictureBox;
        private System.Windows.Forms.PictureBox Dog3PictureBox;
        private System.Windows.Forms.PictureBox Dog2PictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox BettingParlorGroupBox;
        private System.Windows.Forms.Label betBucksOnDogNumLabel;
        private System.Windows.Forms.NumericUpDown amountUpDown;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Label betsLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.NumericUpDown dogNumUpDown;
    }
}

