using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Common
{
    public class Tools
    {
        public static string ConnectionString
        {
            get
            {
                return "Data Source=SONY-PC\\SQLEXPRESS;Initial Catalog=CrmDB;Integrated Security=True";
            }
        }
    }


}
