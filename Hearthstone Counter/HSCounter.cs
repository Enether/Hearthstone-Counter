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
            DFC.loseButtonCLICKED(this);
        }

        private void winButton_Click(object sender, EventArgs e)
        {
            DFC.winButtonCLICKED(this);
        }
        private void resetbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to reset your score to 0?", "Reset Score", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                DFC.resetButtonCLICKED(this);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
        public void DeselectDefault()
        {
            DFC.IsDeselected(this);
        }
        // Default Counter other button (used to sum up wins from other classes)
        public void otherlosebutton()
        {
            DFC.otherloseButtonCLICKED();
        }
       
     


        // Priest Counter
        private void priestbutton_Click(object sender, EventArgs e)
        {
            Priest.priestButtonCLICKED(this);
        }

        private void priestWinButton_Click(object sender, EventArgs e)
        {
            Priest.priestWinButtonCLICKED(this);
        }

        private void priestLoseButton_Click(object sender, EventArgs e)
        {
            Priest.priestLoseButtonCLICKED(this);
        }
        private void priestResetButton_Click(object sender, EventArgs e)
        {
            DialogResult priestdialogResult = MessageBox.Show("Are you sure that you want to reset your priest score to 0?", "Reset Priest Score", MessageBoxButtons.YesNo);
            if (priestdialogResult == DialogResult.Yes)
            {
                Priest.priestResetButtonCLICKED(this);
            }
            else if (priestdialogResult == DialogResult.No)
            {

            }
        }
        public void DeselectPriest()
        {
            Priest.IsDeselected(this);
        }

        // Paladin Counter
        private void paladinbutton_Click(object sender, EventArgs e)
        {
            Paladin.paladinButtonCLICKED(this);
        }
         

        private void paladinWinButton_Click(object sender, EventArgs e)
        {
            Paladin.paladinWinButtonCLICKED(this);
        }

        private void paladinLoseButton_Click(object sender, EventArgs e)
        {
            Paladin.paladinLoseButtonCLICKED(this);
        }
        private void paladinResetButton_Click(object sender, EventArgs e)
        {
            DialogResult paladindialogResult = MessageBox.Show("Are you sure that you want to reset your paladin score to 0?", "Reset Paladin Score", MessageBoxButtons.YesNo);
            if (paladindialogResult == DialogResult.Yes)
            {
                Paladin.paladinResetButtonCLICKED(this);
            }
            else if (paladindialogResult == DialogResult.No)
            {

            }
        }
        public void DeselectPaladin()
        {
            Paladin.IsDeselected(this);
        }

        // Druid Counter

        private void druidbutton_Click(object sender, EventArgs e)
        {
            Druid.druidButtonCLICKED(this);
        }

        private void druidWinButton_Click(object sender, EventArgs e)
        {
            Druid.druidWinButtonCLICKED(this);
        }

        private void druidLoseButton_Click(object sender, EventArgs e)
        {
            Druid.druidLoseButtonCLICKED(this);
        }
        public void DeselectDruid()
        {
            Druid.IsDeselected(this);
        }
        private void druidResetButton_Click(object sender, EventArgs e)
        {
            DialogResult druiddialogResult = MessageBox.Show("Are you sure that you want to reset your druid score to 0?", "Reset Druid Score", MessageBoxButtons.YesNo);
            if (druiddialogResult == DialogResult.Yes)
            {
                Druid.druidResetButtonCLICKED(this);
            }
            else if (druiddialogResult == DialogResult.No)
            {

            }       
        }
        // Shaman Counter
        private void shamanbutton_Click(object sender, EventArgs e)
        {
            Shaman.shamanButtonCLICKED(this);
        }

        private void shamanWinButton_Click(object sender, EventArgs e)
        {
            Shaman.shamanWinButtonCLICKED(this);
        }

        private void shamanLoseButton_Click(object sender, EventArgs e)
        {
            Shaman.shamanLoseButtonCLICKED(this);
        }
        private void shamanResetButton_Click(object sender, EventArgs e)
        {
            DialogResult shamandialogResult = MessageBox.Show("Are you sure that you want to reset your shaman score to 0?", "Reset Shaman Score", MessageBoxButtons.YesNo);
            if (shamandialogResult == DialogResult.Yes)
            {
                Shaman.shamanResetButtonCLICKED(this);
            }
            else if (shamandialogResult == DialogResult.No)
            {

            }
        }
        public void DeselectShaman()
        {
            Shaman.IsDeselected(this);
        }
        // Warlock
        private void warlockbutton_Click(object sender, EventArgs e)
        {
            Warlock.warlockButtonCLICKED(this);
        }

        private void warlockWinButton_Click(object sender, EventArgs e)
        {
            Warlock.warlockWinButtonCLICKED(this);
        }

        private void warlockLoseButton_Click(object sender, EventArgs e)
        {
            Warlock.warlockLoseButtonCLICKED(this);
        }
        private void warlockResetButton_Click(object sender, EventArgs e)
        {
            DialogResult warlockdialogResult = MessageBox.Show("Are you sure that you want to reset your warlock score to 0?", "Reset Warlock Score", MessageBoxButtons.YesNo);
            if (warlockdialogResult == DialogResult.Yes)
            {
                Warlock.warlockResetButtonCLICKED(this);
            }
            else if (warlockdialogResult == DialogResult.No)
            {

            }
        }
        public void DeselectWarlock()
        {
            Warlock.IsDeselected(this);
        }
        // Hunter Counter

        private void hunterbutton_Click(object sender, EventArgs e)
        {
            Hunter.hunterButtonCLICKED(this);
        }

        private void hunterWinButton_Click(object sender, EventArgs e)
        {
            Hunter.hunterWinButtonCLICKED(this);
        }

        private void hunterLoseButton_Click(object sender, EventArgs e)
        {
            Hunter.hunterLoseButtonCLICKED(this);
        }
        private void hunterResetButton_Click(object sender, EventArgs e)
        {
            DialogResult hunterdialogResult = MessageBox.Show("Are you sure that you want to reset your hunter score to 0?", "Reset Hunter Score", MessageBoxButtons.YesNo);
            if (hunterdialogResult == DialogResult.Yes)
            {
                Hunter.hunterResetButtonCLICKED(this);
            }
            else if (hunterdialogResult == DialogResult.No)
            {

            }
        }
        public void DeselectHunter()
        {
            Hunter.IsDeselected(this);
        }
        // Mage Counter

        private void magebutton_Click(object sender, EventArgs e)
        {
            Mage.mageButtonCLICKED(this);
        }

        private void mageWinButton_Click(object sender, EventArgs e)
        {
            Mage.mageWinButtonCLICKED(this);
        }

        private void mageLoseButton_Click(object sender, EventArgs e)
        {
            Mage.mageLoseButtonCLICKED(this);
        }
        private void mageResetButton_Click(object sender, EventArgs e)
        {
            DialogResult magedialogResult = MessageBox.Show("Are you sure that you want to reset your mage score to 0?", "Reset Mage Score", MessageBoxButtons.YesNo);
            if (magedialogResult == DialogResult.Yes)
            {
                Mage.mageResetButtonCLICKED(this);
            }
            else if (magedialogResult == DialogResult.No)
            {

            }
        }
        public void DeselectMage()
        {
            Mage.IsDeselected(this);
        }
        // Rogue Counter
        private void roguebutton_Click(object sender, EventArgs e)
        {
            Rogue.rogueButtonCLICKED(this);
        }

        private void rogueWinButton_Click(object sender, EventArgs e)
        {
            Rogue.rogueWinButtonCLICKED(this);
        }

        private void rogueLoseButton_Click(object sender, EventArgs e)
        {
            Rogue.rogueLoseButtonCLICKED(this);
        }
        private void rogueResetButton_Click(object sender, EventArgs e)
        {
            DialogResult roguedialogResult = MessageBox.Show("Are you sure that you want to reset your rogue score to 0?", "Reset Rogue Score", MessageBoxButtons.YesNo);
            if (roguedialogResult == DialogResult.Yes)
            {
                Rogue.rogueResetButtonCLICKED(this);
            }
            else if (roguedialogResult == DialogResult.No)
            {

            }
        }
        public void DeselectRogue()
        {
            Rogue.IsDeselected(this);
        }
        // Warrior Counter

        private void warriorbutton_Click(object sender, EventArgs e)
        {
            Warrior.warriorButtonCLICKED(this);
        }

        private void warriorWinButton_Click(object sender, EventArgs e)
        {
            Warrior.warriorWinButtonCLICKED(this);
        }

        private void warriorLoseButton_Click(object sender, EventArgs e)
        {
            Warrior.warriorLoseButtonCLICKED(this);
        }
        private void warriorResetButton_Click(object sender, EventArgs e)
        {
            DialogResult warriordialogResult = MessageBox.Show("Are you sure that you want to reset your warrior score to 0?", "Reset Warrior Score", MessageBoxButtons.YesNo);
            if (warriordialogResult == DialogResult.Yes)
            {
                Warrior.warriorResetButtonCLICKED(this);
            }
            else if (warriordialogResult == DialogResult.No)
            {

            }
        }
        public void DeselectWarrior()
        {
            Warrior.IsDeselected(this);
        }       
    }
}
