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
            DialogResult result = MessageBox.Show("Done loosing all your monies?", "GIVE ME MORE OF YOUR MONEY DON'T QUIT NOW!", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            } 
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
            mnuNewGame.Enabled = false;
            mnuDraw.Enabled = true;
            this.lblHand.Text = hand.Evaluate();
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
            this.lblHand.Text = hand.Evaluate();
        }

        private void lblHand_Click(object sender, EventArgs e)
        {

        }        

        private void btnBet_Click(object sender, EventArgs e)
        {
            double credit = Convert.ToDouble(lblBank.Text);
            Button btn = (Button)sender;
            double value = Convert.ToDouble(btn.Text);
            if (credit - value >= 0)
            {
                credit -= value;
                lblBank.Text = credit.ToString();
                double bet = Convert.ToDouble(lblBetAmount.Text);
                bet += value;
                lblBetAmount.Text = bet.ToString();               
            }
            
            
        }

        private void mnuPurchase_Click(object sender, EventArgs e)
        {
            double credit = Convert.ToDouble(lblBank.Text);
            credit += 1.00;
            lblBank.Text = credit.ToString();
        }
    }
}
