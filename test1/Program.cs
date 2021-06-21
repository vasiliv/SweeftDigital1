using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace test1
{
    class Program
    {
        const string URL = "http://www.nbg.ge/rss.php";
        static void Main(string[] args)
        {
            // reading xml from file
            XDocument doc = XDocument.Load(URL);
            
        }
        
    }
}
