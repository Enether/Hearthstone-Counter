using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class DefaultCounter
    {
        string eMessage;
       public int wins;
        public int losses;

        public void Initialization(HSCounter hsc)
        {           
            hsc.priestWinButton.Hide();
            hsc.priestLoseButton.Hide();
            ReadWins();
            hsc.label1.Text = "Won: " + wins;
            WriteWins(wins);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + losses;
            WriteLosses(losses);
        }
        public void DefaultButtonCLICKED(HSCounter hsc)
        {
            ShowandHideButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + wins;
            WriteWins(wins);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + losses;
            WriteLosses(losses);
        }

        // Writers
        private void WriteWins(int T)
        {
            using (StreamWriter winsWriter = new StreamWriter("Wins.txt", false))
            {
                winsWriter.Write(T);
                winsWriter.Flush();
            }

        }
        private void WriteLosses(int T)
        {
            using (StreamWriter lossesWriter = new StreamWriter("Losses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }
        // Readers
        private void ReadWins()
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Wins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WriteWins(0);
            }
        }
        
        private void ReadLosses()
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Losses.txt"))
                {
                    losses = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WriteLosses(0);
            }
        }
        // Clicked Buttons
        public void loseButtonCLICKED(HSCounter hsc)
        {       
            losses++;
            hsc.lostLabel.Text = "Lost: " + losses;
            WriteLosses(losses);
        }
        public void winButtonCLICKED(HSCounter hsc)
        {
            wins++;
            hsc.label1.Text = "Won: " + wins;
            WriteWins(wins);
        }
        public void otherwinButtonCLICKED()
        {
            wins++;
            WriteWins(wins);
        }
        public void otherloseButtonCLICKED()
        {
            losses++;
            WriteLosses(losses);
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.winButton.Show();
            hsc.loseButton.Show();
            hsc.priestWinButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
        }
    }
}
