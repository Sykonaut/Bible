using System;
namespace BibleTest
{
    public class Verse
    {
        #region Variables

        public int Number { get; private set; }
        public string Text { get; private set; }

        #endregion Variables

        public Verse()
        {
        }

        public Verse(int a_number, string a_text)
        {
            Number = a_number;
            Text = a_text;
        }
    }
}
