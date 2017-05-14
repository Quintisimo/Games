using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Logic_Library;

namespace Games {
    public partial class pigGameForm : Form {
        public pigGameForm() {
            InitializeComponent();
            anotherGameGroup.Enabled = false;
            holdButton.Enabled = false;
            Pig_Single_Die_Game.SetUpGame();
            DiceImage();
        }

        private void DiceImage() {
            diceImage.Image = Images.GetDieImage(Pig_Single_Die_Game.GetFaceValue());
        }
    }
}
