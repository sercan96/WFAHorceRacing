using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HorseGame.Models
{
    public class Player
    {
        public int Budged { get; set; }
        public int interestAmount { get; set; }
        public bool isPlayBet { get; set; }
        public Horse myCurrentHorse { get; set; }


        public Player(int budged)
        {
            Budged = budged;
        }

        public int GetMoneyFromBank(int amount)
        {
            Budged += amount;
            interestAmount += amount;
            return Budged;
        }

        public void PayToDebt()
        {
            float totalDebt = interestAmount + interestAmount * 0.6f;
            if (Budged >= totalDebt)
            {
                Budged -= interestAmount;
                Budged = 0;
            }
            else
            {
                MessageBox.Show($"Bakiyeni faizinizi ödemeniz için yeterli değil! \n Borcunuz {totalDebt} kadardır.");
            }
        }

        public void CalculateBudged(int betValue, float multiply)
        {
            float getValue = betValue;
            getValue += getValue * multiply;
            Budged += Convert.ToInt32(getValue);
        }
    }
}
