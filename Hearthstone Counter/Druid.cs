using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Druid
    {
        public bool selected;
        public int druidwins;
        public int druidlosses;
        string eMessage;
        public void WriteDruidWins(int T)
        {
            using (StreamWriter druidwinsWriter = new StreamWriter("DruidWins.txt", false))
            {
                druidwinsWriter.Write(T);
                druidwinsWriter.Flush();
            }
        }
        public void WriteDruidLosses(int T)
        {
            using (StreamWriter druidlossesWriter = new StreamWriter("DruidLosses.txt", false))
            {
                druidlossesWriter.Write(T);
                druidlossesWriter.Flush();
            }
        }
        public void ReadDruidLosses()
        {
            try
            {
                using (StreamReader readdruidLosses = new StreamReader("DruidLosses.txt"))
                {
                    druidlosses = int.Parse(readdruidLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WriteDruidLosses(0);
            }
        }
        public void ReadDruidWins()
        {
            try
            {
                using (StreamReader readdruidWins = new StreamReader("DruidWins.txt"))
                {
                    druidwins = int.Parse(readdruidWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WriteDruidWins(0);
            }
        }
        public void druidButtonCLICKED(HSCounter hsc)
        {
            druidButtonIsSelected(hsc);
            ShowandHideButtons(hsc);
            ReadDruidWins();
            hsc.label1.Text = "Won: " + druidwins;
            WriteDruidWins(druidwins);
            ReadDruidLosses();
            hsc.lostLabel.Text = "Lost: " + druidlosses;
            WriteDruidLosses(druidlosses);
        }
        public void druidLoseButtonCLICKED(HSCounter hsc)
        {
            druidlosses++;
            hsc.lostLabel.Text = "Lost: " + druidlosses;
            WriteDruidLosses(druidlosses);
            hsc.otherlosebutton();
        }
        public void druidWinButtonCLICKED(HSCounter hsc)
        {
            druidwins++;
            hsc.label1.Text = "Won: " + druidwins;
            WriteDruidWins(druidwins);
            hsc.otherwinbutton();
        }
        public void druidButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.druidbutton.Image = global::Hearthstone_Counter.Icons.DruidIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.druidbutton.Image = global::Hearthstone_Counter.Icons.DruidIcon;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectDefault();
            hsc.DeselectMage();
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
            hsc.druidWinButton.Show();
            hsc.druidLoseButton.Show();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
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
            hsc.warriorWinButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
        }
    }
}
