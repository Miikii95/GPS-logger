using System.Globalization;
using System.Xml;

namespace MapForLoggerHelper
{
    internal class Helper
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("E:DATALOG.txt");
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("root");
            doc.AppendChild(root);

        

            foreach (string line in lines)
            {
                if (line == "Program started!")
                {

                    continue;
                }
                if (line == "") { continue; }

                string[] data = line.Split(';');
                string[] time = data[0].Split(':');
                int hour = int.Parse(time[0]);
                int minute = int.Parse(time[1]);
                int second = int.Parse(time[2]);
                float latitude = float.Parse(data[1].Substring(6), CultureInfo.InvariantCulture);
                float longitude = float.Parse(data[2].Substring(6), CultureInfo.InvariantCulture);
                DateTime dateTime = new DateTime(1, 1, 1, hour, minute, second);

            }



        }
    }
}