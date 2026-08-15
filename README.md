# 🚗 UdemyCarBook - Onion Architecture & CQRS Tabanlı Araç Kiralama Portalı

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-MVC_%26_Web_API-512BD4?style=for-the-badge&logo=dotnet)
![Architecture](https://img.shields.io/badge/Architecture-Onion_%2F_Clean-orange?style=for-the-badge)
![MediatR](https://img.shields.io/badge/MediatR-CQRS-purple?style=for-the-badge)
![SignalR](https://img.shields.io/badge/SignalR-RealTime-blue?style=for-the-badge)
![JWT](https://img.shields.io/badge/JWT-Authentication-black?style=for-the-badge)
![SQL Server](https://img.shields.io/badge/SQL_Server-Database-CC292B?style=for-the-badge&logo=microsoftsqlserver)

**UdemyCarBook**, kurumsal standartlarda **Onion (Soğan) Mimarisi** ve gelişmiş tasarım desenleri (Design Patterns) uygulanarak geliştirilmiş, uçtan uca modern bir "Araç Kiralama" (BookCar) yönetim sistemidir.

Proje; Web API tabanlı backend mimarisi, dinamik frontend entegrasyonu, canlı veri akışları ve güvenli yetkilendirme mekanizmaları ile gerçek hayat sektör senaryolarına birebir uygun olarak kurgulanmıştır.

---

## 📑 İçindekiler

* 📌 [Öne Çıkan Özellikler](#-öne-çıkan-özellikler)
* 🏗️ [Mimari ve Tasarım Desenleri]
* 📊 [Pivot Table & Canlı İstatistikler (SignalR)](#-pivot-table--canlı-istatistikler-signalr)
* 🔑 [Güvenlik ve Kimlik Doğrulama (JWT)](#-güvenlik-ve-kimlik-doğrulama-jwt)
* 🚀 [Kurulum ve Başlangıç](#-kurulum-ve-başlangıç)
* 🛠️ [Teknoloji Yığını](#️-teknoloji-yığını)

---

## 📌 Öne Çıkan Özellikler

### 🏎️ Araç & Lokasyon Yönetimi ve Filtreleme
* Teslim alma/bırakma noktalarına, vites, yakıt tipi ve marka bazlı dinamik araç arama ve listeleme.
* Araçların günlük, haftalık ve aylık bazda fiyatlandırılması ve teknik özellik (Feature) eşleştirmeleri.

### 📝 Blog, Yorum & Değerlendirme Sistemi
* Sektörel blog içerikleri, yazar detayları, etiket bulutu (Tag Cloud) ve araçlara özel kullanıcı yorumları/puanlama sistemi.
* **FluentValidation** ile sunucu tarafında veri doğrulama ve DTO katmanı kontrolü.

### 👑 Admin Paneli & Area Yapısı
* Modüler **Area** mimarisi ile ayrıştırılmış; Marka, Araç, Lokasyon, Referans, Hizmet ve İletişim mesajlarının yönetildiği admin paneli.

## 🏗️ Mimari ve Tasarım Desenleri

Proje, katmanlar arası bağımlılıkları en aza indiren ve esnekliği artıran **Onion Architecture** üzerine kurulmuştur:

* **CQRS Pattern:** Okuma (Query) ve yazma (Command) operasyonlarının mantıksal olarak ayrıştırılması.
* **Mediator Pattern:** `MediatR` kütüphanesi kullanılarak nesneler arasındaki bağımlılıkların azaltılması ve isteklerin merkezi yönetimi.
* **Repository Pattern:** Veri erişim katmanının soyutlanarak `EF Core` ve `Dapper` ile esnek bir şekilde kullanılması.


## 📊 Pivot Table & Canlı İstatistikler (SignalR)
Pivot Table Yapısı: Araç fiyatlandırmaları ve özellik matrislerinin dinamik olarak raporlanması ve SQL Pivot sorguları ile anlamlandırılması.

SignalR ile Real-Time Veri: WebSocket altyapısı kullanılarak admin paneli üzerindeki istatistiklerin (toplam araç, en pahalı/ucuz araç, lokasyon oranları vs.) sayfa yenilenmeden canlı güncellenmesi.

### 🔑 Güvenlik ve Kimlik Doğrulama (JWT)
JSON Web Token (JWT): API katmanındaki endpoint'lerin güvenliğini sağlayan token tabanlı kimlik doğrulama mimarisi.

Rol Tabanlı Yetkilendirme: AppUser ve AppRole yapıları ile güvenli kullanıcı kayıt, giriş ve yetki kontrolleri.

## 🛠️ Teknoloji Yığını
Backend: C#, .NET 8.0, ASP.NET Core Web API, ASP.NET Core MVC (Admin Area)

Mimari & Desens: Onion Architecture, CQRS Pattern, Mediator Pattern (MediatR), Repository Pattern, DTO Pattern

Real-Time & Security: SignalR, JWT (JSON Web Token)

Database & ORM: SQL Server, Entity Framework Core, Dapper (Pivot Table Queries)

Validation & Utilities: FluentValidation, AutoMapper, Newtonsoft.Json

Frontend: Bootstrap 5, Razor Views, HTML5, CSS3, JavaScript, jQuery


### FOTOĞRAFLAR
<img width="1920" height="1080" alt="carbook1" src="https://github.com/user-attachments/assets/f06d529f-731e-4d92-87cd-48bc35d357ee" />
<img width="1920" height="1080" alt="caarbook2" src="https://github.com/user-attachments/assets/1b054565-3f7a-4bca-8e80-21ad0a9f0b82" />
<img width="1920" height="1080" alt="carbook2" src="https://github.com/user-attachments/assets/9a41ba14-9afa-429a-bd34-1c12e6337035" />
<img width="1920" height="1080" alt="carbook3" src="https://github.com/user-attachments/assets/c87f832f-094b-4744-99b1-5bd8aa7276e0" />
<img width="1920" height="1080" alt="carbook4" src="https://github.com/user-attachments/assets/2688e864-c98f-4bd1-95cb-3446ae6919de" />
<img width="1920" height="1080" alt="carbook5" src="https://github.com/user-attachments/assets/42489e13-b49c-47f4-8f92-277209a735a8" />
<img width="1920" height="1080" alt="carbook6" src="https://github.com/user-attachments/assets/5410f462-2aee-4ee5-9ff9-e3f5b5da4485" />
<img width="1920" height="1080" alt="carbook7" src="https://github.com/user-attachments/assets/b4babe8b-9921-43e1-9119-7aba1767ac61" />
<img width="1920" height="1080" alt="carbook8" src="https://github.com/user-attachments/assets/fadd7848-5450-4583-9cb2-40d448fcefe2" />
<img width="1920" height="1080" alt="carbook9" src="https://github.com/user-attachments/assets/5a8f099e-00de-4a63-87f7-5da13fe53ffd" />
<img width="1920" height="1080" alt="carbook10" src="https://github.com/user-attachments/assets/d3db07f4-e61e-4351-a01e-ca87830ac65b" />
<img width="1920" height="1080" alt="carbook11" src="https://github.com/user-attachments/assets/a5321276-57b1-48e7-9348-fb0d25b2dd5f" />
<img width="1920" height="1080" alt="carbook12" src="https://github.com/user-attachments/assets/b71de014-a626-4134-8864-36b3933ee2a5" />
<img width="1920" height="1080" alt="carbook13" src="https://github.com/user-attachments/assets/929f7a72-e6aa-4f62-bece-ccca3deffde1" />
<img width="1920" height="1080" alt="carbook14" src="https://github.com/user-attachments/assets/89d5c34f-9e6c-4cfa-88c9-495cdc4aea8a" />



















