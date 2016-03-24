using System;
namespace Hearthstone_Counter
{
    class Warrior
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private int warriorWins;
        private int warriorLosses;
        private string winPercentage;
        private double winP;
        public void WriteWins(int T, bool won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Warrior");
        }
        public void WriteLosses(int T, bool lost)
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
            ShowAndHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + warriorWins;
            WriteWins(warriorWins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + warriorLosses;
            WriteLosses(warriorLosses, false);
            CalculateWinPercentage(hsc);
        }
        public void WarriorLoseButtonCLICKED(HSCounter hsc)
        {
            warriorLosses++;
            hsc.lostLabel.Text = "Lost: " + warriorLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(warriorLosses, true);
        }
        public void WarriorWinButtonCLICKED(HSCounter hsc)
        {
            warriorWins++;
            hsc.label1.Text = "Won: " + warriorWins;
            CalculateWinPercentage(hsc);
            WriteWins(warriorWins, true);
        }
        public void WarriorResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - warriorWins);
            dfc.WriteLosses(dfc.losses - warriorLosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            WarriorButtonCLICKED(hsc);
        }
        private void SelectButton(HSCounter hsc)
        {
            hsc.warriorbutton.Image = global::Hearthstone_Counter.Icons.WarriorIconSelected;
            DeselectOthers(hsc);
        }
        public void DeselectButton(HSCounter hsc)
        {
            hsc.warriorbutton.Image = global::Hearthstone_Counter.Icons.WarriorIcon;
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
            hsc.warriorWinButton.Show();
            hsc.warriorLoseButton.Show();
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
            hsc.rogueWinButton.Hide();
            hsc.rogueLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
        }
        private void ShowAndHideResetButtons(HSCounter hsc)
        {
            hsc.warriorResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.mageResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.warlockResetButton.Hide();           
        }
    }
}
