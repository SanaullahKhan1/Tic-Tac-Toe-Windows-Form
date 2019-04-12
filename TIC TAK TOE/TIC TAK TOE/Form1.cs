using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAK_TOE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Player = 2;
        int turn = 0;
        //For Check who wins
        int W1 = 0;
        int W2 = 0;
        int D0 = 0;
        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (Player % 2 == 0)
                {
                    button.Text = "X";
                    button.BackColor = Color.Cyan;
                    turn++;
                    Player++;
                }
                else
                {
                    button.Text = "O";
                    button.BackColor = Color.BlueViolet;
                    turn++;
                    Player++;
                }
                if (CheckDraw() == true)
                {
                    MessageBox.Show(" GAME Draw ");
                    D0++;
                    DrawLabal.Text = D0.ToString();
                    NewGame();
                }
                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X is Winner");
                        NewGame();
                        W1++;
                        XLabel.Text = W1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("O is Winner");
                        NewGame();
                        W2++;
                        OLabel.Text = W2.ToString();
                    }
                }
            }
        }
        bool CheckDraw()
        {
            if (turn == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void NewGame()
        {

            Player = 2;
            turn = 0;
            A01.Text = B02.Text = C03.Text = D11.Text = E12.Text = F13.Text = G21.Text = H22.Text = I23.Text = "";
            A01.BackColor = B02.BackColor = C03.BackColor = D11.BackColor = E12.BackColor = F13.BackColor = G21.BackColor = H22.BackColor = I23.BackColor = Color.Transparent;
        }

        bool CheckWinner()
        {
            //Horizontal Check
            if ((A01.Text == B02.Text) && (B02.Text == C03.Text) && A01.Text != "")
                return true;
            else if ((D11.Text == E12.Text) && (E12.Text == F13.Text) && D11.Text != "")
                return true;
            else if ((G21.Text == H22.Text) && (H22.Text == I23.Text) && G21.Text != "")
                return true;

            //Vertical Check
            if ((A01.Text == D11.Text) && (D11.Text == G21.Text) && A01.Text != "")
                return true;
            else if ((B02.Text == E12.Text) && (E12.Text == H22.Text) && B02.Text != "")
                return true;
            else if ((G21.Text == H22.Text) && (H22.Text == I23.Text) && G21.Text != "")
                return true;

            //Diagonal Check
            if ((A01.Text == E12.Text) && (E12.Text == I23.Text) && A01.Text != "")
                return true;
            else if ((C03.Text == E12.Text) && (E12.Text == G21.Text) && C03.Text != "")
                return true;

            return false;

        }
        private void button10_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
