using System;
using System.IO;

namespace Hearthstone_Counter
{
    class WinReader
    {
        WinWriter ww = new WinWriter();
        string eMessage;
        public int ReadDefaultWins(ref int wins)
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Textfiles/Wins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                ww.WriteDefaultWins(0);
            }
            return wins;
        }
        // DRUID
        public int ReadDruidWins(ref int wins)
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Textfiles/DruidWins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                ww.WriteDruidWins(0);
            }
            return wins;
        }
        // HUNTER
        public int ReadHunterWins(ref int wins)
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Textfiles/HunterWins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                ww.WriteHunterWins(0);
            }
            return wins;
        }
        // MAGE
        public int ReadMageWins(ref int wins)
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Textfiles/MageWins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                ww.WriteMageWins(0);
            }
            return wins;
        }
        // PALADIN
        public int ReadPaladinWins(ref int wins)
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Textfiles/PaladinWins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                ww.WritePaladinWins(0);
            }
            return wins;
        }

        // PRIEST
        public int ReadPriestWins(ref int wins)
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Textfiles/PriestWins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                ww.WritePriestWins(0);
            }
            return wins;
        }
        // ROGUE
        public int ReadRogueWins(ref int wins)
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Textfiles/RogueWins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                ww.WriteRogueWins(0);
            }
            return wins;
        }
        // SHAMAN
        public int ReadShamanWins(ref int wins)
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Textfiles/ShamanWins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                ww.WriteShamanWins(0);
            }
            return wins;
        }
        // WARLOCK
        public int ReadWarlockWins(ref int wins)
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Textfiles/WarlockWins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                ww.WriteWarlockWins(0);
            }
            return wins;
        }
        // WARRIOR
        public int ReadWarriorWins(ref int wins)
        {
            try
            {
                using (StreamReader readWins = new StreamReader("Textfiles/WarriorWins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                ww.WriteWarriorWins(0);
            }
            return wins;
        }
    }
}
