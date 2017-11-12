using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DTO
{
    public class YazarDataSource
    {
        public int YazarId { get; set; }
        public string AdiSoyadi { get; set; }

        public override string ToString()
        {
            return this.AdiSoyadi;
        }
    }
}
