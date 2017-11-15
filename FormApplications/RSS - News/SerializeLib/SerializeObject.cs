using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SerializeLib
{
    public class SerializeObject<T> where T : class
    {
        public void GetXMLFile(IList<T> data,string fileName)
        {
            XmlDocument xDoc = new XmlDocument();

            XmlDeclaration xDec = xDoc.CreateXmlDeclaration("1.0","UTF-8",string.Empty);

            xDoc.AppendChild(xDec);

            XmlElement root = xDoc.CreateElement("DocumentElement");

            foreach (var d in data)
            {
                XmlElement element = xDoc.CreateElement(d.GetType().Name);

                foreach (var item in d.GetType().GetProperties())
                {
                    XmlElement piElement = xDoc.CreateElement(item.Name);

                    piElement.InnerText = item.GetValue(d,null).ToString();

                    element.AppendChild(piElement);
                }
                root.AppendChild(element);
            }
            xDoc.AppendChild(root);

            xDoc.Save(fileName);
        }
    }
}
