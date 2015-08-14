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
        public void DeselectDefault()
        {
            DFC.IsDeselected(this);
        }
        // Default Counter other button (used to sum up wins from other classes)
        public void otherwinbutton()
        {
            DFC.otherwinButtonCLICKED();
        }
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
        public void DeselectRogue()
        {
            Rogue.IsDeselected(this);
        }

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
        public void DeselectWarrior()
        {
            Warrior.IsDeselected(this);
        }
    }
}
