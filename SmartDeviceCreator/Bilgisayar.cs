using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SmartDeviceCreator
{
    public class Bilgisayar : BaseMakine
    {
        private int _usbGirisi;

        public int UsbGirisi
        {
            get
            {
                return _usbGirisi;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbGirisi = value;
                }
                else
                {
                    Console.WriteLine("USB Giriş Sayısı sadece 2 veya 4 olabilir. Varsayılan olarak -1 atanmıştır.");
                    _usbGirisi = -1;
                }
            }
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine("Usb Girişi : " + UsbGirisi);

        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine("\nBilgisayarınızın Adı --> " + Ad);
        }
    }
}
