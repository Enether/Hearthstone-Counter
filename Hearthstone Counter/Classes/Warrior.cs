using System;
namespace Hearthstone_Counter
{
    class Warrior
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        public bool selected;
        public int warriorwins;
        public int warriorlosses;
        public string winPercentage;
        public double winP;
        public void WriteWins(int T, bool won)
        {
            ww.WriteWins(wr.ReadWinsArray(), T, won, "Warrior");
        }
        public void WriteLosses(int T, bool lost)
        {
            lw.WriteLosses(lr.ReadLossesDictionary(), T, lost, "Warrior");
        }
        public void ReadLosses()
        {
            warriorlosses = lr.ReadLosses("Warrior");
        }
        public void ReadWins()
        {
            warriorwins = wr.ReadWins("Warrior");
        }
        public void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)warriorwins / (warriorwins + warriorlosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void warriorButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            warriorButtonIsSelected(hsc);
            DeselectOthers(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + warriorwins;
            WriteWins(warriorwins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + warriorlosses;
            WriteLosses(warriorlosses, false);
            CalculateWinPercentage(hsc);
        }
        public void warriorLoseButtonCLICKED(HSCounter hsc)
        {
            warriorlosses++;
            hsc.lostLabel.Text = "Lost: " + warriorlosses;
            CalculateWinPercentage(hsc);
            WriteLosses(warriorlosses, true);
            hsc.otherlosebutton();
        }
        public void warriorWinButtonCLICKED(HSCounter hsc)
        {
            warriorwins++;
            hsc.label1.Text = "Won: " + warriorwins;
            CalculateWinPercentage(hsc);
            WriteWins(warriorwins, true);
        }
        public void warriorResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - warriorwins);
            dfc.WriteLosses(dfc.losses - warriorlosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            warriorButtonCLICKED(hsc);
        }
        public void warriorButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.warriorbutton.Image = global::Hearthstone_Counter.Icons.WarriorIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
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
        private void ShowandHideButtons(HSCounter hsc)
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
        private void ShowandHideResetButtons(HSCounter hsc)
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
