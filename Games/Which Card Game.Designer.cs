namespace Games {
    partial class cardGamesForm {
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
            this.cardGameSelection = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(56, 28);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(377, 37);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Choose a Game to Play";
            // 
            // cardGameSelection
            // 
            this.cardGameSelection.FormattingEnabled = true;
            this.cardGameSelection.Location = new System.Drawing.Point(145, 82);
            this.cardGameSelection.Name = "cardGameSelection";
            this.cardGameSelection.Size = new System.Drawing.Size(172, 33);
            this.cardGameSelection.TabIndex = 1;
            this.cardGameSelection.SelectedIndexChanged += new System.EventHandler(this.cardGameSelection_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(161, 202);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cardGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 350);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cardGameSelection);
            this.Controls.Add(this.headingLabel);
            this.Name = "cardGamesForm";
            this.Text = "Card Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.ComboBox cardGameSelection;
        private System.Windows.Forms.Button exitButton;
    }
}