using System;
namespace SeyahatUygulamasi
{
    class Program
    {
static void Main(string[] args)
{
    tekrarPlanla();        // Kullanıcı yeniden tatil planlamak isterse uygulamayı bastan baslatmak icin fonksiyon tanımlıyoruz.
    
}
static void tekrarPlanla()
{
    int tutar = 0;
    // Kullanıcıdan Lokasyonu secmesini istiyoruz.(Fiyat belirterek)
Console.WriteLine("Lutfen gitmek istediginiz lokasyonu seciniz: ");

System.Console.WriteLine("1 - Bodrum(Paket Baslangic Fiyati 4000TL) ");

System.Console.WriteLine("2 - Marmaris(Paket Baslangic Fiyati 3000TL) ");

System.Console.WriteLine("3 - Çeşme(Paket Baslangic Fiyati 5000TL) ");

string secim = (Console.ReadLine().ToLower());
// Kullanıcının lokasyon secimini alıp sectigi lokasyona gore tutar degiskenine ucreti ekliyoruz.
switch (secim)
{
    case "bodrum":
    Console.WriteLine("Bodrum sectiniz");
    tutar+=4000;
    break;
    case "marmaris":
    System.Console.WriteLine("Marmaris sectiniz");
    tutar+=3000;
    break;
    case "cesme":
    Console.WriteLine("Cesme sectiniz");
    tutar += 5000;
    break;
    default:
    Console.WriteLine("Yanlis lokasyon girdiniz, Lutfen gecerli bir lokasyon giriniz!(Bodrum/Marmaris/Cesme)");
    secim = Console.ReadLine();
    break;
}
// Kac kisilik tatil planladıklarını sorup,  degeri bir degiskene atıyoruz ve sectikleri lokasyonda yapabilecekleri hakkinda biraz bilgi veriyoruz.
Console.WriteLine("Kac kisilik bir tatil planlamak istiyorsunuz? ");
int kisiSayisi = int.Parse(Console.ReadLine());
if (secim == "bodrum")
{
Console.WriteLine("Secim yaptiginiz icin tesekkurler.Iste bodrum tatilinde yapabilecekleriniz:\n plajlar ve Deniz Keyfi: Bodrum'un güzel plajlarında denize girebilir, güneşlenebilir ve su sporları yapabilirsiniz. Bitez, Gümüşlük ve Ortakent gibi popüler plajları ziyaret edebilirsiniz.Tarihi Yerler: Bodrum Kalesi, Antik Tiyatro ve Mausoleum gibi tarihi yerleri gezebilirsiniz. Ayrıca, Bodrum Sualtı Arkeoloji Müzesi de oldukça ilgi çekicidir.Gece Hayatı: Bodrum, canlı gece hayatı ile ünlüdür.Yat Turları: Günlük tekne turları ile Bodrum'un koylarını keşfedebilir, mavi tur deneyimi yaşayabilirsiniz.");
}
else if (secim == "marmaris")
{
Console.WriteLine("Secim yaptiginiz icin tesekkurler.Iste marmaris tatilinde yapabilecekleriniz: \n plajlar ve Deniz Keyfi: Bodrum'un güzel plajlarında denize girebilir, güneşlenebilir ve su sporları yapabilirsiniz.Tarihi Yerler: Bodrum Kalesi, Antik Tiyatro ve Mausoleum gibi tarihi yerleri gezebilirsiniz.Gece Hayatı: Bodrum, canlı gece hayatı ile ünlüdür. Barlar Sokağı'nda eğlenebilir, çeşitli barlar ve kulüplerde keyifli vakit geçirebilirsiniz.Yat Turları: Günlük tekne turları ile Bodrum'un koylarını keşfedebilir, mavi tur deneyimi yaşayabilirsiniz. Özellikle Kos ve Kalymnos gibi yakın Yunan adalarına yapılan turlar popülerdir.");
}
else
{
Console.WriteLine("Secim yaptiginiz icin tesekkurler.Iste cesme tatilinde yapabilecekleriniz:\n plajlar ve Deniz Keyfi: Bodrum'un güzel plajlarında denize girebilir, güneşlenebilir ve su sporları yapabilirsiniz. Bitez, Gümüşlük ve Ortakent gibi popüler plajları ziyaret edebilirsiniz.Tarihi Yerler: Bodrum Kalesi, Antik Tiyatro ve Mausoleum gibi tarihi yerleri gezebilirsiniz. Ayrıca, Bodrum Sualtı Arkeoloji Müzesi de oldukça ilgi çekicidir.Gece Hayatı: Bodrum, canlı gece hayatı ile ünlüdür. Barlar Sokağı'nda eğlenebilir, çeşitli barlar ve kulüplerde keyifli vakit geçirebilirsiniz.Yat Turları: Günlük tekne turları ile Bodrum'un koylarını keşfedebilir, mavi tur deneyimi yaşayabilirsiniz. Özellikle Kos ve Kalymnos gibi yakın Yunan adalarına yapılan turlar popülerdir.");
}
    // Kullanıcının secmek istedigi ulasim yolunu yazdırıyoruz ve cevabı bir degiskene atıyoruz ardından ulasim tutarinida tutar degiskenine ekliyoruz.
Console.WriteLine($"Sectiginiz {secim} Lokasyonuna Hangi Ulasim yolu ile gitmek istersiniz?");
Console.WriteLine("1- Kara Yolu (Kisi basi ulasim tutari gidis-donus 1500 TL)\n2- Hava yolu (Kisi basi ulasim tutari gidis-donus 4000TL)\nLutfen yukaridaki seceneklerden bir tanesini seciniz.(1 veya 2 tuslayarak)");
int ulasimYolu = int.Parse(Console.ReadLine());
switch (ulasimYolu)
{
    case 1:
    tutar += 1500;
    break;
    case 2:
    tutar += 4000;
    break;
    default:
    Console.WriteLine("Yanlis bir deger girdiniz.Lutfen 1 veya 2 olacak sekilde yeniden deger giriniz!");
    ulasimYolu = int.Parse(Console.ReadLine());
    break;
}
Console.WriteLine("Sectiginiz lokasyon, kisi sayisi ve ulasim yoluna gore toplam fiyat: "+ (tutar * kisiSayisi));
//Tatili tekrar planlamak isteyip istemediklerini sorup cevaba gore programı yeniden baslatiyoruz veya bitiriyoruz.
Console.WriteLine("Baska bir tatil planlamak istiyor musunuz?(Evet/Hayır)");
string tekrarPlanlaCevap = Console.ReadLine().ToLower();

if (tekrarPlanlaCevap =="evet")
{
    tekrarPlanla();
} 
else
{
    Console.WriteLine("Bizi sectiginiz icin tesekkurler... :) ");
}
}
}
}
