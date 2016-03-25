using System;
namespace Hearthstone_Counter
{
    class Warrior
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private static bool selected;
        private int warriorWins;
        private int warriorLosses;
        private string winPercentage;
        private double winP;

        public Warrior()
        {
            ReadWins();
            ReadLosses();
        }
        public void WriteWins(int T, int won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Warrior");
        }
        public void WriteLosses(int T, int lost)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, lost, "Warrior");
        }
        private void ReadLosses()
        {
            warriorLosses = reader.ReadLosses("Warrior");
        }
        private void ReadWins()
        {
            warriorWins = reader.ReadWins("Warrior");
        }
        private void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)warriorWins / (warriorWins + warriorLosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void WarriorButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            DeselectOthers(hsc);
            ShowAndHideButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + warriorWins;
            WriteWins(warriorWins, 0);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + warriorLosses;
            WriteLosses(warriorLosses, 0);
            CalculateWinPercentage(hsc);
        }
        public void WarriorLoseButtonCLICKED(HSCounter hsc)
        {
            warriorLosses++;
            hsc.lostLabel.Text = "Lost: " + warriorLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(warriorLosses, 1);
        }
        public void AddLosses(int addedLosses, HSCounter hsc)
        {
            warriorLosses += addedLosses;
            WriteLosses(warriorLosses, addedLosses);
            hsc.lostLabel.Text = "Lost: " + warriorLosses;
            CalculateWinPercentage(hsc);
        }
        public void WarriorWinButtonCLICKED(HSCounter hsc)
        {
            warriorWins++;
            hsc.label1.Text = "Won: " + warriorWins;
            CalculateWinPercentage(hsc);
            WriteWins(warriorWins, 1);
        }
        public void AddWins(int addedWins, HSCounter hsc)
        {
            warriorWins += addedWins;
            WriteWins(warriorWins, addedWins);
            hsc.label1.Text = "Won: " + warriorWins;
            CalculateWinPercentage(hsc);
        }
        public void WarriorResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.WriteWins(dfc.wins - warriorWins);
            dfc.WriteLosses(dfc.losses - warriorLosses);
            WriteWins(0, 0);
            WriteLosses(0, 0);
            WarriorButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            selected = true;
            hsc.warriorbutton.Image = global::Hearthstone_Counter.Icons.WarriorIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            selected = false;
            hsc.warriorbutton.Image = global::Hearthstone_Counter.Icons.WarriorIcon;
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
            hsc.DeselectPaladin();
            hsc.DeselectRogue();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.warriorBG;
        }
        private void ShowAndHideButtons(HSCounter hsc)
        {
            hsc.warriorLoseButton.Show();           
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();      
            hsc.druidLoseButton.Hide();         
            hsc.shamanLoseButton.Hide();         
            hsc.warlockLoseButton.Hide();
            hsc.hunterLoseButton.Hide();        
            hsc.mageLoseButton.Hide();         
            hsc.rogueLoseButton.Hide();          
            hsc.loseButton.Hide();
        }
    }
}
