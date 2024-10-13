//1.Konsola "Merhaba Dünya" yazdıran bir program yazın.

Console.WriteLine("Merhaba Dünya");

Console.ReadKey();
Console.WriteLine("\r\n----------------\r\n");

//2.Kullanıcıdan iki tam sayı alın ve bu sayıların toplamını konsola yazdırın.
Console.WriteLine("Toplama İşlemi");
Console.Write("İlk sayı: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayı: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 + number2;
Console.WriteLine($"Toplam: {result}");

Console.ReadKey();
Console.WriteLine("\r\n----------------\r\n");

//3.Kullanıcıdan yaşını isteyin. Eğer yaş 18 veya daha büyükse "Yetişkinsiniz" yazdırın, aksi takdirde "Çocuksunuz" yazdırın.

Console.Write("Yaşınız: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(age >= 18 ? "Yetişkinsiniz" : "Çocuksunuz");

Console.ReadKey();
Console.WriteLine("\r\n----------------\r\n");

//4.Kullanıcıdan bir tam sayı alın. Eğer sayı çift ise "Çift sayıdır" yazdırın, tek ise "Tek sayıdır" yazdırın.

Console.Write("Bir sayı girin (Tek/Çift): ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((number % 2 == 0 || number == 0) ? "Çift sayıdır" : "Tek sayıdır");

Console.ReadKey();
Console.WriteLine("\r\n----------------\r\n");

//5.Kullanıcıdan bir sıcaklık değeri alın (Celsius cinsinden). Eğer sıcaklık 0'dan küçükse "Donuyor", 0 ile 30 arasında ise "Normal", 30'dan büyükse "Sıcak" yazdırın

Console.Write("Celcius cinsinden sıcaklık değerini girin: ");

int degree = Convert.ToInt32(Console.ReadLine());

if(degree < 0)
    Console.WriteLine("Donuyor");
else if(degree < 31)
    Console.WriteLine("Normal");
else
    Console.WriteLine("Sıcak");

Console.ReadKey();
Console.WriteLine("\r\n----------------\r\n");

//6.Kullanıcıdan 1 ile 7 arasında bir sayı alın. Bu sayı günlerden birini temsil ediyor. Sayıya göre "Pazartesi", "Salı", vb. gün adlarını yazdırın.
//Geçersiz bir sayı girildiğinde "Geçersiz gün" yazdırın.

Console.Write("Bir gün girin (1 - 2...7): ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;

    case 2: 
        Console.WriteLine("Salı");
        break;

    case 3:
        Console.WriteLine("Çarşamba");
        break;

    case 4:
        Console.WriteLine("Perşembe");
        break;

    case 5:
        Console.WriteLine("Cuma");
        break;

    case 6:
        Console.WriteLine("Cumartesi");
        break;

    case 7:
        Console.WriteLine("Pazar");
        break;

    default:
        Console.WriteLine("Geçersiz gün");
        break ;
}

Console.ReadKey();
Console.WriteLine("\r\n----------------\r\n");

//7.Kullanıcıdan bir not(0-100 arasında) alın.Notun aralığına göre "Başarılı", "Orta", "Başarısız" yazdırın. (0-60 başarısız, 61-80 orta, 81-100 başarılı)

Console.Write("Notunuzu girin: ");
int scores = Convert.ToInt32(Console.ReadLine());

if(scores > 80)
    Console.WriteLine("Başarılı");
else if(scores > 60)
    Console.WriteLine("Orta");
else
    Console.WriteLine("Başarısız");

Console.ReadKey();
Console.WriteLine("\r\n----------------\r\n");

//8.Kullanıcıdan bir ay numarası (1-12) alın ve bu ayın kaç gün olduğunu yazdırın. Şubat ayı için 28 gün, diğer aylar için gün sayısını kontrol edin.

Console.Write("Bir ay girin (1 - 2 ... 12): ");
int month = Convert.ToInt32(Console.ReadLine());

switch(month)
{
    case 2:
        Console.WriteLine("28 Gün");
        break;

    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("30 Gün");
        break;

    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("31 Gün");
        break;

    default:
        Console.WriteLine("Geçersiz gün");
        break ;
}

Console.ReadKey();
Console.WriteLine("\r\n----------------\r\n");

//9.Kullanıcıdan bir şifre isteyin. Eğer şifre "12345" ise "Giriş Başarılı" yazdırın, değilse "Giriş Başarısız" yazdırın.

string myPassword = "12345";

Console.Write("Şifrenizi girin: ");
string password = Console.ReadLine();

Console.WriteLine(myPassword == password ? "Giriş Başarılı" : "Giriş Başarısız");

Console.ReadKey();
Console.WriteLine("\r\n----------------\r\n");

//10.Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın. Seçilen işleme göre sonucu hesaplayın ve yazdırın. Eğer geçersiz bir işlem girilirse "Geçersiz işlem" yazdırın.

Console.Write("İlk sayısı girin: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayısı girin: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Yapmak istediğiniz işlemi seçin (+; -, *, /): ");
string selectedOperator = Console.ReadLine();

switch(selectedOperator)
{
    case "+":
        Console.WriteLine($"{num1} {selectedOperator} {num2} = {num1 + num2}");
        break;

    case "-":
        Console.WriteLine($"{num1} {selectedOperator} {num2} = {num1 - num2}");
        break;

    case "*":
        Console.WriteLine($"{num1} {selectedOperator} {num2} = {num1 * num2}");
        break;

    case "/":
        Console.WriteLine($"{num1} {selectedOperator} {num2} = {num1 / num2}");
        break;

    default :
        Console.WriteLine("Geçersiz işlem");
        break ;
}

Console.ReadKey();
