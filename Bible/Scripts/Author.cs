using System;
namespace BibleTest
{
    public class Author
    {
        #region Variables

        public int TemplateID { get; private set; }
        public string DebugName { get; private set; }
        public string AuthorName { get; private set; }

        #endregion

        public Author()
        {
        }

        public Author(int a_templateID, string a_name)
        {
            TemplateID = a_templateID;
            DebugName = a_name;
            AuthorName = a_name;
        }
    }
}
