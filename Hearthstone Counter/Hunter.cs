using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Hunter
    {
        public bool selected;
        public int hunterwins;
        public int hunterlosses;
        string eMessage;
        public void WriteHunterWins(int T)
        {
            using (StreamWriter hunterwinsWriter = new StreamWriter("Textfiles/HunterWins.txt", false))
            {
                hunterwinsWriter.Write(T);
                hunterwinsWriter.Flush();
            }
        }
        public void WriteHunterLosses(int T)
        {
            using (StreamWriter hunterlossesWriter = new StreamWriter("Textfiles/HunterLosses.txt", false))
            {
                hunterlossesWriter.Write(T);
                hunterlossesWriter.Flush();
            }
        }
        public void ReadHunterLosses()
        {
            try
            {
                using (StreamReader readhunterLosses = new StreamReader("Textfiles/HunterLosses.txt"))
                {
                    hunterlosses = int.Parse(readhunterLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WriteHunterLosses(0);
            }
        }
        public void ReadHunterWins()
        {
            try
            {
                using (StreamReader readhunterWins = new StreamReader("Textfiles/HunterWins.txt"))
                {
                    hunterwins = int.Parse(readhunterWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WriteHunterWins(0);
            }
        }
        public void hunterButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            hunterButtonIsSelected(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);
            ReadHunterWins();
            hsc.label1.Text = "Won: " + hunterwins;
            WriteHunterWins(hunterwins);
            ReadHunterLosses();
            hsc.lostLabel.Text = "Lost: " + hunterlosses;
            WriteHunterLosses(hunterlosses);
        }
        public void hunterLoseButtonCLICKED(HSCounter hsc)
        {
            hunterlosses++;
            hsc.lostLabel.Text = "Lost: " + hunterlosses;
            WriteHunterLosses(hunterlosses);
            hsc.otherlosebutton();
        }
        public void hunterWinButtonCLICKED(HSCounter hsc)
        {
            hunterwins++;
            hsc.label1.Text = "Won: " + hunterwins;
            WriteHunterWins(hunterwins);
            hsc.otherwinbutton();
        }
        public void hunterResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - hunterwins);
            dfc.WriteLosses(dfc.losses - hunterlosses);
            WriteHunterWins(0);
            WriteHunterLosses(0);
            hunterButtonCLICKED(hsc);
        }
        public void hunterButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.hunterbutton.Image = global::Hearthstone_Counter.Icons.hunterSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.hunterbutton.Image = global::Hearthstone_Counter.Icons.hunter_4;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectMage();
            hsc.DeselectPaladin();
            hsc.DeselectPriest();
            hsc.DeselectShaman();
            hsc.DeselectWarlock();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.hunterBG;
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.hunterWinButton.Show();
            hsc.hunterLoseButton.Show();
            hsc.warlockWinButton.Hide();
            hsc.warlockLoseButton.Hide();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.shamanWinButton.Hide();
            hsc.shamanLoseButton.Hide();
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
            hsc.hunterResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.warriorResetButton.Hide();
            hsc.mageResetButton.Hide();
        }
    }
}

