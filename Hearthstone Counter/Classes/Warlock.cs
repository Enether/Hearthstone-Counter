﻿using System;

namespace Hearthstone_Counter
{
    class Warlock
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private int warlockWins;
        private int warlockLosses;
        private string winPercentage;
        private double winP;
        public void WriteWins(int T, bool won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Warlock");
        }
        public void WriteLosses(int T, bool lost)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, lost, "Warlock");
        }
        private void ReadLosses()
        {
            warlockLosses = reader.ReadLosses("Warlock");
        }
        private void ReadWins()
        {
            warlockWins = reader.ReadWins("Warlock");
        }
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)warlockWins / (warlockWins + warlockLosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void WarlockButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            ShowAndHideButtons(hsc);
            ShowAndHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + warlockWins;
            WriteWins(warlockWins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + warlockLosses;
            WriteLosses(warlockLosses, false);
            CalculateWinPercentage(hsc);
        }
        public void WarlockLoseButtonCLICKED(HSCounter hsc)
        {
            warlockLosses++;
            hsc.lostLabel.Text = "Lost: " + warlockLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(warlockLosses, true);
        }
        public void WarlockWinButtonCLICKED(HSCounter hsc)
        {
            warlockWins++;
            hsc.label1.Text = "Won: " + warlockWins;
            CalculateWinPercentage(hsc);
            WriteWins(warlockWins, true);
        }
        public void WarlockResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - warlockWins);
            dfc.WriteLosses(dfc.losses - warlockLosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            WarlockButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            hsc.warlockbutton.Image = global::Hearthstone_Counter.Icons.WarlockIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            hsc.warlockbutton.Image = global::Hearthstone_Counter.Icons.WarlockIcon;
        }
        private void DeselectOthers(HSCounter hsc)
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
        private void ShowAndHideButtons(HSCounter hsc)
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
        private void ShowAndHideResetButtons(HSCounter hsc)
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
