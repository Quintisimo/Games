using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games {
    public partial class gamesForm : Form {
        public gamesForm() {
            InitializeComponent();
            startButton.Enabled = false;
        }

        private void gameSelection_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;
        }

        private void startButton_Click(object sender, EventArgs e) {
            if (diceGame.Checked) {
                diceGamesForm DiceGameForm = new diceGamesForm();
                DiceGameForm.Show();
                diceGame.Checked = false;
            } else if (cardGame.Checked) {
                cardGamesForm CardGameForm = new cardGamesForm();
                CardGameForm.Show();
                cardGame.Checked = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to quit ?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes) {
                this.Close();
            }
        }
    }
}
