using System.Windows.Forms;

namespace Hearthstone_Counter
{
    class ScoreResetter
    {
        // move all the dialog boxes to reset the score here and reduce the reset buttons to one.

        public void ResetScore(HSCounter hsc)
        {
            if (DefaultCounter.IsSelected())
                ResetWholeScore(hsc);
            else if (Druid.IsSelected())
                ResetDruidScore(hsc);
            else if (Hunter.IsSelected())
                ResetHunterScore(hsc);
            else if (Mage.IsSelected())
                ResetMageScore(hsc);
            else if (Paladin.IsSelected())
                ResetPaladinScore(hsc);
            else if (Priest.IsSelected())
                ResetPriestScore(hsc);
            else if (Rogue.IsSelected())
                ResetRogueScore(hsc);
            else if (Shaman.IsSelected())
                ResetShamanScore(hsc);
            else if (Warlock.IsSelected())
                ResetWarlockScore(hsc);
            else if (Warrior.IsSelected())
                ResetWarriorScore(hsc);
        }
        private void ResetWholeScore(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();

            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to reset your score to 0?", "Reset Score", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dfc.ResetButtonCLICKED(hsc);
            }
        }
        private void ResetDruidScore(HSCounter hsc)
        {
            Druid druid = new Druid();

            DialogResult druidDialogResult = MessageBox.Show("Are you sure that you want to reset your druid score to 0?", "Reset Druid Score", MessageBoxButtons.YesNo);
            if (druidDialogResult == DialogResult.Yes)
            {
                druid.DruidResetButtonCLICKED(hsc);
            }
        }
        private void ResetHunterScore(HSCounter hsc)
        {
            Hunter hunter = new Hunter();

            DialogResult hunterDialogResult = MessageBox.Show("Are you sure that you want to reset your hunter score to 0?", "Reset Hunter Score", MessageBoxButtons.YesNo);
            if (hunterDialogResult == DialogResult.Yes)
            {
                hunter.HunterResetButtonCLICKED(hsc);
            }
        }
        private void ResetMageScore(HSCounter hsc)
        {
            Mage mage = new Mage();

            DialogResult mageDialogResult = MessageBox.Show("Are you sure that you want to reset your mage score to 0?", "Reset Mage Score", MessageBoxButtons.YesNo);
            if (mageDialogResult == DialogResult.Yes)
            {
                mage.MageResetButtonCLICKED(hsc);
            }
        }
        private void ResetPaladinScore(HSCounter hsc)
        {
            Paladin paladin = new Paladin();

            DialogResult paladinDialogResult = MessageBox.Show("Are you sure that you want to reset your paladin score to 0?", "Reset Paladin Score", MessageBoxButtons.YesNo);
            if (paladinDialogResult == DialogResult.Yes)
            {
                paladin.PaladinResetButtonCLICKED(hsc);
            }
        }
        private void ResetPriestScore(HSCounter hsc)
        {
            Priest priest = new Priest();

            DialogResult priestDialogResult = MessageBox.Show("Are you sure that you want to reset your priest score to 0?", "Reset Priest Score", MessageBoxButtons.YesNo);
            if (priestDialogResult == DialogResult.Yes)
            {
                priest.PriestResetButtonCLICKED(hsc);
            }
        }
        private void ResetRogueScore(HSCounter hsc)
        {
            Rogue rogue = new Rogue();

            DialogResult rogueDialogResult = MessageBox.Show("Are you sure that you want to reset your rogue score to 0?", "Reset Rogue Score", MessageBoxButtons.YesNo);
            if (rogueDialogResult == DialogResult.Yes)
            {
                rogue.RogueResetButtonCLICKED(hsc);
            }
        }
        private void ResetShamanScore(HSCounter hsc)
        {
            Shaman shaman = new Shaman();

            DialogResult shamanDialogResult = MessageBox.Show("Are you sure that you want to reset your shaman score to 0?", "Reset Shaman Score", MessageBoxButtons.YesNo);
            if (shamanDialogResult == DialogResult.Yes)
            {
                shaman.ShamanResetButtonCLICKED(hsc);
            }
        }
        private void ResetWarlockScore(HSCounter hsc)
        {
            Warlock warlock = new Warlock();

            DialogResult warlockDialogResult = MessageBox.Show("Are you sure that you want to reset your warlock score to 0?", "Reset Warlock Score", MessageBoxButtons.YesNo);
            if (warlockDialogResult == DialogResult.Yes)
            {
                warlock.WarlockResetButtonCLICKED(hsc);
            }
        }
        private void ResetWarriorScore(HSCounter hsc)
        {
            Warrior warrior = new Warrior();

            DialogResult warriorDialogResult = MessageBox.Show("Are you sure that you want to reset your warrior score to 0?", "Reset Warrior Score", MessageBoxButtons.YesNo);
            if (warriorDialogResult == DialogResult.Yes)
            {
                warrior.WarriorResetButtonCLICKED(hsc);
            }
        }
    }
}
