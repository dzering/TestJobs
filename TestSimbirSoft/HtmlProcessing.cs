using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.IO;

namespace TestSimbirSoft
{
    class HtmlProcessing
    {
        public string GetText(Stream stream)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.Load(stream);

            string text = htmlDocument.DocumentNode.InnerText;
            text = text.Replace("\n", " ");
            text = Regex.Replace(text, "  +", " ");
            return text;
        }

    }
}
