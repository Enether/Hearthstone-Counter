using System;

namespace Hearthstone_Counter
{
    class Hunter
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        public bool selected;
        public int hunterwins;
        public int hunterlosses;
        public string winPercentage;
        public double winP;

        public void WriteWins(int T, bool won)
        {
            ww.WriteWins(wr.ReadWinsArray(), T, won, "Hunter");
        }
        public void WriteLosses(int T, bool lost)
        {
            lw.WriteLosses(lr.ReadLossesDictionary(), T, lost, "Hunter");
        }
        public void ReadLosses()
        {
            hunterlosses = lr.ReadLosses("Hunter");
        }
        public void ReadWins()
        {
            hunterwins = wr.ReadWins("Hunter");
        }
        public void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)hunterwins / (hunterwins + hunterlosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void hunterButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            hunterButtonIsSelected(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + hunterwins;
            WriteWins(hunterwins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + hunterlosses;
            WriteLosses(hunterlosses, false);
            CalculateWinPercentage(hsc);
        }
        public void hunterLoseButtonCLICKED(HSCounter hsc)
        {
            hunterlosses++;
            hsc.lostLabel.Text = "Lost: " + hunterlosses;
            CalculateWinPercentage(hsc);
            WriteLosses(hunterlosses, true);
            hsc.otherlosebutton();
        }
        public void hunterWinButtonCLICKED(HSCounter hsc)
        {
            hunterwins++;
            hsc.label1.Text = "Won: " + hunterwins;
            CalculateWinPercentage(hsc);
            WriteWins(hunterwins, true);
        }
        public void hunterResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - hunterwins);
            dfc.WriteLosses(dfc.losses - hunterlosses);
            WriteWins(0, false);
            WriteLosses(0, false);
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
        private void DeselectOthers(HSCounter hsc)
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
        private void ShowandHideButtons(HSCounter hsc)
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
        private void ShowandHideResetButtons(HSCounter hsc)
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

