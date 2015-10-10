using System;
using System.IO;

namespace Hearthstone_Counter
{
    class LossReader
    {
        LossWriter lw = new LossWriter();
        string eMessage;

        public int ReadDefaultLosses(ref int losses)
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Textfiles/Losses.txt"))
                {
                    losses = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                lw.WriteDefaultLosses(0);
            }
            return losses;
        }
        // DRUID
        public int ReadDruidLosses(ref int losses)
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Textfiles/DruidLosses.txt"))
                {
                    losses = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                lw.WriteDruidLosses(0);
            }
            return losses;
        }
        // HUNTER
        public int ReadHunterLosses(ref int losses)
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Textfiles/HunterLosses.txt"))
                {
                    losses = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                lw.WriteHunterLosses(0);
            }
            return losses;
        }
        // MAGE
        public int ReadMageLosses(ref int losses)
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Textfiles/MageLosses.txt"))
                {
                    losses = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                lw.WriteMageLosses(0);
            }
            return losses;
        }
        // PALADIN
        public int ReadPaladinLosses(ref int losses)
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Textfiles/PaladinLosses.txt"))
                {
                    losses = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                lw.WritePaladinLosses(0);
            }
            return losses;
        }
        // PRIEST
        public int ReadPriestLosses(ref int losses)
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Textfiles/PriestLosses.txt"))
                {
                    losses = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                lw.WritePriestLosses(0);
            }
            return losses;
        }
        // ROGUE
        public int ReadRogueLosses(ref int losses)
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Textfiles/RogueLosses.txt"))
                {
                    losses = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                lw.WriteRogueLosses(0);
            }
            return losses;
        }
        // SHAMAN
        public int ReadShamanLosses(ref int ALOT)
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Textfiles/ShamanLosses.txt"))
                {
                    ALOT = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                lw.WriteShamanLosses(0);
            }
            return ALOT;
        }
        // WARLOCK
        public int ReadWarlockLosses(ref int losses)
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Textfiles/WarlockLosses.txt"))
                {
                    losses = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                lw.WriteWarlockLosses(0);
            }
            return losses;
        }
        // WARRIOR
        public int ReadWarriorLosses(ref int losses)
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Textfiles/WarriorLosses.txt"))
                {
                    losses = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                lw.WriteWarriorLosses(0);
            }
            return losses;
        }
    }
}
