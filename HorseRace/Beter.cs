using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLabelMove
{
    class Beter
    {
        public int money;
        public int horse;
        public horse Better;
      
        public string MoneyLB()
        {
            
            if (money > 0)
            {
                return Better.Name + " Bets " + money + " on " + "horse no" + horse;
            }
            
           
            else
            {

                return Better.Name + " did not placed the bet yet";
            }

        }

        public int Winnerrace(int winner)
        {
            if (horse == winner)
            {
                return money;
            }
            else
            {
                return -money;
            }
        }

    }
}
