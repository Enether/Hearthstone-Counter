using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hearthstone_Counter
{
    public partial class AddWins : Form
    {
        string pattern = @"^(\d{1}\d{0,1})$";
        public int wins = 0;
        HSCounter hsc;
        public AddWins(HSCounter T)
        {
            hsc = T;
            InitializeComponent();
            this.addWinsBox.KeyPress += new KeyPressEventHandler(CheckEnter);
        }
        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                wins = ValidateWins(addWinsBox.Text);

                //Choose which class to assign the wins to
                if (DefaultCounter.IsSelected())
                    AddDefaultWins(wins);
                else if (Druid.IsSelected())
                    AddDruidWins(wins);
                else if (Hunter.IsSelected())
                    AddHunterWins(wins);
                else if (Mage.IsSelected())
                    AddMageWins(wins);
                else if (Paladin.IsSelected())
                    AddPaladinWins(wins);
                else if (Priest.IsSelected())
                    AddPriestWins(wins);
                else if (Rogue.IsSelected())
                    AddRogueWins(wins);
                else if (Shaman.IsSelected())
                    AddShamanWins(wins);
                else if (Warlock.IsSelected())
                    AddWarlockWins(wins);
                else if (Warrior.IsSelected())
                    AddWarriorWins(wins);

                this.Close();
            }
        }
        private int ValidateWins(string wins)
        {
            Regex validateWins = new Regex(pattern);
            Match match = validateWins.Match(wins);

            if (match.Success)
                return int.Parse(match.Value);

            return 0;   
        }
        private void AddDefaultWins(int wins)
        {
            DefaultCounter dfc = new DefaultCounter();

            dfc.AddWins(wins, hsc);
        }
        private void AddDruidWins(int wins)
        {
            Druid druid = new Druid();

            druid.AddWins(wins, hsc);
        }
        private void AddHunterWins(int wins)
        {
            Hunter hunter = new Hunter();

            hunter.AddWins(wins, hsc);
        }
        private void AddMageWins(int wins)
        {
            Mage mage = new Mage();

            mage.AddWins(wins, hsc);
        }
        private void AddPaladinWins(int wins)
        {
            Paladin paladin = new Paladin();

            paladin.AddWins(wins, hsc);
        }
        private void AddPriestWins(int wins)
        {
            Priest priest = new Priest();

            priest.AddWins(wins, hsc);
        }
        private void AddRogueWins(int wins)
        {
            Rogue rogue = new Rogue();

            rogue.AddWins(wins, hsc);
        }
        private void AddShamanWins(int wins)
        {
            Shaman shaman = new Shaman();

            shaman.AddWins(wins, hsc);
        }
        private void AddWarlockWins(int wins)
        {
            Warlock warlock = new Warlock();

            warlock.AddWins(wins, hsc);
        }
        private void AddWarriorWins(int wins)
        {
            Warrior warrior = new Warrior();

            warrior.AddWins(wins, hsc);
        }
    }
}
