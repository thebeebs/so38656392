using System.Collections.Generic;

namespace so38656392.Models
{
   public class ResultViewModel
    {
        public ResultViewModel()
        {
        }

        public List<string> KeyPhrases { get; internal set; }
        public string OriginalText { get; internal set; }

        private string myVar;

        public string MarkText()
        {
            string text = this.OriginalText;
            foreach (string word in KeyPhrases)
            {
                text = text.Replace(word, string.Format("<mark>{0}</mark>",word));
            }
            return text;

        }        

    }
}