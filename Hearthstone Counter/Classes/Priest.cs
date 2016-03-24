using System;

namespace Hearthstone_Counter
{
    class Priest
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        private int priestWins;
        private int priestLosses;
        private string winPercentage;
        private double winP;

        public void WriteWins(int T, bool won)
        {
            ww.WriteWins(wr.ReadWinsArray(), T, won, "Priest");
        }
        public void WriteLosses(int T, bool lost)
        {
            lw.WriteLosses(lr.ReadLossesDictionary(), T, lost, "Priest");
        }
        private void ReadLosses()
        {
            priestLosses = lr.ReadLosses("Priest");
        }
        private void ReadWins()
        {
            priestWins = wr.ReadWins("Priest");
        }
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)priestWins / (priestWins + priestLosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void PriestButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            ShowAndHideButtons(hsc);
            ShowAndHideResetButtons(hsc);           
            ReadWins();
            hsc.label1.Text = "Won: " + priestWins;
            WriteWins(priestWins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + priestLosses;
            WriteLosses(priestLosses, false);
            CalculateWinPercentage(hsc);
        }
        public void PriestLoseButtonCLICKED(HSCounter hsc)
        {           
            priestLosses++;
            hsc.lostLabel.Text = "Lost: " + priestLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(priestLosses, true);
        }
        public void PriestWinButtonCLICKED(HSCounter hsc)
        {           
            priestWins++;
            hsc.label1.Text = "Won: " + priestWins;
            CalculateWinPercentage(hsc);
            WriteWins(priestWins, true);        
        }
        public void PriestResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - priestWins);
            dfc.WriteLosses(dfc.losses - priestLosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            PriestButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            hsc.priestbutton.Image = global::Hearthstone_Counter.Icons.priestSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            hsc.priestbutton.Image = global::Hearthstone_Counter.Icons.priestIcon;
        }
        private void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPaladin();
            hsc.DeselectMage();
            hsc.DeselectShaman();
            hsc.DeselectWarlock();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.priestBG;
        }
        private void ShowAndHideButtons(HSCounter hsc)
        {
            hsc.priestLoseButton.Show();
            hsc.priestWinButton.Show();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.warlockWinButton.Hide();
            hsc.warlockLoseButton.Hide();
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
            hsc.priestResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();         
            hsc.mageResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.warriorResetButton.Hide();
        }
    }
}
