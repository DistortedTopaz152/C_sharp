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
        public String XTOKEN = "X";
        public String OTOKEN = "O";
        private String turn = "X";
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
            update_message(turn);
            // if a space is open
            // places a token on the board
            
            // lock button
            // check for win
            // if win update scores and reset board
            // switch turns
            turn = switch_turns(turn);
            // update turn_lbl with current turn
            
        }
        public void reset_board()
        {

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

            return win;
        }
        private void update_message(string turn)
        {
            turn_lbl.Text = "It is "+turn+"'s turn";
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            update_message(turn);
        }
    }
}
