using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Main.Entity
{
    // 3. IEntity'den geldim ...
    public class Entity : IEntity // InterFace'den kalıtım aldırdım ve bu sayede ID'ye hükmedebileceğim ...
    {
        private int _Id;
        public int Id
        {
            set
            {
                this._Id = value;
            }
            get
            {
                return this._Id;
            }           
        }

        // "Product.cs" 'deyim.
    }
}
