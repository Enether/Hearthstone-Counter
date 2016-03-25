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
            DFC.WinButtonCLICKED(this);
        }
        private void resetbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to reset your score to 0?", "Reset Score", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                DFC.ResetButtonCLICKED(this);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
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

        private void priestWinButton_Click(object sender, EventArgs e)
        {
            Priest.PriestWinButtonCLICKED(this);
        }

        private void priestLoseButton_Click(object sender, EventArgs e)
        {
            Priest.PriestLoseButtonCLICKED(this);
        }
        private void priestResetButton_Click(object sender, EventArgs e)
        {
            DialogResult priestDialogResult = MessageBox.Show("Are you sure that you want to reset your priest score to 0?", "Reset Priest Score", MessageBoxButtons.YesNo);
            if (priestDialogResult == DialogResult.Yes)
            {
                Priest.PriestResetButtonCLICKED(this);
            }
            else if (priestDialogResult == DialogResult.No)
            {

            }
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
         

        private void paladinWinButton_Click(object sender, EventArgs e)
        {
            Paladin.PaladinWinButtonCLICKED(this);
        }

        private void paladinLoseButton_Click(object sender, EventArgs e)
        {
            Paladin.PaladinLoseButtonCLICKED(this);
        }
        private void paladinResetButton_Click(object sender, EventArgs e)
        {
            DialogResult paladinDialogResult = MessageBox.Show("Are you sure that you want to reset your paladin score to 0?", "Reset Paladin Score", MessageBoxButtons.YesNo);
            if (paladinDialogResult == DialogResult.Yes)
            {
                Paladin.PaladinResetButtonCLICKED(this);
            }
            else if (paladinDialogResult == DialogResult.No)
            {

            }
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

        private void druidWinButton_Click(object sender, EventArgs e)
        {
            Druid.DruidWinButtonCLICKED(this);
        }

        private void druidLoseButton_Click(object sender, EventArgs e)
        {
            Druid.DruidLoseButtonCLICKED(this);
        }
        public void DeselectDruid()
        {
            Druid.DeselectButton(this);
        }
        private void druidResetButton_Click(object sender, EventArgs e)
        {
            DialogResult druidDialogResult = MessageBox.Show("Are you sure that you want to reset your druid score to 0?", "Reset Druid Score", MessageBoxButtons.YesNo);
            if (druidDialogResult == DialogResult.Yes)
            {
                Druid.DruidResetButtonCLICKED(this);
            }
            else if (druidDialogResult == DialogResult.No)
            {

            }       
        }
        // Shaman Counter
        private void shamanbutton_Click(object sender, EventArgs e)
        {
            Shaman.ShamanButtonCLICKED(this);
        }

        private void shamanWinButton_Click(object sender, EventArgs e)
        {
            Shaman.ShamanWinButtonCLICKED(this);
        }

        private void shamanLoseButton_Click(object sender, EventArgs e)
        {
            Shaman.ShamanLoseButtonCLICKED(this);
        }
        private void shamanResetButton_Click(object sender, EventArgs e)
        {
            DialogResult shamanDialogResult = MessageBox.Show("Are you sure that you want to reset your shaman score to 0?", "Reset Shaman Score", MessageBoxButtons.YesNo);
            if (shamanDialogResult == DialogResult.Yes)
            {
                Shaman.ShamanResetButtonCLICKED(this);
            }
            else if (shamanDialogResult == DialogResult.No)
            {

            }
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

        private void warlockWinButton_Click(object sender, EventArgs e)
        {
            Warlock.WarlockWinButtonCLICKED(this);
        }

        private void warlockLoseButton_Click(object sender, EventArgs e)
        {
            Warlock.WarlockLoseButtonCLICKED(this);
        }
        private void warlockResetButton_Click(object sender, EventArgs e)
        {
            DialogResult warlockDialogResult = MessageBox.Show("Are you sure that you want to reset your warlock score to 0?", "Reset Warlock Score", MessageBoxButtons.YesNo);
            if (warlockDialogResult == DialogResult.Yes)
            {
                Warlock.WarlockResetButtonCLICKED(this);
            }
            else if (warlockDialogResult == DialogResult.No)
            {

            }
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

        private void hunterWinButton_Click(object sender, EventArgs e)
        {
            Hunter.HunterWinButtonCLICKED(this);
        }

        private void hunterLoseButton_Click(object sender, EventArgs e)
        {
            Hunter.HunterLoseButtonCLICKED(this);
        }
        private void hunterResetButton_Click(object sender, EventArgs e)
        {
            DialogResult hunterDialogResult = MessageBox.Show("Are you sure that you want to reset your hunter score to 0?", "Reset Hunter Score", MessageBoxButtons.YesNo);
            if (hunterDialogResult == DialogResult.Yes)
            {
                Hunter.HunterResetButtonCLICKED(this);
            }
            else if (hunterDialogResult == DialogResult.No)
            {

            }
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

        private void mageWinButton_Click(object sender, EventArgs e)
        {
            Mage.MageWinButtonCLICKED(this);
        }

        private void mageLoseButton_Click(object sender, EventArgs e)
        {
            Mage.MageLoseButtonCLICKED(this);
        }
        private void mageResetButton_Click(object sender, EventArgs e)
        {
            DialogResult mageDialogResult = MessageBox.Show("Are you sure that you want to reset your mage score to 0?", "Reset Mage Score", MessageBoxButtons.YesNo);
            if (mageDialogResult == DialogResult.Yes)
            {
                Mage.MageResetButtonCLICKED(this);
            }
            else if (mageDialogResult == DialogResult.No)
            {

            }
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

        private void rogueWinButton_Click(object sender, EventArgs e)
        {
            Rogue.RogueWinButtonCLICKED(this);
        }

        private void rogueLoseButton_Click(object sender, EventArgs e)
        {
            Rogue.RogueLoseButtonCLICKED(this);
        }
        private void rogueResetButton_Click(object sender, EventArgs e)
        {
            DialogResult rogueDialogResult = MessageBox.Show("Are you sure that you want to reset your rogue score to 0?", "Reset Rogue Score", MessageBoxButtons.YesNo);
            if (rogueDialogResult == DialogResult.Yes)
            {
                Rogue.RogueResetButtonCLICKED(this);
            }
            else if (rogueDialogResult == DialogResult.No)
            {

            }
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

        private void warriorWinButton_Click(object sender, EventArgs e)
        {
            Warrior.WarriorWinButtonCLICKED(this);
        }

        private void warriorLoseButton_Click(object sender, EventArgs e)
        {
            Warrior.WarriorLoseButtonCLICKED(this);
        }
        private void warriorResetButton_Click(object sender, EventArgs e)
        {
            DialogResult warriorDialogResult = MessageBox.Show("Are you sure that you want to reset your warrior score to 0?", "Reset Warrior Score", MessageBoxButtons.YesNo);
            if (warriorDialogResult == DialogResult.Yes)
            {
                Warrior.WarriorResetButtonCLICKED(this);
            }
            else if (warriorDialogResult == DialogResult.No)
            {

            }
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
            if (DFC.IsSelected())
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
            if (DFC.IsSelected())
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
