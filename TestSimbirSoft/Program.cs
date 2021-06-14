using System;
using System.Collections.Generic;
using System.IO;



namespace TestSimbirSoft
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адресс страницы WWW.");
            string fileName = Console.ReadLine();   

            WebClientService wcs = new WebClientService();
            HtmlProcessing hp = new HtmlProcessing();
            TextHandler th = new TextHandler();

            Stream stream = wcs.GetPage(fileName);
            string text = hp.GetText(stream);

            Console.WriteLine(text);

            
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
