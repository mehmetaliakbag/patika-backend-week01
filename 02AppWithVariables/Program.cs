Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz.");

// T.C. Kimlik Numarası girişi
Console.Write("T.C. Kimlik Numarası: ");
string noTc = Console.ReadLine(); // Kullanıcının kimlik numarasını alıyoruz

// İsim girişi
Console.Write("Ad: ");
string name = Console.ReadLine(); // Kullanıcının adını alıyoruz

// Soyad girişi
Console.Write("Soyad: ");
string surname = Console.ReadLine(); // Kullanıcının soyadını alıyoruz

// Telefon numarası girişi (statik bir değer)
Console.Write("Telefon Numarası: ");
string noPhone = Console.ReadLine(); // Kullanıcının telefon numarasını alıyoruz

// Yaş girişi
Console.Write("Yaş: ");
string age = Console.ReadLine(); // Kullanıcının yaşını alıyoruz (şu an kullanılmıyor)

// İlk alınan ürünün fiyatı girişi (aritmetik işlem için double tipi)
Console.Write("İlk Aldığı Ürünün Fiyatı: ");
double price1 = Convert.ToDouble(Console.ReadLine()); // İlk ürünün fiyatını alıyoruz

// Son alınan ürünün fiyatı girişi (aritmetik işlem için double tipi)
Console.Write("Son Aldığı Ürünün Fiyatı: ");
double price2 = double.Parse(Console.ReadLine()); // Son ürünün fiyatını alıyoruz

// Toplam harcama hesaplama
double total = price1 + price2; // İki ürünün fiyatlarını topluyoruz

// %10 Patika Puan hesaplama
double result = total / 10; // Toplam harcamanın %10'unu hesaplıyoruz


Console.WriteLine($"\r\n{noTc} T.C. kimlik numaralı {name} {surname} isimli kişi için kayıt oluşturulmuştur." +
                  $"\r\n{noPhone} telefon numarasına bildirim mesajı gönderilmiştir." +
                  $"\r\n{total} toplam harcama karşılığı kazanılan %10 Patika Puan miktarı -> {result} TL'dir.");


Console.ReadKey();