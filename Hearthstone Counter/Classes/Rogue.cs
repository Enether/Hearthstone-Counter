using System;


namespace Hearthstone_Counter
{
    class Rogue
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private int rogueWins;
        private int rogueLosses;
        private string winPercentage;
        private double winP;
        public void WriteWins(int T, bool won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Rogue");
        }
        public void WriteLosses(int T, bool lost)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, lost, "Rogue");
        }
        private void ReadLosses()
        {
            rogueLosses = reader.ReadLosses("Rogue");
        }
        private void ReadWins()
        {
            rogueWins = reader.ReadWins("Rogue");
        }
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)rogueWins / (rogueWins + rogueLosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void RogueButtonCLICKED(HSCounter hsc)
        {            
            SelectButton(hsc);
            DeselectOthers(hsc);
            ShowAndHideButtons(hsc);
            ShowAndHideResetButtons(hsc);
            ChangeBG(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + rogueWins;
            WriteWins(rogueWins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + rogueLosses;
            WriteLosses(rogueLosses, false);
            CalculateWinPercentage(hsc);
        }
        public void RogueLoseButtonCLICKED(HSCounter hsc)
        {
            rogueLosses++;
            hsc.lostLabel.Text = "Lost: " + rogueLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(rogueLosses, true);
        }
        public void RogueWinButtonCLICKED(HSCounter hsc)
        {
            rogueWins++;
            hsc.label1.Text = "Won: " + rogueWins;
            CalculateWinPercentage(hsc);
            WriteWins(rogueWins, true);
        }
        public void RogueResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - rogueWins);
            dfc.WriteLosses(dfc.losses - rogueLosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            RogueButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            hsc.roguebutton.Image = global::Hearthstone_Counter.Icons.RogueIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            hsc.roguebutton.Image = global::Hearthstone_Counter.Icons.RogueIcon;
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
            hsc.DeselectPaladin();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.rogueBG;
        }
        private void ShowAndHideButtons(HSCounter hsc)
        {
            hsc.rogueWinButton.Show();
            hsc.rogueLoseButton.Show();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
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
            hsc.warriorWinButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
        }
        private void ShowAndHideResetButtons(HSCounter hsc)
        {
            hsc.rogueResetButton.Show();           
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.mageResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.hunterResetButton.Hide();           
            hsc.warriorResetButton.Hide();
        }

    }
}
