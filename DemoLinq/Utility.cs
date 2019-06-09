using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DemoLinq
{
    public static class Utility
    {
        public static string ConvertObjectToXml()
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(KhachHang));
            var subReq = new KhachHang();

            return null;
        }
    }
}
