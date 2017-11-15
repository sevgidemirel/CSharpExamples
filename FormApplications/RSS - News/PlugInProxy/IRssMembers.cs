using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugInProxy
{
    //Loaddan geldim
    public interface IRssMembers
    {
        string Title { get; set; } //başlık
        string Source { get; set; } //haber kaynagı
        string Link { get; set; } //link

    }
}
