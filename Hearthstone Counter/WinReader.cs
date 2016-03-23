using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Hearthstone_Counter
{
    class WinReader
    {
        WinWriter ww = new WinWriter();
        
        string eMessage;
        string[] allWins = new string[10];
        string[] placeholder = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"};
        Dictionary<string, int> winsDictionary = new Dictionary<string, int>();
        
        public Dictionary<string, int> ReadWinsArray()
        {
            try
            {
                using (StreamReader allReader = new StreamReader("Textfiles/AllWins.txt"))
                {
                    allWins = allReader.ReadLine().Split(' ');
                }
            }
            catch(Exception e)
            {
                ww.WriteAllWins(placeholder);
                allWins = placeholder;
            }

            winsDictionary = FillDictionary(allWins);

            return winsDictionary;
        }
        public int ReadDefaultWins()
        {
            Dictionary<string, int> winsDictionary = ReadWinsArray();

            return winsDictionary["DefaultWins"];
        }
        // DRUID
        public int ReadDruidWins()
        {
            Dictionary<string, int> winsDictionary = ReadWinsArray();

            return winsDictionary["DruidWins"];
        }
        // HUNTER
        public int ReadHunterWins()
        {
            Dictionary<string, int> winsDictionary = ReadWinsArray();

            return winsDictionary["HunterWins"];
        }
        // MAGE
        public int ReadMageWins()
        {
            Dictionary<string, int> winsDictionary = ReadWinsArray();

            return winsDictionary["MageWins"];
        }
        // PALADIN
        public int ReadPaladinWins()
        {
            Dictionary<string, int> winsDictionary = ReadWinsArray();

            return winsDictionary["PaladinWins"];
        }

        // PRIEST
        public int ReadPriestWins()
        {
            Dictionary<string, int> winsDictionary = ReadWinsArray();

            return winsDictionary["PriestWins"];
        }
        // ROGUE
        public int ReadRogueWins()
        {
            Dictionary<string, int> winsDictionary = ReadWinsArray();

            return winsDictionary["RogueWins"];
        }
        // SHAMAN
        public int ReadShamanWins()
        {
            Dictionary<string, int> winsDictionary = ReadWinsArray();

            return winsDictionary["ShamanWins"];
        }
        // WARLOCK
        public int ReadWarlockWins()
        {
            Dictionary<string, int> winsDictionary = ReadWinsArray();

            return winsDictionary["WarlockWins"];
        }
        // WARRIOR
        public int ReadWarriorWins()
        {
            Dictionary<string, int> winsDictionary = ReadWinsArray();

            return winsDictionary["WarriorWins"];
        }
        public Dictionary<string, int> FillDictionary(string[] wins)
        {
            Dictionary<string, int> winsDic = new Dictionary<string, int>();

            winsDic.Add("DefaultWins", int.Parse(wins[0]));
            winsDic.Add("DruidWins", int.Parse(wins[1]));
            winsDic.Add("HunterWins", int.Parse(wins[2]));
            winsDic.Add("MageWins", int.Parse(wins[3]));
            winsDic.Add("PaladinWins", int.Parse(wins[4]));
            winsDic.Add("PriestWins", int.Parse(wins[5]));
            winsDic.Add("RogueWins", int.Parse(wins[6]));
            winsDic.Add("ShamanWins", int.Parse(wins[7]));
            winsDic.Add("WarlockWins", int.Parse(wins[8]));
            winsDic.Add("WarriorWins", int.Parse(wins[9]));

            return winsDic;
        }
    }
}
