using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPoker
{
    public partial class frmTable : Form
    {
        Random rnd = new Random();
        Deck deck;
        Hand hand;

        public frmTable()
        {
            InitializeComponent();
            mnuNewGame.Enabled = true;
            mnuDraw.Enabled = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void enable()
        {
            if (mnuNewGame.Enabled == true)
            {
                mnuDraw.Enabled = true;
                mnuNewGame.Enabled = false;
            }
            else
            {
                mnuDraw.Enabled = false;
                mnuNewGame.Enabled = true;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            enable();
            if (deck != null)
            {
                deck.Dispose();
            }

           deck = new Deck(this, rnd);
            deck.Show();



            if (hand != null)
            {
                hand.Dispose();
            }

            hand = new Hand();
            for (int i = 0; i < 5; i++)
            {
                hand.Deal = deck.Deal();
            }
            hand.Show();
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
                
        }

        private void mnuDraw_Click(object sender, EventArgs e)
        {

            enable();
            hand.Draw(deck);
            hand.Show();
            mnuNewGame.Enabled = true;

        }
    }
}
