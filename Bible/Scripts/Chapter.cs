using System;
using System.Collections.Generic;

namespace BibleTest
{
    public class Chapter
    {
        #region Variables

        private int m_chapterNum;
        private List<Verse> m_verses;

        #endregion Variables

        public Chapter()
        {
        }

        public Chapter(int a_chapterNum, List<Verse> a_verses)
        {
            m_chapterNum = a_chapterNum;
            m_verses = a_verses;
        }

        #region Methods

        public int GetNumber()
        {
            return m_chapterNum;
        }

        public IList<Verse> GetVerses()
        {
            return m_verses == null ? null : m_verses.AsReadOnly();
        }

        public Verse GetVerseByNum(int a_verseNum)
        {
            // TODO: Assuming verses are in ordered (0 -> n-1)
            Verse verse = null;
            if (m_verses != null && m_verses.Count > a_verseNum)
            {
                verse = m_verses[a_verseNum - 1];
            }

            return verse;
        }

        #endregion

        public override string ToString()
        {
            return string.Format("Chapter - Num[{0}] Verses[{1}]", m_chapterNum, m_verses == null ? "null" : m_verses.Count.ToString());
        }
    }
}
