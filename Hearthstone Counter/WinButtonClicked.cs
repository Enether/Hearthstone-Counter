namespace Hearthstone_Counter
{
    class WinButtonClicked
    {
        public void AddWin(HSCounter hsc)
        {
            if (DefaultCounter.IsSelected())
                AddDefaultWin(hsc);
            else if (Druid.IsSelected())
                AddDruidWin(hsc);
            else if (Hunter.IsSelected())
                AddHunterWin(hsc);
            else if (Mage.IsSelected())
                AddMageWin(hsc);
            else if (Paladin.IsSelected())
                AddPaladinWin(hsc);
            else if (Priest.IsSelected())
                AddPriestWin(hsc);
            else if (Rogue.IsSelected())
                AddRogueWin(hsc);
            else if (Shaman.IsSelected())
                AddShamanWin(hsc);
            else if (Warlock.IsSelected())
                AddWarlockWin(hsc);
            else if (Warrior.IsSelected())
                AddWarriorWin(hsc);
        }
        private void AddDefaultWin(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.WinButtonCLICKED(hsc);
        }
        private void AddDruidWin(HSCounter hsc)
        {
            Druid druid = new Druid();
            druid.DruidWinButtonCLICKED(hsc);
        }
        private void AddHunterWin(HSCounter hsc)
        {
            Hunter hunter = new Hunter();
            hunter.HunterWinButtonCLICKED(hsc);
        }
        private void AddMageWin(HSCounter hsc)
        {
            Mage mage = new Mage();
            mage.MageWinButtonCLICKED(hsc);
        }
        private void AddPaladinWin(HSCounter hsc)
        {
            Paladin paladin = new Paladin();
            paladin.PaladinWinButtonCLICKED(hsc);
        }
        private void AddPriestWin(HSCounter hsc)
        {
            Priest priest = new Priest();
            priest.PriestWinButtonCLICKED(hsc);
        }
        private void AddRogueWin(HSCounter hsc)
        {
            Rogue rogue = new Rogue();
            rogue.RogueWinButtonCLICKED(hsc);
        }
        private void AddShamanWin(HSCounter hsc)
        {
            Shaman shaman = new Shaman();
            shaman.ShamanWinButtonCLICKED(hsc);
        }
        private void AddWarlockWin(HSCounter hsc)
        {
            Warlock warlock = new Warlock();
            warlock.WarlockWinButtonCLICKED(hsc);
        }
        private void AddWarriorWin(HSCounter hsc)
        {
            Warrior warrior = new Warrior();
            warrior.WarriorWinButtonCLICKED(hsc);
        }
    }
}
