using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hearthstone_Counter
{
    public partial class Form1 : Form
    {
        string eMessage;
        int wins;
        int losses;
       // StreamWriter winsWriter = new StreamWriter("Wins.txt", false);
       // StreamWriter lossesWriter = new StreamWriter("Losses.txt");

        public Form1()
        {          
            InitializeComponent();
            ReadWins();
            label1.Text = "Won: " + wins;
            WriteWins(wins);
            ReadLosses();
            lostLabel.Text = "Lost: " + losses;
            WriteLosses(losses);
        }

        public void ReadWins()
        {
            try {
                using (StreamReader readWins = new StreamReader("Wins.txt"))
                {
                    wins = int.Parse(readWins.ReadLine());
                }
            } catch(Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WriteWins(0);
            }
        }


        public void ReadLosses()
        {
            try
            {
                using (StreamReader readLosses = new StreamReader("Losses.txt"))
                {
                    losses = int.Parse(readLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WriteLosses(0);
            }
        }

        public void loseButton_Click(object sender, EventArgs e)
        {
            
            losses++;
            lostLabel.Text = "Lost: " + losses;
            WriteLosses(losses);
        }

        public void winButton_Click(object sender, EventArgs e)
        {     
            wins++;
            label1.Text = "Won: " + wins;
            WriteWins(wins);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
       private void WriteWins(int T)
        {
            using (StreamWriter winsWriter = new StreamWriter("Wins.txt", false))
            {
                winsWriter.Write(T);
                winsWriter.Flush();
            }
                                   
        }    
        private void WriteLosses(int T)
        {
            using (StreamWriter lossesWriter = new StreamWriter("Losses.txt", false))
            {
                lossesWriter.Write(T);
                lossesWriter.Flush();
            }
        }    
    }
}
