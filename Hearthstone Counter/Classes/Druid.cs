using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Druid
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        public bool selected;
        public int druidwins;
        public int druidlosses;
        public double winP;
        public string winPercentage;

        public void WriteWins(int T, bool won)
        {
            ww.WriteWins(wr.ReadWinsArray(), T, won, "Druid");
        }
        public void WriteLosses(int T, bool lost)
        {
            lw.WriteLosses(lr.ReadLossesDictionary(), T, lost, "Druid");
        }
        public void ReadLosses()
        {
            druidlosses = lr.ReadLosses("Druid");
        }
        public void ReadWins()
        {
            druidwins = wr.ReadWins("Druid");
        }
        public void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)druidwins / (druidwins + druidlosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void druidButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            druidButtonIsSelected(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + druidwins;
            WriteWins(druidwins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + druidlosses;
            WriteLosses(druidlosses, false);
            CalculateWinPercentage(hsc);
        }
        public void druidLoseButtonCLICKED(HSCounter hsc)
        {
            druidlosses++;
            hsc.lostLabel.Text = "Lost: " + druidlosses;
            CalculateWinPercentage(hsc);
            WriteLosses(druidlosses, true);
            hsc.otherlosebutton();
        }
        public void druidWinButtonCLICKED(HSCounter hsc)
        {
            druidwins++;
            hsc.label1.Text = "Won: " + druidwins;
            CalculateWinPercentage(hsc);
            WriteWins(druidwins, true);
        }
        public void druidResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - druidwins);
            dfc.WriteLosses(dfc.losses - druidlosses);
            WriteWins(0, false);
            WriteLosses(0, false);
            druidButtonCLICKED(hsc);
        }
        public void druidButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.druidbutton.Image = global::Hearthstone_Counter.Icons.DruidIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.druidbutton.Image = global::Hearthstone_Counter.Icons.DruidIcon;
        }
        private void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectMage();
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
            hsc.BackgroundImage = Background.druidBG;
        }
        private void ShowandHideButtons(HSCounter hsc)
        {
            hsc.druidWinButton.Show();
            hsc.druidLoseButton.Show();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
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
            hsc.warriorWinButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
        }
        private void ShowandHideResetButtons(HSCounter hsc)
        {         
            hsc.druidResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.priestResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.warriorResetButton.Hide();
            hsc.mageResetButton.Hide();
        }
    }
}
