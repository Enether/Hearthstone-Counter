using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Priest
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        public bool selected;
        public int priestwins;
        public int priestlosses;
        public string winPercentage;
        public double winP;
        string eMessage;
        public void WriteWins(int T, bool won)
        {
            ww.WriteWins(wr.ReadWinsArray(), T, won, "Priest");
        }
        public void WriteLosses(int T)
        {
            lw.WritePriestLosses(T);
        }
        public void ReadLosses()
        {
            lr.ReadPriestLosses(ref priestlosses);
        }
        public void ReadWins()
        {
            priestwins = wr.ReadWins("Priest");
        }
        public void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)priestwins / (priestwins + priestlosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void priestButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            priestButtonIsSelected(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);           
            ReadWins();
            hsc.label1.Text = "Won: " + priestwins;
            WriteWins(priestwins, false);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + priestlosses;
            WriteLosses(priestlosses);
            CalculateWinPercentage(hsc);
        }
        public void priestLoseButtonCLICKED(HSCounter hsc)
        {           
            priestlosses++;
            hsc.lostLabel.Text = "Lost: " + priestlosses;
            CalculateWinPercentage(hsc);
            WriteLosses(priestlosses);
            hsc.otherlosebutton();
        }
        public void priestWinButtonCLICKED(HSCounter hsc)
        {           
            priestwins++;
            hsc.label1.Text = "Won: " + priestwins;
            CalculateWinPercentage(hsc);
            WriteWins(priestwins, true);        
        }
        public void priestResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - priestwins);
            dfc.WriteLosses(dfc.losses - priestlosses);
            WriteWins(0, false);
            WriteLosses(0);
            priestButtonCLICKED(hsc);
        }
        public void priestButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.priestbutton.Image = global::Hearthstone_Counter.Icons.priestSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
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
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.priestBG;
        }
        private void ShowandHideButtons(HSCounter hsc)
        {
            hsc.priestLoseButton.Show();
            hsc.priestWinButton.Show();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.warlockWinButton.Hide();
            hsc.warlockLoseButton.Hide();
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
        private void ShowandHideResetButtons(HSCounter hsc)
        {
            hsc.priestResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();         
            hsc.mageResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.warriorResetButton.Hide();
        }
    }
}
