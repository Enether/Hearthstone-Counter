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
        public void WriteWins(Dictionary<string, int> wins, int T, bool won, string classStr)
        {
            wins[classStr + "Wins"] = T;

            if (won)
                wins["DefaultWins"]++;


            using (StreamWriter winsWriter = new StreamWriter("Textfiles/AllWins.txt", false))
            {
                toWrite = string.Join(" ", wins.Values);

                winsWriter.Write(toWrite);
            }
        }
    }
}
