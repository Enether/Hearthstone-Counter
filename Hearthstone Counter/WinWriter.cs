using System.Collections.Generic;
using System.IO;

namespace Hearthstone_Counter
{
    class WinWriter
    {
        string toWrite = "";        
        public void WriteAllWins(string[] wins)
        {
            using (StreamWriter allWrites = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins);

                allWrites.Write(toWrite);
            }
        }
        public void WriteDefaultWins(Dictionary<string, int> wins, int T)
        {
            // DEFAULT
            wins["DefaultWins"] = T;
            using (StreamWriter winsWriter = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins.Values);

                winsWriter.Write(toWrite);
            }
        }
        public void WriteDruidWins(Dictionary<string, int> wins, int T, bool won)
        {
            // DRUID
            wins["DruidWins"] = T;
            if(won)
                wins["DefaultWins"]++;

            using (StreamWriter winWriter = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins.Values);

                winWriter.Write(toWrite);
            }
        }
        public void WriteHunterWins(Dictionary<string,int> wins, int T, bool won)
        {
            // HUNTER
            wins["HunterWins"] = T;

            if (won)
                wins["DefaultWins"]++;

            using (StreamWriter winWriter = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins.Values);

                winWriter.Write(toWrite);
            }
        }
        public void WriteMageWins(Dictionary<string, int> wins, int T, bool won)
        {
            // MAGE
            wins["MageWins"] = T;

            if (won)
                wins["DefaultWins"]++;

            using (StreamWriter winWriter = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins.Values);

                winWriter.Write(toWrite);
            }
        }
        public void WritePaladinWins(Dictionary<string, int> wins, int T, bool won)
        {
            // PALADIN
            wins["PaladinWins"] = T;

            if (won)
                wins["DefaultWins"]++;

            using (StreamWriter winWriter = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins.Values);

                winWriter.Write(toWrite);
            }
        }
        public void WritePriestWins(Dictionary<string, int> wins, int T, bool won)
        {
            // PRIEST
            wins["PriestWins"] = T;

            if (won)
                wins["DefaultWins"]++;

            using (StreamWriter winWriter = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins.Values);

                winWriter.Write(toWrite);
            }
        }
        public void WriteRogueWins(Dictionary<string, int> wins, int T, bool won)
        {
            // ROGUE
            wins["RogueWins"] = T;

            if (won)
                wins["DefaultWins"]++;

            using (StreamWriter winWriter = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins.Values);

                winWriter.Write(toWrite);
            }
        }
        public void WriteShamanWins(Dictionary<string, int> wins, int T, bool won)
        {
            // SHAMAN
            wins["ShamanWins"] = T;

            if (won)
                wins["DefaultWins"]++;

            using (StreamWriter winWriter = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins.Values);

                winWriter.Write(toWrite);
            }
        }
        public void WriteWarlockWins(Dictionary<string, int> wins, int T, bool won)
        {
            // WARLOCK
            wins["WarlockWins"] = T;

            if (won)
                wins["DefaultWins"]++;

            using (StreamWriter winWriter = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins.Values);

                winWriter.Write(toWrite);
            }
        }
        public void WriteWarriorWins(Dictionary<string, int> wins, int T, bool won)
        {
            // WARRIOR
            wins["WarriorWins"] = T;

            if (won)
                wins["DefaultWins"]++;

            using (StreamWriter winWriter = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins.Values);

                winWriter.Write(toWrite);
            }
        }
    }
}
