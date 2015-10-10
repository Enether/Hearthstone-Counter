using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Hunter
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        public bool selected;
        public int hunterwins;
        public int hunterlosses;
        string eMessage;
        public void WriteWins(int T)
        {
            ww.WriteHunterWins(T);
        }
        public void WriteLosses(int T)
        {
            lw.WriteHunterLosses(T);
        }
        public void ReadLosses()
        {
            lr.ReadHunterLosses(ref hunterlosses);
        }
        public void ReadWins()
        {
            wr.ReadHunterWins(ref hunterwins);
        }
        public void hunterButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            hunterButtonIsSelected(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + hunterwins;
            WriteWins(hunterwins);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + hunterlosses;
            WriteLosses(hunterlosses);
        }
        public void hunterLoseButtonCLICKED(HSCounter hsc)
        {
            hunterlosses++;
            hsc.lostLabel.Text = "Lost: " + hunterlosses;
            WriteLosses(hunterlosses);
            hsc.otherlosebutton();
        }
        public void hunterWinButtonCLICKED(HSCounter hsc)
        {
            hunterwins++;
            hsc.label1.Text = "Won: " + hunterwins;
            WriteWins(hunterwins);
            hsc.otherwinbutton();
        }
        public void hunterResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - hunterwins);
            dfc.WriteLosses(dfc.losses - hunterlosses);
            WriteWins(0);
            WriteLosses(0);
            hunterButtonCLICKED(hsc);
        }
        public void hunterButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.hunterbutton.Image = global::Hearthstone_Counter.Icons.hunterSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.hunterbutton.Image = global::Hearthstone_Counter.Icons.hunter_4;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectMage();
            hsc.DeselectPaladin();
            hsc.DeselectPriest();
            hsc.DeselectShaman();
            hsc.DeselectWarlock();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.hunterBG;
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.hunterWinButton.Show();
            hsc.hunterLoseButton.Show();
            hsc.warlockWinButton.Hide();
            hsc.warlockLoseButton.Hide();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.shamanWinButton.Hide();
            hsc.shamanLoseButton.Hide();
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
            hsc.hunterResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.warriorResetButton.Hide();
            hsc.mageResetButton.Hide();
        }
    }
}

