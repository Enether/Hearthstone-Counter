using System;

namespace Hearthstone_Counter
{
    class Warlock
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private static bool selected;
        private int warlockWins;
        private int warlockLosses;
        private string winPercentage;
        private double winP;

        public Warlock()
        {
            ReadWins();
            ReadLosses();
        }
        public void WriteWins(int T, int won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Warlock");
        }
        public void WriteLosses(int T, int lost)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, lost, "Warlock");
        }
        private void ReadLosses()
        {
            warlockLosses = reader.ReadLosses("Warlock");
        }
        private void ReadWins()
        {
            warlockWins = reader.ReadWins("Warlock");
        }
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)warlockWins / (warlockWins + warlockLosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void WarlockButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            ShowAndHideButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + warlockWins;
            WriteWins(warlockWins, 0);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + warlockLosses;
            WriteLosses(warlockLosses, 0);
            CalculateWinPercentage(hsc);
        }
        public void WarlockLoseButtonCLICKED(HSCounter hsc)
        {
            warlockLosses++;
            hsc.lostLabel.Text = "Lost: " + warlockLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(warlockLosses, 1);
        }
        public void AddLosses(int addedLosses, HSCounter hsc)
        {
            warlockLosses += addedLosses;
            WriteLosses(warlockLosses, addedLosses);
            hsc.lostLabel.Text = "Lost: " + warlockLosses;
            CalculateWinPercentage(hsc);
        }
        public void WarlockWinButtonCLICKED(HSCounter hsc)
        {
            warlockWins++;
            hsc.label1.Text = "Won: " + warlockWins;
            CalculateWinPercentage(hsc);
            WriteWins(warlockWins, 1);
        }
        public void AddWins(int addedWins, HSCounter hsc)
        {
            warlockWins += addedWins;
            WriteWins(warlockWins, addedWins);
            hsc.label1.Text = "Won: " + warlockWins;
            CalculateWinPercentage(hsc);
        }
        public void WarlockResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.WriteWins(dfc.wins - warlockWins);
            dfc.WriteLosses(dfc.losses - warlockLosses);
            WriteWins(0, 0);
            WriteLosses(0, 0);
            WarlockButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            selected = true;
            hsc.warlockbutton.Image = global::Hearthstone_Counter.Icons.WarlockIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            selected = false;
            hsc.warlockbutton.Image = global::Hearthstone_Counter.Icons.WarlockIcon;
        }
        public static bool IsSelected()
        {
            return selected;
        }
        private void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPaladin();
            hsc.DeselectPriest();
            hsc.DeselectShaman();
            hsc.DeselectMage();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.warlockBG;
        }
        private void ShowAndHideButtons(HSCounter hsc)
        {
            hsc.warlockLoseButton.Show();           
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();            
            hsc.druidLoseButton.Hide();            
            hsc.shamanLoseButton.Hide();            
            hsc.hunterLoseButton.Hide();           
            hsc.mageLoseButton.Hide();            
            hsc.rogueLoseButton.Hide();            
            hsc.warriorLoseButton.Hide();            
            hsc.loseButton.Hide();
        }
    }
}
