// Kullanıcıdan bir sayı girmesini istiyoruz.
Console.Write("Bir sayı girin: ");

// Kullanıcının girdiği değeri int tipine çeviriyoruz
int num = Convert.ToInt32(Console.ReadLine());


// Girdiği sayının 10'dan büyük, küçük veya eşit olup olmadığını kontrol ediyoruz
if (num > 10)
{ 
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");  // Sayı 10'dan büyükse
}
else if (num < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür."); // Sayı 10'dan küçükse
}
else
{
    Console.WriteLine("Girilen sayı 10'dur.");  // Sayı 10'a eşitse
}

// Girilen sayının pozitif mi negatif mi olduğunu kontrol ediyoruz
if (num % 2 == 0 || num == 0)
{
    Console.WriteLine("Girilen sayı çifttir.");  // Sayı çiftse
}
else
{
    Console.WriteLine("Girilen sayı tektir."); // Sayı tekse
}

Console.ReadKey();