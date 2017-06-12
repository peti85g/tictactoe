using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game by Peti", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Text = "";
                    b.Enabled = true;
                    turn_count = 0;
                    turn = true;
                }
            }
            catch
            {
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "O";
            else
                b.Text = "X";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            CheckForWinner();
        }
        private void CheckForWinner()
        {
            bool thereIsAWinner = false;
            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Enabled == false)
                thereIsAWinner = true;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Enabled == false)
                thereIsAWinner = true;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Enabled == false)
                thereIsAWinner = true;
            else if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Enabled == false)
                thereIsAWinner = true;
            else if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Enabled == false)
                thereIsAWinner = true;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Enabled == false)
                thereIsAWinner = true;
            else if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Enabled == false)
                thereIsAWinner = true;
            else if (A3.Text == B2.Text && B2.Text == C1.Text && C1.Enabled == false)
                thereIsAWinner = true;

            if (thereIsAWinner)
            {
                string winner = "";
                DisableButtons();
                if (turn)
                {
                    winner = "X";
                }
                else
                    winner = "O";
                MessageBox.Show(winner + " is the winner!!!");
            }
            else if(turn_count==9)
            {
                MessageBox.Show("There is a draw!");
            }

        }
        private void DisableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }

        }


    }
}
