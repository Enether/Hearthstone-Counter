using System;
using System.IO;

namespace Hearthstone_Counter
{
    class DefaultCounter
    {
        public bool selected;
        
        public int wins;
        public int losses;
        public double winP;
        public string winPercentage;
        Druid druid = new Druid();
        Hunter hunter = new Hunter();
        Mage mage = new Mage();
        Paladin paladin = new Paladin();
        Priest priest = new Priest();
        Rogue rogue = new Rogue();
        Shaman shaman = new Shaman();
        Warlock warlock = new Warlock();
        Warrior warrior = new Warrior();
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();

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
            CalculateWinPercentage(hsc);
        }

        // Writers
        public void WriteWins(int T)
        {
            ww.WriteWins(wr.ReadWinsArray(),T, false, "Default");
           // ww.WriteAllWins(T);
        }
        public void WriteLosses(int T)
        {
            lw.WriteLosses(lr.ReadLossesDictionary(), T, false, "Default");
        }
        // Readers
        public void ReadWins()
        {
            wins = wr.ReadWins("Default");
        }
        
        public void ReadLosses()
        {
            losses = lr.ReadLosses("Default");
        }
        public void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)wins / (wins + losses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        // Clicked Buttons
        public void loseButtonCLICKED(HSCounter hsc)
        {       
            losses++;
            hsc.lostLabel.Text = "Lost: " + losses;
            CalculateWinPercentage(hsc);
            WriteLosses(losses);
        }
        public void winButtonCLICKED(HSCounter hsc)
        {
            wins++;
            hsc.label1.Text = "Won: " + wins;
            CalculateWinPercentage(hsc);
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
            druid.WriteWins(0, false);
            druid.WriteLosses(0, false);

            hunter.WriteWins(0, false);
            hunter.WriteLosses(0, false);

            mage.WriteWins(0, false);
            mage.WriteLosses(0, false);

            paladin.WriteWins(0, false);
            paladin.WriteLosses(0, false);

            priest.WriteWins(0, false);
            priest.WriteLosses(0, false);

            rogue.WriteWins(0, false);
            rogue.WriteLosses(0, false);

            shaman.WriteWins(0, false);
            shaman.WriteLosses(0, false);

            warlock.WriteWins(0, false);
            warlock.WriteLosses(0, false);

            warrior.WriteWins(0, false);
            warrior.WriteLosses(0, false);
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
        private void ShowandHideButtons(HSCounter hsc)
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
        private void ShowandHideResetButtons(HSCounter hsc)
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
