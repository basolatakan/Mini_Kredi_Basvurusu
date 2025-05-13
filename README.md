**Kullanılan Teknolojiler;**
- MVC Mimarisi
- ViewBag/ViewData
- Razor
- Form yapılanması(Kullanıcıdan veri almak için)
- Tuple Nesne Post etme ve yakalama
- ModelBinding
- Modelstate(Serverside validation)
- ViewModel-DTO(Clientside validation)
- Layout yapılanması(RenderBody,RenderSection)
- ViewStart ve ViewImport dosyaları
- Linq
- Middleware
- Dependency Injection


📄 **İŞ ANALİZİ DÖKÜMANI Proje Adı: MiniKredi Başvuru Ekranı**

🎯 AMAÇ: Kullanıcıların online ortamda temel bilgilerle kredi başvurusu yapabilecekleri bir form ekranı hazırlanacak. Kullanıcı bu formu doldurduğunda, sistem başvuru durumunu bir mesaj olarak ekranda gösterecek.

🧩 GENEL KAPSAM: Kullanıcı bir kredi başvuru formu dolduracak. Formda isim, soyisim, maaş bilgisi ve kredi tutarı yer alacak. Sistem, girilen bilgilere göre başvurunun onaylanıp onaylanmadığını belirleyecek (örneğin maaşın, kredi tutarına oranı yetersizse reddedilecek). Sonuç kullanıcıya ekranda gösterilecek.

📌 **FORMDAKİ ALANLAR:**
Alan	Zorunlu	Tür
Ad	Evet	string
Soyad	Evet	string
Aylık Net Maaş	Evet	decimal
Talep Edilen Kredi Tutarı	Evet	decimal

⚙️ **İŞ KURALLARI:**
Eğer maaş, kredi tutarının %30’undan azsa, başvuru reddedilir.
Aksi halde başvuru onaylanır.
Mesaj şu şekilde olmalı: Onaylıysa: "Sayın [Ad] [Soyad], başvurunuz onaylandı." Reddedildiyse: "Sayın [Ad] [Soyad], başvurunuz reddedildi. Maaş yeterli değil."

🖥️ **TEKNİK DETAYLAR:**
Form POST olarak gönderilmeli.
IApplicationService isminde bir servis olacak, iş kuralı burada çalışacak.
Sonuç Controller’da alınacak ve ViewBag ya da ViewModel ile View’a taşınacak.

✅**TESLİMAT KRİTERLERİ:**
Form düzgün çalışmalı, zorunlu alanlar boş geçilmemeli.
Kurallar birebir uygulanmalı.
Kullanıcıya gösterilen mesaj beklentilere uygun olmalı.
Kod DI mantığına uygun olmalı.
Görsel olarak sade ama düzenli bir View tercih edilmeli.
