namespace Games {
    partial class gamesForm {
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
            this.headingLabel = new System.Windows.Forms.Label();
            this.gameType = new System.Windows.Forms.GroupBox();
            this.cardGame = new System.Windows.Forms.RadioButton();
            this.diceGame = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gameType.SuspendLayout();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(89, 37);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(291, 37);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Interactive Games";
            // 
            // gameType
            // 
            this.gameType.Controls.Add(this.cardGame);
            this.gameType.Controls.Add(this.diceGame);
            this.gameType.Location = new System.Drawing.Point(103, 117);
            this.gameType.Name = "gameType";
            this.gameType.Size = new System.Drawing.Size(267, 158);
            this.gameType.TabIndex = 1;
            this.gameType.TabStop = false;
            this.gameType.Text = "Select Game Type";
            // 
            // cardGame
            // 
            this.cardGame.AutoSize = true;
            this.cardGame.Location = new System.Drawing.Point(19, 99);
            this.cardGame.Name = "cardGame";
            this.cardGame.Size = new System.Drawing.Size(152, 29);
            this.cardGame.TabIndex = 1;
            this.cardGame.Text = "Card Game";
            this.cardGame.UseVisualStyleBackColor = true;
            this.cardGame.CheckedChanged += new System.EventHandler(this.gameSelection_CheckedChanged);
            // 
            // diceGame
            // 
            this.diceGame.AutoSize = true;
            this.diceGame.Location = new System.Drawing.Point(19, 46);
            this.diceGame.Name = "diceGame";
            this.diceGame.Size = new System.Drawing.Size(149, 29);
            this.diceGame.TabIndex = 0;
            this.diceGame.Text = "Dice Game";
            this.diceGame.UseVisualStyleBackColor = true;
            this.diceGame.CheckedChanged += new System.EventHandler(this.gameSelection_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(162, 340);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(139, 41);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(162, 434);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 41);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 566);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameType);
            this.Controls.Add(this.headingLabel);
            this.Name = "gamesForm";
            this.Text = "Games";
            this.gameType.ResumeLayout(false);
            this.gameType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.GroupBox gameType;
        private System.Windows.Forms.RadioButton cardGame;
        private System.Windows.Forms.RadioButton diceGame;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
    }
}

