using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeeSnakeLadderV5._0
{
    public partial class Form1 : Form
    {
        public static String gameVersion = "V5.32";
        public static string lastUpdateDate = "20/11/2020";
        Random r = new Random();
        private bool playerOneTwo = true;
        private bool playerOneOnline = false;
        private bool playerTwoOnline = false;
        private int playerOnePosition = -5, playerTwoPosition = -5;
        int playerOnePreviousPosition = 0, playerTwoPreviousPosition = 0;
        private PictureBox[] pic = new PictureBox[101];

        public Form1()
        {
            InitializeComponent();
            pic[1] = pictureBox1;
            pic[2] = pictureBox2;
            pic[3] = pictureBox3;
            pic[4] = pictureBox4;
            pic[5] = pictureBox5;
            pic[6] = pictureBox6;
            pic[7] = pictureBox7;
            pic[8] = pictureBox8;
            pic[9] = pictureBox9;
            pic[10] = pictureBox10;
            pic[11] = pictureBox11;
            pic[12] = pictureBox12;
            pic[13] = pictureBox13;
            pic[14] = pictureBox14;
            pic[15] = pictureBox15;
            pic[16] = pictureBox16;
            pic[17] = pictureBox17;
            pic[18] = pictureBox18;
            pic[19] = pictureBox19;
            pic[20] = pictureBox20;
            pic[21] = pictureBox21;
            pic[22] = pictureBox22;
            pic[23] = pictureBox23;
            pic[24] = pictureBox24;
            pic[25] = pictureBox25;
            pic[26] = pictureBox26;
            pic[27] = pictureBox27;
            pic[28] = pictureBox28;
            pic[29] = pictureBox29;
            pic[30] = pictureBox30;
            pic[31] = pictureBox31;
            pic[32] = pictureBox32;
            pic[33] = pictureBox33;
            pic[34] = pictureBox34;
            pic[35] = pictureBox35;
            pic[36] = pictureBox36;
            pic[37] = pictureBox37;
            pic[38] = pictureBox38;
            pic[39] = pictureBox39;
            pic[40] = pictureBox40;
            pic[41] = pictureBox41;
            pic[42] = pictureBox42;
            pic[43] = pictureBox43;
            pic[44] = pictureBox44;
            pic[45] = pictureBox45;
            pic[46] = pictureBox46;
            pic[47] = pictureBox47;
            pic[48] = pictureBox48;
            pic[49] = pictureBox49;
            pic[50] = pictureBox50;
            pic[51] = pictureBox51;
            pic[52] = pictureBox52;
            pic[53] = pictureBox53;
            pic[54] = pictureBox54;
            pic[55] = pictureBox55;
            pic[56] = pictureBox56;
            pic[57] = pictureBox57;
            pic[58] = pictureBox58;
            pic[59] = pictureBox59;
            pic[60] = pictureBox60;
            pic[61] = pictureBox61;
            pic[62] = pictureBox62;
            pic[63] = pictureBox63;
            pic[64] = pictureBox64;
            pic[65] = pictureBox65;
            pic[66] = pictureBox66;
            pic[67] = pictureBox67;
            pic[68] = pictureBox68;
            pic[69] = pictureBox69;
            pic[70] = pictureBox70;
            pic[71] = pictureBox71;
            pic[72] = pictureBox72;
            pic[73] = pictureBox73;
            pic[74] = pictureBox74;
            pic[75] = pictureBox75;
            pic[76] = pictureBox76;
            pic[77] = pictureBox77;
            pic[78] = pictureBox78;
            pic[79] = pictureBox79;
            pic[80] = pictureBox80;
            pic[81] = pictureBox81;
            pic[82] = pictureBox82;
            pic[83] = pictureBox83;
            pic[84] = pictureBox84;
            pic[85] = pictureBox85;
            pic[86] = pictureBox86;
            pic[87] = pictureBox87;
            pic[88] = pictureBox88;
            pic[89] = pictureBox89;
            pic[90] = pictureBox90;
            pic[91] = pictureBox91;
            pic[92] = pictureBox92;
            pic[93] = pictureBox93;
            pic[94] = pictureBox94;
            pic[95] = pictureBox95;
            pic[96] = pictureBox96;
            pic[97] = pictureBox97;
            pic[98] = pictureBox98;
            pic[99] = pictureBox99;
            pic[100] = pictureBox100;
        }

        private void RollDiceButton_Click(object sender, EventArgs e)
        {
            Dice();
        }

        private void Dice()
        {
            int rand1 = 0;
            int rand2 = 0;

            if (playerOneTwo)
            {
                rand1 = (r.Next() % 6) + 1;
                labelDiceRoll.Text = rand1.ToString();
                RollDicePic(rand1);

                playerOneTwo = false;
                radioButton1.Checked = true;

                if (rand1 == 6)
                {
                    playerOneOnline = true;
                }
                movePlayerOne(rand1);
            }
            else if (playerOneTwo == false)
            {
                rand2 = (r.Next() % 6) + 1;
                labelDiceRoll.Text = rand2.ToString();
                RollDicePic(rand2);

                playerOneTwo = true;
                radioButton2.Checked = true;
                if (rand2 == 6)
                {
                    playerTwoOnline = true;
                }
                movePlayerTwo(rand2);
            }

        }

        private void RollDicePic(int ran)
        {
            switch (ran)
            {
                case 1:
                    pictureBoxDice.Image = Properties.Resources.dice1;
                    pictureBoxDice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    pictureBoxDice.Image = Properties.Resources.dice2;
                    pictureBoxDice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    pictureBoxDice.Image = Properties.Resources.dice3;
                    pictureBoxDice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 4:
                    pictureBoxDice.Image = Properties.Resources.dice4;
                    pictureBoxDice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 5:
                    pictureBoxDice.Image = Properties.Resources.dice5;
                    pictureBoxDice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 6:
                    pictureBoxDice.Image = Properties.Resources.dice6;
                    pictureBoxDice.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                default:
                    break;
            }
        }

        private void movePlayerOne(int diceNumber1)
        {
            if (playerOneOnline)
            {
                playerOnePosition += diceNumber1;
                snakeLadder(playerOnePosition, true);
                beforeWinningRules(playerOnePosition, diceNumber1, true);
                movePlayersToken(playerOnePosition, true, playerOnePreviousPosition);
                playerOnePreviousPosition = playerOnePosition;
                labelPOneScore.Text = playerOnePosition.ToString();
                winner();
            }
        }
        private void movePlayerTwo(int diceNumber2)
        {
            if (playerTwoOnline)
            {
                playerTwoPosition += diceNumber2;
                snakeLadder(playerTwoPosition, false);
                beforeWinningRules(playerTwoPosition, diceNumber2, false);
                movePlayersToken(playerTwoPosition, false, playerTwoPreviousPosition);
                playerTwoPreviousPosition = playerTwoPosition;
                labelPTwoScore.Text = playerTwoPosition.ToString();
                winner();
            }
        }

        private void beforeWinningRules(int playerPosition, int diceNumber, bool chk)
        {
            if (playerPosition > 100 && chk)
            {
                playerOnePosition -= diceNumber;
            }
            else if (playerPosition > 100 && chk == false)
            {
                playerTwoPosition -= diceNumber;
            }
        }

        private void winner()
        {
            DialogResult dRedult = DialogResult.Abort;
            if (playerOnePosition == 100)
            {
                letsCelebrate.BringToFront();
                letsCelebrate.Visible = true;
                dRedult  = MessageBox.Show("Player One ( Purple ) is Winner!\nWant to Play Again?", "Winner",MessageBoxButtons.YesNo);
                
            }

            if (playerTwoPosition == 100)
            {
                letsCelebrate.BringToFront();
                letsCelebrate.Visible = true;
                dRedult = MessageBox.Show("Player Two ( Green ) is Winner!\nWant to Play Again?", "Winner",MessageBoxButtons.YesNo);
            }

            if (dRedult == DialogResult.Yes)
            {
                letsCelebrate.Visible = false;
                restartGame();
            }

            if (dRedult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void snakeLadder(int playerPosition, bool chk)
        {
            animate.Image = null;
            switch (playerPosition)
            {
                case 2:
                    if (chk)
                    {
                        playerOnePosition += 36;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    else
                    {
                        playerTwoPosition += 36;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    break;
                case 7:
                    if (chk)
                    {
                        playerOnePosition += 7;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    else
                    {
                        playerTwoPosition += 7;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    break;
                case 8:
                    if (chk)
                    {
                        playerOnePosition += 23;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    else
                    {
                        playerTwoPosition += 23;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    break;
                case 15:
                    if (chk)
                    {
                        playerOnePosition += 11;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    else
                    {
                        playerTwoPosition += 11;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    break;
                case 16:
                    if (chk)
                    {
                        playerOnePosition -= 10;
                        animate.Image = Properties.Resources.Snake;
                    }
                    else
                    {
                        playerTwoPosition -= 10;
                        animate.Image = Properties.Resources.Snake;
                    }
                    break;
                case 21:
                    if (chk)
                    {
                        playerOnePosition += 21;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    else
                    {
                        playerTwoPosition += 21;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    break;
                case 28:
                    if (chk)
                    {
                        playerOnePosition += 56;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    else
                    {
                        playerTwoPosition += 56;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    break;
                case 36:
                    if (chk)
                    {
                        playerOnePosition += 8;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    else
                    {
                        playerTwoPosition += 8;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    break;
                case 46:
                    if (chk)
                    {
                        playerOnePosition -= 21;
                        animate.Image = Properties.Resources.Snake;
                    }
                    else
                    {
                        playerTwoPosition -= 21;
                        animate.Image = Properties.Resources.Snake;
                    }
                    break;
                case 49:
                    if (chk)
                    {
                        playerOnePosition -= 38;
                        animate.Image = Properties.Resources.Snake;
                    }
                    else
                    {
                        playerTwoPosition -= 38;
                        animate.Image = Properties.Resources.Snake;
                    }
                    break;
                case 51:
                    if (chk)
                    {
                        playerOnePosition += 16;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    else
                    {
                        playerTwoPosition += 16;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    break;
                case 62:
                    if (chk)
                    {
                        playerOnePosition -= 43;
                        animate.Image = Properties.Resources.Snake;
                    }
                    else
                    {
                        playerTwoPosition -= 43;
                        animate.Image = Properties.Resources.Snake;
                    }
                    break;
                case 64:
                    if (chk)
                    {
                        playerOnePosition -= 4;
                        animate.Image = Properties.Resources.Snake;
                    }
                    else
                    {
                        playerTwoPosition -= 4;
                        animate.Image = Properties.Resources.Snake;
                    }
                    break;
                case 71:
                    if (chk)
                    {
                        playerOnePosition += 20;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    else
                    {
                        playerTwoPosition += 20;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    break;
                case 74:
                    if (chk)
                    {
                        playerOnePosition -= 21;
                        animate.Image = Properties.Resources.Snake;
                    }
                    else
                    {
                        playerTwoPosition -= 21;
                        animate.Image = Properties.Resources.Snake;
                    }
                    break;
                case 78:
                    if (chk)
                    {
                        playerOnePosition += 20;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    else
                    {
                        playerTwoPosition += 20;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    break;
                case 87:
                    if (chk)
                    {
                        playerOnePosition += 7;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    else
                    {
                        playerTwoPosition += 7;
                        animate.Image = Properties.Resources.Ladder;
                    }
                    break;
                case 89:
                    if (chk)
                    {
                        playerOnePosition -= 21;
                        animate.Image = Properties.Resources.Snake;
                    }
                    else
                    {
                        playerTwoPosition -= 21;
                        animate.Image = Properties.Resources.Snake;
                    }
                    break;
                case 92:
                    if (chk)
                    {
                        playerOnePosition -= 4;
                        animate.Image = Properties.Resources.Snake;
                    }
                    else
                    {
                        playerTwoPosition -= 4;
                        animate.Image = Properties.Resources.Snake;
                    }
                    break;
                case 95:
                    if (chk)
                    {
                        playerOnePosition -= 20;
                        animate.Image = Properties.Resources.Snake;
                    }
                    else
                    {
                        playerTwoPosition -= 20;
                        animate.Image = Properties.Resources.Snake;
                    }
                    break;
                case 99:
                    if (chk)
                    {
                        playerOnePosition -= 19;
                        animate.Image = Properties.Resources.Snake;
                    }
                    else
                    {
                        playerTwoPosition -= 19;
                        animate.Image = Properties.Resources.Snake;
                    }
                    break;
                default:
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void movePlayersToken(int playerPosition, bool chk, int previousPosition)
        {
            if (playerOnePosition == playerTwoPosition)
            {
                removePlayersToken(previousPosition);
                pic[playerPosition].Image = Properties.Resources.player12;
                pic[playerPosition].SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (chk)
            {
                removePlayersToken(previousPosition);
                pic[playerPosition].Image = Properties.Resources.player1;
                pic[playerPosition].SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                removePlayersToken(previousPosition);
                pic[playerPosition].Image = Properties.Resources.player2;
                pic[playerPosition].SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void removePlayersToken(int previousPosition)
        {
            if (previousPosition > 0)
            {
                pic[previousPosition].Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void restartGame()
        {
            removePlayersToken(playerOnePreviousPosition);
            removePlayersToken(playerTwoPreviousPosition);
            playerOneTwo = true;
            playerOneOnline = false;
            playerTwoOnline = false;
            playerOnePosition = -5;
            playerTwoPosition = -5;
            playerOnePreviousPosition = 0;
            playerTwoPreviousPosition = 0;
            labelDiceRoll.Text = null;
            labelPOneScore.Text = null;
            labelPTwoScore.Text = null;
            pictureBoxDice.Image = Properties.Resources.diceGIF;
            animate.Image = null;
            radioButton1.Checked = true;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

    }
}
