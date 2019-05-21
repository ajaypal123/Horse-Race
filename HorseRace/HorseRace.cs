using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    public partial class game : Form
    {
        horse[] Horse = new horse[3];
        Beter obj_bet = new Beter();
        racers[] race = new racers[4];
        Random random = new Random();
        public game()
        {
            InitializeComponent();
            Horse[0] = new horse()
            {
                Name = "Kate",//it is the name of the bettor
                amount = 50,//starting amount
                radiobtnb = KateRB,
                Labe = KateLB
            };
            Horse[1] = new horse()
            {
                Name = "Jhon",//it is the name of the bettor
                amount = 50,//starting amount
                radiobtnb = jhonRb,
                Labe = jhonLB
            };
            Horse[2] = new horse()

            {
                Name = "Amous",//it is the name of the bettor
                amount = 50,//starting amount
                radiobtnb = AmousRB,
                Labe =AmousLB
            };

            UPlabel();
            Horse[0].Bet(0,0);
            Horse[1].Bet(0,0);
            Horse[2].Bet(0,0);

          
        }

       
 
        private void Race_Click(object sender, EventArgs e)
        {
            gb1.Enabled = false;
            timer1.Start();
            race[0] = new racers();
            race[0].Randomizer = random;
            race[0].Horses = pictureBox1;
            race[0].Startpos = pictureBox1.Left;


            race[1] = new racers();
            race[1].Randomizer = random;
            race[1].Horses = pictureBox2;
            race[1].Startpos = pictureBox1.Left;

            race[2] = new racers();
            race[2].Randomizer = random;
            race[2].Horses = pictureBox3;
            race[2].Startpos = pictureBox1.Left;

            race[3] = new racers();
            race[3].Randomizer = random;
            race[3].Horses = pictureBox4;
            race[3].Startpos = pictureBox1.Left;
        }

        private void timer1_Tick(object sender, EventArgs e) 
        {
            int win;
            for(int i=0; i<4; i++)//it is the timer 
            {
                if(race[i] != null)
                {
                    race[i].HorseRun();
                    if(race[i].HorseRun())
                    {
                        timer1.Stop();
                        
                        win = i+1;
                        MessageBox.Show("The Winner Horse is " + win);
                        AmountWin(win);
                        gb1.Enabled = true;
                        for (int m=0; m<4; m++)
                        {
                            race[m].Horsesstartline();
                        }
                    }
                    
                }
            }
        }
        private void AmountWin(int Winhorse)
        {
            for (int i = 0; i < 3; i++)//it is a for loop
            {
                Horse[i].FirstHorse(Winhorse);
            }
        }

        private void Beter_Click(object sender, EventArgs e)
        {
            if(KateRB.Checked)
            {
                if (Horse[0].Bet((int)betmoneyupdown.Value, (int)Housenumberupdown.Value))
                {                    
                    KateLB = Horse[0].Labe;
                }
                else
                {
                    MessageBox.Show("not enough money to bet");//it is a meesage pop up
                    Horse[0].Bet(0, 0); 
                }
            }
            else if(jhonRb.Checked)
            {
                if (Horse[1].Bet((int)betmoneyupdown.Value, (int)Housenumberupdown.Value))
                {
                    KateLB = Horse[1].Labe;
                }
                else
                {
                    MessageBox.Show("not enough money to bet");// it is a meeage pop up
                    Horse[1].Bet(0, 0);
                }
            }
            else if(AmousRB.Checked)
            {
                if (Horse[2].Bet((int)betmoneyupdown.Value, (int)Housenumberupdown.Value))
                {
                    KateLB = Horse[2].Labe;
                }
                else
                {
                    MessageBox.Show("not enough money to bet");//it is a message pop up
                    Horse[2].Bet(0, 0);
                }
            }
        }

        private void KateRB_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = Horse[0].Name;
        }

        private void JhonRB_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = Horse[1].Name;
        }

        private void AmousRB_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = Horse[2].Name;
        }

        private void UPlabel()
        {
            for (int i = 0; i < 3; i++)//it update the label
            {
                Horse[i].LabelUpdt();
            }
        }

        

        private void raceTrackPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
