# MultiCatcher

![C#](https://img.shields.io/badge/C%23-7.3-239120?logo=c-sharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.5-512BD4?logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-0078D6)
![Lisans](https://img.shields.io/badge/Lisans-MIT-green)

## Neden Bu Proje?
MultiCatcher, verilen web sayfalarının kaynak kodunu tarayarak e-posta adresi ve Türkiye formatındaki telefon numaralarını hızlıca çıkarmayı hedefleyen bir masaüstü aracıdır; özellikle OSINT, içerik denetimi ve toplu iletişim bilgisi doğrulama gibi senaryolarda manuel kopyala-yapıştır yükünü azaltarak zaman kazandırır.

## Mimari / Özellikler
- Windows Forms tabanlı tek ekranlı kullanım deneyimi.
- Birden fazla URL için toplu tarama ve ilerleme takibi.
- Regex tabanlı e-posta ve telefon numarası ayrıştırma.
- Bulunan verileri tekilleştirip listeleme.
- Sonuçları `.txt` dosyasına dışa aktarma.
- Ardışık sayfa üretimi (URL şablonu ile seri link ekleme).

## Hızlı Başlangıç
> Not: Proje **.NET Framework 4.5** hedefler ve Windows ortamında çalıştırılır.

```powershell
git clone https://github.com/furkanisikay/MultiCatcher.git
cd MultiCatcher
msbuild .\GetEMail.sln /p:Configuration=Release
.\GetEMail\bin\Release\GetEMail.exe
```

## Ortam Kurulumu
1. **Visual Studio 2019/2022** (".NET desktop development" iş yükü) kurun.
2. Gerekirse **.NET Framework 4.5 Developer Pack** kurun.
3. Projeyi Visual Studio ile açın: `GetEMail.sln`.
4. `Debug` veya `Release` ile derleyip çalıştırın.

## Güvenlik Denetimi Özeti
Kod tabanında yapılan taramada aşağıdakiler kontrol edilmiştir:
- Hardcoded şifre / API anahtarı
- Gizli token veya bağlantı dizesi
- Yerel kullanıcı yolu (örn. `C:\Users\...`)

Mevcut sürümde doğrudan gömülü sır bilgisi veya yerel geliştirici yolu bulunmamıştır.

## Kritik Refactoring Önerileri
1. **`GetEMail/Funcs.cs` içinde boş `catch` blokları kaldırılmalı**
   - Hata nedenini yutan `catch { return false; }` blokları, teşhisi zorlaştırır.
2. **`HttpWebRequest` yerine `HttpClient` tercih edilmeli**
   - Modern API ile kaynak yönetimi ve hata kontrolü iyileşir.
3. **UI ve iş mantığı ayrıştırılmalı**
   - `MultiCatcher.cs` içinde tarama/parse işlemleri servis sınıfına taşınarak test edilebilirlik artırılır.

## Katkı
Katkı adımları için [CONTRIBUTING.md](./CONTRIBUTING.md) dosyasına bakın.

## Lisans
Bu proje [MIT](./LICENSE) lisansı ile lisanslanmıştır.
