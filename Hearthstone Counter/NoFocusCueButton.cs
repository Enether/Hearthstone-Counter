using System.Windows.Forms;

namespace Hearthstone_Counter
{
    public class NoFocusCueButton : Button
    {
        public NoFocusCueButton() : base()
        {
            //Used to make buttons un-selectable
            this.SetStyle(ControlStyles.Selectable, false);
        }
        protected override bool ShowFocusCues
        {
            get { return false; }
        }
    }
}
