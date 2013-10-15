using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XElementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement sitemap = XElement.Load("http://www.dotnetperls.com/sitemap.xml");

            // ... XNames.
            XName url = XName.Get("url", "http://www.sitemaps.org/schemas/sitemap/0.9");
            XName loc = XName.Get("loc", "http://www.sitemaps.org/schemas/sitemap/0.9");

            // ... Loop over url elements.
            // ... Then access each loc element.
            foreach (var urlElement in sitemap.Elements(url))
            {
                var locElement = urlElement.Element(loc);
                Console.WriteLine(locElement.Value);
            }

            // ... Display count.
            Console.WriteLine("Count: {0}", sitemap.Elements(url).Count());
            Console.Read();
        }
    }
}
