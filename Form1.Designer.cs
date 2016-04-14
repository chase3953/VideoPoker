namespace VideoPoker
{
    partial class frmTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTable));
            this.mnuPoker = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHand = new System.Windows.Forms.Label();
            this.lblBankText = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblBetText = new System.Windows.Forms.Label();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn75 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuPoker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPoker
            // 
            this.mnuPoker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnuPoker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mnuPoker.Location = new System.Drawing.Point(0, 0);
            this.mnuPoker.Name = "mnuPoker";
            this.mnuPoker.Size = new System.Drawing.Size(803, 24);
            this.mnuPoker.TabIndex = 0;
            this.mnuPoker.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewGame,
            this.mnuDraw,
            this.mnuPurchase,
            this.toolStripSeparator1,
            this.mnuExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem1.Text = "Poker";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Name = "mnuNewGame";
            this.mnuNewGame.Size = new System.Drawing.Size(152, 22);
            this.mnuNewGame.Text = "New Game";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
            // 
            // mnuDraw
            // 
            this.mnuDraw.Name = "mnuDraw";
            this.mnuDraw.Size = new System.Drawing.Size(152, 22);
            this.mnuDraw.Text = "Draw";
            this.mnuDraw.Click += new System.EventHandler(this.mnuDraw_Click);
            // 
            // mnuPurchase
            // 
            this.mnuPurchase.Name = "mnuPurchase";
            this.mnuPurchase.Size = new System.Drawing.Size(152, 22);
            this.mnuPurchase.Text = "Purchase 1.00";
            this.mnuPurchase.Click += new System.EventHandler(this.mnuPurchase_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblHand
            // 
            this.lblHand.BackColor = System.Drawing.Color.Transparent;
            this.lblHand.Location = new System.Drawing.Point(675, 122);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(116, 30);
            this.lblHand.TabIndex = 1;
            this.lblHand.Click += new System.EventHandler(this.lblHand_Click);
            // 
            // lblBankText
            // 
            this.lblBankText.AutoSize = true;
            this.lblBankText.BackColor = System.Drawing.Color.Transparent;
            this.lblBankText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankText.ForeColor = System.Drawing.Color.Red;
            this.lblBankText.Location = new System.Drawing.Point(-3, 162);
            this.lblBankText.Name = "lblBankText";
            this.lblBankText.Size = new System.Drawing.Size(85, 22);
            this.lblBankText.TabIndex = 2;
            this.lblBankText.Text = "CREDIT";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.BackColor = System.Drawing.Color.Transparent;
            this.lblBank.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.ForeColor = System.Drawing.Color.Red;
            this.lblBank.Location = new System.Drawing.Point(88, 162);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(20, 22);
            this.lblBank.TabIndex = 3;
            this.lblBank.Text = "0";
            // 
            // lblBetText
            // 
            this.lblBetText.AutoSize = true;
            this.lblBetText.BackColor = System.Drawing.Color.Transparent;
            this.lblBetText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetText.ForeColor = System.Drawing.Color.Red;
            this.lblBetText.Location = new System.Drawing.Point(33, 184);
            this.lblBetText.Name = "lblBetText";
            this.lblBetText.Size = new System.Drawing.Size(49, 22);
            this.lblBetText.TabIndex = 4;
            this.lblBetText.Text = "BET";
            // 
            // btn25
            // 
            this.btn25.Location = new System.Drawing.Point(1, 209);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(75, 23);
            this.btn25.TabIndex = 5;
            this.btn25.Text = "¢25";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(0, 238);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(75, 23);
            this.btn50.TabIndex = 6;
            this.btn50.Text = "¢50";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btn75
            // 
            this.btn75.Location = new System.Drawing.Point(0, 267);
            this.btn75.Name = "btn75";
            this.btn75.Size = new System.Drawing.Size(75, 23);
            this.btn75.TabIndex = 7;
            this.btn75.Text = "¢75";
            this.btn75.UseVisualStyleBackColor = true;
            this.btn75.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(0, 296);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(75, 23);
            this.btn100.TabIndex = 8;
            this.btn100.Text = "$1.00";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblBetAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetAmount.ForeColor = System.Drawing.Color.Red;
            this.lblBetAmount.Location = new System.Drawing.Point(88, 184);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(20, 22);
            this.lblBetAmount.TabIndex = 9;
            this.lblBetAmount.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 146);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::VideoPoker.Properties.Resources.blackjack22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBetAmount);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn75);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.lblBetText);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblBankText);
            this.Controls.Add(this.lblHand);
            this.Controls.Add(this.mnuPoker);
            this.MainMenuStrip = this.mnuPoker;
            this.Name = "frmTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.mnuPoker.ResumeLayout(false);
            this.mnuPoker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPoker;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuNewGame;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDraw;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.Label lblBankText;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblBetText;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn75;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

