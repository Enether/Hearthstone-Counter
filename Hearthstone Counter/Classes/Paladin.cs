using System;

namespace Hearthstone_Counter
{
    class Paladin
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private static bool selected;
        private int paladinWins;
        private int paladinLosses;
        private string winPercentage;
        private double winP;

        public Paladin()
        {
            ReadWins();
            ReadLosses();
        }
        public void WriteWins(int T, int won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Paladin");
        }
        public void WriteLosses(int T, int lost)
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
            DeselectOthers(hsc);
            ShowAndHideButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + paladinWins;
            WriteWins(paladinWins, 0);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + paladinLosses;
            WriteLosses(paladinLosses, 0);
            CalculateWinPercentage(hsc);
        }
        public void PaladinLoseButtonCLICKED(HSCounter hsc)
        {
            paladinLosses++;
            hsc.lostLabel.Text = "Lost: " + paladinLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(paladinLosses, 1);
        }
        public void AddLosses(int addedLosses, HSCounter hsc)
        {
            paladinLosses += addedLosses;
            WriteLosses(paladinLosses, addedLosses);
            hsc.lostLabel.Text = "Lost: " + paladinLosses;
            CalculateWinPercentage(hsc);
        }
        public void PaladinWinButtonCLICKED(HSCounter hsc)
        {
            paladinWins++;
            hsc.label1.Text = "Won: " + paladinWins;
            CalculateWinPercentage(hsc);
            WriteWins(paladinWins, 1);
        }
        public void AddWins(int addedWins, HSCounter hsc)
        {
            paladinWins += addedWins;
            WriteWins(paladinWins, addedWins);
            hsc.label1.Text = "Won: " + paladinWins;
            CalculateWinPercentage(hsc);
        }
        public void PaladinResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.WriteWins(dfc.wins - paladinWins);
            dfc.WriteLosses(dfc.losses - paladinLosses);
            WriteWins(0, 0);
            WriteLosses(0, 0);
            PaladinButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            selected = true;
            hsc.paladinbutton.Image = global::Hearthstone_Counter.Icons.PaladinIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            selected = false;
            hsc.paladinbutton.Image = global::Hearthstone_Counter.Icons.PaladinIcon;
        }
        public static bool IsSelected()
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
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {           
            hsc.BackgroundImage = Background.paladinBG;
        }
        private void ShowAndHideButtons(HSCounter hsc)
        {
            hsc.paladinLoseButton.Show();
            hsc.priestLoseButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.shamanLoseButton.Hide();
            hsc.warlockLoseButton.Hide();
            hsc.hunterLoseButton.Hide();
            hsc.mageLoseButton.Hide();
            hsc.rogueLoseButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.loseButton.Hide();           
        }
    }
}
