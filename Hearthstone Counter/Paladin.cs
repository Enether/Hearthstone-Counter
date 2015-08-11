using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Paladin
    {
        public int paladinwins;
        public int paladinlosses;
        string eMessage;
        public void WritePaladinWins(int T)
        {
            using (StreamWriter paladinwinsWriter = new StreamWriter("PaladinWins.txt", false))
            {
                paladinwinsWriter.Write(T);
                paladinwinsWriter.Flush();
            }
        }
        public void WritePaladinLosses(int T)
        {
            using (StreamWriter paladinlossesWriter = new StreamWriter("PaladinLosses.txt", false))
            {
                paladinlossesWriter.Write(T);
                paladinlossesWriter.Flush();
            }
        }
        public void ReadPaladinLosses()
        {
            try
            {
                using (StreamReader readpaladinLosses = new StreamReader("PaladinLosses.txt"))
                {
                    paladinlosses = int.Parse(readpaladinLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WritePaladinLosses(0);
            }
        }
        public void ReadPaladinWins()
        {
            try
            {
                using (StreamReader readpaladinWins = new StreamReader("PaladinWins.txt"))
                {
                    paladinwins = int.Parse(readpaladinWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WritePaladinWins(0);
            }
        }
        public void paladinButtonCLICKED(HSCounter hsc)
        {
            ShowandHideButtons(hsc);
            ReadPaladinWins();
            hsc.label1.Text = "Won: " + paladinwins;
            WritePaladinWins(paladinwins);
            ReadPaladinLosses();
            hsc.lostLabel.Text = "Lost: " + paladinlosses;
            WritePaladinLosses(paladinlosses);
        }
        public void paladinLoseButtonCLICKED(HSCounter hsc)
        {
            paladinlosses++;
            hsc.lostLabel.Text = "Lost: " + paladinlosses;
            WritePaladinLosses(paladinlosses);
            hsc.otherlosebutton();
        }
        public void paladinWinButtonCLICKED(HSCounter hsc)
        {
            paladinwins++;
            hsc.label1.Text = "Won: " + paladinwins;
            WritePaladinWins(paladinwins);
            hsc.otherwinbutton();
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.paladinWinButton.Show();
            hsc.paladinLoseButton.Show();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();           
        }
    }
}
