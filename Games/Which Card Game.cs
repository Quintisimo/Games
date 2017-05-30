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
    public partial class cardGamesForm : Form {

        private twentyOneGameForm TwentyOneForm;


        public cardGamesForm() {
            InitializeComponent();
            cardGameSelection.Items.Add("");
            cardGameSelection.Items.Add("Solitaire");
            cardGameSelection.Items.Add("Twenty-One");
        }

        private void exitButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to quit ?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes) {
                this.Close();
            }
        }

        private void cardGameSelection_SelectedIndexChanged(object sender, EventArgs e) {
            int solitaire = 1;
            int twentyOne = 2;
            int reset = -1;

            if (cardGameSelection.SelectedIndex == solitaire) {
                solitaireForm SolitaireForm = new solitaireForm();
           
                cardGameSelection.SelectedIndex = reset;
                SolitaireForm.Show();
            } else if (cardGameSelection.SelectedIndex == twentyOne) {

                if (TwentyOneForm == null || TwentyOneForm.IsDisposed) {
                    TwentyOneForm = new twentyOneGameForm();
                }
                cardGameSelection.SelectedIndex = reset;
                TwentyOneForm.Show();
            }
        }
    }
}
