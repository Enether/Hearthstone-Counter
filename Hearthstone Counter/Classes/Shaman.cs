using System;

namespace Hearthstone_Counter
{
    class Shaman
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        private int shamanWins;
        private int shamanLosses;
        private double winP;
        private string winPercentage;
        public void WriteWins(int T, bool won)
        {
            ww.WriteWins(wr.ReadWinsArray(), T, won, "Shaman");
        }
        public void WriteLosses(int T, bool lost)
        {
            lw.WriteLosses(lr.ReadLossesDictionary(), T, lost, "Shaman");
        }
        private void ReadLosses()
        {
            shamanLosses = lr.ReadLosses("Shaman");
        }
        private void ReadWins()
        {
           shamanWins = wr.ReadWins("Shaman");
        }
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)shamanWins / (shamanWins + shamanLosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void ShamanButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            this.ShowAndHideButtons(hsc);
            this.ShowAndHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + shamanWins;
            WriteWins(shamanWins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + shamanLosses;
            WriteLosses(shamanLosses, false);
            CalculateWinPercentage(hsc);
        }
        public void ShamanLoseButtonCLICKED(HSCounter hsc)
        {
            shamanLosses++;
            hsc.lostLabel.Text = "Lost: " + shamanLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(shamanLosses, true);
        }
        public void ShamanWinButtonCLICKED(HSCounter hsc)
        {
            shamanWins++;
            hsc.label1.Text = "Won: " + shamanWins;
            CalculateWinPercentage(hsc);
            WriteWins(shamanWins, true);
        }
        public void ShamanResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - shamanWins);
            dfc.WriteLosses(dfc.losses - shamanLosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            ShamanButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            hsc.shamanbutton.Image = global::Hearthstone_Counter.Icons.ShamanIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            hsc.shamanbutton.Image = global::Hearthstone_Counter.Icons.ShamanIcon;
        }
        private void DeselectOthers(HSCounter hsc)
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
        private void ShowAndHideButtons(HSCounter hsc)
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
        private void ShowAndHideResetButtons(HSCounter hsc)
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
