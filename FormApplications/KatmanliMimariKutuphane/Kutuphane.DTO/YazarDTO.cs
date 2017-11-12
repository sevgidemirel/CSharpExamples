using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DTO
{
    public class YazarDTO
    {
        public int YazarId { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyad { get; set; }
        public string Ozgecmis { get; set; }

        public override string ToString()
        {
            return this.YazarAdi + " " + this.YazarSoyad;
        }
    }
}
