using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Main.Entity
{
    // 4. Entity.cs'den geldim ...
    public class Product : Entity // ID'yi kalıtım aldırdım ...
    {
        // public int ProductId { get; set; }
        // ID -> ProductId kalıtımdan Entity üzerinden gelecek ...
        // -------------------------------------------------------
        // prop + tab + tab
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public bool Discontinued { get; set; } // 0 veya 1
        // -------------------------------------------------------
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        // -------------------------------------------------------
        public override string ToString()
        {
            return this.ProductName;
        }
        // "Category.cs" 'deyim...
    }
}
