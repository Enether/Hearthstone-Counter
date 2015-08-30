using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Warlock
    {
        public bool selected;
        public int warlockwins;
        public int warlocklosses;
        string eMessage;
        public void WriteWarlockWins(int T)
        {
            using (StreamWriter warlockwinsWriter = new StreamWriter("Textfiles/WarlockWins.txt", false))
            {
                warlockwinsWriter.Write(T);
                warlockwinsWriter.Flush();
            }
        }
        public void WriteWarlockLosses(int T)
        {
            using (StreamWriter warlocklossesWriter = new StreamWriter("Textfiles/WarlockLosses.txt", false))
            {
                warlocklossesWriter.Write(T);
                warlocklossesWriter.Flush();
            }
        }
        public void ReadWarlockLosses()
        {
            try
            {
                using (StreamReader readwarlockLosses = new StreamReader("Textfiles/WarlockLosses.txt"))
                {
                    warlocklosses = int.Parse(readwarlockLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WriteWarlockLosses(0);
            }
        }
        public void ReadWarlockWins()
        {
            try
            {
                using (StreamReader readwarlockWins = new StreamReader("Textfiles/WarlockWins.txt"))
                {
                    warlockwins = int.Parse(readwarlockWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WriteWarlockWins(0);
            }
        }
        public void warlockButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            warlockButtonIsSelected(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);
            ReadWarlockWins();
            hsc.label1.Text = "Won: " + warlockwins;
            WriteWarlockWins(warlockwins);
            ReadWarlockLosses();
            hsc.lostLabel.Text = "Lost: " + warlocklosses;
            WriteWarlockLosses(warlocklosses);
        }
        public void warlockLoseButtonCLICKED(HSCounter hsc)
        {
            warlocklosses++;
            hsc.lostLabel.Text = "Lost: " + warlocklosses;
            WriteWarlockLosses(warlocklosses);
            hsc.otherlosebutton();
        }
        public void warlockWinButtonCLICKED(HSCounter hsc)
        {
            warlockwins++;
            hsc.label1.Text = "Won: " + warlockwins;
            WriteWarlockWins(warlockwins);
            hsc.otherwinbutton();
        }
        public void warlockResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - warlockwins);
            dfc.WriteLosses(dfc.losses - warlocklosses);
            WriteWarlockWins(0);
            WriteWarlockLosses(0);
            warlockButtonCLICKED(hsc);
        }
        public void warlockButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.warlockbutton.Image = global::Hearthstone_Counter.Icons.WarlockIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.warlockbutton.Image = global::Hearthstone_Counter.Icons.WarlockIcon;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPaladin();
            hsc.DeselectPriest();
            hsc.DeselectShaman();
            hsc.DeselectMage();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.warlockBG;
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.warlockWinButton.Show();
            hsc.warlockLoseButton.Show();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
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
            hsc.warlockResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.mageResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.warriorResetButton.Hide();
        }
    }
}
