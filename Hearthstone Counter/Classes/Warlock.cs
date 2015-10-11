using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Warlock
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        public bool selected;
        public int warlockwins;
        public int warlocklosses;
        public string winPercentage;
        public double winP;
        string eMessage;
        public void WriteWins(int T)
        {
            ww.WriteWarlockWins(T);
        }
        public void WriteLosses(int T)
        {
            lw.WriteWarlockLosses(T);
        }
        public void ReadLosses()
        {
            lr.ReadWarlockLosses(ref warlocklosses);
        }
        public void ReadWins()
        {
            wr.ReadWarlockWins(ref warlockwins);
        }
        public void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)warlockwins / (warlockwins + warlocklosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void warlockButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            warlockButtonIsSelected(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + warlockwins;
            WriteWins(warlockwins);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + warlocklosses;
            WriteLosses(warlocklosses);
            CalculateWinPercentage(hsc);
        }
        public void warlockLoseButtonCLICKED(HSCounter hsc)
        {
            warlocklosses++;
            hsc.lostLabel.Text = "Lost: " + warlocklosses;
            CalculateWinPercentage(hsc);
            WriteLosses(warlocklosses);
            hsc.otherlosebutton();
        }
        public void warlockWinButtonCLICKED(HSCounter hsc)
        {
            warlockwins++;
            hsc.label1.Text = "Won: " + warlockwins;
            CalculateWinPercentage(hsc);
            WriteWins(warlockwins);
            hsc.otherwinbutton();
        }
        public void warlockResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - warlockwins);
            dfc.WriteLosses(dfc.losses - warlocklosses);
            WriteWins(0);
            WriteLosses(0);
            warlockButtonCLICKED(hsc);
        }
        public void warlockButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.warlockbutton.Image = global::Hearthstone_Counter.Icons.WarlockIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.warlockbutton.Image = global::Hearthstone_Counter.Icons.WarlockIcon;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPaladin();
            hsc.DeselectPriest();
            hsc.DeselectShaman();
            hsc.DeselectMage();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.warlockBG;
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.warlockWinButton.Show();
            hsc.warlockLoseButton.Show();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.shamanWinButton.Hide();
            hsc.shamanLoseButton.Hide();
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
        public void ShowandHideResetButtons(HSCounter hsc)
        {
            hsc.warlockResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.mageResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.warriorResetButton.Hide();
        }
    }
}
