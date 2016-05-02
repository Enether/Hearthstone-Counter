using System;
using System.IO;

namespace Hearthstone_Counter
{
    class DefaultCounter
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private static bool selected;
        private int wins;
        public int Wins { get { return wins; } }
        private int losses;
        public int Losses { get { return losses; } }
        private double winPercentage;
        private string winPercentageString;
        Druid druid = new Druid();
        Hunter hunter = new Hunter();
        Mage mage = new Mage();
        Paladin paladin = new Paladin();
        Priest priest = new Priest();
        Rogue rogue = new Rogue();
        Shaman shaman = new Shaman();
        Warlock warlock = new Warlock();
        Warrior warrior = new Warrior();

        public DefaultCounter()
        {
            ReadWins();
            ReadLosses();
        }
        public void Initialization(HSCounter hsc)
        {
            Directory.CreateDirectory("Textfiles");
            Directory.CreateDirectory("Textfiles/LogFiles");
            DefaultButton_Clicked(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + wins;
            WriteWins(wins);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + losses;
            WriteLosses(losses);            
        }

        // Clicked Buttons
        public void DefaultButton_Clicked(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + wins;
            WriteWins(wins);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + losses;
            WriteLosses(losses);
            CalculateWinPercentage(hsc);
        }
        public void WinButton_Clicked(HSCounter hsc)
        {
            wins++;
            hsc.label1.Text = "Won: " + wins;
            CalculateWinPercentage(hsc);
            WriteWins(wins);
        }
        public void LoseButton_Clicked(HSCounter hsc)
        {       
            losses++;
            hsc.lostLabel.Text = "Lost: " + losses;
            CalculateWinPercentage(hsc);
            WriteLosses(losses);
        }
        public void ResetButton_Clicked(HSCounter hsc)
        {
            writer.ResetResults();

            wins = losses = 0;
            hsc.label1.Text = "Won: 0";
            hsc.lostLabel.Text = "Lost: 0";
            CalculateWinPercentage(hsc);
        }

        // Add results when the "Add More" button is clicked
        public void AddWins(int addedWins, HSCounter hsc)
        {
            wins += addedWins;
            WriteWins(wins);
            hsc.label1.Text = "Won: " + wins;
            CalculateWinPercentage(hsc);
        }
        public void AddLosses(int addedLosses, HSCounter hsc)
        {
            losses += addedLosses;
            WriteLosses(losses);
            hsc.lostLabel.Text = "Lost: " + losses;
            CalculateWinPercentage(hsc);
        }

        // Writers
        public void WriteWins(int T)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, 0, "Default");
        }
        public void WriteLosses(int T)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, 0, "Default");
        }

        // Readers
        private void ReadWins()
        {
            wins = reader.ReadWins("Default");
        }      
        private void ReadLosses()
        {
            losses = reader.ReadLosses("Default");
        }

        // Calculates the win percentage
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winPercentage = (double)wins / (wins + losses);

            if (Double.IsNaN(winPercentage)) 
                winPercentage = 0;

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
            hsc.defaultbutton.Image = global::Hearthstone_Counter.Icons.DefaultIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            selected = false;
            hsc.defaultbutton.Image = global::Hearthstone_Counter.Icons.DefaultIcon;
        }
        private void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectMage();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPaladin();
            hsc.DeselectPriest();
            hsc.DeselectShaman();
            hsc.DeselectWarlock();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }

        //Changes the background to the class' background picture
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.defaultBG;
        }
    }
}
