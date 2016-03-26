using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hearthstone_Counter
{
    public partial class AddLosses : Form
    {
        string pattern = @"^(\d{1}\d{0,1})$";
        public int losses = 0;
        HSCounter hsc;
        public AddLosses(HSCounter T)
        {
            hsc = T;
            InitializeComponent();
            this.addLossesBox.KeyPress += new KeyPressEventHandler(CheckEnter);
        }
        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                losses = ValidateLosses(addLossesBox.Text);

                //Choose which class to assign the wins to
                if (DefaultCounter.IsSelected())
                    AddDefaultLosses(losses);
                else if (Druid.IsSelected())
                    AddDruidLosses(losses);
                else if (Hunter.IsSelected())
                    AddHunterLosses(losses);
                else if (Mage.IsSelected())
                    AddMageLosses(losses);
                else if (Paladin.IsSelected())
                    AddPaladinLosses(losses);
                else if (Priest.IsSelected())
                    AddPriestLosses(losses);
                else if (Rogue.IsSelected())
                    AddRogueLosses(losses);
                else if (Shaman.IsSelected())
                    AddShamanLosses(losses);
                else if (Warlock.IsSelected())
                    AddWarlockLosses(losses);
                else if (Warrior.IsSelected())
                    AddWarriorLosses(losses);

                this.Close();
            }
        }
        private int ValidateLosses(string wins)
        {
            Regex validateLosses = new Regex(pattern);
            Match match = validateLosses.Match(wins);

            if (match.Success)
                return int.Parse(match.Value);

            return 0;
        }
        private void AddDefaultLosses(int losses)
        {
            DefaultCounter dfc = new DefaultCounter();

            dfc.AddLosses(losses, hsc);
        }
        private void AddDruidLosses(int losses)
        {
            Druid druid = new Druid();

            druid.AddLosses(losses, hsc);
        }
        private void AddHunterLosses(int losses)
        {
            Hunter hunter = new Hunter();

            hunter.AddLosses(losses, hsc);
        }
        private void AddMageLosses(int losses)
        {
            Mage mage = new Mage();

            mage.AddLosses(losses, hsc);
        }
        private void AddPaladinLosses(int losses)
        {
            Paladin paladin = new Paladin();

            paladin.AddLosses(losses, hsc);
        }
        private void AddPriestLosses(int losses)
        {
            Priest priest = new Priest();

            priest.AddLosses(losses, hsc);
        }
        private void AddRogueLosses(int Losses)
        {
            Rogue rogue = new Rogue();

            rogue.AddLosses(Losses, hsc);
        }
        private void AddShamanLosses(int losses)
        {
            Shaman shaman = new Shaman();

            shaman.AddLosses(losses, hsc);
        }
        private void AddWarlockLosses(int losses)
        {
            Warlock warlock = new Warlock();

            warlock.AddLosses(losses, hsc);
        }
        private void AddWarriorLosses(int losses)
        {
            Warrior warrior = new Warrior();

            warrior.AddLosses(losses, hsc);
        }
    }
}
