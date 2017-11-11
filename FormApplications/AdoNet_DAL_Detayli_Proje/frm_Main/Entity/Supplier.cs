using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Main.Entity
{
    // 6. Category.cs'den geldim ...
    public class Supplier : Entity
    {
        // public int SupplierId { get; set; }
        // ID -> SupplierId kalıtımdan Entity üzerinden gelecek ...
        // -------------------------------------------------------
        // prop + tab + tab
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return this.CompanyName;            
        }
        // Proje içine folder ekliyorum - "DAL" adında "Data Access Layer - veri erişim katmanı" ...
        // her tabloda insert / update / delete / list() / selectById(id) işlemleri yapılır. belirttiğimiz id yi geri döndürür. bunların hepsini bir tabloda tutmak istersek bir abstract sınıf tanımlarız... DAL'dayım ...
    }
}
