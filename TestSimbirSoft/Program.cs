using System;
using System.Collections.Generic;
using System.IO;



namespace TestSimbirSoft
{

    class Program
    {
        static void Main(string[] args)
        {
            WebClientService wcs = new WebClientService();
            Stream stream = wcs.GetPage("https://www.simbirsoft.com/");

            HtmlProcessing hp = new HtmlProcessing();
            string text = hp.GetText(stream);

            Console.WriteLine(text);

            TextHandler th = new TextHandler();
            Dictionary<string, int> dictionary = th.GetWordsStatistic(text);

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }

            Console.WriteLine(dictionary.Count);
            Console.ReadLine();
        }
    }
}
