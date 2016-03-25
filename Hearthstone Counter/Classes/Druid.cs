using System;

namespace Hearthstone_Counter
{
    class Druid
    {
        Writer writer = new Writer();
        Reader reader = new Reader();

        private static bool selected;
        private int druidWins;
        private int druidLosses;
        private double winP;
        private string winPercentage;

        public void WriteWins(int T, int won)
        {
            writer.WriteWins(reader.ReadResultsDictionary(), T, won, "Druid");
        }
        public void WriteLosses(int T, int lost)
        {
            writer.WriteLosses(reader.ReadResultsDictionary(), T, lost, "Druid");
        }
        private void ReadLosses()
        {
            druidLosses = reader.ReadLosses("Druid");
        }
        private void ReadWins()
        {
            druidWins = reader.ReadWins("Druid");
        }
        public void CalculateWinPercentage(HSCounter hsc)
        {
            winP = (double)druidWins / (druidWins + druidLosses);
            if (Double.IsNaN(winP)) winP = 0;
            winPercentage = string.Format("{0:0.0%}", winP);
            hsc.defwinPlabel.Text = "Win %: " + winPercentage;
        }
        public void DruidButtonCLICKED(HSCounter hsc)
        {
            ChangeBG(hsc);
            SelectButton(hsc);
            ShowAndHideButtons(hsc);
            ShowAndHideButtons(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + druidWins;
            WriteWins(druidWins, 0);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + druidLosses;
            WriteLosses(druidLosses, 0);
            CalculateWinPercentage(hsc);
        }
        public void DruidLoseButtonCLICKED(HSCounter hsc)
        {
            druidLosses++;
            hsc.lostLabel.Text = "Lost: " + druidLosses;
            CalculateWinPercentage(hsc);
            WriteLosses(druidLosses, 1);
        }
        public void AddLosses(int addedLosses, HSCounter hsc)
        {
            druidLosses += addedLosses;
            WriteLosses(druidLosses, addedLosses);
            hsc.lostLabel.Text = "Lost: " + druidLosses;
            CalculateWinPercentage(hsc);
        }
        public void DruidWinButtonCLICKED(HSCounter hsc)
        {
            druidWins++;
            hsc.label1.Text = "Won: " + druidWins;
            CalculateWinPercentage(hsc);
            WriteWins(druidWins, 1);
        }
        public void AddWins(int addedWins, HSCounter hsc)
        {
            druidWins += addedWins;
            WriteWins(druidWins, addedWins);
            hsc.label1.Text = "Won: " + druidWins;
            CalculateWinPercentage(hsc);
        }
        public void DruidResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            ReadWins();
            ReadLosses();
            dfc.WriteWins(dfc.wins - druidWins);
            dfc.WriteLosses(dfc.losses - druidLosses);
            WriteWins(0, 0);
            WriteLosses(0, 0);
            DruidButtonCLICKED(hsc); // useless
        }
        private void SelectButton(HSCounter hsc)
        {
            selected = true;
            hsc.druidbutton.Image = global::Hearthstone_Counter.Icons.DruidIconSelected;
            DeselectOthers(hsc);
        }

        public void DeselectButton(HSCounter hsc)
        {
            selected = false;
            hsc.druidbutton.Image = global::Hearthstone_Counter.Icons.DruidIcon;
        }
        public static bool IsSelected()
        {
            return selected;
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
        private void ShowAndHideButtons(HSCounter hsc)
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
    }
}
