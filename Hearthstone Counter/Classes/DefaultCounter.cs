﻿using System;
using System.IO;

namespace Hearthstone_Counter
{
    class DefaultCounter
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

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
            ShowAndHideResetButtons(hsc);
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
            writer.WriteWins(reader.ReadResultsDictionary(), T, false, "Default");
           // ww.WriteAllWins(T);
        }
        public void WriteLosses(int T)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, false, "Default");
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
        public void WinButtonCLICKED(HSCounter hsc)
        {
            wins++;
            hsc.label1.Text = "Won: " + wins;
            CalculateWinPercentage(hsc);
            WriteWins(wins);
        }
        public void ResetButtonCLICKED(HSCounter hsc)
        {
            writer.ResetResults();
            DefaultButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            hsc.defaultbutton.Image = global::Hearthstone_Counter.Icons.DefaultIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
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
        private void ShowAndHideButtons(HSCounter hsc)
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
        private void ShowAndHideResetButtons(HSCounter hsc)
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
