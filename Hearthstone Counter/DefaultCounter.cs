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
        public bool selected;
        string eMessage;
        public int wins;
        public int losses;
        Druid druid = new Druid();
        Hunter hunter = new Hunter();
        Mage mage = new Mage();
        Paladin paladin = new Paladin();
        Priest priest = new Priest();
        Rogue rogue = new Rogue();
        Shaman shaman = new Shaman();
        Warlock warlock = new Warlock();
        Warrior warrior = new Warrior();

        public void Initialization(HSCounter hsc)
        {
            Directory.CreateDirectory("Textfiles");
            DefaultButtonCLICKED(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + wins;
            WriteWins(wins);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + losses;
            WriteLosses(losses);
            
        }
        public void DefaultButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            defaultButtonIsSelected(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + wins;
            WriteWins(wins);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + losses;
            WriteLosses(losses);
        }

        // Writers
        public void WriteWins(int T)
        {
            using (StreamWriter winsWriter = new StreamWriter("Textfiles/Wins.txt", false))
            {
                winsWriter.Write(T);
                winsWriter.Flush();
            }

        }
        public void WriteLosses(int T)
        {
            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/Losses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }
        // Readers
        public void ReadWins()
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Textfiles/Wins.txt"))
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
        
        public void ReadLosses()
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Textfiles/Losses.txt"))
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
        public void resetButtonCLICKED(HSCounter hsc)
        {
            WriteWins(0);
            WriteLosses(0);
            DefaultButtonCLICKED(hsc);
            resetClassesScores(hsc);
        }
        public void resetClassesScores(HSCounter hsc)
        {
            druid.WriteDruidWins(0);
            druid.WriteDruidLosses(0);

            hunter.WriteHunterWins(0);
            hunter.WriteHunterLosses(0);

            mage.WriteMageWins(0);
            mage.WriteMageLosses(0);

            paladin.WritePaladinWins(0);
            paladin.WritePaladinLosses(0);

            priest.WritePriestWins(0);
            priest.WritePriestLosses(0);

            rogue.WriteRogueWins(0);
            rogue.WriteRogueLosses(0);

            shaman.WriteShamanWins(0);
            shaman.WriteShamanLosses(0);

            warlock.WriteWarlockWins(0);
            warlock.WriteWarlockLosses(0);

            warrior.WriteWarriorWins(0);
            warrior.WriteWarriorLosses(0);
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
        public void defaultButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.defaultbutton.Image = global::Hearthstone_Counter.Icons.DefaultIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.defaultbutton.Image = global::Hearthstone_Counter.Icons.DefaultIcon;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectMage();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPaladin();
            hsc.DeselectPriest();
            hsc.DeselectShaman();
            hsc.DeselectWarlock();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.defaultBG;
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.winButton.Show();
            hsc.loseButton.Show();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.priestWinButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.shamanWinButton.Hide();
            hsc.shamanLoseButton.Hide();
            hsc.warlockWinButton.Hide();
            hsc.warlockLoseButton.Hide();
            hsc.hunterWinButton.Hide();
            hsc.hunterLoseButton.Hide();
            hsc.rogueWinButton.Hide();
            hsc.rogueLoseButton.Hide();
            hsc.warriorWinButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.mageWinButton.Hide();
            hsc.mageLoseButton.Hide();
        }
        public void ShowandHideResetButtons(HSCounter hsc)
        {
            hsc.resetbutton.Show();
            hsc.druidResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.warriorResetButton.Hide();
            hsc.mageResetButton.Hide();
        }
    }
}
