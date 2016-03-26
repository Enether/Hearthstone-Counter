namespace Hearthstone_Counter
{
    class LoseButtonClicked
    {
        public void AddLoss(HSCounter hsc)
        {
            if (DefaultCounter.IsSelected())
                AddDefaultLoss(hsc);
            else if (Druid.IsSelected())
                AddDruidLoss(hsc);
            else if (Hunter.IsSelected())
                AddHunterLoss(hsc);
            else if (Mage.IsSelected())
                AddMageLoss(hsc);
            else if (Paladin.IsSelected())
                AddPaladinLoss(hsc);
            else if (Priest.IsSelected())
                AddPriestLoss(hsc);
            else if (Rogue.IsSelected())
                AddRogueLoss(hsc);
            else if (Shaman.IsSelected())
                AddShamanLoss(hsc);
            else if (Warlock.IsSelected())
                AddWarlockLoss(hsc);
            else if (Warrior.IsSelected())
                AddWarriorLoss(hsc);
        }
        private void AddDefaultLoss(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.LoseButtonCLICKED(hsc);
        }
        private void AddDruidLoss(HSCounter hsc)
        {
            Druid druid = new Druid();
            druid.DruidLoseButtonCLICKED(hsc);
        }
        private void AddHunterLoss(HSCounter hsc)
        {
            Hunter hunter = new Hunter();
            hunter.HunterLoseButtonCLICKED(hsc);
        }
        private void AddMageLoss(HSCounter hsc)
        {
            Mage mage = new Mage();
            mage.MageLoseButtonCLICKED(hsc);
        }
        private void AddPaladinLoss(HSCounter hsc)
        {
            Paladin paladin = new Paladin();
            paladin.PaladinLoseButtonCLICKED(hsc);
        }
        private void AddPriestLoss(HSCounter hsc)
        {
            Priest priest = new Priest();
            priest.PriestLoseButtonCLICKED(hsc);
        }
        private void AddRogueLoss(HSCounter hsc)
        {
            Rogue rogue = new Rogue();
            rogue.RogueLoseButtonCLICKED(hsc);
        }
        private void AddShamanLoss(HSCounter hsc)
        {
            Shaman shaman = new Shaman();
            shaman.ShamanLoseButtonCLICKED(hsc);
        }
        private void AddWarlockLoss(HSCounter hsc)
        {
            Warlock warlock = new Warlock();
            warlock.WarlockLoseButtonCLICKED(hsc);
        }
        private void AddWarriorLoss(HSCounter hsc)
        {
            Warrior warrior = new Warrior();
            warrior.WarriorLoseButtonCLICKED(hsc);
        }
    }
}
