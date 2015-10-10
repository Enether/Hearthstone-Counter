using System;
using System.IO;

namespace Hearthstone_Counter
{
    class Shaman
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        public bool selected;
        public int shamanwins;
        public int shamanlosses;
        string eMessage;
        public void WriteWins(int T)
        {
            ww.WriteShamanWins(T);
        }
        public void WriteLosses(int T)
        {
            lw.WriteShamanLosses(T);
        }
        public void ReadLosses()
        {
            lr.ReadShamanLosses(ref shamanlosses);
        }
        public void ReadWins()
        {
           wr.ReadShamanWins(ref shamanwins);
        }
        public void shamanButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            shamanButtonIsSelected(hsc);
            this.ShowandHideButtons(hsc);
            this.ShowandHideResetButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + shamanwins;
            WriteWins(shamanwins);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + shamanlosses;
            WriteLosses(shamanlosses);
        }
        public void shamanLoseButtonCLICKED(HSCounter hsc)
        {
            shamanlosses++;
            hsc.lostLabel.Text = "Lost: " + shamanlosses;
            WriteLosses(shamanlosses);
            hsc.otherlosebutton();
        }
        public void shamanWinButtonCLICKED(HSCounter hsc)
        {
            shamanwins++;
            hsc.label1.Text = "Won: " + shamanwins;
            WriteWins(shamanwins);
            hsc.otherwinbutton();
        }
        public void shamanResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - shamanwins);
            dfc.WriteLosses(dfc.losses - shamanlosses);
            WriteWins(0);
            WriteLosses(0);
            shamanButtonCLICKED(hsc);
        }
        public void shamanButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.shamanbutton.Image = global::Hearthstone_Counter.Icons.ShamanIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.shamanbutton.Image = global::Hearthstone_Counter.Icons.ShamanIcon;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPaladin();
            hsc.DeselectPriest();
            hsc.DeselectMage();
            hsc.DeselectWarlock();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.shamanBG;
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.shamanWinButton.Show();
            hsc.shamanLoseButton.Show();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
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
        public void ShowandHideResetButtons(HSCounter hsc)
        {
            hsc.shamanResetButton.Show();
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.mageResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.rogueResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.hunterResetButton.Hide();
            hsc.warriorResetButton.Hide();
        }
    }
}
