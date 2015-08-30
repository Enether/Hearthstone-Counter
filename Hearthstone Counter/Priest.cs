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
        public bool selected;
        public int priestwins;
        public int priestlosses;
        string eMessage;
        public void WritePriestWins(int T)
        {
            using (StreamWriter priestwinsWriter = new StreamWriter("Textfiles/PriestWins.txt", false))
            {
                priestwinsWriter.Write(T);
                priestwinsWriter.Flush();
                
            }

        }
        public void WritePriestLosses(int T)
        {
            using (StreamWriter priestlossesWriter = new StreamWriter("Textfiles/PriestLosses.txt", false))
            {
                priestlossesWriter.Write(T);
                priestlossesWriter.Flush();
            }
        }
        public void ReadPriestLosses()
        {
            try
            {
                using (StreamReader readpriestLosses = new StreamReader("Textfiles/PriestLosses.txt"))
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
                using (StreamReader readPriestWins = new StreamReader("Textfiles/PriestWins.txt"))
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
            ChangeBG(hsc);
            priestButtonIsSelected(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);           
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
        public void priestResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - priestwins);
            dfc.WriteLosses(dfc.losses - priestlosses);
            WritePriestWins(0);
            WritePriestLosses(0);
            priestButtonCLICKED(hsc);
        }
        public void priestButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.priestbutton.Image = global::Hearthstone_Counter.Icons.priestSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.priestbutton.Image = global::Hearthstone_Counter.Icons.priestIcon;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPaladin();
            hsc.DeselectMage();
            hsc.DeselectShaman();
            hsc.DeselectWarlock();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.priestBG;
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.priestLoseButton.Show();
            hsc.priestWinButton.Show();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.warlockWinButton.Hide();
            hsc.warlockLoseButton.Hide();
            hsc.shamanWinButton.Hide();
            hsc.shamanLoseButton.Hide();
            hsc.hunterWinButton.Hide();
            hsc.hunterLoseButton.Hide();
            hsc.mageWinButton.Hide();
            hsc.mageLoseButton.Hide();
            hsc.rogueWinButton.Hide();
            hsc.rogueLoseButton.Hide();
            hsc.warriorWinButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
        }
        public void ShowandHideResetButtons(HSCounter hsc)
        {
            hsc.priestResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();         
            hsc.mageResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.warriorResetButton.Hide();
        }
    }
}
