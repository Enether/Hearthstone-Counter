using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Priest
    {
        
       
        public int priestwins;
        public int priestlosses;
        string eMessage;
        public void WritePriestWins(int T)
        {
            using (StreamWriter priestwinsWriter = new StreamWriter("PriestWins.txt", false))
            {
                priestwinsWriter.Write(T);
                priestwinsWriter.Flush();
                
            }

        }
        public void WritePriestLosses(int T)
        {
            using (StreamWriter priestlossesWriter = new StreamWriter("PriestLosses.txt", false))
            {
                priestlossesWriter.Write(T);
                priestlossesWriter.Flush();
            }
        }
        public void ReadPriestLosses()
        {
            try
            {
                using (StreamReader readpriestLosses = new StreamReader("PriestLosses.txt"))
                {
                    priestlosses = int.Parse(readpriestLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WritePriestLosses(0);
            }
        }
        public void ReadPriestWins()
        {
            try
            {
                using (StreamReader readPriestWins = new StreamReader("PriestWins.txt"))
                {
                    priestwins = int.Parse(readPriestWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WritePriestWins(0);
            }
        }
        public void priestButtonCLICKED(HSCounter hsc)
        {
            ShowandHideButtons(hsc);                 
            ReadPriestWins();
            hsc.label1.Text = "Won: " + priestwins;
            WritePriestWins(priestwins);
            ReadPriestLosses();
            hsc.lostLabel.Text = "Lost: " + priestlosses;
            WritePriestLosses(priestlosses);
        }
        public void priestLoseButtonCLICKED(HSCounter hsc)
        {           
            priestlosses++;
            hsc.lostLabel.Text = "Lost: " + priestlosses;
            WritePriestLosses(priestlosses);
            hsc.otherlosebutton();
        }
        public void priestWinButtonCLICKED(HSCounter hsc)
        {           
            priestwins++;
            hsc.label1.Text = "Won: " + priestwins;
            WritePriestWins(priestwins);
            hsc.otherwinbutton();          
        }     
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.priestLoseButton.Show();
            hsc.priestWinButton.Show();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
        }
    }
}
