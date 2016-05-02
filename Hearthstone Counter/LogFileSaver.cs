using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_Counter
{
    class LogFileSaver
    {
        private Dictionary<string, int> results;
        private string exactTime;
        private string month;
        public void CreateLog()
        {
            GetMonth();
            CreateLogFile();
            GetResults();
            WriteLogFile();
        }
        private void WriteLogFile()
        {
            using (StreamWriter writer = new StreamWriter("Textfiles/LogFiles/" + month + "/LogFile_" + exactTime + ".txt", true))
            {
                writer.WriteLine("Hearthstone Counter Log File - " + exactTime);
                writer.WriteLine();
                writer.WriteLine("Total wins - {0}", results["DefaultWins"]);
                writer.WriteLine("Total losses - {0}", results["DefaultLosses"]);
                writer.WriteLine("Total win percentage - {0}", CalculateWinPercentage(results["DefaultWins"], results["DefaultLosses"]));
                writer.WriteLine();
                writer.WriteLine("Druid wins - {0}", results["DruidWins"]);
                writer.WriteLine("Druid losses - {0}", results["DruidLosses"]);
                writer.WriteLine("Druid win percentage - {0}", CalculateWinPercentage(results["DruidWins"], results["DruidLosses"]));
                writer.WriteLine();
                writer.WriteLine("Mage wins - {0}", results["MageWins"]);
                writer.WriteLine("Mage losses - {0}", results["MageLosses"]);
                writer.WriteLine("Mage win percentage - {0}", CalculateWinPercentage(results["MageWins"], results["MageLosses"]));
                writer.WriteLine();
                writer.WriteLine("Paladin wins - {0}", results["PaladinWins"]);
                writer.WriteLine("Paladin losses - {0}", results["PaladinLosses"]);
                writer.WriteLine("Paladin win percentage - {0}", CalculateWinPercentage(results["PaladinWins"], results["PaladinLosses"]));
                writer.WriteLine();
                writer.WriteLine("Priest wins - {0}", results["PriestWins"]);
                writer.WriteLine("Priest losses - {0}", results["PriestLosses"]);
                writer.WriteLine("Priest win percentage - {0}", CalculateWinPercentage(results["PriestWins"], results["PriestLosses"]));
                writer.WriteLine();
                writer.WriteLine("Rogue wins - {0}", results["RogueWins"]);
                writer.WriteLine("Rogue losses - {0}", results["RogueLosses"]);
                writer.WriteLine("Rogue win percentage - {0}", CalculateWinPercentage(results["RogueWins"], results["RogueLosses"]));
                writer.WriteLine();
                writer.WriteLine("Shaman wins - {0}", results["ShamanWins"]);
                writer.WriteLine("Shaman losses - {0}", results["ShamanLosses"]);
                writer.WriteLine("Shaman win percentage - {0}", CalculateWinPercentage(results["ShamanWins"], results["ShamanLosses"]));
                writer.WriteLine();
                writer.WriteLine("Warlock wins - {0}", results["WarlockWins"]);
                writer.WriteLine("Warlock losses - {0}", results["WarlockLosses"]);
                writer.WriteLine("Warlock win percentage - {0}", CalculateWinPercentage(results["WarlockWins"], results["WarlockLosses"]));
                writer.WriteLine();
                writer.WriteLine("Warrior wins - {0}", results["WarriorWins"]);
                writer.WriteLine("Warrior losses - {0}", results["WarriorLosses"]);
                writer.WriteLine("Warrior win percentage - {0}", CalculateWinPercentage(results["WarriorWins"], results["WarriorLosses"]));
            }
        }
        private void CreateLogFile()
        {
            DateTime now = DateTime.Now;
            exactTime = (now.ToShortDateString() + " " + now.ToShortTimeString()).Replace('/', '-').Replace(':', '-');

            File.CreateText("Textfiles/LogFiles/" + month + "/LogFile_" + exactTime + ".txt").Close();
        }
        private void GetResults()
        {
            Reader reader = new Reader();
            results = reader.ReadResultsDictionary();
        }
        private string CalculateWinPercentage(int wins, int losses)
        {
            double winPercentage = (double)wins / (wins + losses);
            if (Double.IsNaN(winPercentage)) winPercentage = 0;
            string winPercentageString = string.Format("{0:0.0%}", winPercentage);

            return winPercentageString;
        }
        private void GetMonth()
        {
            month = DateTime.Now.ToString("MMMM");
            Directory.CreateDirectory("Textfiles/LogFiles/" + month);
        }
    }
}
