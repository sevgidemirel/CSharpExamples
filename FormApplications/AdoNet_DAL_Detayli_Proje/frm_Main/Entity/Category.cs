using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Main.Entity
{
    // 5. Product.cs'den geldim ...
    public class Category : Entity
    {
        // public int CategoryId { get; set; }
        // ID -> CategoryId kalıtımdan Entity üzerinden gelecek ...
        // -------------------------------------------------------
        // prop + tab + tab
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string ToString() 
        {
            return this.CategoryName;
            //return this.Id.ToString();
        }
    }
    // "Supplier.cs" 'deyim...
}
