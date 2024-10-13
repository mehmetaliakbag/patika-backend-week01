# Kim Milyoner Olmak İster Oyun Uygulaması

Bu uygulama, "Kim Milyoner Olmak İster?" oyununu basit bir konsol uygulaması şeklinde simüle eder. Oyuncular, üç sorudan ikisini doğru yanıtlayarak oyunu kazanmayı hedeflerler.

## Kullanılan Teknolojiler

- **C#**
- **.NET (Konsol Uygulaması)**

## Oyun Kuralları

1. Oyuncu, toplamda 3 soru ile karşılaşır.
2. İlk iki sorunun doğru cevapları, oyunun kazanılması için gereklidir.
3. Yanlış cevap durumunda, oyuncu elenir.
4. Doğru cevap verildiğinde, kullanıcıya tebrik mesajı gösterilir.

## Kod

Aşağıda oyunun temel kodu yer almaktadır:

```csharp
// Oyun başlangıcı mesajı
Console.WriteLine("Kim Milyoner Olmak İster'e hoşgeldiniz." +
                  "\r\nOyun çok basit, 3 sorudan 2'sine doğru cevap vermelisiniz." +
                  "\r\nCevaplarınızı şık olarak belirtiniz, \nHadi başlayalım...");

// Doğru cevap sayısını tutan değişken
int counter = 0;

// Kullanıcıya ilk soruyu sorup şıklardan birini seçmesini istiyoruz.

// 1. Soru
Console.Write("\r\nDünyanın en büyük okyanusu hangisidir?" +
              "\r\nA) Atlantik Okyanusu" +
              "\r\nB) Pasifik Okyanusu" +
              "\r\nCevap: ");

string answer1 = Console.ReadLine().ToLower(); // Kullanıcının cevabını al ve küçük harfe çevir

// Cevap kontrolü
if (answer1 == "b")
{
    Console.WriteLine("Tebrikler, doğru cevap verdiniz.");
    Console.WriteLine("\nYarışmayı kazandınız, artık milyonersiniz!");
    counter++; // Doğru cevap sayısını arttır
}
else
{
    Console.WriteLine("Maalesef, yanlış cevap.");
}

// 2. Soru
Console.Write("\r\nHangi gezegen \"Kırmızı Gezegen\" olarak bilinir?" +
              "\r\nA) Mars" +
              "\r\nB) Venüs" +
              "\r\nCevap: ");

string answer2 = Console.ReadLine().ToLower(); // Kullanıcının cevabını al ve küçük harfe çevir

// Cevap kontrolü
if (answer2 == "a")
{
    Console.WriteLine("Tebrikler, doğru cevap verdiniz.");
    counter++; // Doğru cevap sayısını arttır
}
else
{
    Console.WriteLine("Maalesef, yanlış cevap.");
}

// 3. Sorunun sorulma koşulu
if (counter == 1)
{
    // 3. Soru
    Console.Write("\nHangisi \"En Hızlı\" kara canlısıdır?" +
                  "\nA) Aslan" +
                  "\nB) Çita" +
                  "\nCevap: ");

    string answer3 = Console.ReadLine().ToLower(); // Kullanıcının cevabını al ve küçük harfe çevir

    // Cevap kontrolü
    if (answer3 == "b")
    {
        Console.WriteLine("Tebrikler, doğru cevap verdiniz.");
        Console.WriteLine("\nYarışmayı kazandınız, artık milyonersiniz!");
        counter++; // Doğru cevap sayısını arttır
    }
    else
    {
        Console.WriteLine("Maalesef, yanlış cevap.");
        Console.WriteLine("Elendiniz!");
    }
}
else if (counter == 0)
{
    Console.WriteLine("Elendiniz!"); // 0 doğru cevap durumunda mesaj
}
```

### Çalıştırma Talimatları

C# geliştirme ortamını (örneğin, Visual Studio veya Visual Studio Code) kurun.

Yukarıdaki kodu bir .cs dosyasına yapıştırın (örneğin KimMilyonerOlmakIster.cs).

Uygulamayı çalıştırarak oyunu oynayın.

### İletişim

Herhangi bir soru veya geri dönüş için GitHub kullanıcı adım üzerinden iletişime geçebilirsiniz.

### Lisans

```css
Bu proje MIT lisansı altındadır. İstediğiniz gibi kullanabilir ve dağıtabilirsiniz.
```
