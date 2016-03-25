using System;

namespace Hearthstone_Counter
{
    class Mage
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private static bool selected;
        private int mageWins;
        private int mageLosses;
        private string winPercentage;
        private double winP;

        public void WriteWins(int T, int won)
        {
            writer.WriteWins(reader.ReadResultsDictionary() ,T, won, "Mage");
        }
        public void WriteLosses(int T, int lost)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, lost, "Mage");
        }
        private void ReadLosses()
        {
            mageLosses = reader.ReadLosses("Mage");
        }
        private void ReadWins()
        {
            mageWins = reader.ReadWins("Mage");
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
            ShowAndHideButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + mageWins;
            WriteWins(mageWins, 0);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + mageLosses;
            WriteLosses(mageLosses, 0);
            CalculateWinPercentage(hsc);
        }
        public void MageLoseButtonCLICKED(HSCounter hsc)
        {
            mageLosses++;
            hsc.lostLabel.Text = "Lost: " + mageLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(mageLosses, 1);
        }
        public void AddLosses(int addedLosses, HSCounter hsc)
        {
            mageLosses += addedLosses;
            WriteLosses(mageLosses, addedLosses);
            hsc.lostLabel.Text = "Lost: " + mageLosses;
        }
        public void MageWinButtonCLICKED(HSCounter hsc)
        {
            mageWins++;
            hsc.label1.Text = "Won: " + mageWins;
            CalculateWinPercentage(hsc);
            WriteWins(mageWins, 1);
        }
        public void AddWins(int addedWins, HSCounter hsc)
        {
            mageWins += addedWins;
            WriteWins(mageWins, addedWins);
            hsc.label1.Text = "Won: " + mageWins;
        }
        public void MageResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            ReadWins();
            ReadLosses();
            dfc.WriteWins(dfc.wins - mageWins);
            dfc.WriteLosses(dfc.losses - mageLosses);
            WriteWins(0, 0);
            WriteLosses(0, 0);
            MageButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            selected = true;
            hsc.magebutton.Image = global::Hearthstone_Counter.Icons.MageIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            selected = false;
            hsc.magebutton.Image = global::Hearthstone_Counter.Icons.MageIcon;
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
    }
}
