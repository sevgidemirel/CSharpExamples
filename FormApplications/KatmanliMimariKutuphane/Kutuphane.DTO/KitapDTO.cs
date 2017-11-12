using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DTO
{
    public class KitapDTO
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string KitapKonusu { get; set; }
        public string Yayinevi { get; set; }
        public string YayinTarihi { get; set; }
        public int YazarId { get; set; }

        public override string ToString()
        {
            return this.KitapAdi;
        }
    }
}
