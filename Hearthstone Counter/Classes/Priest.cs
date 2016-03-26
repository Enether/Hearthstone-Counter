using System;

namespace Hearthstone_Counter
{
    class Priest
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private static bool selected;
        private int priestWins;
        private int priestLosses;
        private string winPercentage;
        private double winP;

        public Priest()
        {
            ReadWins();
            ReadLosses();
        }
        public void WriteWins(int T, int won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Priest");
        }
        public void WriteLosses(int T, int lost)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, lost, "Priest");
        }
        private void ReadLosses()
        {
            priestLosses = reader.ReadLosses("Priest");
        }
        private void ReadWins()
        {
            priestWins = reader.ReadWins("Priest");
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
            ReadWins();
            hsc.label1.Text = "Won: " + priestWins;
            WriteWins(priestWins, 0);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + priestLosses;
            WriteLosses(priestLosses, 0);
            CalculateWinPercentage(hsc);
        }
        public void PriestLoseButtonCLICKED(HSCounter hsc)
        {           
            priestLosses++;
            hsc.lostLabel.Text = "Lost: " + priestLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(priestLosses, 1);
        }
        public void AddLosses(int addedLosses, HSCounter hsc)
        {
            priestLosses += addedLosses;
            WriteLosses(priestLosses, addedLosses);
            hsc.lostLabel.Text = "Lost: " + priestLosses;
            CalculateWinPercentage(hsc);
        }
        public void PriestWinButtonCLICKED(HSCounter hsc)
        {           
            priestWins++;
            hsc.label1.Text = "Won: " + priestWins;
            CalculateWinPercentage(hsc);
            WriteWins(priestWins, 1);        
        }
        public void AddWins(int addedWins, HSCounter hsc)
        {
            priestWins += addedWins;
            WriteWins(priestWins, addedWins);
            hsc.label1.Text = "Won: " + priestWins;
            CalculateWinPercentage(hsc);
        }
        public void PriestResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.WriteWins(dfc.wins - priestWins);
            dfc.WriteLosses(dfc.losses - priestLosses);
            WriteWins(0, 0);
            WriteLosses(0, 0);
            PriestButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            selected = true;
            hsc.priestbutton.Image = global::Hearthstone_Counter.Icons.priestSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            selected = false;
            hsc.priestbutton.Image = global::Hearthstone_Counter.Icons.priestIcon;
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
    }
}
