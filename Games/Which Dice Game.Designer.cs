namespace Games {
    partial class diceGamesForm {
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
            this.selectDiceGame = new System.Windows.Forms.GroupBox();
            this.twoDicePig = new System.Windows.Forms.RadioButton();
            this.singleDicePig = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.selectDiceGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectDiceGame
            // 
            this.selectDiceGame.Controls.Add(this.twoDicePig);
            this.selectDiceGame.Controls.Add(this.singleDicePig);
            this.selectDiceGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDiceGame.Location = new System.Drawing.Point(70, 57);
            this.selectDiceGame.Name = "selectDiceGame";
            this.selectDiceGame.Size = new System.Drawing.Size(356, 148);
            this.selectDiceGame.TabIndex = 0;
            this.selectDiceGame.TabStop = false;
            this.selectDiceGame.Text = "Select which pig to play";
            // 
            // twoDicePig
            // 
            this.twoDicePig.AutoSize = true;
            this.twoDicePig.Location = new System.Drawing.Point(22, 92);
            this.twoDicePig.Name = "twoDicePig";
            this.twoDicePig.Size = new System.Drawing.Size(181, 29);
            this.twoDicePig.TabIndex = 1;
            this.twoDicePig.Text = "Two Dice Pig";
            this.twoDicePig.UseVisualStyleBackColor = true;
            this.twoDicePig.CheckedChanged += new System.EventHandler(this.diceGameSelection_CheckedChanged);
            // 
            // singleDicePig
            // 
            this.singleDicePig.AutoSize = true;
            this.singleDicePig.Location = new System.Drawing.Point(22, 41);
            this.singleDicePig.Name = "singleDicePig";
            this.singleDicePig.Size = new System.Drawing.Size(192, 29);
            this.singleDicePig.TabIndex = 0;
            this.singleDicePig.Text = "Single Die Pig";
            this.singleDicePig.UseVisualStyleBackColor = true;
            this.singleDicePig.CheckedChanged += new System.EventHandler(this.diceGameSelection_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(170, 252);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(159, 36);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // diceGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 379);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectDiceGame);
            this.Name = "diceGamesForm";
            this.Text = "Dice Games";
            this.selectDiceGame.ResumeLayout(false);
            this.selectDiceGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox selectDiceGame;
        private System.Windows.Forms.RadioButton twoDicePig;
        private System.Windows.Forms.RadioButton singleDicePig;
        private System.Windows.Forms.Button exitButton;
    }
}