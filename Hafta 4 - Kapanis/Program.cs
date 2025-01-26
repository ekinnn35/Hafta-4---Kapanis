using System;

abstract class BaseMakine
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string IsletimSistemi { get; set; }

    public BaseMakine()
    {
        UretimTarihi = DateTime.Now;
    }

    public virtual void BilgileriYazdir()
    {
        Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
        Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
        Console.WriteLine($"Ad: {Ad}");
        Console.WriteLine($"Açıklama: {Aciklama}");
        Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
    }

    public abstract void UrunAdiGetir();
}

class Telefon : BaseMakine
{
    public bool TrLisansli { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"TR Lisanslı mı?: {(TrLisansli ? "Evet" : "Hayır")}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
    }
}

class Bilgisayar : BaseMakine
{
    private int usbGirisSayisi;
    public int UsbGirisSayisi
    {
        get { return usbGirisSayisi; }
        set
        {
            if (value == 2 || value == 4)
            {
                usbGirisSayisi = value;
            }
            else
            {
                Console.WriteLine("Geçersiz USB giriş sayısı! Değer 2 veya 4 olmalıdır.");
                usbGirisSayisi = -1;
            }
        }
    }

    public bool BluetoothVarMi { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"USB Giriş Sayısı: {usbGirisSayisi}");
        Console.WriteLine($"Bluetooth Var Mı?: {(BluetoothVarMi ? "Evet" : "Hayır")}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız.");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Telefon telefon = new Telefon();

                Console.Write("Seri Numarası: ");
                telefon.SeriNumarasi = Console.ReadLine();

                Console.Write("Ad: ");
                telefon.Ad = Console.ReadLine();

                Console.Write("Açıklama: ");
                telefon.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                telefon.IsletimSistemi = Console.ReadLine();

                Console.Write("TR Lisanslı mı? (true/false): ");
                telefon.TrLisansli = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("\nÜrün başarıyla üretildi!\n");
                telefon.BilgileriYazdir();
                telefon.UrunAdiGetir();
            }
            else if (secim == "2")
            {
                Bilgisayar bilgisayar = new Bilgisayar();

                Console.Write("Seri Numarası: ");
                bilgisayar.SeriNumarasi = Console.ReadLine();

                Console.Write("Ad: ");
                bilgisayar.Ad = Console.ReadLine();

                Console.Write("Açıklama: ");
                bilgisayar.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                bilgisayar.IsletimSistemi = Console.ReadLine();

                Console.Write("USB Giriş Sayısı (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bluetooth Var Mı? (true/false): ");
                bilgisayar.BluetoothVarMi = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("\nÜrün başarıyla üretildi!\n");
                bilgisayar.BilgileriYazdir();
                bilgisayar.UrunAdiGetir();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim! Lütfen 1 veya 2 tuşlayın.");
                continue;
            }

            Console.Write("Başka bir ürün üretmek ister misiniz? (E/H): ");
            string devam = Console.ReadLine().ToUpper();

            if (devam != "E")
            {
                Console.WriteLine("İyi günler dileriz!");
                break;
            }
        }
    }
}
