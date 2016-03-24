using System.Collections.Generic;
using System.IO;

namespace Hearthstone_Counter
{
    class LossWriter
    {
        string toWrite = "";
        public void WriteAllLosses(string[] losses)
        {
            using (StreamWriter allWriter = new StreamWriter("Textfiles/AllLosses.txt", false))
            {
                toWrite = string.Join(" ", losses);

                allWriter.Write(toWrite);
            }
        }

        public void WriteLosses(Dictionary<string, int> losses, int T, bool lost, string classStr)
        {
            losses[classStr + "Losses"] = T;

            if (lost)
                losses["DefaultLosses"]++;


            using (StreamWriter lossesWriter = new StreamWriter("Textfiles/AllLosses.txt", false))
            {
                toWrite = string.Join(" ", losses.Values);

                lossesWriter.Write(toWrite);
            }
        }
    }
}
