using System;

namespace FindPrimeNumbers.Extensions
{
    public static class TextBoxRefresh
    {
        public static System.Windows.Forms.TextBox RefreshText(System.Windows.Forms.TextBox box, dynamic value)
        {
            return (System.Windows.Forms.TextBox)box.Invoke(new Action(delegate ()
            {
                box.Text = Convert.ToString(value);
            }));
        }
    }
}
