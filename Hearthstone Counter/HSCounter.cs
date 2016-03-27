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
        string[] classes =
        {
            "Default", "Warrior", "Rogue", "Paladin", "Hunter", "Warlock", "Priest", "Mage", "Shaman", "Druid"
        };

        public HSCounter()
        {         
            InitializeComponent();
            DFC.Initialization(this);
            
        }
        private void defaultbutton_Click(object sender, EventArgs e)
        {
            DFC.DefaultButton_Clicked(this);
        }
        // Default Counter
        private void loseButton_Click(object sender, EventArgs e)
        {
            LoseButtonClicked lbc = new LoseButtonClicked();

            lbc.AddLoss(this);
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
            Priest.PriestButton_Clicked(this);
        }

        public void DeselectPriest()
        {
            Priest.DeselectButton(this);
        }

        // Paladin Counter
        private void paladinbutton_Click(object sender, EventArgs e)
        {
            Paladin.PaladinButton_Clicked(this);
        }        
        public void DeselectPaladin()
        {
            Paladin.DeselectButton(this);
        }

        // Druid Counter

        private void druidbutton_Click(object sender, EventArgs e)
        {
            Druid.DruidButton_Clicked(this);
        }
        public void DeselectDruid()
        {
            Druid.DeselectButton(this);
        }
        // Shaman Counter
        private void shamanbutton_Click(object sender, EventArgs e)
        {
            Shaman.ShamanButton_Clicked(this);
        }



        public void DeselectShaman()
        {
            Shaman.DeselectButton(this);
        }
        // Warlock
        private void warlockbutton_Click(object sender, EventArgs e)
        {
            Warlock.WarlockButton_Clicked(this);
        }


        private void warlockLoseButton_Click(object sender, EventArgs e)
        {
            Warlock.LoseButton_Clicked(this);
        }
        public void DeselectWarlock()
        {
            Warlock.DeselectButton(this);
        }
        // Hunter Counter

        private void hunterbutton_Click(object sender, EventArgs e)
        {
            Hunter.HunterButton_Clicked(this);
        }


        public void DeselectHunter()
        {
            Hunter.DeselectButton(this);
        }
        // Mage Counter

        private void magebutton_Click(object sender, EventArgs e)
        {
            Mage.MageButton_Clicked(this);
        }


        public void DeselectMage()
        {
            Mage.DeselectButton(this);
        }
        // Rogue Counter
        private void roguebutton_Click(object sender, EventArgs e)
        {
            Rogue.RogueButton_Clicked(this);
        }

        public void DeselectRogue()
        {
            Rogue.DeselectButton(this);
        }
        // Warrior Counter

        private void warriorbutton_Click(object sender, EventArgs e)
        {
            Warrior.WarriorButton_Clicked(this);
        }

        public void DeselectWarrior()
        {
            Warrior.DeselectButton(this);
        }

        private void moreWinsButton_Click(object sender, EventArgs e)
        {
            AddWins addWins = new AddWins(this);
            addWins.Show();
            this.Enabled = false;

            addWins.FormClosed += new FormClosedEventHandler(AddWins_FormClosed);
        }
        private void moreLossesButton_Click(object sender, EventArgs e)
        {
            AddLosses addLosses = new AddLosses(this);
            addLosses.Show();
            this.Enabled = false;

            addLosses.FormClosed += new FormClosedEventHandler(AddLosses_FormClosed);
        }

        public void AddWins_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
        public void AddLosses_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
        private void SelectClass(string classString)
        {
            switch (classString)
            {
                case "Default":
                    DFC.DefaultButton_Clicked(this);
                    break;
                case "Druid":
                    Druid.DruidButton_Clicked(this);
                    break;
                case "Hunter":
                    Hunter.HunterButton_Clicked(this);
                    break;
                case "Mage":
                    Mage.MageButton_Clicked(this);
                    break;
                case "Paladin":
                    Paladin.PaladinButton_Clicked(this);
                    break;
                case "Priest":
                    Priest.PriestButton_Clicked(this);
                    break;
                case "Rogue":
                    Rogue.RogueButton_Clicked(this);
                    break;
                case "Shaman":
                    Shaman.ShamanButton_Clicked(this);
                    break;
                case "Warlock":
                    Warlock.WarlockButton_Clicked(this);
                    break;
                case "Warrior":
                    Warrior.WarriorButton_Clicked(this);
                    break;
            }
        }
        private string CurrentlySelected()
        {
            string currentlySelectedClass = "";

            if (DefaultCounter.IsSelected())
                currentlySelectedClass = "Default";
            else if (Druid.IsSelected())
                currentlySelectedClass = "Druid";
            else if (Hunter.IsSelected())
                currentlySelectedClass = "Hunter";
            else if (Mage.IsSelected())
                currentlySelectedClass = "Mage";
            else if (Paladin.IsSelected())
                currentlySelectedClass = "Paladin";
            else if (Priest.IsSelected())
                currentlySelectedClass = "Priest";
            else if (Rogue.IsSelected())
                currentlySelectedClass = "Rogue";
            else if (Shaman.IsSelected())
                currentlySelectedClass = "Shaman";
            else if (Warlock.IsSelected())
                currentlySelectedClass = "Warlock";
            else if (Warrior.IsSelected())
                currentlySelectedClass = "Warrior";

            return currentlySelectedClass;
        }

        private void HSCounter_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void HSCounter_KeyDown(object sender, KeyEventArgs e)
        {
            if ((char)e.KeyCode == (char)Keys.Right)
            {
                int index = Array.IndexOf(classes, CurrentlySelected());

                if (index != classes.Length - 1) // checks if it's not at the rightmost class
                    SelectClass(classes[index + 1]);  // selects the class to the right      
            }
            else if ((char)e.KeyCode == (char)Keys.Left)
            {
                int index = Array.IndexOf(classes, CurrentlySelected());

                if (index != 0) // checks if it's not at the leftmost class
                    SelectClass(classes[index - 1]); // selects the class to the left
            }
        }
    }
}
