using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson8_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p = new Point(45.123, 78.963, "Point1");
            //XmlSerialize(p);
            Point p = XmlDeserialize();
            p.Print();
        }

        static Point XmlDeserialize()
        {
            FileStream stream = new FileStream("data.xml", FileMode.Open, FileAccess.Read);
            Point p = new Point();
            XmlSerializer serializer = new XmlSerializer(p.GetType());
            p = (Point)serializer.Deserialize(stream);
            stream.Close();
            return p;
        }

        static void XmlSerialize(Point p)
        {
            FileStream stream = new FileStream("data.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(p.GetType());
            serializer.Serialize(stream, p);
            stream.Close();
        }
    }

    [Serializable]
    public class Point
    {
        //[NonSerialized]
        public double x;
        //[Serializable]
        public double y;
        public string label;

        public Point()
        {   }

        public Point(double x, double y, string label)
        {
            this.x = x;
            this.y = y;
            this.label = label;
        }

        public void Print()
        {
            Console.WriteLine("X = {0}\nY = {1}\nLabel - {2}", x, y, label);
        }
    }
}
