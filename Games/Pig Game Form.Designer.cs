namespace Class_Assignment {
    partial class pigGameForm {
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
            this.turnLabel = new System.Windows.Forms.Label();
            this.rollOrHoldLabel = new System.Windows.Forms.Label();
            this.diceImage = new System.Windows.Forms.PictureBox();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.playerOneText = new System.Windows.Forms.TextBox();
            this.playerTwoText = new System.Windows.Forms.TextBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.holdButton = new System.Windows.Forms.Button();
            this.anotherGameGroup = new System.Windows.Forms.GroupBox();
            this.yesButton = new System.Windows.Forms.RadioButton();
            this.noButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage)).BeginInit();
            this.anotherGameGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.Location = new System.Drawing.Point(63, 82);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(195, 31);
            this.turnLabel.TabIndex = 0;
            this.turnLabel.Text = "Whose turn to";
            // 
            // rollOrHoldLabel
            // 
            this.rollOrHoldLabel.AutoSize = true;
            this.rollOrHoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollOrHoldLabel.Location = new System.Drawing.Point(69, 129);
            this.rollOrHoldLabel.Name = "rollOrHoldLabel";
            this.rollOrHoldLabel.Size = new System.Drawing.Size(151, 31);
            this.rollOrHoldLabel.TabIndex = 1;
            this.rollOrHoldLabel.Text = "roll or hold";
            // 
            // diceImage
            // 
            this.diceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diceImage.Location = new System.Drawing.Point(298, 96);
            this.diceImage.Name = "diceImage";
            this.diceImage.Size = new System.Drawing.Size(55, 55);
            this.diceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceImage.TabIndex = 2;
            this.diceImage.TabStop = false;
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneLabel.Location = new System.Drawing.Point(414, 87);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(159, 25);
            this.playerOneLabel.TabIndex = 3;
            this.playerOneLabel.Text = "Player 1 Total";
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoLabel.Location = new System.Drawing.Point(414, 143);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(159, 25);
            this.playerTwoLabel.TabIndex = 4;
            this.playerTwoLabel.Text = "Player 2 Total";
            // 
            // playerOneText
            // 
            this.playerOneText.Location = new System.Drawing.Point(591, 81);
            this.playerOneText.Name = "playerOneText";
            this.playerOneText.Size = new System.Drawing.Size(159, 31);
            this.playerOneText.TabIndex = 5;
            // 
            // playerTwoText
            // 
            this.playerTwoText.Location = new System.Drawing.Point(591, 137);
            this.playerTwoText.Name = "playerTwoText";
            this.playerTwoText.Size = new System.Drawing.Size(159, 31);
            this.playerTwoText.TabIndex = 6;
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.Lime;
            this.rollButton.Location = new System.Drawing.Point(91, 272);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(114, 42);
            this.rollButton.TabIndex = 7;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = false;
            // 
            // holdButton
            // 
            this.holdButton.BackColor = System.Drawing.Color.Red;
            this.holdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.holdButton.Location = new System.Drawing.Point(238, 272);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(107, 42);
            this.holdButton.TabIndex = 8;
            this.holdButton.Text = "Hold";
            this.holdButton.UseVisualStyleBackColor = false;
            // 
            // anotherGameGroup
            // 
            this.anotherGameGroup.Controls.Add(this.noButton);
            this.anotherGameGroup.Controls.Add(this.yesButton);
            this.anotherGameGroup.Location = new System.Drawing.Point(491, 225);
            this.anotherGameGroup.Name = "anotherGameGroup";
            this.anotherGameGroup.Size = new System.Drawing.Size(230, 118);
            this.anotherGameGroup.TabIndex = 9;
            this.anotherGameGroup.TabStop = false;
            this.anotherGameGroup.Text = "Another Game ?";
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.Location = new System.Drawing.Point(14, 34);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(81, 29);
            this.yesButton.TabIndex = 0;
            this.yesButton.TabStop = true;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.Location = new System.Drawing.Point(14, 73);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(70, 29);
            this.noButton.TabIndex = 1;
            this.noButton.TabStop = true;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            // 
            // pigGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 395);
            this.Controls.Add(this.anotherGameGroup);
            this.Controls.Add(this.holdButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.playerTwoText);
            this.Controls.Add(this.playerOneText);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerOneLabel);
            this.Controls.Add(this.diceImage);
            this.Controls.Add(this.rollOrHoldLabel);
            this.Controls.Add(this.turnLabel);
            this.Name = "pigGameForm";
            this.Text = "Pig Game";
            ((System.ComponentModel.ISupportInitialize)(this.diceImage)).EndInit();
            this.anotherGameGroup.ResumeLayout(false);
            this.anotherGameGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label rollOrHoldLabel;
        private System.Windows.Forms.PictureBox diceImage;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.TextBox playerOneText;
        private System.Windows.Forms.TextBox playerTwoText;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button holdButton;
        private System.Windows.Forms.GroupBox anotherGameGroup;
        private System.Windows.Forms.RadioButton noButton;
        private System.Windows.Forms.RadioButton yesButton;
    }
}