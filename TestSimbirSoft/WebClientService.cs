﻿using System.IO;
using System.Net;

namespace TestSimbirSoft
{
    internal class WebClientService
    {
        private string GetFileName(string url)
        {
            string name = null;
            string[] urlSplit = url.Split('/');
            string lastElArray = urlSplit[urlSplit.Length - 1];
            if (lastElArray == "")
            {
                name = "index.html";
            }
            if(lastElArray == url)
            {
                name = "index.html";
            }
            return name;
        }

        public Stream GetPage(string url)
        {
            string fileName = GetFileName(url);

            if (!File.Exists(fileName))
            {
                WebClient webClient = new WebClient();

                Stream stream = webClient.OpenRead(url);

                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    stream.CopyTo(fs);
                }
            }

            StreamReader sr = new StreamReader(fileName);
            return sr.BaseStream;
        }
    }
}