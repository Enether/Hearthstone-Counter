using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Warrior
    {
        public bool selected;
        public int warriorwins;
        public int warriorlosses;
        string eMessage;
        public void WriteWarriorWins(int T)
        {
            using (StreamWriter warriorwinsWriter = new StreamWriter("WarriorWins.txt", false))
            {
                warriorwinsWriter.Write(T);
                warriorwinsWriter.Flush();
            }
        }
        public void WriteWarriorLosses(int T)
        {
            using (StreamWriter warriorlossesWriter = new StreamWriter("WarriorLosses.txt", false))
            {
                warriorlossesWriter.Write(T);
                warriorlossesWriter.Flush();
            }
        }
        public void ReadWarriorLosses()
        {
            try
            {
                using (StreamReader readwarriorLosses = new StreamReader("WarriorLosses.txt"))
                {
                    warriorlosses = int.Parse(readwarriorLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WriteWarriorLosses(0);
            }
        }
        public void ReadWarriorWins()
        {
            try
            {
                using (StreamReader readwarriorWins = new StreamReader("WarriorWins.txt"))
                {
                    warriorwins = int.Parse(readwarriorWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WriteWarriorWins(0);
            }
        }
        public void warriorButtonCLICKED(HSCounter hsc)
        {
            warriorButtonIsSelected(hsc);
            DeselectOthers(hsc);
            ShowandHideButtons(hsc);
            ReadWarriorWins();
            hsc.label1.Text = "Won: " + warriorwins;
            WriteWarriorWins(warriorwins);
            ReadWarriorLosses();
            hsc.lostLabel.Text = "Lost: " + warriorlosses;
            WriteWarriorLosses(warriorlosses);
        }
        public void warriorLoseButtonCLICKED(HSCounter hsc)
        {
            warriorlosses++;
            hsc.lostLabel.Text = "Lost: " + warriorlosses;
            WriteWarriorLosses(warriorlosses);
            hsc.otherlosebutton();
        }
        public void warriorWinButtonCLICKED(HSCounter hsc)
        {
            warriorwins++;
            hsc.label1.Text = "Won: " + warriorwins;
            WriteWarriorWins(warriorwins);
            hsc.otherwinbutton();
        }
        public void warriorButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.warriorbutton.Image = global::Hearthstone_Counter.Icons.WarriorIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.warriorbutton.Image = global::Hearthstone_Counter.Icons.WarriorIcon;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectMage();
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPriest();
            hsc.DeselectShaman();
            hsc.DeselectWarlock();
            hsc.DeselectPaladin();
            hsc.DeselectRogue();
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.warriorWinButton.Show();
            hsc.warriorLoseButton.Show();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.shamanWinButton.Hide();
            hsc.shamanLoseButton.Hide();
            hsc.warlockWinButton.Hide();
            hsc.warlockLoseButton.Hide();
            hsc.hunterWinButton.Hide();
            hsc.hunterLoseButton.Hide();
            hsc.mageWinButton.Hide();
            hsc.mageLoseButton.Hide();
            hsc.rogueWinButton.Hide();
            hsc.rogueLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
        }
    }
}
