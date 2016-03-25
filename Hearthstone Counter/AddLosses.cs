using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hearthstone_Counter
{
    public partial class AddLosses : Form
    {
        string pattern = @"^(\d{1}\d{0,1})$";
        public int losses = 0;
        public AddLosses()
        {
            InitializeComponent();
            this.addLossesBox.KeyPress += new KeyPressEventHandler(CheckEnter);
        }
        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                losses = ValidateLosses(addLossesBox.Text);
                HSCounter.SaveLosses(losses);
                this.Close();
            }
        }
        private int ValidateLosses(string wins)
        {
            Regex validateLosses = new Regex(pattern);
            Match match = validateLosses.Match(wins);

            if (match.Success)
                return int.Parse(match.Value);

            return 0;
        }
    }
}
