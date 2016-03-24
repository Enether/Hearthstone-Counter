using System;

namespace Hearthstone_Counter
{
    class Mage
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        public bool selected;
        public int magewins;
        public int magelosses;
        public string winPercentage;
        public double winP;

        public void WriteWins(int T, bool won)
        {
            ww.WriteWins(wr.ReadWinsArray() ,T, won, "Mage");
        }
        public void WriteLosses(int T, bool lost)
        {
            lw.WriteLosses(lr.ReadLossesDictionary(), T, lost, "Mage");
        }
        public void ReadLosses()
        {
            magelosses = lr.ReadLosses("Mage");
        }
        public void ReadWins()
        {
            magewins = wr.ReadWins("Mage");
        }
        public void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)magewins / (magewins + magelosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void mageButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            mageButtonIsSelected(hsc);
            this.ShowandHideButtons(hsc);
            this.ShowandHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + magewins;
            WriteWins(magewins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + magelosses;
            WriteLosses(magelosses, false);
            CalculateWinPercentage(hsc);
        }
        public void mageLoseButtonCLICKED(HSCounter hsc)
        {
            magelosses++;
            hsc.lostLabel.Text = "Lost: " + magelosses;
            CalculateWinPercentage(hsc);
            WriteLosses(magelosses, true);
            hsc.otherlosebutton();
        }
        public void mageWinButtonCLICKED(HSCounter hsc)
        {
            magewins++;
            hsc.label1.Text = "Won: " + magewins;
            CalculateWinPercentage(hsc);
            WriteWins(magewins, true);
        }
        public void mageResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - magewins);
            dfc.WriteLosses(dfc.losses - magelosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            mageButtonCLICKED(hsc);
        }
        public void mageButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.magebutton.Image = global::Hearthstone_Counter.Icons.MageIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.magebutton.Image = global::Hearthstone_Counter.Icons.MageIcon;
        }
        private void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
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
            hsc.BackgroundImage = Background.mageBG;
        }
        private void ShowandHideButtons(HSCounter hsc)
        {
            hsc.mageWinButton.Show();
            hsc.mageLoseButton.Show();
            hsc.hunterWinButton.Hide();
            hsc.hunterLoseButton.Hide();
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
            hsc.rogueWinButton.Hide();
            hsc.rogueLoseButton.Hide();
            hsc.warriorWinButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
        }
        private void ShowandHideResetButtons(HSCounter hsc)
        {
            hsc.mageResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.warriorResetButton.Hide();
        }
    }
}
