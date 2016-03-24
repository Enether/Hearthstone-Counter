using System;

namespace Hearthstone_Counter
{
    class Hunter
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private int hunterWins;
        private int hunterLosses;
        private string winPercentage;
        private double winP;

        public void WriteWins(int T, bool won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Hunter");
        }
        public void WriteLosses(int T, bool lost)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, lost, "Hunter");
        }
        private void ReadLosses()
        {
            hunterLosses = reader.ReadLosses("Hunter");
        }
        private void ReadWins()
        {
            hunterWins = reader.ReadWins("Hunter");
        }
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)hunterWins / (hunterWins + hunterLosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void HunterButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            ShowAndHideButtons(hsc);
            ShowAndHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + hunterWins;
            WriteWins(hunterWins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + hunterLosses;
            WriteLosses(hunterLosses, false);
            CalculateWinPercentage(hsc);
        }
        public void HunterLoseButtonCLICKED(HSCounter hsc)
        {
            hunterLosses++;
            hsc.lostLabel.Text = "Lost: " + hunterLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(hunterLosses, true);
        }
        public void HunterWinButtonCLICKED(HSCounter hsc)
        {
            hunterWins++;
            hsc.label1.Text = "Won: " + hunterWins;
            CalculateWinPercentage(hsc);
            WriteWins(hunterWins, true);
        }
        public void HunterResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - hunterWins);
            dfc.WriteLosses(dfc.losses - hunterLosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            HunterButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            hsc.hunterbutton.Image = global::Hearthstone_Counter.Icons.hunterSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
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
        private void ShowAndHideButtons(HSCounter hsc)
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
        private void ShowAndHideResetButtons(HSCounter hsc)
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

