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
    public partial class diceGamesForm : Form {

        /// <summary>
        /// Form that is used to pick dice game
        /// 
        /// Author Quintus Cardozo
        /// Student Number: n9703578
        /// </summary>
        public diceGamesForm() {
            InitializeComponent();
        }

        private void diceGameSelection_CheckedChanged(object sender, EventArgs e) {

            if (singleDicePig.Checked) {
                pigGameForm OneDiceForm = new pigGameForm();
                OneDiceForm.Show();
                singleDicePig.Checked = false;
            } else if (twoDicePig.Checked) {
                pigWithTwoDiceForm TwoDiceForm = new pigWithTwoDiceForm();
                TwoDiceForm.Show();
                twoDicePig.Checked = false;
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
