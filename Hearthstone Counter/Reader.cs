using System;
using System.Collections.Generic;
using System.IO;

namespace Hearthstone_Counter
{
    class Reader
    {
        Writer writer = new Writer();
        string[] allResults = new string[20];
        string[] placeholder = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        Dictionary<string, int> resultsDictionary = new Dictionary<string, int>();
        public Dictionary<string, int> ReadResultsDictionary()
        {
            try
            {
                using (StreamReader allReader = new StreamReader("Textfiles/Results.txt"))
                {
                    allResults = allReader.ReadLine().Split(' ');
                }
            }
            catch (Exception e)
            {
                writer.WriteAllResults(placeholder);
                allResults = placeholder;
            }

            resultsDictionary = FillDictionary(allResults);

            return resultsDictionary;
        }
        public int ReadWins(string classStr)
        {
            Dictionary<string, int> winsDictionary = ReadResultsDictionary();

            return winsDictionary[classStr + "Wins"];
        }
        public int ReadLosses(string classStr)
        {
            Dictionary<string, int> lossesDictionary = ReadResultsDictionary();

            return lossesDictionary[classStr + "Losses"];
        }
        private Dictionary<string, int> FillDictionary(string[] allResults)
        {
            Dictionary<string, int> resultsDic = new Dictionary<string, int>();

            resultsDic.Add("DefaultWins", int.Parse(allResults[0]));
            resultsDic.Add("DefaultLosses", int.Parse(allResults[1]));

            resultsDic.Add("DruidWins", int.Parse(allResults[2]));
            resultsDic.Add("DruidLosses", int.Parse(allResults[3]));

            resultsDic.Add("HunterWins", int.Parse(allResults[4]));
            resultsDic.Add("HunterLosses", int.Parse(allResults[5]));

            resultsDic.Add("MageWins", int.Parse(allResults[6]));
            resultsDic.Add("MageLosses", int.Parse(allResults[7]));

            resultsDic.Add("PaladinWins", int.Parse(allResults[8]));
            resultsDic.Add("PaladinLosses", int.Parse(allResults[9]));

            resultsDic.Add("PriestWins", int.Parse(allResults[10]));
            resultsDic.Add("PriestLosses", int.Parse(allResults[11]));

            resultsDic.Add("RogueWins", int.Parse(allResults[12]));
            resultsDic.Add("RogueLosses", int.Parse(allResults[13]));

            resultsDic.Add("ShamanWins", int.Parse(allResults[14]));
            resultsDic.Add("ShamanLosses", int.Parse(allResults[15]));

            resultsDic.Add("WarlockWins", int.Parse(allResults[16]));
            resultsDic.Add("WarlockLosses", int.Parse(allResults[17]));

            resultsDic.Add("WarriorWins", int.Parse(allResults[18]));
            resultsDic.Add("WarriorLosses", int.Parse(allResults[19]));

            return resultsDic;
        }
    }
}
