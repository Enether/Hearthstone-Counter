using System;

namespace Hearthstone_Counter
{
    class Priest
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private static bool selected;
        private int wins;
        private int losses;
        private double winPercentage;
        private string winPercentageString;


        public Priest()
        {
            ReadWins();
            ReadLosses();
        }

        // Clicked Buttons
        public void PriestButton_Clicked(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + wins;
            WriteWins(wins, 0);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + losses;
            WriteLosses(losses, 0);
            CalculateWinPercentage(hsc);
        }
        public void WinButton_Clicked(HSCounter hsc)
        {
            wins++;
            hsc.label1.Text = "Won: " + wins;
            CalculateWinPercentage(hsc);
            WriteWins(wins, 1);
        }
        public void LoseButton_Clicked(HSCounter hsc)
        {
            losses++;
            hsc.lostLabel.Text = "Lost: " + losses;
            CalculateWinPercentage(hsc);
            WriteLosses(losses, 1);
        }
        public void ResetButton_Clicked(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.WriteWins(dfc.wins - wins);
            dfc.WriteLosses(dfc.losses - losses);
            WriteWins(0, 0);
            WriteLosses(0, 0);
            PriestButton_Clicked(hsc); // useless-ish TO DO: refactor
        }

        // Add  results when the "Add More" button is clicked
        public void AddWins(int addedWins, HSCounter hsc)
        {
            wins += addedWins;
            WriteWins(wins, addedWins);
            hsc.label1.Text = "Won: " + wins;
            CalculateWinPercentage(hsc);
        }
        public void AddLosses(int addedLosses, HSCounter hsc)
        {
            losses += addedLosses;
            WriteLosses(losses, addedLosses);
            hsc.lostLabel.Text = "Lost: " + losses;
            CalculateWinPercentage(hsc);
        }

        // Writers
        private void WriteWins(int T, int won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Priest");
        }
        private void WriteLosses(int T, int lost)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, lost, "Priest");
        }

        // Readers
        private void ReadWins()
        {
            wins = reader.ReadWins("Priest");
        }
        private void ReadLosses()
        {
            losses = reader.ReadLosses("Priest");
        }

        // Calculates the win percentage
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winPercentage = (double)wins / (wins + losses);
            if (Double.IsNaN(winPercentage)) winPercentage = 0;
            winPercentageString = string.Format("{0:0.0%}", winPercentage);
            hsc.defwinPlabel.Text = "Win %: " + winPercentageString;
        }

        // Select Methods
        public static bool IsSelected()
        {
            return selected;
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

        // Changes the background to the class' background picture
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.priestBG;
        }
    }
}
