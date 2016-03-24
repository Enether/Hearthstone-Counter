using System;

namespace Hearthstone_Counter
{
    class Paladin
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private int paladinWins;
        private int paladinLosses;
        private string winPercentage;
        private double winP;

        public void WriteWins(int T, bool won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Paladin");
        }
        public void WriteLosses(int T, bool lost)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, lost, "Paladin");
        }
        private void ReadLosses()
        {
            paladinLosses = reader.ReadLosses("Paladin");
        }
        private void ReadWins()
        {
            paladinWins = reader.ReadWins("Paladin");
        }
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)paladinWins / (paladinWins + paladinLosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void PaladinButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            this.ShowAndHideResetButtons(hsc);
            DeselectOthers(hsc);
            ShowAndHideButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + paladinWins;
            WriteWins(paladinWins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + paladinLosses;
            WriteLosses(paladinLosses, false);
            CalculateWinPercentage(hsc);
        }
        public void PaladinLoseButtonCLICKED(HSCounter hsc)
        {
            paladinLosses++;
            hsc.lostLabel.Text = "Lost: " + paladinLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(paladinLosses, true);
        }
        public void PaladinWinButtonCLICKED(HSCounter hsc)
        {
            paladinWins++;
            hsc.label1.Text = "Won: " + paladinWins;
            CalculateWinPercentage(hsc);
            WriteWins(paladinWins, true);
        }
        public void PaladinResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - paladinWins);
            dfc.WriteLosses(dfc.losses - paladinLosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            PaladinButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            hsc.paladinbutton.Image = global::Hearthstone_Counter.Icons.PaladinIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
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
        private void ShowAndHideButtons(HSCounter hsc)
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
        private void ShowAndHideResetButtons(HSCounter hsc)
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
