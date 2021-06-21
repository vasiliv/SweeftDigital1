using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace test2
{
    class Program
    {
        const string URL = "http://www.nbg.ge/rss.php";
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load(URL);
            Config config;

            using (var reader = new XmlReader(doc))
            {
                config = (Config)new XmlSerializer(typeof(Config)).Deserialize(reader);
            }

            Console.WriteLine(config);

            GetKeyFromUser("\n\nDone! Press any key to exit...");
        }
    }
    public class Config
    {
        public UI Ui { get; set; }
        public Output Output { get; set; }

        public override string ToString()
        {
            return $"Config has properties:\n - Ui: {Ui}\n - Output: {Output}";
        }
    }

    public class UI
    {
        public string Colour { get; set; }
        public string Size { get; set; }

        public override string ToString()
        {
            return $"(Colour: {Colour}, Size: {Size})";
        }
    }
    public class Output
    {
        public string Mode { get; set; }
        public int Version { get; set; }

        public override string ToString()
        {
            return $"(Mode: {Mode}, Version: {Version})";
        }
    }
}
