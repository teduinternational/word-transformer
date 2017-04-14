using System.Collections.Generic;
using System.Linq;

namespace Dictionary.Helpers
{
    public class TransformHelper
    {
        //private static char[] characters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private static Dictionary<int, char> characters = new Dictionary<int, char>() {
            { 0,'a' },
            { 1,'b' },
            { 2,'c'},
            { 3,'d'},
            { 4,'e'},
            { 5,'f'},
            { 6,'g'},
            { 7,'h'},
            { 8,'i'},
            { 9,'j'},
            { 10,'k'},
            { 11,'l'},
            { 12,'m'},
            { 13,'n'},
            { 14,'o'},
            { 15,'p'},
            { 16,'q'},
            { 17,'r'},
            { 18,'s'},
            { 19,'t'},
            { 20,'u'},
            { 21,'v'},
            { 22,'w'},
            { 23,'x'},
            { 24,'y'},
            { 25,'z'}
        };

        public static IList<string> AddLetter(HashSet<string> origin, string word)
        {
            var outputArr = new List<string>();
            for (int i = 0; i < word.ToCharArray().Length; i++)
            {
                for (int j = 0; j < characters.Count; j++)
                {
                    var newWord = word.Insert(i, characters[j].ToString());
                    if (origin.Contains(newWord) && newWord != word && !outputArr.Contains(newWord))
                    {
                        outputArr.Add(newWord);
                    }
                }
            }
            return outputArr;
        }

        public static IList<string> ReplaceLetter(HashSet<string> origin, string word)
        {
            var outputArr = new List<string>();
            for (int i = 0; i < word.ToCharArray().Length; i++)
            {
                for (int j = 0; j < characters.Count; j++)
                {
                    var newWord = word.Replace(word.ToCharArray()[i], characters[j]);
                    if (origin.Contains(newWord) && newWord != word && !outputArr.Contains(newWord))
                    {
                        outputArr.Add(newWord);
                    }
                }
            }
            return outputArr;
        }

        public static IList<string> RemoveLetter(HashSet<string> origin, string word)
        {
            var outputArr = new List<string>();
            for (int i = 0; i < word.ToCharArray().Length; i++)
            {
                var newWord = word.Remove(i, 1);
                if (origin.Contains(newWord) && newWord != string.Empty && !outputArr.Contains(newWord))
                {
                    outputArr.Add(newWord);
                }
            }
            return outputArr;
        }
    }
}