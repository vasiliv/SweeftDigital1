using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asad - The C# Programmer’s Study Guide (MCSD)_ Exam_ 70-483 (2017)
            // Listing 6-17
            // Creation of XML data
            XElement rootElement = new XElement("RootElement");
            rootElement.Add(new XElement("Name", "Hamza Ali"));
            rootElement.Add(new XElement("Age", "21"));
            rootElement.Add(new XElement("Address", "Pakistan"));
            // saves in G:\Projects\SweeftDigital1\test\bin\Debug\net5.0
            rootElement.Save("Sample.xml");

            //read xml from file
            Stream xmlFromFile = File.Open("Sample.xml", FileMode.Open);
            StreamReader reader = new StreamReader(xmlFromFile);
            string xmlData = reader.ReadToEnd();

            string xmlData1 = @" <RootElement>
                <Name>Hamza Ali</Name>
                <Age>21</Age>
                <Address>Pakistan</Address>
                </RootElement>";
            XDocument document = new XDocument();
            document = XDocument.Parse(xmlData1);
            var xml = (from p in document.Elements()
                       select p).ToList();
            foreach (var item in xml)
            {
                Console.WriteLine(item.ToString());
            }
            //this will read the Name's Node
            var readNode = (from p in document.Descendants()
                            select p.Element("Name")).FirstOrDefault();
            Console.WriteLine(readNode);
            //this query will read Name (Node)'s Value
            var readNodeValue = (from p in document.Descendants()
                                 select p.Element("Name").Value).FirstOrDefault();
            Console.WriteLine(readNodeValue);
            
            //this will read the Name's Node if the age is 21
            var readNode1 = (from p in document.Descendants()
                where p.Element("Age").Value == "21"
                select p.Element("Name")).FirstOrDefault();
            Console.WriteLine(readNode1);
        }
    }
}
