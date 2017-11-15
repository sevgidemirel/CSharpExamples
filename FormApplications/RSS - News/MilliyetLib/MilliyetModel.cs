using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlugInProxy;

namespace MilliyetLib
{
    public class MilliyetModel : IRssMembers
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string Source { get; set; }
        public string Link { get; set; }

    }
}
