using System;

namespace Hearthstone_Counter
{
    class Shaman
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private static bool selected;
        private int shamanWins;
        private int shamanLosses;
        private double winP;
        private string winPercentage;
        public void WriteWins(int T, int won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Shaman");
        }
        public void WriteLosses(int T, int lost)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, lost, "Shaman");
        }
        private void ReadLosses()
        {
            shamanLosses = reader.ReadLosses("Shaman");
        }
        private void ReadWins()
        {
           shamanWins = reader.ReadWins("Shaman");
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
            ReadWins();
            hsc.label1.Text = "Won: " + shamanWins;
            WriteWins(shamanWins, 0);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + shamanLosses;
            WriteLosses(shamanLosses, 0);
            CalculateWinPercentage(hsc);
        }
        public void ShamanLoseButtonCLICKED(HSCounter hsc)
        {
            shamanLosses++;
            hsc.lostLabel.Text = "Lost: " + shamanLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(shamanLosses, 1);
        }
        public void AddLosses(int addedLosses, HSCounter hsc)
        {
            shamanLosses += addedLosses;
            WriteLosses(shamanLosses, addedLosses);
            hsc.lostLabel.Text = "Lost: " + shamanLosses;
        }
        public void ShamanWinButtonCLICKED(HSCounter hsc)
        {
            shamanWins++;
            hsc.label1.Text = "Won: " + shamanWins;
            CalculateWinPercentage(hsc);
            WriteWins(shamanWins, 1);
        }
        public void AddWins(int addedWins, HSCounter hsc)
        {
            shamanWins += addedWins;
            WriteWins(shamanWins, addedWins);
            hsc.label1.Text = "Won: " + shamanWins;
        }
        public void ShamanResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            ReadWins();
            ReadLosses();
            dfc.WriteWins(dfc.wins - shamanWins);
            dfc.WriteLosses(dfc.losses - shamanLosses);
            WriteWins(0, 0);
            WriteLosses(0, 0);
            ShamanButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            selected = true;
            hsc.shamanbutton.Image = global::Hearthstone_Counter.Icons.ShamanIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            selected = false;
            hsc.shamanbutton.Image = global::Hearthstone_Counter.Icons.ShamanIcon;
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
    }
}
