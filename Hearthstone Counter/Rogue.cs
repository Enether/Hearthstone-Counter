using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Rogue
    {
        public bool selected;
        public int roguewins;
        public int roguelosses;
        string eMessage;
        public void WriteRogueWins(int T)
        {
            using (StreamWriter roguewinsWriter = new StreamWriter("RogueWins.txt", false))
            {
                roguewinsWriter.Write(T);
                roguewinsWriter.Flush();
            }
        }
        public void WriteRogueLosses(int T)
        {
            using (StreamWriter roguelossesWriter = new StreamWriter("RogueLosses.txt", false))
            {
                roguelossesWriter.Write(T);
                roguelossesWriter.Flush();
            }
        }
        public void ReadRogueLosses()
        {
            try
            {
                using (StreamReader readrogueLosses = new StreamReader("RogueLosses.txt"))
                {
                    roguelosses = int.Parse(readrogueLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WriteRogueLosses(0);
            }
        }
        public void ReadRogueWins()
        {
            try
            {
                using (StreamReader readrogueWins = new StreamReader("RogueWins.txt"))
                {
                    roguewins = int.Parse(readrogueWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WriteRogueWins(0);
            }
        }
        public void rogueButtonCLICKED(HSCounter hsc)
        {
            rogueButtonIsSelected(hsc);
            DeselectOthers(hsc);
            ShowandHideButtons(hsc);
            ReadRogueWins();
            hsc.label1.Text = "Won: " + roguewins;
            WriteRogueWins(roguewins);
            ReadRogueLosses();
            hsc.lostLabel.Text = "Lost: " + roguelosses;
            WriteRogueLosses(roguelosses);
        }
        public void rogueLoseButtonCLICKED(HSCounter hsc)
        {
            roguelosses++;
            hsc.lostLabel.Text = "Lost: " + roguelosses;
            WriteRogueLosses(roguelosses);
            hsc.otherlosebutton();
        }
        public void rogueWinButtonCLICKED(HSCounter hsc)
        {
            roguewins++;
            hsc.label1.Text = "Won: " + roguewins;
            WriteRogueWins(roguewins);
            hsc.otherwinbutton();
        }
        public void rogueButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.roguebutton.Image = global::Hearthstone_Counter.Icons.RogueIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.roguebutton.Image = global::Hearthstone_Counter.Icons.RogueIcon;
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
            hsc.DeselectWarrior();
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.rogueWinButton.Show();
            hsc.rogueLoseButton.Show();
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
            hsc.warriorWinButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
        }
    }
}
