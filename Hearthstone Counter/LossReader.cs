using System;
using System.Collections.Generic;
using System.IO;

namespace Hearthstone_Counter
{
    class LossReader
    {
        LossWriter lw = new LossWriter();

        string[] allLosses = new string[10];
        string[] placeholder = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        Dictionary<string, int> lossesDictionary = new Dictionary<string, int>();

        public Dictionary<string, int> ReadLossesDictionary()
        {
            try
            {
                using (StreamReader allReader = new StreamReader("Textfiles/AllLosses.txt"))
                {
                    allLosses = allReader.ReadLine().Split(' ');
                }
            }
            catch (Exception e)
            {
                lw.WriteAllLosses(placeholder);
                allLosses = placeholder;
            }

            lossesDictionary = FillDictionary(allLosses);

            return lossesDictionary;
        }
        public int ReadLosses(string classStr)
        {
            Dictionary<string, int> lossesDictionary = ReadLossesDictionary();

            return lossesDictionary[classStr + "Losses"];
        }
        public Dictionary<string, int> FillDictionary(string[] losses)
        {
            Dictionary<string, int> lossesDic = new Dictionary<string, int>();

            lossesDic.Add("DefaultLosses", int.Parse(losses[0]));
            lossesDic.Add("DruidLosses", int.Parse(losses[1]));
            lossesDic.Add("HunterLosses", int.Parse(losses[2]));
            lossesDic.Add("MageLosses", int.Parse(losses[3]));
            lossesDic.Add("PaladinLosses", int.Parse(losses[4]));
            lossesDic.Add("PriestLosses", int.Parse(losses[5]));
            lossesDic.Add("RogueLosses", int.Parse(losses[6]));
            lossesDic.Add("ShamanLosses", int.Parse(losses[7]));
            lossesDic.Add("WarlockLosses", int.Parse(losses[8]));
            lossesDic.Add("WarriorLosses", int.Parse(losses[9]));

            return lossesDic;
        }
    }
}
