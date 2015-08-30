using System;
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
            using (StreamWriter shamanwinsWriter = new StreamWriter("Textfiles/ShamanWins.txt", false))
            {
                shamanwinsWriter.Write(T);
                shamanwinsWriter.Flush();
            }
        }
        public void WriteShamanLosses(int T)
        {
            using (StreamWriter shamanlossesWriter = new StreamWriter("Textfiles/ShamanLosses.txt", false))
            {
                shamanlossesWriter.Write(T);
                shamanlossesWriter.Flush();
            }
        }
        public void ReadShamanLosses()
        {
            try
            {
                using (StreamReader readshamanLosses = new StreamReader("Textfiles/ShamanLosses.txt"))
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
                using (StreamReader readshamanWins = new StreamReader("Textfiles/ShamanWins.txt"))
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
            ChangeBG(hsc);
            shamanButtonIsSelected(hsc);
            this.ShowandHideButtons(hsc);
            this.ShowandHideResetButtons(hsc);
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
        public void shamanResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - shamanwins);
            dfc.WriteLosses(dfc.losses - shamanlosses);
            WriteShamanWins(0);
            WriteShamanLosses(0);
            shamanButtonCLICKED(hsc);
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
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.shamanBG;
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
        public void ShowandHideResetButtons(HSCounter hsc)
        {
            hsc.shamanResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.mageResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.warriorResetButton.Hide();
        }
    }
}
