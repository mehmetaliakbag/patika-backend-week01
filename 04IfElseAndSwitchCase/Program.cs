// Kullanıcıya mevcut ürünleri listeleyip bir seçim yapmasını isteyeceğiz.

// Kullanıcıya mevcut ürünleri listeleyip bir seçim yapmasını isteyeceğiz.
Console.WriteLine("Rüya Manavına Hoşgeldiniz:" +
                 "\nElma = 2 TL" +
                 "\nArmut = 3 TL" +
                 "\nÇilek = 2 TL" +
                 "\nMuz = 3 TL" +
                 "\nDiğer tüm meyveler = 4 TL");

Console.Write("\nHangi meyveyi satın almak istersiniz? (Elma\\Armut\\Çilek\\Muz\\Diğer): ");

string fruit = Console.ReadLine().ToLower(); // Kullanıcının girdiğini küçük harfe çeviriyoruz
int price; // Seçilen meyvenin fiyatını tutacak değişken

// Switch-Case ile tercih edilen meyvenin fiyatını belirliyoruz
switch (fruit)
{
    case "elma":
        price = 2;
        break;
    case "armut":
        price = 3;
        break;
    case "çilek":
        price = 2;
        break;
    case "muz":
        price = 3;
        break;
    default:
        price = 4; // Diğer meyveler için varsayılan fiyat
        break;
}

// Alışveriş tutarını ekrana yazdırıyoruz
Console.WriteLine($"\r\nSeçtiğiniz meyvenin fiyatı {price} TL");

// If-Else ile tercih edilen meyvenin fiyatını belirliyoruz

if (fruit == "elma")
{
    price = 2;
}
else if (fruit == "armut")
{
    price = 3;
}
else if (fruit == "çilek")
{
    price = 2;
}
else if (fruit == "muz")
{
    price = 3;
}
else
{
    price = 4;
}

// Alışveriş tutarını ekrana yazdırıyoruz
Console.WriteLine($"\r\nSeçtiğiniz meyvenin fiyatı {price} TL");


/*
 * Eğer kontrol edilecek durum sayısı fazlaysa, if-else yapısı karmaşık hale gelebilir.
 * Bu durum, kodun okunabilirliğini azaltır ve hata yapma olasılığını artırır.
 * 
 * Bu gibi durumlarda switch-case yapısı daha uygun bir çözümdür. 
 * Hem kodu daha düzenli hale getirir, hem de birden fazla durumu kontrol etmeyi kolaylaştırır.
 */