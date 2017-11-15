using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugInProxy
{
    public interface IRssMethods<T>
    {
        IList<T> GetNews();
    }
}
