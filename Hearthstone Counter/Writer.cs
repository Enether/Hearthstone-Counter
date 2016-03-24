using System.Collections.Generic;
using System.IO;

namespace Hearthstone_Counter
{
    class Writer
    {
        string toWrite = "";
        string[] resetScore = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        public void WriteAllResults(string[] results)
        {
            using (StreamWriter allWriter = new StreamWriter("Textfiles/Results.txt", false))
            {
                toWrite = string.Join(" ", results);

                allWriter.Write(toWrite);
            }
        }
        public void WriteWins(Dictionary<string, int> results, int T, bool won, string classStr)
        {
            results[classStr + "Wins"] = T;

            if (won)
                results["DefaultWins"]++;


            using (StreamWriter winsWriter = new StreamWriter("Textfiles/Results.txt", false))
            {
                toWrite = string.Join(" ", results.Values);

                winsWriter.Write(toWrite);
            }
        }
        public void WriteLosses(Dictionary<string, int> results, int T, bool lost, string classStr)
        {
            results[classStr + "Losses"] = T;

            if (lost)
                results["DefaultLosses"]++;


            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/Results.txt", false))
            {
                toWrite = string.Join(" ", results.Values);

                lossesWriter.Write(toWrite);
            }
        }
        public void ResetResults()
        {
            toWrite = string.Join(" ", resetScore);

            using (StreamWriter resetScoreWriter= new StreamWriter("Textfiles/Results.txt", false))
            {
                resetScoreWriter.Write(toWrite);
            }
        }
    }
}
