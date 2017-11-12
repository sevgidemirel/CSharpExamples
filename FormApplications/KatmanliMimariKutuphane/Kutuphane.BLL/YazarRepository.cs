using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Kutuphane.DAL;
using Kutuphane.DTO;

namespace Kutuphane.BLL
{
    public class YazarRepository
    {

        static KutuphaneDBEntities1 db = new KutuphaneDBEntities1();

        public static List<YazarDataSource> dataSourceTumYazarlar()
        {
            var sonuc = db.Yazarlars.Select(y => new YazarDataSource { YazarId = y.YazarId, AdiSoyadi = y.YazarAd + " " + y.YazarSoyad }).ToList();
            return sonuc;
        }

        public static List<YazarDTO> tumYazarlar()
        {

            var sonuc = db.Yazarlars.Select
                (y => new YazarDTO
                {
                    YazarId = y.YazarId,
                    YazarAdi = y.YazarAd,
                    YazarSoyad = y.YazarSoyad,
                    Ozgecmis = y.Ozgecmis
                }).ToList();

            return sonuc;
        }

        public void addYazar(YazarDTO y)
        {

            Yazarlar yazar = new Yazarlar
            {
                YazarAd = y.YazarAdi,
                YazarSoyad = y.YazarSoyad,
                Ozgecmis = y.Ozgecmis

            };

            db.Yazarlars.Add(yazar);
            db.SaveChanges();
        }

        public void updateYazar(YazarDTO y)
        {

            var result = db.Yazarlars.SingleOrDefault(yz => yz.YazarId == y.YazarId);

            if (result != null)
            {
                result.YazarAd = y.YazarAdi;
                result.YazarSoyad = y.YazarSoyad;
                result.Ozgecmis = y.Ozgecmis;
                db.SaveChanges();
            }
        }

        public static void deleteYazar(YazarDTO y)
        {
            var yazar = db.Yazarlars.First(yz => yz.YazarId == y.YazarId);

            db.Yazarlars.Remove(yazar);

            db.SaveChanges();
        }


    }

}

