using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DTO;
using Kutuphane.DAL;

namespace Kutuphane.BLL
{
    public class KitapRepository
    {
        static KutuphaneDBEntities1 db = new KutuphaneDBEntities1();

        public static List<KitapDTO> getKitap(int yazarId)
        {

            var sonuc = db.Kitaplars.Where(k => k.YazarId == yazarId).Select(k => new KitapDTO
            {
                KitapAdi = k.KitapAdi,
                KitapKonusu = k.KitapKonusu,
                YayinTarihi = k.YayinTarihi,
                Yayinevi = k.Yayinevi,
                KitapId = k.KitapId

            }
            ).ToList();

            return sonuc;
        }

        public void addKitap(KitapDTO k)
        {

            Kitaplar kitap = new Kitaplar
            {
                KitapAdi = k.KitapAdi,
                KitapKonusu = k.KitapKonusu,
                Yayinevi = k.Yayinevi,
                YayinTarihi = k.YayinTarihi,
                YazarId = k.YazarId
            };

            db.Kitaplars.Add(kitap);
            db.SaveChanges();

        }

        public void updateKitap(KitapDTO k)
        {
            var result = db.Kitaplars.SingleOrDefault(kt => kt.KitapId == k.KitapId);

            if (result != null)
            {
                result.KitapAdi = k.KitapAdi;
                result.KitapKonusu = k.KitapKonusu;
                result.YayinTarihi = k.YayinTarihi;
                result.Yayinevi = k.Yayinevi;
                result.YazarId = k.YazarId;
                db.SaveChanges();
            }
        }

        public static void deleteKitap(KitapDTO k)
        {
            var snc = db.Kitaplars.First(kt => kt.KitapId == k.KitapId);

            db.Kitaplars.Remove(snc);

            db.SaveChanges();
        }

    }
}
