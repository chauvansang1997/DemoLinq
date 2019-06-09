using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace DemoLinq
{
    public static class Utility
    {
        public static string ConvertObjectToXml<T>(T target)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(T));

            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, target);
                    xml = sww.ToString(); // Your XML
                }
            }
            return xml;
        }

        public static string WriteObjectToXml<T>(T target, string path )
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
            //if(path == null)
            //{
            //    path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\KhachHang.xml"));
            //}
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, target);
                    xml = sww.ToString(); // Your XML
                }
            }
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);
            xdoc.Save(path);
            return xml;
        }
    }
}
