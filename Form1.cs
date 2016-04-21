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
        List<Button> buttons;

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

        private void ChangeButtonsStatus(bool status)
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = status;
            }
        }

        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            lblWinnings.Text = 0.ToString();
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
            HandValue result = hand.Evaluate();
            this.lblHand.Text = result.Description;
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            deck = new Deck(this, rnd);
            deck.Show();
            mnuDraw.Enabled = false;
            mnuNewGame.Enabled = true;
            buttons = new List<Button>();
            buttons.Add(btn25);
            buttons.Add(btn50);
            buttons.Add(btn75);
            buttons.Add(btn100);

            decimal bank = decimal.Parse(lblBank.Text);
            if (bank == 0)
            {
                ChangeButtonsStatus(false);
                mnuNewGame.Enabled = false;
            }
            else
            {
                ChangeButtonsStatus(true);
                mnuNewGame.Enabled = true;
            }
        }

        private void Calculate(Values multiplier)
        {
            double bet = double.Parse(this.lblBetAmount.Text);
            double cash = (bet) * ((double)multiplier);
            double credit = double.Parse(lblBank.Text);
            credit += cash;
            lblBank.Text = string.Format("{0:F}", credit);
            lblWinnings.Text = string.Format("{0:F}", cash);
        }

        private void mnuDraw_Click(object sender, EventArgs e)
        {
            enable();
            hand.Draw(deck);
            hand.Show();
            mnuNewGame.Enabled = true;
            HandValue result = hand.Evaluate();
            this.lblHand.Text = result.Description;
            Calculate(result.Multiplier);
            lblBetAmount.Text = 0.ToString();
            this.ChangeButtonsStatus(true);
            mnuNewGame.Enabled = false;
        }

        private void lblHand_Click(object sender, EventArgs e)
        {

        }        

        private void btnBet_Click(object sender, EventArgs e)
        {
            double credit = Convert.ToDouble(lblBank.Text);
            Button btn = (Button)sender;
            double value = Convert.ToDouble(btn.Tag);
            if (credit - value >= 0)
            {
                credit -= value;
                lblBank.Text = credit.ToString();
                double bet = Convert.ToDouble(lblBetAmount.Text);
                bet = value;
                lblBetAmount.Text = bet.ToString();               
            }
            this.ChangeButtonsStatus(false);
            this.mnuNewGame.Enabled = true;


        }

        private void mnuPurchase_Click(object sender, EventArgs e)
        {
            double credit = Convert.ToDouble(lblBank.Text);
            credit += 1.00;
            lblBank.Text = String.Format("{0:F}", credit);
            double bank = double.Parse(lblBank.Text);
            if (bank > 0)
            {                
                this.ChangeButtonsStatus(true);
            }
        }
    }
}
