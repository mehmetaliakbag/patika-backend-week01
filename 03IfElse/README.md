# If - Else

*Bu uygulama, kullanıcıdan bir sayı alarak bu sayının belirli özelliklerini kontrol eder.*
*Kullanıcı girdiği sayının 10'dan büyük, küçük veya eşit olup olmadığını ve sayının çift mi tek mi olduğunu öğrenir.*

## İçindekiler
- Kurulum
- Kullanım
- Kod Açıklaması
- Katkıda Bulunma
- Lisans

### Kurulum

Bu projeyi çalıştırmak için .NET ortamına ihtiyacınız var. Aşağıdaki adımları izleyerek projeyi çalıştırabilirsiniz:

.NET SDK'nın yüklü olduğundan emin olun. [Buradan indirebilirsiniz.](https://dotnet.microsoft.com/en-us/download)
- Uygulama kodunu bir .cs dosyasına yapıştırın (örneğin SayiKontrol.cs).
- Terminal veya komut istemcisinde projenin bulunduğu dizine gidin.
- Aşağıdaki komutu kullanarak uygulamayı derleyin ve çalıştırın:

```bash
dotnet run SayiKontrol.cs
```

### Kullanım

Uygulama çalıştığında, konsolda "Bir sayı girin:" mesajı görünecektir.

İstediğiniz bir sayıyı girin ve Enter tuşuna basın.

Uygulama, girdiğiniz sayının 10'dan büyük, küçük veya eşit olduğunu ve sayının çift mi tek mi olduğunu belirtecektir.

#### Kod Açıklaması

Console.Write("Bir sayı girin: ");: Kullanıcıdan bir sayı girmesini ister.

Convert.ToInt32(Console.ReadLine());: Kullanıcının girdiği değeri int tipine çevirir.

İlk if yapısı, sayının 10'dan büyük, küçük veya eşit olduğunu kontrol eder.

İkinci if yapısı, sayının çift mi tek mi olduğunu kontrol eder.

Son olarak, Console.ReadKey(); ile kullanıcıdan bir tuşa basması beklenir.

###### Katkıda Bulunma
Bu projeye katkıda bulunmak isterseniz, öneri veya hata bildirimlerinizi paylaşabilirsiniz.

###### Lisans

```css
Bu proje MIT lisansı altındadır. İstediğiniz gibi kullanabilir ve dağıtabilirsiniz.
```
