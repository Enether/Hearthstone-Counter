using System.IO;

namespace Hearthstone_Counter
{
    class WinWriter
    {
        public void WriteDefaultWins(int T)
        {
            // DEFAULT
            using (StreamWriter winsWriter = new StreamWriter("Textfiles/Wins.txt", false))
            {
                winsWriter.Write(T);
                winsWriter.Flush();
            }
        }
        public void WriteDruidWins(int T)
        {
            // DRUID
            using (StreamWriter winWriter = new StreamWriter("Textfiles/DruidWins.txt", false))
            {
                winWriter.Write(T);
                winWriter.Flush();
            }
        }
        public void WriteHunterWins(int T)
        {
            // HUNTER
            using (StreamWriter winWriter = new StreamWriter("Textfiles/HunterWins.txt", false))
            {
                winWriter.Write(T);
                winWriter.Flush();
            }
        }
        public void WriteMageWins(int T)
        {
            // MAGE
            using (StreamWriter winWriter = new StreamWriter("Textfiles/MageWins.txt", false))
            {
                winWriter.Write(T);
                winWriter.Flush();
            }
        }
        public void WritePaladinWins(int T)
        {
            // PALADIN
            using (StreamWriter winWriter = new StreamWriter("Textfiles/PaladinWins.txt", false))
            {
                winWriter.Write(T);
                winWriter.Flush();
            }
        }
        public void WritePriestWins(int T)
        {
            // PRIEST
            using (StreamWriter winWriter = new StreamWriter("Textfiles/PriestWins.txt", false))
            {
                winWriter.Write(T);
                winWriter.Flush();
            }
        }
        public void WriteRogueWins(int T)
        {
            // ROGUE
            using (StreamWriter winWriter = new StreamWriter("Textfiles/RogueWins.txt", false))
            {
                winWriter.Write(T);
                winWriter.Flush();
            }
        }
        public void WriteShamanWins(int T)
        {
            // SHAMAN
            using (StreamWriter winWriter = new StreamWriter("Textfiles/ShamanWins.txt", false))
            {
                winWriter.Write(T);
                winWriter.Flush();
            }
        }
        public void WriteWarlockWins(int T)
        {
            // WARLOCK
            using (StreamWriter winWriter = new StreamWriter("Textfiles/WarlockWins.txt", false))
            {
                winWriter.Write(T);
                winWriter.Flush();
            }
        }
        public void WriteWarriorWins(int T)
        {
            // WARRIOR
            using (StreamWriter winWriter = new StreamWriter("Textfiles/WarriorWins.txt", false))
            {
                winWriter.Write(T);
                winWriter.Flush();
            }
        }
    }
}
