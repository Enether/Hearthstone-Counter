using System.IO;

namespace Hearthstone_Counter
{
    class LossWriter
    {
        public void WriteDefaultLosses(int T)
        {
            // DEFAULT
            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/Losses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }
        public void WriteDruidLosses(int T)
        {
            // DRUID
            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/DruidLosses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }
        public void WriteHunterLosses(int T)
        {
            // HUNTER
            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/HunterLosses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }
        public void WriteMageLosses(int T)
        {
            // MAGE
            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/MageLosses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }
        public void WritePaladinLosses(int T)
        {
            // PALADIN
            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/PaladinLosses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }
        public void WritePriestLosses(int T)
        {
            // PRIEST
            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/PriestLosses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }
        public void WriteRogueLosses(int T)
        {
            // ROGUE
            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/RogueLosses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }
        public void WriteShamanLosses(int ALOT)
        {
            // SHAMAN
            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/ShamanLosses.txt", false))
            {
                lossesWriter.Write(ALOT);
                lossesWriter.Flush();
            }
        }
        public void WriteWarlockLosses(int T)
        {
            // WARLOCK
            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/WarlockLosses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }
        public void WriteWarriorLosses(int T)
        {
            // WARRIOR
            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/WarriorLosses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }
    }
}
