using System;


namespace Hearthstone_Counter
{
    class Rogue
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private bool selected;
        private int rogueWins;
        private int rogueLosses;
        private string winPercentage;
        private double winP;
        public void WriteWins(int T, int won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Rogue");
        }
        public void WriteLosses(int T, int lost)
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
            WriteWins(rogueWins, 0);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + rogueLosses;
            WriteLosses(rogueLosses, 0);
            CalculateWinPercentage(hsc);
        }
        public void RogueLoseButtonCLICKED(HSCounter hsc)
        {
            rogueLosses++;
            hsc.lostLabel.Text = "Lost: " + rogueLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(rogueLosses, 1);
        }
        public void AddLosses(int addedLosses, HSCounter hsc)
        {
            rogueLosses += addedLosses;
            WriteLosses(rogueLosses, addedLosses);
            hsc.lostLabel.Text = "Lost: " + rogueLosses;
        }
        public void RogueWinButtonCLICKED(HSCounter hsc)
        {
            rogueWins++;
            hsc.label1.Text = "Won: " + rogueWins;
            CalculateWinPercentage(hsc);
            WriteWins(rogueWins, 1);
        }
        public void AddWins(int addedWins, HSCounter hsc)
        {
            rogueWins += addedWins;
            WriteWins(rogueWins, addedWins);
            hsc.label1.Text = "Won: " + rogueWins;
        }
        public void RogueResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - rogueWins);
            dfc.WriteLosses(dfc.losses - rogueLosses);
            WriteWins(0, 0);
            WriteLosses(0, 0);
            RogueButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            selected = true;
            hsc.roguebutton.Image = global::Hearthstone_Counter.Icons.RogueIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            selected = false;
            hsc.roguebutton.Image = global::Hearthstone_Counter.Icons.RogueIcon;
        }
        public bool IsSelected()
        {
            return selected;
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
