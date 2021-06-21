using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Linq;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {            
            double usdToGel = exchangeRate("USD", "GEL");
            Console.WriteLine(usdToGel);

            double eurToGel = exchangeRate("EUR", "GEL");
            Console.WriteLine(eurToGel);
        }
        static double exchangeRate(String from, String to)
        {
            //String URLString = "http://www.nbg.ge/rss.php";
            //XmlTextReader reader = new XmlTextReader(URLString);
            //WebRequest request = WebRequest.Create("http://www.nbg.ge/rss.php");
            //WebResponse response = request.GetResponse();
            //Stream dataStream = response.GetResponseStream();
            //XElement doc = Xelement.Load(dataStream);
            ////Console.WriteLine(reader);
            //return 0;
            if (from == "USD" && to == "GEL")
            {
                //string usdResult = result.Substring(result.IndexOf("USD"), 47);
                //return Convert.ToDouble(usdResult.Substring(41));
            }
            else if (from == "EUR" && to == "GEL")
            {
                //string eurResult = result.Substring(result.IndexOf("EUR"), 41);
                //return Convert.ToDouble(eurResult.Substring(35));
            }
            else
                return 0;
        }
        static string RssFeed()
        {
            WebRequest webRequest = WebRequest.Create("http://www.nbg.ge/rss.php");
            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                //return reader.ReadToEnd();
                var mySourceDoc = new XmlDocument();
                mySourceDoc.LoadXml(reader.ReadToEnd());
                return mySourceDoc;
            }
        }
    }
}
