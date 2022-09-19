//Hata Yönetimi için kullnılacak Kalıp

// { Hataya sebebiyet verme ihtimali olan kod }
try
{
    System.Console.WriteLine("Bir sayı giriniz:");
    int sayi = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Sayınız " + sayi);   
}
// { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }
catch(ArgumentNullException)
{
    System.Console.WriteLine("!!!HATA!!!    Hata mesajı: BOŞ değer girdiniz.");
}
catch(FormatException)
{
    System.Console.WriteLine("!!!HATA!!!    Hata mesajı: Veri tipi uygun DEĞİL.");
}
catch(OverflowException)
{
    System.Console.WriteLine("!!!HATA!!!    Hata mesajı: Veri Boyutu uygun DEĞİL.");
}
// { Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }
finally
{
    System.Console.WriteLine("Hata Denemesi Testi BİTTİ");
}