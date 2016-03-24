using System;

namespace Hearthstone_Counter
{
    class Mage
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        private int mageWins;
        private int mageLosses;
        private string winPercentage;
        private double winP;

        public void WriteWins(int T, bool won)
        {
            ww.WriteWins(wr.ReadWinsArray() ,T, won, "Mage");
        }
        public void WriteLosses(int T, bool lost)
        {
            lw.WriteLosses(lr.ReadLossesDictionary(), T, lost, "Mage");
        }
        private void ReadLosses()
        {
            mageLosses = lr.ReadLosses("Mage");
        }
        private void ReadWins()
        {
            mageWins = wr.ReadWins("Mage");
        }
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)mageWins / (mageWins + mageLosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void MageButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            this.ShowAndHideButtons(hsc);
            this.ShowAndHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + mageWins;
            WriteWins(mageWins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + mageLosses;
            WriteLosses(mageLosses, false);
            CalculateWinPercentage(hsc);
        }
        public void MageLoseButtonCLICKED(HSCounter hsc)
        {
            mageLosses++;
            hsc.lostLabel.Text = "Lost: " + mageLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(mageLosses, true);
        }
        public void MageWinButtonCLICKED(HSCounter hsc)
        {
            mageWins++;
            hsc.label1.Text = "Won: " + mageWins;
            CalculateWinPercentage(hsc);
            WriteWins(mageWins, true);
        }
        public void MageResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - mageWins);
            dfc.WriteLosses(dfc.losses - mageLosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            MageButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            hsc.magebutton.Image = global::Hearthstone_Counter.Icons.MageIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
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
        private void ShowAndHideButtons(HSCounter hsc)
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
        private void ShowAndHideResetButtons(HSCounter hsc)
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
