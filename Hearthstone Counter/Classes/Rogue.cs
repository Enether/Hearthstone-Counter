using System;
using System.IO;


namespace Hearthstone_Counter
{
    class Rogue
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        public bool selected;
        public int roguewins;
        public int roguelosses;
        public string winPercentage;
        public double winP;
        string eMessage;
        public void WriteWins(int T, bool won)
        {
            ww.WriteWins(wr.ReadWinsArray(), T, won, "Rogue");
        }
        public void WriteLosses(int T)
        {
            lw.WriteRogueLosses(T);
        }
        public void ReadLosses()
        {
            lr.ReadRogueLosses(ref roguelosses);
        }
        public void ReadWins()
        {
            roguewins = wr.ReadWins("Rogue");
        }
        public void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)roguewins / (roguewins + roguelosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void rogueButtonCLICKED(HSCounter hsc)
        {            
            rogueButtonIsSelected(hsc);
            DeselectOthers(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);
            ChangeBG(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + roguewins;
            WriteWins(roguewins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + roguelosses;
            WriteLosses(roguelosses);
            CalculateWinPercentage(hsc);
        }
        public void rogueLoseButtonCLICKED(HSCounter hsc)
        {
            roguelosses++;
            hsc.lostLabel.Text = "Lost: " + roguelosses;
            CalculateWinPercentage(hsc);
            WriteLosses(roguelosses);
            hsc.otherlosebutton();
        }
        public void rogueWinButtonCLICKED(HSCounter hsc)
        {
            roguewins++;
            hsc.label1.Text = "Won: " + roguewins;
            CalculateWinPercentage(hsc);
            WriteWins(roguewins, true);
        }
        public void rogueResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - roguewins);
            dfc.WriteLosses(dfc.losses - roguelosses);
            WriteWins(0, false);
            WriteLosses(0);
            rogueButtonCLICKED(hsc);
        }
        public void rogueButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.roguebutton.Image = global::Hearthstone_Counter.Icons.RogueIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.roguebutton.Image = global::Hearthstone_Counter.Icons.RogueIcon;
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
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.rogueBG;
        }
        private void ShowandHideButtons(HSCounter hsc)
        {
            hsc.rogueWinButton.Show();
            hsc.rogueLoseButton.Show();
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
            hsc.warriorWinButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
        }
        private void ShowandHideResetButtons(HSCounter hsc)
        {
            hsc.rogueResetButton.Show();           
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.mageResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.hunterResetButton.Hide();           
            hsc.warriorResetButton.Hide();
        }

    }
}
