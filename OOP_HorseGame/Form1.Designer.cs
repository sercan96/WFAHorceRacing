namespace OOP_HorseGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnCheat = new System.Windows.Forms.Button();
            this.btnPayDebt = new System.Windows.Forms.Button();
            this.lblBet = new System.Windows.Forms.Label();
            this.tbxBet = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.tbxBanka = new System.Windows.Forms.TextBox();
            this.Banka = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.Bakiye = new System.Windows.Forms.Label();
            this.btnGold = new System.Windows.Forms.Button();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.pbGold = new System.Windows.Forms.PictureBox();
            this.pbBrown = new System.Windows.Forms.PictureBox();
            this.pbGray = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGray)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheat
            // 
            this.btnCheat.Location = new System.Drawing.Point(749, 443);
            this.btnCheat.Name = "btnCheat";
            this.btnCheat.Size = new System.Drawing.Size(91, 50);
            this.btnCheat.TabIndex = 30;
            this.btnCheat.Text = "Cheat";
            this.btnCheat.UseVisualStyleBackColor = true;
            this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
            // 
            // btnPayDebt
            // 
            this.btnPayDebt.Location = new System.Drawing.Point(619, 552);
            this.btnPayDebt.Name = "btnPayDebt";
            this.btnPayDebt.Size = new System.Drawing.Size(103, 34);
            this.btnPayDebt.TabIndex = 29;
            this.btnPayDebt.Text = "Pay Debt";
            this.btnPayDebt.UseVisualStyleBackColor = true;
            this.btnPayDebt.Click += new System.EventHandler(this.btnPayDebt_Click);
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Location = new System.Drawing.Point(221, 449);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(71, 16);
            this.lblBet.TabIndex = 28;
            this.lblBet.Text = "PLAY BET";
            // 
            // tbxBet
            // 
            this.tbxBet.Location = new System.Drawing.Point(191, 488);
            this.tbxBet.Name = "tbxBet";
            this.tbxBet.Size = new System.Drawing.Size(136, 22);
            this.tbxBet.TabIndex = 27;
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(492, 552);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(106, 34);
            this.btnCek.TabIndex = 26;
            this.btnCek.Text = "Para Çek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // tbxBanka
            // 
            this.tbxBanka.Location = new System.Drawing.Point(556, 506);
            this.tbxBanka.Name = "tbxBanka";
            this.tbxBanka.Size = new System.Drawing.Size(100, 22);
            this.tbxBanka.TabIndex = 25;
            // 
            // Banka
            // 
            this.Banka.AutoSize = true;
            this.Banka.Location = new System.Drawing.Point(489, 506);
            this.Banka.Name = "Banka";
            this.Banka.Size = new System.Drawing.Size(55, 16);
            this.Banka.TabIndex = 23;
            this.Banka.Text = "Banka : ";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(553, 460);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(28, 16);
            this.lblBakiye.TabIndex = 22;
            this.lblBakiye.Text = "100";
            // 
            // Bakiye
            // 
            this.Bakiye.AutoSize = true;
            this.Bakiye.Location = new System.Drawing.Point(489, 460);
            this.Bakiye.Name = "Bakiye";
            this.Bakiye.Size = new System.Drawing.Size(58, 16);
            this.Bakiye.TabIndex = 24;
            this.Bakiye.Text = "Bakiye : ";
            // 
            // btnGold
            // 
            this.btnGold.BackColor = System.Drawing.Color.Yellow;
            this.btnGold.Location = new System.Drawing.Point(336, 543);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(90, 43);
            this.btnGold.TabIndex = 21;
            this.btnGold.Text = "GoldHorse";
            this.btnGold.UseVisualStyleBackColor = false;
            this.btnGold.Click += new System.EventHandler(this.DoBet);
            // 
            // btnBrown
            // 
            this.btnBrown.BackColor = System.Drawing.Color.Chocolate;
            this.btnBrown.Location = new System.Drawing.Point(213, 543);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(90, 43);
            this.btnBrown.TabIndex = 20;
            this.btnBrown.Text = "BrownHorse";
            this.btnBrown.UseVisualStyleBackColor = false;
            this.btnBrown.Click += new System.EventHandler(this.DoBet);
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGray.Location = new System.Drawing.Point(90, 543);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(90, 43);
            this.btnGray.TabIndex = 19;
            this.btnGray.Text = "GrayHorse";
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.DoBet);
            // 
            // pbGold
            // 
            this.pbGold.Image = global::OOP_HorseGame.Properties.Resources.at3;
            this.pbGold.Location = new System.Drawing.Point(47, 322);
            this.pbGold.Name = "pbGold";
            this.pbGold.Size = new System.Drawing.Size(150, 69);
            this.pbGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGold.TabIndex = 18;
            this.pbGold.TabStop = false;
            // 
            // pbBrown
            // 
            this.pbBrown.Image = global::OOP_HorseGame.Properties.Resources.at2;
            this.pbBrown.Location = new System.Drawing.Point(47, 185);
            this.pbBrown.Name = "pbBrown";
            this.pbBrown.Size = new System.Drawing.Size(150, 69);
            this.pbBrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBrown.TabIndex = 17;
            this.pbBrown.TabStop = false;
            // 
            // pbGray
            // 
            this.pbGray.Image = global::OOP_HorseGame.Properties.Resources.at1;
            this.pbGray.Location = new System.Drawing.Point(47, 53);
            this.pbGray.Name = "pbGray";
            this.pbGray.Size = new System.Drawing.Size(150, 69);
            this.pbGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGray.TabIndex = 16;
            this.pbGray.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(909, 493);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 49);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(35, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1052, 16);
            this.label3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(35, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1052, 16);
            this.label2.TabIndex = 12;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Aquamarine;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(1093, 31);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(26, 509);
            this.lblFinish.TabIndex = 14;
            this.lblFinish.Text = "Finish";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1052, 16);
            this.label1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 617);
            this.Controls.Add(this.btnCheat);
            this.Controls.Add(this.btnPayDebt);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.tbxBet);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.tbxBanka);
            this.Controls.Add(this.Banka);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.Bakiye);
            this.Controls.Add(this.btnGold);
            this.Controls.Add(this.btnBrown);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.pbGold);
            this.Controls.Add(this.pbBrown);
            this.Controls.Add(this.pbGray);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheat;
        private System.Windows.Forms.Button btnPayDebt;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.TextBox tbxBet;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.TextBox tbxBanka;
        private System.Windows.Forms.Label Banka;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label Bakiye;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.PictureBox pbGold;
        private System.Windows.Forms.PictureBox pbBrown;
        private System.Windows.Forms.PictureBox pbGray;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

