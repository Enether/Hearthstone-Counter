﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Mage
    {
        public bool selected;
        public int magewins;
        public int magelosses;
        string eMessage;
        public void WriteMageWins(int T)
        {
            using (StreamWriter magewinsWriter = new StreamWriter("MageWins.txt", false))
            {
                magewinsWriter.Write(T);
                magewinsWriter.Flush();
            }
        }
        public void WriteMageLosses(int T)
        {
            using (StreamWriter magelossesWriter = new StreamWriter("MageLosses.txt", false))
            {
                magelossesWriter.Write(T);
                magelossesWriter.Flush();
            }
        }
        public void ReadMageLosses()
        {
            try
            {
                using (StreamReader readmageLosses = new StreamReader("MageLosses.txt"))
                {
                    magelosses = int.Parse(readmageLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WriteMageLosses(0);
            }
        }
        public void ReadMageWins()
        {
            try
            {
                using (StreamReader readmageWins = new StreamReader("MageWins.txt"))
                {
                    magewins = int.Parse(readmageWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WriteMageWins(0);
            }
        }
        public void mageButtonCLICKED(HSCounter hsc)
        {
            mageButtonIsSelected(hsc);
            this.ShowandHideButtons(hsc);
            ReadMageWins();
            hsc.label1.Text = "Won: " + magewins;
            WriteMageWins(magewins);
            ReadMageLosses();
            hsc.lostLabel.Text = "Lost: " + magelosses;
            WriteMageLosses(magelosses);
        }
        public void mageLoseButtonCLICKED(HSCounter hsc)
        {
            magelosses++;
            hsc.lostLabel.Text = "Lost: " + magelosses;
            WriteMageLosses(magelosses);
            hsc.otherlosebutton();
        }
        public void mageWinButtonCLICKED(HSCounter hsc)
        {
            magewins++;
            hsc.label1.Text = "Won: " + magewins;
            WriteMageWins(magewins);
            hsc.otherwinbutton();
        }
        public void mageButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.magebutton.Image = global::Hearthstone_Counter.Icons.MageIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.magebutton.Image = global::Hearthstone_Counter.Icons.MageIcon;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPaladin();
            hsc.DeselectPriest();
            hsc.DeselectShaman();
            hsc.DeselectWarlock();
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }

        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.mageWinButton.Show();
            hsc.mageLoseButton.Show();
            hsc.hunterWinButton.Hide();
            hsc.hunterLoseButton.Hide();
            hsc.warlockWinButton.Hide();
            hsc.warlockLoseButton.Hide();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.shamanWinButton.Hide();
            hsc.shamanLoseButton.Hide();
            hsc.rogueWinButton.Hide();
            hsc.rogueLoseButton.Hide();
            hsc.warriorWinButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
        }
    }
}