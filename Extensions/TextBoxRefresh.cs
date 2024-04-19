using System;
using System.Windows.Forms;

namespace FindPrimeNumbers.Extensions
{
    public static class TextBoxRefresh
    {
        public static TextBox RefreshText(TextBox box, dynamic value)
        {
            return (TextBox)box.Invoke(new Action(delegate ()
            {
                box.Text = Convert.ToString(value);
            }));
        }
    }
}
