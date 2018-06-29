using System;

namespace BibleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Bible bible = new Bible();
            bible.SetupBible();

            foreach (var book in bible.GetBooks())
            {
                Console.WriteLine(book);

                var chapters = book.GetChapters();
                if (chapters != null)
                {
                    foreach (var chap in book.GetChapters())
                    {
                        Console.WriteLine("Chapter - " + chap);

                        foreach (var verse in chap.GetVerses())
                        {
                            Console.WriteLine(verse.Text);
                        }
                    }
                }
            }
        }
    }
}
