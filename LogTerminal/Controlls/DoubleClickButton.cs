using System;
using System.Windows.Forms;

namespace LogTerminal
{
    public class DoubleClickButton : System.Windows.Forms.Button
    {
        public new event EventHandler DoubleClick;
        DateTime clickTime;
        bool isClicked = false;
        private static readonly int DoubleClickTime = 200;
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (isClicked)
            {
                TimeSpan span = DateTime.Now - clickTime;
                if (span.Milliseconds <  DoubleClickTime)
                {
                    DoubleClick(this, e);
                    isClicked = false;
                }
                else
                {
                    isClicked = true;
                    clickTime = DateTime.Now;
                }
            }
            else
            {
                isClicked = true;
                clickTime = DateTime.Now;
            }

        }
    }
}
