using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDeviceCreator
{
    public  abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; set; }
        public string SeriNo { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine("\nÜretim Tarihi: " + DateTime.Now);
            Console.WriteLine("Seri No: " + SeriNo);
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Açıklama: " + Aciklama);
            Console.WriteLine("İşletim Sistemi: " + IsletimSistemi);          
        }

        public abstract void UrunAdiGetir();

       



    }
}
