using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace Hearthstone_Counter
{
    public partial class HSCounter : Form
    {
        Warrior Warrior = new Warrior();
        Rogue Rogue = new Rogue();
        Mage Mage = new Mage();
        Hunter Hunter = new Hunter();
        Warlock Warlock = new Warlock();
        Shaman Shaman = new Shaman();
        Druid Druid = new Druid();
        Paladin Paladin = new Paladin();
        Priest Priest = new Priest();
        DefaultCounter DFC = new DefaultCounter();
        static int saveWins = 0;
        static int saveLosses = 0;
        public HSCounter()
        {         
            InitializeComponent();
            DFC.Initialization(this);
        }
        private void defaultbutton_Click(object sender, EventArgs e)
        {
            DFC.DefaultButtonCLICKED(this);
        }
        // Default Counter
        private void loseButton_Click(object sender, EventArgs e)
        {
            DFC.LoseButtonCLICKED(this);
        }

        private void winButton_Click(object sender, EventArgs e)
        {
            WinButtonClicked wbc = new WinButtonClicked();

            wbc.AddWin(this);
        }
        private void resetbutton_Click(object sender, EventArgs e)
        {
            ScoreResetter sr = new ScoreResetter();
            sr.ResetScore(this);
        }
        public void DeselectDefault()
        {
            DFC.DeselectButton(this);
        }
          
        // Priest Counter
        private void priestbutton_Click(object sender, EventArgs e)
        {
            Priest.PriestButtonCLICKED(this);
        }

        private void priestLoseButton_Click(object sender, EventArgs e)
        {
            Priest.PriestLoseButtonCLICKED(this);
        }
        public void DeselectPriest()
        {
            Priest.DeselectButton(this);
        }

        // Paladin Counter
        private void paladinbutton_Click(object sender, EventArgs e)
        {
            Paladin.PaladinButtonCLICKED(this);
        }        

        private void paladinLoseButton_Click(object sender, EventArgs e)
        {
            Paladin.PaladinLoseButtonCLICKED(this);
        }
        public void DeselectPaladin()
        {
            Paladin.DeselectButton(this);
        }

        // Druid Counter

        private void druidbutton_Click(object sender, EventArgs e)
        {
            Druid.DruidButtonCLICKED(this);
        }


        private void druidLoseButton_Click(object sender, EventArgs e)
        {
            Druid.DruidLoseButtonCLICKED(this);
        }
        public void DeselectDruid()
        {
            Druid.DeselectButton(this);
        }
        // Shaman Counter
        private void shamanbutton_Click(object sender, EventArgs e)
        {
            Shaman.ShamanButtonCLICKED(this);
        }


        private void shamanLoseButton_Click(object sender, EventArgs e)
        {
            Shaman.ShamanLoseButtonCLICKED(this);
        }
        public void DeselectShaman()
        {
            Shaman.DeselectButton(this);
        }
        // Warlock
        private void warlockbutton_Click(object sender, EventArgs e)
        {
            Warlock.WarlockButtonCLICKED(this);
        }


        private void warlockLoseButton_Click(object sender, EventArgs e)
        {
            Warlock.WarlockLoseButtonCLICKED(this);
        }
        public void DeselectWarlock()
        {
            Warlock.DeselectButton(this);
        }
        // Hunter Counter

        private void hunterbutton_Click(object sender, EventArgs e)
        {
            Hunter.HunterButtonCLICKED(this);
        }


        private void hunterLoseButton_Click(object sender, EventArgs e)
        {
            Hunter.HunterLoseButtonCLICKED(this);
        }
        public void DeselectHunter()
        {
            Hunter.DeselectButton(this);
        }
        // Mage Counter

        private void magebutton_Click(object sender, EventArgs e)
        {
            Mage.MageButtonCLICKED(this);
        }


        private void mageLoseButton_Click(object sender, EventArgs e)
        {
            Mage.MageLoseButtonCLICKED(this);
        }
        public void DeselectMage()
        {
            Mage.DeselectButton(this);
        }
        // Rogue Counter
        private void roguebutton_Click(object sender, EventArgs e)
        {
            Rogue.RogueButtonCLICKED(this);
        }

        private void rogueLoseButton_Click(object sender, EventArgs e)
        {
            Rogue.RogueLoseButtonCLICKED(this);
        }
        public void DeselectRogue()
        {
            Rogue.DeselectButton(this);
        }
        // Warrior Counter

        private void warriorbutton_Click(object sender, EventArgs e)
        {
            Warrior.WarriorButtonCLICKED(this);
        }

        private void warriorLoseButton_Click(object sender, EventArgs e)
        {
            Warrior.WarriorLoseButtonCLICKED(this);
        }
        public void DeselectWarrior()
        {
            Warrior.DeselectButton(this);
        }

        private void moreWinsButton_Click(object sender, EventArgs e)
        {
            AddWins addWins = new AddWins();
            addWins.Show();
            this.Enabled = false;

            addWins.FormClosed += new FormClosedEventHandler(AddWins_FormClosed);
        }
        private void moreLossesButton_Click(object sender, EventArgs e)
        {
            AddLosses addLosses = new AddLosses();
            addLosses.Show();
            this.Enabled = false;

            addLosses.FormClosed += new FormClosedEventHandler(AddLosses_FormClosed);
        }
        public static void SaveLosses(int i)
        {
            saveLosses = i;
        }
        public static void SaveWins(int i)
        {
            saveWins = i;
        }
        public void AddWins_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;

            // Choose which class to assign the wins to
            if (DefaultCounter.IsSelected())
                DFC.AddWins(saveWins, this);
            else if (Druid.IsSelected())
                Druid.AddWins(saveWins, this);
            else if (Hunter.IsSelected())
                Hunter.AddWins(saveWins, this);
            else if (Mage.IsSelected())
                Mage.AddWins(saveWins, this);
            else if (Paladin.IsSelected())
                Paladin.AddWins(saveWins, this);
            else if (Priest.IsSelected())
                Priest.AddWins(saveWins, this);
            else if (Rogue.IsSelected())
                Rogue.AddWins(saveWins, this);
            else if (Shaman.IsSelected())
                Shaman.AddWins(saveWins, this);
            else if (Warlock.IsSelected())
                Warlock.AddWins(saveWins, this);
            else if (Warrior.IsSelected())
                Warrior.AddWins(saveWins, this);


        }
        public void AddLosses_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;

            // Choose which class to assign the wins to
            if (DefaultCounter.IsSelected())
                DFC.AddLosses(saveLosses, this);
            else if (Druid.IsSelected())
                Druid.AddLosses(saveLosses, this);
            else if (Hunter.IsSelected())
                Hunter.AddLosses(saveLosses, this);
            else if (Mage.IsSelected())
                Mage.AddLosses(saveLosses, this);
            else if (Paladin.IsSelected())
                Paladin.AddLosses(saveLosses, this);
            else if (Priest.IsSelected())
                Priest.AddLosses(saveLosses, this);
            else if (Rogue.IsSelected())
                Rogue.AddLosses(saveLosses, this);
            else if (Shaman.IsSelected())
                Shaman.AddLosses(saveLosses, this);
            else if (Warlock.IsSelected())
                Warlock.AddLosses(saveLosses, this);
            else if (Warrior.IsSelected())
                Warrior.AddLosses(saveLosses, this);
        }
    }
}
