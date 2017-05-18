namespace Games {
    partial class twentyOneGameForm {
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
            this.dealerTable = new System.Windows.Forms.TableLayoutPanel();
            this.playerTable = new System.Windows.Forms.TableLayoutPanel();
            this.dealerPointsLabel = new System.Windows.Forms.Label();
            this.playerPointsLabel = new System.Windows.Forms.Label();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.dealerBustedLabel = new System.Windows.Forms.Label();
            this.playerBustedLabel = new System.Windows.Forms.Label();
            this.dealerGamesWonLabel = new System.Windows.Forms.Label();
            this.playerGamesWonLabel = new System.Windows.Forms.Label();
            this.dealerGamesWonText = new System.Windows.Forms.TextBox();
            this.playerGamesWonText = new System.Windows.Forms.TextBox();
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dealerTable
            // 
            this.dealerTable.ColumnCount = 8;
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.Location = new System.Drawing.Point(10, 46);
            this.dealerTable.Name = "dealerTable";
            this.dealerTable.RowCount = 1;
            this.dealerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dealerTable.Size = new System.Drawing.Size(576, 95);
            this.dealerTable.TabIndex = 0;
            // 
            // playerTable
            // 
            this.playerTable.ColumnCount = 8;
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.Location = new System.Drawing.Point(9, 158);
            this.playerTable.Name = "playerTable";
            this.playerTable.RowCount = 1;
            this.playerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerTable.Size = new System.Drawing.Size(576, 95);
            this.playerTable.TabIndex = 1;
            // 
            // dealerPointsLabel
            // 
            this.dealerPointsLabel.AutoSize = true;
            this.dealerPointsLabel.Location = new System.Drawing.Point(272, 9);
            this.dealerPointsLabel.Name = "dealerPointsLabel";
            this.dealerPointsLabel.Size = new System.Drawing.Size(89, 25);
            this.dealerPointsLabel.TabIndex = 2;
            this.dealerPointsLabel.Text = "POINTS";
            // 
            // playerPointsLabel
            // 
            this.playerPointsLabel.AutoSize = true;
            this.playerPointsLabel.Location = new System.Drawing.Point(272, 263);
            this.playerPointsLabel.Name = "playerPointsLabel";
            this.playerPointsLabel.Size = new System.Drawing.Size(89, 25);
            this.playerPointsLabel.TabIndex = 3;
            this.playerPointsLabel.Text = "POINTS";
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerLabel.Location = new System.Drawing.Point(159, 9);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(81, 25);
            this.dealerLabel.TabIndex = 4;
            this.dealerLabel.Text = "Dealer";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(161, 263);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(79, 25);
            this.playerLabel.TabIndex = 5;
            this.playerLabel.Text = "Player";
            // 
            // dealerBustedLabel
            // 
            this.dealerBustedLabel.AutoSize = true;
            this.dealerBustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerBustedLabel.ForeColor = System.Drawing.Color.Red;
            this.dealerBustedLabel.Location = new System.Drawing.Point(15, 9);
            this.dealerBustedLabel.Name = "dealerBustedLabel";
            this.dealerBustedLabel.Size = new System.Drawing.Size(103, 25);
            this.dealerBustedLabel.TabIndex = 6;
            this.dealerBustedLabel.Text = "BUSTED";
            // 
            // playerBustedLabel
            // 
            this.playerBustedLabel.AutoSize = true;
            this.playerBustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBustedLabel.ForeColor = System.Drawing.Color.Red;
            this.playerBustedLabel.Location = new System.Drawing.Point(15, 263);
            this.playerBustedLabel.Name = "playerBustedLabel";
            this.playerBustedLabel.Size = new System.Drawing.Size(103, 25);
            this.playerBustedLabel.TabIndex = 7;
            this.playerBustedLabel.Text = "BUSTED";
            // 
            // dealerGamesWonLabel
            // 
            this.dealerGamesWonLabel.AutoSize = true;
            this.dealerGamesWonLabel.Location = new System.Drawing.Point(393, 9);
            this.dealerGamesWonLabel.Name = "dealerGamesWonLabel";
            this.dealerGamesWonLabel.Size = new System.Drawing.Size(130, 25);
            this.dealerGamesWonLabel.TabIndex = 8;
            this.dealerGamesWonLabel.Text = "Games Won";
            // 
            // playerGamesWonLabel
            // 
            this.playerGamesWonLabel.AutoSize = true;
            this.playerGamesWonLabel.Location = new System.Drawing.Point(393, 263);
            this.playerGamesWonLabel.Name = "playerGamesWonLabel";
            this.playerGamesWonLabel.Size = new System.Drawing.Size(130, 25);
            this.playerGamesWonLabel.TabIndex = 9;
            this.playerGamesWonLabel.Text = "Games Won";
            // 
            // dealerGamesWonText
            // 
            this.dealerGamesWonText.Location = new System.Drawing.Point(523, 7);
            this.dealerGamesWonText.Name = "dealerGamesWonText";
            this.dealerGamesWonText.Size = new System.Drawing.Size(40, 31);
            this.dealerGamesWonText.TabIndex = 10;
            // 
            // playerGamesWonText
            // 
            this.playerGamesWonText.Location = new System.Drawing.Point(523, 259);
            this.playerGamesWonText.Name = "playerGamesWonText";
            this.playerGamesWonText.Size = new System.Drawing.Size(40, 31);
            this.playerGamesWonText.TabIndex = 11;
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(20, 324);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(80, 39);
            this.dealButton.TabIndex = 12;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(119, 324);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(87, 39);
            this.hitButton.TabIndex = 13;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(221, 324);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(106, 39);
            this.standButton.TabIndex = 14;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(333, 324);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 39);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(500, 306);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(78, 40);
            this.testButton.TabIndex = 16;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // twentyOneGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 389);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.playerGamesWonText);
            this.Controls.Add(this.dealerGamesWonText);
            this.Controls.Add(this.playerGamesWonLabel);
            this.Controls.Add(this.dealerGamesWonLabel);
            this.Controls.Add(this.playerBustedLabel);
            this.Controls.Add(this.dealerBustedLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.playerPointsLabel);
            this.Controls.Add(this.dealerPointsLabel);
            this.Controls.Add(this.playerTable);
            this.Controls.Add(this.dealerTable);
            this.Name = "twentyOneGameForm";
            this.Text = "TwentyOne Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel dealerTable;
        private System.Windows.Forms.TableLayoutPanel playerTable;
        private System.Windows.Forms.Label dealerPointsLabel;
        private System.Windows.Forms.Label playerPointsLabel;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label dealerBustedLabel;
        private System.Windows.Forms.Label playerBustedLabel;
        private System.Windows.Forms.Label dealerGamesWonLabel;
        private System.Windows.Forms.Label playerGamesWonLabel;
        private System.Windows.Forms.TextBox dealerGamesWonText;
        private System.Windows.Forms.TextBox playerGamesWonText;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button testButton;
    }
}