using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Priest
    {
        public int priestwins;
        public int priestlosses;
        string eMessage;
        public void WritePriestWins(int T)
        {
            using (StreamWriter priestwinsWriter = new StreamWriter("PriestWins.txt", false))
            {
                priestwinsWriter.Write(T);
                priestwinsWriter.Flush();
            }

        }
        public void WritePriestLosses(int T)
        {
            using (StreamWriter priestlossesWriter = new StreamWriter("PriestLosses.txt", false))
            {
                priestlossesWriter.Write(T);
                priestlossesWriter.Flush();
            }
        }
        public void ReadPriestLosses()
        {
            try
            {
                using (StreamReader readpriestLosses = new StreamReader("PriestLosses.txt"))
                {
                    priestlosses = int.Parse(readpriestLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WritePriestLosses(0);
            }
        }
        public void ReadPriestWins()
        {
            try
            {
                using (StreamReader readPriestWins = new StreamReader("PriestWins.txt"))
                {
                    priestwins = int.Parse(readPriestWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WritePriestWins(0);
            }
        }
    }
}
