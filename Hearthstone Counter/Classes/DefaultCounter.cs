using System;
using System.IO;

namespace Hearthstone_Counter
{
    class DefaultCounter
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private static bool selected;
        public int wins;
        public int losses;
        private double winP;
        private string winPercentage;
        Druid druid = new Druid();
        Hunter hunter = new Hunter();
        Mage mage = new Mage();
        Paladin paladin = new Paladin();
        Priest priest = new Priest();
        Rogue rogue = new Rogue();
        Shaman shaman = new Shaman();
        Warlock warlock = new Warlock();
        Warrior warrior = new Warrior();

        public DefaultCounter()
        {
            ReadWins();
            ReadLosses();
        }
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
            SelectButton(hsc);
            ShowAndHideButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + wins;
            WriteWins(wins);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + losses;
            WriteLosses(losses);
            CalculateWinPercentage(hsc);
        }

        // Writers
        public void WriteWins(int T)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, 0, "Default");
        }
        public void WriteLosses(int T)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, 0, "Default");
        }
        // Readers
        public void ReadWins()
        {
            wins = reader.ReadWins("Default");
        }
        
        public void ReadLosses()
        {
            losses = reader.ReadLosses("Default");
        }
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)wins / (wins + losses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        // Clicked Buttons
        public void LoseButtonCLICKED(HSCounter hsc)
        {       
            losses++;
            hsc.lostLabel.Text = "Lost: " + losses;
            CalculateWinPercentage(hsc);
            WriteLosses(losses);
        }
        public void AddLosses(int addedLosses, HSCounter hsc)
        {
            losses += addedLosses;
            WriteLosses(losses);
            hsc.lostLabel.Text = "Lost: " + losses;
            CalculateWinPercentage(hsc);
        }
        public void WinButtonCLICKED(HSCounter hsc)
        {
            wins++;
            hsc.label1.Text = "Won: " + wins;
            CalculateWinPercentage(hsc);
            WriteWins(wins);
        }
        public void AddWins(int addedWins, HSCounter hsc)
        {
            wins += addedWins;
            WriteWins(wins);
            hsc.label1.Text = "Won: " + wins;
            CalculateWinPercentage(hsc);
        }
        public void ResetButtonCLICKED(HSCounter hsc)
        {
            writer.ResetResults();
            DefaultButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            selected = true;
            hsc.defaultbutton.Image = global::Hearthstone_Counter.Icons.DefaultIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            selected = false;
            hsc.defaultbutton.Image = global::Hearthstone_Counter.Icons.DefaultIcon;
        }
        public static bool IsSelected()
        {
            return selected;
        }
        private void DeselectOthers(HSCounter hsc)
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
        private void ShowAndHideButtons(HSCounter hsc)
        {
            hsc.loseButton.Show();
            hsc.druidLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.shamanLoseButton.Hide();
            hsc.warlockLoseButton.Hide();
            hsc.hunterLoseButton.Hide();
            hsc.rogueLoseButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.mageLoseButton.Hide();
        }
    }
}
