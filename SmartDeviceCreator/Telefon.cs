using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDeviceCreator
{
    public class Telefon : BaseMakine
    {
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine("\nTelefonunuzun Adı --> " + Ad);
        }
    }
}
