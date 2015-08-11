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
    public partial class HSCounter : Form
    {
        Paladin Paladin = new Paladin();
        Priest Priest = new Priest();
        DefaultCounter DFC = new DefaultCounter();
        public HSCounter()
        {
            
            InitializeComponent();
            DFC.Initialization(this);
        }
        private void defaultbutton_Click(object sender, EventArgs e)
        {
            DFC.DefaultButtonCLICKED(this);
        }
        // Default Counter
        private void loseButton_Click(object sender, EventArgs e)
        {
            DFC.loseButtonCLICKED(this);
        }

        private void winButton_Click(object sender, EventArgs e)
        {
            DFC.winButtonCLICKED(this);
        }
        // Default Counter other button (used to sum up wins from other classes)
        public void otherwinbutton()
        {
            DFC.otherwinButtonCLICKED();
        }
        public void otherlosebutton()
        {
            DFC.otherloseButtonCLICKED();
        }
       
     


        // Priest Counter
        private void priestbutton_Click(object sender, EventArgs e)
        {
            Priest.priestButtonCLICKED(this);
        }

        private void priestWinButton_Click(object sender, EventArgs e)
        {
            Priest.priestWinButtonCLICKED(this);
        }

        private void priestLoseButton_Click(object sender, EventArgs e)
        {
            Priest.priestLoseButtonCLICKED(this);
        }

        // Paladin Counter
        private void paladinbutton_Click(object sender, EventArgs e)
        {
            Paladin.paladinButtonCLICKED(this);
        }

        private void paladinWinButton_Click(object sender, EventArgs e)
        {
            Paladin.paladinWinButtonCLICKED(this);
        }

        private void paladinLoseButton_Click(object sender, EventArgs e)
        {
            Paladin.paladinLoseButtonCLICKED(this);
        }     
    }
}
