using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlugInProxy;
using System.Net;
using System.Xml;

namespace CnnLib
{
    public class CnnMethods : IRssMethods<CnnModel>
    {
        public IList<CnnModel> GetNews()
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;

            // https://www.cnnturk.com/feed/rss/all/news

            string data = wc.DownloadString("https://www.cnnturk.com/feed/rss/all/news");

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(data);

            XmlNodeList haberler = xdoc.SelectNodes("rss/channel/item");

            var veri = new List<CnnModel>();

            foreach (XmlNode haber in haberler)
            {
                CnnModel cm = new CnnModel();

                try
                {
                    cm.Source = "CNN Turk";
                    cm.Link = haber.SelectSingleNode("link").InnerText;
                    cm.Title = haber.SelectSingleNode("title").InnerText;
                    cm.Description = haber.SelectSingleNode("description").InnerText;
                    veri.Add(cm);
                    
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
