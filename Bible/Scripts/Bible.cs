using System;
using System.Collections.Generic;
using System.Xml;

namespace BibleTest
{
    public class Bible
    {
        //***** Variables *****
        #region Variables

        private List<BibleBook> m_books = new List<BibleBook>();
        private List<Author> m_authors = new List<Author>();

        #endregion Variables

        public Bible()
        {
        }

        /// <summary>
        /// Fills out the bible books with the needed data
        /// </summary>
        public void SetupBible()
        {
            SetupAuthors();

            // TODO: Chapter and Verses
            m_books.Add(new BibleBook(1, 1, "Genesis", m_authors[0].TemplateID, m_authors[0].AuthorName, Testament.Old, null));
            m_books.Add(new BibleBook(2, 2, "Exodus", m_authors[0].TemplateID, m_authors[0].AuthorName, Testament.Old, null));

            List<Verse> john1Verses = new List<Verse>
            {
                new Verse(1, "In the beginning was the Word, and the Word was with God, and the Word was God."),
                new Verse(2, "He was in the beginning with God."),
                new Verse(3, "All things were made through Him, and without Him nothing was made that was made."),
            };
            Chapter john1 = new Chapter(1, john1Verses);

            List<Chapter> johnChapters = new List<Chapter>
            {
                john1,
            };

            m_books.Add(new BibleBook(43, 43, "John", m_authors[1].TemplateID, m_authors[1].AuthorName, Testament.New, johnChapters));
        }

        private void SetupAuthors()
        {
            // TODO: This would be perfect to pull data from xml

            m_authors.Add(new Author(1, "Moses"));
            m_authors.Add(new Author(7, "John"));
        }

        public IList<BibleBook> GetBooks()
        {
            return m_books.AsReadOnly();
        }
    }
}
