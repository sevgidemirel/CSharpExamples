using PlugInProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MilliyetLib
{
    public class MilliyetMethods : IRssMethods<MilliyetModel>
    {
        public IList<MilliyetModel> GetNews()
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;

            string data = wc.DownloadString("http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml");

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(data);

            XmlNodeList haberler = xdoc.SelectNodes("rss/channel/item");

            var veri = new List<MilliyetModel>();

            foreach (XmlNode haber in haberler)
            {
                MilliyetModel mm = new MilliyetModel();

                try
                {
                    mm.Source = "Milliyet";
                    mm.Link = haber.SelectSingleNode("link").InnerText;
                    mm.Title = haber.SelectSingleNode("title").InnerText;
                    mm.Description = haber.SelectSingleNode("description").InnerText;
                    veri.Add(mm);

                }
                catch (Exception)
                {

                    continue;
                }

            }

            return veri;
        }
    }
}
