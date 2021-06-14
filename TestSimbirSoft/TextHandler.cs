using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSimbirSoft
{
    class TextHandler
    {
        public Dictionary<string, int> GetWordsStatistic(string text)
        {
            char[] separator = new char[] { ' ', '.', ',', '?', '!', ':', ';', '"' };
            var comparer = StringComparer.OrdinalIgnoreCase;
            Dictionary<string, int> dictionary = new Dictionary<string, int>(comparer);
            string[] splitText = text.Split(separator);

            foreach (string el in splitText)
            {
                if (!dictionary.ContainsKey(el))
                {
                    dictionary.Add(el, 1);
                }
                else
                {
                    dictionary[el] = dictionary[el] + 1;
                }
            }

            return dictionary;


        }
    }
}
