using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class GameScreen : Form
    {
        public String XTOKEN;
        public String OTOKEN;
        private String turn;
        int scores_x;
        int scores_y;
        Button[] grid = new Button[9];
        String win = "";
        public GameScreen()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            update_message(turn);
            // if a space is open and lock button
            if (button.Text == "")
            {
                // places a token on the board
                button.Text = turn;
                // check for win
                // if win update scores and reset_bttn_click()
                win = check_for_win();
                if (win != "")
                {
                    if (win == XTOKEN)
                    {
                        scores_x++;
                        x_score_lbl.Text = "X = " + scores_x.ToString();
                        turn_lbl.Text = "X wins";
                    }
                    else
                    {
                        scores_y++;
                        o_score_lbl.Text = "O = " + scores_y.ToString();
                        turn_lbl.Text = ") win";
                    }
                    reset_board();
                }
                // switch turns
                turn = switch_turns(turn);
            }

        }
        public void reset_board()
        {
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i].Text = "";
            }
            turn = XTOKEN;
            update_message(turn);
        }
        public string switch_turns(string turn)
        {
            if(turn == OTOKEN)
            {
                turn = XTOKEN;
            }
            else
            {
                turn = OTOKEN;
            }
            return turn;
        }
        public string check_for_win()
        {
            string win = "";
            if ((grid[0].Text==grid[1].Text) && (grid[1].Text == grid[2].Text))
            {
                win = grid[0].Text;
                return win;
            }
            else if ((grid[0].Text == grid[3].Text) && (grid[3].Text == grid[6].Text))
            {
                win = grid[0].Text;
                return win;
            }
            else if ((grid[0].Text == grid[4].Text) && (grid[4].Text == grid[8].Text))
            {
                win = grid[0].Text;
                return win;
            }
            else if ((grid[1].Text == grid[4].Text) && (grid[4].Text == grid[7].Text))
            {
                win = grid[1].Text;
                return win;
            }
            else if ((grid[2].Text == grid[4].Text) && (grid[4].Text == grid[6].Text))
            {
                win = grid[2].Text;
                return win;
            }
            else if ((grid[2].Text == grid[5].Text) && (grid[5].Text == grid[8].Text))
            {
                win = grid[2].Text;
                return win;
            }
            else if ((grid[3].Text == grid[4].Text) && (grid[4].Text == grid[5].Text))
            {
                win = grid[3].Text;
                return win;
            }
            else if ((grid[6].Text == grid[7].Text) && (grid[7].Text == grid[8].Text))
            {
                win = grid[6].Text;
                return win;
            }
            else if ((grid[0].Text == grid[2].Text) && (grid[2].Text == grid[8].Text))
            {
                win = grid[0].Text;
                return win;
            }
            return win;
        }
        private void update_message(string turn)
        {
            turn_lbl.Text = "It is "+turn+"'s turn";
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            turn_lbl.Text = "Welcome \nX gose first";
            OTOKEN = "O";
            XTOKEN = "X";
            turn = XTOKEN;
            scores_x = 0;
            scores_y = 0;
            grid[0] = button1;
            grid[1] = button5;
            grid[2] = button2;
            grid[3] = button3;
            grid[4] = button6;
            grid[5] = button4;
            grid[6] = button7;
            grid[7] = button9;
            grid[8] = button8;

        }

        private void reset_bttn_Click(object sender, EventArgs e)
        {
            for (int i =0; i< grid.Length; i++)
            {
                grid[i].Text = "";
            }
            turn = XTOKEN;
            update_message(turn);
        }
    }
}
