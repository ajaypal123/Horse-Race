using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    class horse
    {
        public string Name;
        public Beter position;
        public int amount;
        public int k;
        public RadioButton radiobtnb;
        public Label Labe;
      

        public void LabelUpdt()
        {
            radiobtnb.Text = Name + " has " + amount + " $";

            Labe.Text = Name+" need to place a bet yet";

            if (k == 1)
            {
                Labe.Text = Name + " need to place a bet yet";
            }
        }

        public void FirstHorse(int frstHorse)
        {
            amount += position.Winnerrace(frstHorse);
            RemoveBet();
            LabelUpdt();
        }

        public bool Bet(int BetMoney, int FirstHorse)
        {
            position = new Beter()
            {
                money = BetMoney,
                horse = FirstHorse,
                Better = this
            };
            position.money = BetMoney;
            if (BetMoney > amount)
            {
                MessageBox.Show($@"not Enough Money");
                return false;
            }
            if (amount >= 1)
            {
                Labe.Text = position.MoneyLB();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveBet()
        {
            position.money = 0;
        }

        
    }
}
