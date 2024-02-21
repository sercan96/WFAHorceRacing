using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHorceRacing_1
{
    public partial class Form2 : Form
    {

        //Bazı kontrollerinizin üzerinde minik ok işareti görürsünüz (sag kosesinde) ... Bu işaretler smart tag işaretleri olarak bilinir...Smart Tag, sizin ilgili kontrolünüzde cok sık kullandıgınız property'lere erişmenizi kısa yoldan saglar...
        public Form2()
        {
            InitializeComponent();
        }
        private enum BetType
        {
            GrayHorse,
            BrownHorse,
            GoldHorse
        }
        private BetType _betType;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = budged.ToString();
            BackColor = ChooseFloor();
            levelAmount++;
        }

        Random rnd = new Random();

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isBet)
            {
                MessageBox.Show("Lütfen bir bahis oynayın!!");
                return;
            }
            timer1.Start();
        }
        int pbGolge_advPoint = 1, pbRuzgar_advPoint = 1, pbGun_advPoint = 1;
        int budged = 1000;
        int interestAmount;
        int levelAmount;
        bool isBet;
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region YarisKodlari

            Movement();

            HealthControl();

            if (pbGolgeGray.Right >= lblFinish.Left)
            {
                EarnMoney(BetType.GrayHorse, Color.Gray);
                FinishLane("Golge");      
            }

            else if (pbRuzgarBrown.Right >= lblFinish.Left)
            {
                EarnMoney(BetType.BrownHorse, Color.Brown);
                FinishLane("Rüzgar");         
            }

        
            else if (pbGunBatimiGold.Right >= lblFinish.Left)
            {
                EarnMoney(BetType.GoldHorse, Color.Gold);
                FinishLane("GünBatımı");           
            }

            #endregion
        }

        private bool AddCheat()
        {
            if (_betType == BetType.GrayHorse)
            {
                pbGolge_advPoint = 20;
                return true;
            }
            else if (_betType == BetType.BrownHorse)
            {
                pbRuzgar_advPoint = 20;
                return true;
            }
            else if (_betType == BetType.GoldHorse)
            {
                pbGun_advPoint = 20;
                return true;
            }
            return false;
        }
        bool isMafia;
        private void EarnMoney(BetType betType,Color color)
        {
            
            if (_betType == betType && !isMafia)
            {

                isMafia = GetRandomBoolean(10);
                if (isMafia)
                {
                    MessageBox.Show("Bahse mafya el koydu ve paralarınız yok oldu!!");
                    timer1.Stop();
                    return;
                }

                if (BackColor == color)
                {
                    CalculateBudged(0.4f);
                }
                else
                {
                    CalculateBudged(0.6f);
                }
            }
        }

        private void CalculateBudged(float value)
        {
            float getValue = int.Parse(tbxBet.Text);
            getValue += getValue * value;
            budged += Convert.ToInt32(getValue);
            lblBakiye.Text = budged.ToString();
        }
        private void Movement()
        {
            pbGolgeGray.Left += rnd.Next(5 + pbGolge_advPoint, 30);
            pbRuzgarBrown.Left += rnd.Next(5 + pbRuzgar_advPoint, 30);
            pbGunBatimiGold.Left += rnd.Next(5 + pbGun_advPoint, 30);

        }

        private void FinishLane(string horseName)
        {
            timer1.Stop();
            DialogResult dr = MessageBox.Show("Yarısı " + horseName + " kazanarak günü ismine layık bir şekilde sonlandırdı", "Günbattı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                PlayAgain();
            }
            else
            {
                Application.Exit();
            }
        }

        private void PlayAgain()
        {
            if(levelAmount >= 10 && interestAmount > 0)
            {
                if(levelAmount > 12)
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
            levelAmount++;
        }

        private void Reset()
        {
            pbGolgeGray.Left = pbRuzgarBrown.Left = pbGunBatimiGold.Left = 0;

            SetRandomVisibility(pbGolgeGray);
            SetRandomVisibility(pbRuzgarBrown);
            SetRandomVisibility(pbGunBatimiGold);

            pbGolge_advPoint = pbGun_advPoint = pbRuzgar_advPoint = 1;
            isBet = false;
            enter1 = enter2 = enter3 = false;
            isMafia = false;
        }

        private void SetRandomVisibility(PictureBox pictureBox)
        {
            if (!pictureBox.Visible)
            {
                pictureBox.Visible = GetRandomBoolean(50);
            }
        }

        private bool GetRandomBoolean(int chancePercentage)
        {
            Random random = new Random();
            return random.Next(100) < chancePercentage;
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            budged += Convert.ToInt32(tbxBanka.Text);
            interestAmount += Convert.ToInt32(tbxBanka.Text);
            lblBakiye.Text = budged.ToString();
        }
      
        private void DoBet(object sender, EventArgs e)
        {            
            if(tbxBet.Text == "")
            {
                MessageBox.Show("Lütfen bir bahis miktarı girin!");
                return;
            }

            if (budged < int.Parse(tbxBet.Text))
            {
                MessageBox.Show("Lütfen bankadan para çekiniz!");
                return;
            }

            if (levelAmount >= 10 && interestAmount > 0)
            {
                MessageBox.Show("Lütfen faiz borcunuzu ödeyin!");
                return;
            }

            isBet = true;
            budged -= int.Parse(tbxBet.Text);
            lblBakiye.Text = budged.ToString();

            Button button = sender as Button;
            if(button.Name == "btnGray")
            {
                _betType = BetType.GrayHorse; 
            }
            else if (button.Name == "btnBrown")
            {
                _betType = BetType.BrownHorse;
            }
            else if (button.Name == "btnGold")
            {
                _betType = BetType.GoldHorse;
            }

        }

        private void btnPayDebt_Click(object sender, EventArgs e)
        {
            float totalDebt = interestAmount + interestAmount * 0.6f;
            if(budged >= totalDebt)
            {
                budged -= interestAmount;
                lblBakiye.Text = budged.ToString();
                interestAmount = 0;
            }
            else
            {
                MessageBox.Show($"Bakiyeni faizinizi ödemeniz için yeterli değil! /n Borcunuz {totalDebt} kadardır. ");
            }
        }

        private Color ChooseFloor()
        {
            Random random = new Random();
            Color[] colors = new Color[] { Color.Gray, Color.Brown, Color.Gold };
            int randomColor = random.Next(0, colors.Length);
            return colors[randomColor];  
        }

        private void ChooseAdvantageHorse()
        {
            Color color = BackColor;
            if(color == Color.Gray)
            {
                pbGolge_advPoint = 2;
            }
            else if(color == Color.Brown)
            {
                pbRuzgar_advPoint = 2;
            }
            else if(color == Color.Gold)
            {
                pbGun_advPoint = 2;
            }
        }

        private void btnCheat_Click(object sender, EventArgs e)
        {
            bool state = AddCheat();
            if (!state) return;

            bool result = GetRandomBoolean(60);

            if(result == true)
            {
                MessageBox.Show("Hile kullandığınız tespit edildi. Elendiniz!");
                Application.Exit();
            }

        }

        bool enter1 = false, enter2 = false, enter3 = false;
        private void HealthControl()
        {
            Random random = new Random();
            int getRandomNumber = random.Next(1, 500); 

            if (getRandomNumber == 1 && !enter1 && !enter2)
            {
                pbGolgeGray.Visible = false;
                enter1 = true;
                MessageBox.Show("Gölge malesef sakatlandı. Yarışa devam edemeyecek!");
            }
            else if (getRandomNumber == 2 && !enter2 && !enter3)
            {
                pbRuzgarBrown.Visible = false;
                enter2 = true;
                MessageBox.Show("Rüzgar çok kötü sakatlandı. Yarışa devam edemeyecek!");
            }
            else if (getRandomNumber == 3 && !enter1 && !enter3)
            {
                pbGunBatimiGold.Visible = false;
                enter3 = true;
                MessageBox.Show("Gün batımı feci şekilde sakatlandı. Yarışa devam edemeyecek!");
            }
        }
   
    }
}
