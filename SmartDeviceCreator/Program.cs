using SmartDeviceCreator;

uretim:

Console.WriteLine("\nBir ürün üretmek için seçim yapınız.");
Console.WriteLine("1- Telefon");
Console.WriteLine("2- Bilgisayar");
Console.Write("Seçiminiz: ");
string secim = Console.ReadLine();

if (secim == "1")
{
    Telefon telefon = new Telefon();

    Console.Write("\nSeri No: ");
    telefon.SeriNo = Console.ReadLine();

    Console.Write("Ad: ");
    telefon.Ad = Console.ReadLine();

    Console.Write("Açıklama: ");
    telefon.Aciklama = Console.ReadLine();

    Console.Write("işletim Sistemi: ");
    telefon.IsletimSistemi = Console.ReadLine();

    telefon.BilgileriYazdir();

    telefon.UrunAdiGetir();
}
else if (secim == "2")
{
    Bilgisayar bilgisayar = new Bilgisayar();

    Console.Write("\nSeri No: ");
    bilgisayar.SeriNo = Console.ReadLine();

    Console.Write("Ad: ");
    bilgisayar.Ad = Console.ReadLine();

    Console.Write("Açıklama: ");
    bilgisayar.Aciklama = Console.ReadLine();

    Console.Write("İşletim Sistemi: ");
    bilgisayar.IsletimSistemi = Console.ReadLine();

    Console.Write("USB Giriş Sayısı: ");
    bilgisayar.UsbGirisi = Convert.ToInt32(Console.ReadLine());

    bilgisayar.BilgileriYazdir();

    bilgisayar.UrunAdiGetir();

}
else
{
    Console.WriteLine("Hatalı giriş yaptınız. Program sonlandırılıyor.");
    return;
}

Console.WriteLine("\nÜrün başarılı bir şekilde üretildi.");
Console.Write("Başka bir ürün üretmek istiyor musunuz? (Evet/Hayır): ");
string yeniUrun = Console.ReadLine().ToLower();

if (yeniUrun == "evet")
{
    goto uretim;
}
else if (yeniUrun == "hayır")
{
    Console.WriteLine("\nİyi günler! Uygulamadan çıkılıyor...");
}
else
{
    Console.WriteLine("Hatalı giriş yaptınız. Program sonlandırılıyor.");
}



