using System;
using System.Collections.Generic;

namespace BibleTest
{
    public enum Testament
    {
        Old,
        New,
    }

    /// <summary>
    /// Bible book.
    /// </summary>
    public class BibleBook
    {
        //***** Variables *****
        #region Variables

        public int TemplateID { get; private set; }
        private int m_orderID;

        public string BookName { get; private set; }
        private string m_debugName;

        private int m_authorID;
        private string m_authorName;

        private Testament m_testament;

        //----- Text Data -----

        private List<Chapter> m_chapters;

        #endregion Variables

        //***** Constructors *****
        #region Constructors

        public BibleBook()
        {
        }

        public BibleBook(int a_templateID, int a_orderID, string a_bookName, int a_authorID, string a_authorName, Testament a_testament, List<Chapter> a_chapters)
        {
            TemplateID = a_templateID;
            m_orderID = a_orderID;
            BookName = a_bookName;
            m_debugName = a_bookName;
            m_authorID = a_authorID;
            m_authorName = a_authorName;
            m_testament = a_testament;
            m_chapters = a_chapters;
        }

        #endregion Constructors

        public IList<Chapter> GetChapters()
        {
            return m_chapters == null ? null : m_chapters.AsReadOnly();
        }

        public override string ToString()
        {
            return string.Format("BibleBook - TID[{0}] Order[{1}] Name[{2}] Author[{3}] Test[{4}] Chapters[{5}]", TemplateID, m_orderID, m_debugName, m_authorName, m_testament, m_chapters == null ? "null" : m_chapters.Count.ToString());
        }
    }
}
