using System;

namespace Hearthstone_Counter
{
    class Druid
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        private int druidWins;
        private int druidLosses;
        private double winP;
        private string winPercentage;

        public void WriteWins(int T, bool won)
        {
            ww.WriteWins(wr.ReadWinsArray(), T, won, "Druid");
        }
        public void WriteLosses(int T, bool lost)
        {
            lw.WriteLosses(lr.ReadLossesDictionary(), T, lost, "Druid");
        }
        private void ReadLosses()
        {
            druidLosses = lr.ReadLosses("Druid");
        }
        private void ReadWins()
        {
            druidWins = wr.ReadWins("Druid");
        }
        public void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)druidWins / (druidWins + druidLosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void DruidButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            ShowAndHideButtons(hsc);
            ShowAndHideButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + druidWins;
            WriteWins(druidWins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + druidLosses;
            WriteLosses(druidLosses, false);
            CalculateWinPercentage(hsc);
        }
        public void DruidLoseButtonCLICKED(HSCounter hsc)
        {
            druidLosses++;
            hsc.lostLabel.Text = "Lost: " + druidLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(druidLosses, true);
        }
        public void DruidWinButtonCLICKED(HSCounter hsc)
        {
            druidWins++;
            hsc.label1.Text = "Won: " + druidWins;
            CalculateWinPercentage(hsc);
            WriteWins(druidWins, true);
        }
        public void DruidResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - druidWins);
            dfc.WriteLosses(dfc.losses - druidLosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            DruidButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            hsc.druidbutton.Image = global::Hearthstone_Counter.Icons.DruidIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            hsc.druidbutton.Image = global::Hearthstone_Counter.Icons.DruidIcon;
        }
        private void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectMage();
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
            hsc.BackgroundImage = Background.druidBG;
        }
        private void ShowAndHideButtons(HSCounter hsc)
        {
            hsc.druidWinButton.Show();
            hsc.druidLoseButton.Show();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
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
        private void ShowAndHideResetButtons(HSCounter hsc)
        {         
            hsc.druidResetButton.Show();
            hsc.resetbutton.Hide();
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
