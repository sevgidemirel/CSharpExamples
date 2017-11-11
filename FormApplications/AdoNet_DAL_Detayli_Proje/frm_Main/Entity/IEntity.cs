using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Main.Entity
{
    // 2. Load'dan geldim.
    public interface IEntity
    {
        // Veritabanımızda Tüm Tablolarda ortak olan alan -> ID veya CreatedDate (YaratılmaTarihi) için kendime bir AraYüz (InterFace) tanımlıyorum ... (Yer Açtım.)

        // şuanda bir tablom (Products) var ancak başka tablolarda da mutlaka ID olacağından bu sınıf benim ana sınıfım (base class) olacaktır ve hepsinde de bu sınıfı kullanacağım ...

        int Id { get; set; }

        // "Entity.cs" class'ındayım ...
    }
}
