# Rüya Manavı Uygulaması

Bu uygulama, kullanıcıya mevcut meyveleri listeleyip, bir seçim yapmasını sağlayarak seçilen meyvenin fiyatını gösterir. 

Kullanıcı, meyve seçiminin ardından fiyat bilgisini alır.

## İçindekiler

- Kurulum
- Kullanım
- Kod Açıklaması
- Katkıda Bulunma
- Lisans

### Kurulum

Bu projeyi çalıştırmak için .NET ortamına ihtiyacınız var. Aşağıdaki adımları izleyerek projeyi çalıştırabilirsiniz:

.NET SDK'nın yüklü olduğundan emin olun. [Buradan indirebilirsiniz.](https://dotnet.microsoft.com/en-us/download)

Uygulama kodunu bir .cs dosyasına yapıştırın (örneğin RuyaManav.cs).

Terminal veya komut istemcisinde projenin bulunduğu dizine gidin.

Aşağıdaki komutu kullanarak uygulamayı derleyin ve çalıştırın:

```bash
dotnet run RuyaManav.cs
```

### Kullanım
Uygulama çalıştığında, konsolda mevcut meyveler ve fiyatları listelenecektir.

İstediğiniz meyveyi yazın ve Enter tuşuna basın.

Uygulama, seçtiğiniz meyvenin fiyatını gösterecektir.

### Kod Açıklaması
Console.WriteLine(...): Kullanıcıya mevcut meyveleri ve fiyatlarını listeler.

Console.ReadLine().ToLower(): Kullanıcının girdiği meyve adını küçük harfe çevirir.

switch: Kullanıcının seçtiği meyveye göre fiyatı belirler.

if-else: Alternatif olarak, meyve seçimini kontrol eder ve fiyatı belirler.

Console.WriteLine(...): Seçilen meyvenin fiyatını ekrana yazdırır.

###### Neden Switch-Case?
Eğer kontrol edilecek durum sayısı fazlaysa, if-else yapısı karmaşık hale gelebilir. Bu durum, kodun okunabilirliğini azaltır ve hata yapma olasılığını artırır. switch-case yapısı, hem kodu daha düzenli hale getirir hem de birden fazla durumu kontrol etmeyi kolaylaştırır.

### Katkıda Bulunma
Bu projeye katkıda bulunmak isterseniz, öneri veya hata bildirimlerinizi paylaşabilirsiniz.

###### Lisans

```css
Bu proje MIT lisansı altındadır. İstediğiniz gibi kullanabilir ve dağıtabilirsiniz.
```

