using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hearthstone_Counter
{
    public partial class AddWins : Form
    {
        string pattern = @"^(\d{1}\d{0,1})$";
        public int wins = 0;
        public AddWins()
        {
            InitializeComponent();
            this.addWinsBox.KeyPress += new KeyPressEventHandler(CheckEnter);
        }
        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                wins = ValidateWins(addWinsBox.Text);
                HSCounter.SaveWins(wins);
                this.Close();
            }
        }
        private int ValidateWins(string wins)
        {
            Regex validateWins = new Regex(pattern);
            Match match = validateWins.Match(wins);

            if (match.Success)
                return int.Parse(match.Value);

            return 0;   
        }
    }
}
