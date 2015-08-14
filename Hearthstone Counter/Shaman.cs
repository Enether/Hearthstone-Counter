using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Shaman
    {
        public bool selected;
        public int shamanwins;
        public int shamanlosses;
        string eMessage;
        public void WriteShamanWins(int T)
        {
            using (StreamWriter shamanwinsWriter = new StreamWriter("ShamanWins.txt", false))
            {
                shamanwinsWriter.Write(T);
                shamanwinsWriter.Flush();
            }
        }
        public void WriteShamanLosses(int T)
        {
            using (StreamWriter shamanlossesWriter = new StreamWriter("ShamanLosses.txt", false))
            {
                shamanlossesWriter.Write(T);
                shamanlossesWriter.Flush();
            }
        }
        public void ReadShamanLosses()
        {
            try
            {
                using (StreamReader readshamanLosses = new StreamReader("ShamanLosses.txt"))
                {
                    shamanlosses = int.Parse(readshamanLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WriteShamanLosses(0);
            }
        }
        public void ReadShamanWins()
        {
            try
            {
                using (StreamReader readshamanWins = new StreamReader("ShamanWins.txt"))
                {
                    shamanwins = int.Parse(readshamanWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WriteShamanWins(0);
            }
        }
        public void shamanButtonCLICKED(HSCounter hsc)
        {
            shamanButtonIsSelected(hsc);
            this.ShowandHideButtons(hsc);
            ReadShamanWins();
            hsc.label1.Text = "Won: " + shamanwins;
            WriteShamanWins(shamanwins);
            ReadShamanLosses();
            hsc.lostLabel.Text = "Lost: " + shamanlosses;
            WriteShamanLosses(shamanlosses);
        }
        public void shamanLoseButtonCLICKED(HSCounter hsc)
        {
            shamanlosses++;
            hsc.lostLabel.Text = "Lost: " + shamanlosses;
            WriteShamanLosses(shamanlosses);
            hsc.otherlosebutton();
        }
        public void shamanWinButtonCLICKED(HSCounter hsc)
        {
            shamanwins++;
            hsc.label1.Text = "Won: " + shamanwins;
            WriteShamanWins(shamanwins);
            hsc.otherwinbutton();
        }
        public void shamanButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.shamanbutton.Image = global::Hearthstone_Counter.Icons.ShamanIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.shamanbutton.Image = global::Hearthstone_Counter.Icons.ShamanIcon;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPaladin();
            hsc.DeselectPriest();
            hsc.DeselectMage();
            hsc.DeselectWarlock();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.shamanWinButton.Show();
            hsc.shamanLoseButton.Show();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
            hsc.warlockWinButton.Hide();
            hsc.warlockLoseButton.Hide();
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
    }
}
