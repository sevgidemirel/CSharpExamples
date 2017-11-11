using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Entity
{
    public class Customers : BaseType
    {
        public Customers()
        {
            this.CreateDate = DateTime.Now;
     //       this.Id = Convert.ToInt32(Guid.NewGuid());
        }

        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool? Gender { get; set; } // ? nullable ile boş geçme olayı izin verilir.
        public string PhotoPath { get; set; }




    }
}
