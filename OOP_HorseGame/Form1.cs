using OOP_HorseGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HorseGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Horse> horses = new List<Horse>();
        Random rnd = new Random();
        Player _player;
        private int _levelAmount;
        Horse _grayHorse;
        Horse _brownHorse;
        Horse _goldHorse;
        bool _isMafia;

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
            lblBakiye.Text = _player.Budged.ToString();
            BackColor = ChooseFloor();
        }
      
        private void Initialize()
        {
            _grayHorse = new Horse(Name = "GrayHorse", 10, pbGray,Color.Gray,1);
            _brownHorse = new Horse(Name = "BrownHorse", 10, pbBrown,Color.Brown,2);
            _goldHorse = new Horse(Name = "GoldHorse", 10, pbGold,Color.Gold,3);

            _player = new Player(1000);

            horses.Add(_grayHorse);
            horses.Add(_brownHorse);
            horses.Add(_goldHorse);
               
        }

        private void Movement()
        {
            foreach (var horse in horses)
            {
                horse.PictureBox.Left += rnd.Next(5 + horse.EkstraPoint, 30);
            }
        }

        private Color ChooseFloor()
        {        
            Color[] colors = new Color[] { _grayHorse.HipodromBackground,_brownHorse.HipodromBackground,_goldHorse.HipodromBackground };
            int randomColor = rnd.Next(0, colors.Length);
            return colors[randomColor];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!_player.isPlayBet)
            {
                MessageBox.Show("Lütfen bir bahis oynayın!!");
                return;
            }
            timer1.Start();
        }

        private void DoBet(object sender, EventArgs e)
        {
            if (tbxBet.Text == "")
            {
                MessageBox.Show("Lütfen bir bahis miktarı girin!");
                return;
            }

            if (_player.Budged < int.Parse(tbxBet.Text))
            {
                MessageBox.Show("Lütfen bankadan para çekiniz!");
                return;
            }

            if (_levelAmount >= 10 && _player.interestAmount > 0)
            {
                MessageBox.Show("Lütfen faiz borcunuzu ödeyin!");
                return;
            }

            _player.isPlayBet = true;
            _player.Budged -= int.Parse(tbxBet.Text);
            lblBakiye.Text = _player.Budged.ToString();

            Button button = sender as Button;
            switch(button.Name)
            {
                case "btnGray":
                    _player.myCurrentHorse = _grayHorse;
                    break;
                case "btnBrown":
                    _player.myCurrentHorse = _brownHorse;
                    break;
                case "btnGold":
                    _player.myCurrentHorse = _goldHorse;
                    break;
            }        
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Movement();
            HealthControl();
            FinishLine();
        }

        private void HealthControl()
        {
            int totalNumber = 0;

            CheckAllHorseState(ref totalNumber);

            foreach (Horse item in horses)
            {
                if (totalNumber > 2) break;
                else item.CheckAndHandleInjury();
            }     
        }

        private void CheckAllHorseState(ref int totalNumber)
        {          
            foreach (Horse item in horses)
            {
                if (item.Injured)
                    totalNumber++;
            }                    
        }

        private void FinishLine()
        {
            foreach (var horse in horses)
            {
                CheckAndFinishRace(horse);
            }
        }

        private void CheckAndFinishRace(Horse horse)
        {
            if (horse.PictureBox.Right >= lblFinish.Left)
            {
                EarnMoney(horse);
                FinishLane(horse);
            }
        }

        private void PlayAgain()
        {
            if (_levelAmount >= 10 && _player.interestAmount > 0)
            {
                if (_levelAmount > 12)
                {
                    MessageBox.Show("Game Over!");
                    Application.Exit();
                    return;
                }
                MessageBox.Show("Lütfen faiz borçlarınızı ödeyin.");
                return;
            }

            Reset();
            BackColor = ChooseFloor();
            ChooseAdvantageHorse();
            _levelAmount++;
        }

        private void Reset()
        {
            foreach (Horse item in horses)
            {
                item.PictureBox.Left = 0;
                item.EkstraPoint = 1;
                item.Injured = false;
            }
               
            _player.isPlayBet = false;

            SetRandomVisibility(_grayHorse.PictureBox);
            SetRandomVisibility(_brownHorse.PictureBox);
            SetRandomVisibility(_goldHorse.PictureBox);

            _isMafia = false;
        }

        private void SetRandomVisibility(PictureBox pictureBox)
        {
            if (!pictureBox.Visible)
            {
                pictureBox.Visible = GetRandomBoolean(50);
            }
        }

        private void ChooseAdvantageHorse()
        {
            foreach (Horse item in horses)
            {
                if(item.HipodromBackground == BackColor)
                {
                    item.EkstraPoint = 2;
                    break;
                }
            }
        }

        private void FinishLane(Horse horse)
        {
            timer1.Stop();

            DialogResult dr = MessageBox.Show($"Yarısı {horse.Name} kazanarak günü ismine layık bir şekilde sonlandırdı", "",MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes) PlayAgain();
            else Application.Exit();
      
        }

        private void EarnMoney(Horse horse)
        {
            if (horse != _player.myCurrentHorse || _isMafia)
            {
                return;
            }

            _isMafia = GetRandomBoolean(10);

            if (_isMafia)
            {
                MessageBox.Show("Bahse mafya el koydu ve paralarınız yok oldu!!");
                timer1.Stop();
                return;
            }

            float winMultiplier = (BackColor == _player.myCurrentHorse.HipodromBackground) ? 0.4f : 0.6f;
            _player.CalculateBudged(int.Parse(tbxBet.Text), winMultiplier);

            lblBakiye.Text = _player.Budged.ToString();
        }


        private bool GetRandomBoolean(int chancePercentage)
        {
            return rnd.Next(100) < chancePercentage;
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            int budged = _player.GetMoneyFromBank(Convert.ToInt32(tbxBanka.Text));
            lblBakiye.Text = budged.ToString();
        }

        private void btnPayDebt_Click(object sender, EventArgs e)
        {
            _player.PayToDebt();
            lblBakiye.Text = _player.Budged.ToString();
        }

        private void btnCheat_Click(object sender, EventArgs e)
        {
            bool state = GetRandomBoolean(70);

            if(state)
            {
                MessageBox.Show("Hile yaptığınızı tespit ettik. Oyundan atıldınız!!");
                Application.Exit();
                return;
            }

            foreach (Horse item in horses)
            {
                if (item == _player.myCurrentHorse)
                {
                    item.EkstraPoint = 20;
                    break;
                }
            }
        }
    }
}
