using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Game_Logic_Library;

namespace Games {
    public partial class solitaireForm : Form {
        TableLayoutPanel[] tableLayoutPanels;

        public solitaireForm() {
            InitializeComponent();
            tableLayoutPanels = new TableLayoutPanel[] { tableLayoutPanel1, tableLayoutPanel2,
                tableLayoutPanel3, tableLayoutPanel4, tableLayoutPanel5, tableLayoutPanel6,
                tableLayoutPanel7 };
            Solitare_Game.SetUpGame();

            for (int i = 0; i < tableLayoutPanels.Length; i++) {
                Hand hand = Solitare_Game.GetHand(i);
                int numOfCards = hand.GetCount();
                DisplayGuiHand(hand, tableLayoutPanels[i], numOfCards);
            }
            drawPileImage.Image = Images.GetBackOfCardImage();
        }

        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel, int lastCard) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            int cardNumber = 0;

            foreach (Card card in hand) {
                cardNumber++;
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);

                if (cardNumber == lastCard) {
                    pictureBox.Image = Images.GetCardImage(card);
                } else {
                    pictureBox.Image = Images.GetBackOfCardImage();
                }
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand
    }
}
