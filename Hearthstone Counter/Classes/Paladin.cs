using System;

namespace Hearthstone_Counter
{
    class Paladin
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        public bool selected;
        public int paladinwins;
        public int paladinlosses;
        public string winPercentage;
        public double winP;

        public void WriteWins(int T, bool won)
        {
            ww.WriteWins(wr.ReadWinsArray(), T, won, "Paladin");
        }
        public void WriteLosses(int T, bool lost)
        {
            lw.WriteLosses(lr.ReadLossesDictionary(), T, lost, "Paladin");
        }
        public void ReadLosses()
        {
            paladinlosses = lr.ReadLosses("Paladin");
        }
        public void ReadWins()
        {
            paladinwins = wr.ReadWins("Paladin");
        }
        public void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)paladinwins / (paladinwins + paladinlosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void paladinButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            paladinButtonIsSelected(hsc);
            this.ShowandHideResetButtons(hsc);
            DeselectOthers(hsc);
            ShowandHideButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + paladinwins;
            WriteWins(paladinwins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + paladinlosses;
            WriteLosses(paladinlosses, false);
            CalculateWinPercentage(hsc);
        }
        public void paladinLoseButtonCLICKED(HSCounter hsc)
        {
            paladinlosses++;
            hsc.lostLabel.Text = "Lost: " + paladinlosses;
            CalculateWinPercentage(hsc);
            WriteLosses(paladinlosses, true);
            hsc.otherlosebutton();
        }
        public void paladinWinButtonCLICKED(HSCounter hsc)
        {
            paladinwins++;
            hsc.label1.Text = "Won: " + paladinwins;
            CalculateWinPercentage(hsc);
            WriteWins(paladinwins, true);
        }
        public void paladinResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - paladinwins);
            dfc.WriteLosses(dfc.losses - paladinlosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            paladinButtonCLICKED(hsc);
        }
        public void paladinButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.paladinbutton.Image = global::Hearthstone_Counter.Icons.PaladinIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.paladinbutton.Image = global::Hearthstone_Counter.Icons.PaladinIcon;
        }
        private void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectMage();
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPriest();
            hsc.DeselectShaman();
            hsc.DeselectWarlock();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {           
            hsc.BackgroundImage = Background.paladinBG;
        }
        private void ShowandHideButtons(HSCounter hsc)
        {
            hsc.paladinWinButton.Show();
            hsc.paladinLoseButton.Show();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.shamanWinButton.Hide();
            hsc.shamanLoseButton.Hide();
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
        private void ShowandHideResetButtons(HSCounter hsc)
        {
            hsc.paladinResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.priestResetButton.Hide();            
            hsc.mageResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.warriorResetButton.Hide();
        }
    }
}
