// Oyun başlangıcı mesajı
Console.WriteLine("Kim Milyoner Olmak İster'e hoşgeldiniz." +
                  "\r\nnOyun çok basit, 3 sorudan 2'sine doğru cevap vermelisiniz." +
                  "\r\nCevaplarınızı şık olarak belirtiniz, \nHadi başlıyalım...");

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

// 3. Sorunun sorulma koşulu sağlanmıyorsa
else if (counter == 0)
{
    Console.WriteLine("Elendiniz!"); // 0 doğru cevap durumunda mesaj
}


