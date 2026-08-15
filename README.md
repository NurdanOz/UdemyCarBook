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
* 🏗️ [Mimari ve Tasarım Desenleri](#️-mimari-ve-tasarım-desenleri)
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

---

## 🏗️ Mimari ve Tasarım Desenleri

Proje, katmanlar arası bağımlılıkları en aza indiren ve esnekliği artıran **Onion Architecture** üzerine kurulmuştur:

* **CQRS Pattern:** Okuma (Query) ve yazma (Command) operasyonlarının mantıksal olarak ayrıştırılması.
* **Mediator Pattern:** `MediatR` kütüphanesi kullanılarak nesneler arasındaki bağımlılıkların azaltılması ve isteklerin merkezi yönetimi.
* **Repository Pattern:** Veri erişim katmanının soyutlanarak `EF Core` ve `Dapper` ile esnek bir şekilde kullanılması.

```text
UdemyCarBook/
├── Core/
│   ├── UdemyCarBook.Domain/         # Entities ve Veritabanı Modelleri
│   └── UdemyCarBook.Application/    # CQRS Commands/Queries, MediatR Handlers, DTOs, Interfaces, FluentValidation
├── Infrastructure/
│   └── UdemyCarBook.Persistence/    # DbContext, Repository Implementations, Migrations
├── Presentation/
│   └── UdemyCarBook.WebApi/         # RESTful API Endpoints, JWT Config, SignalR Hubs
└── Frontends/
    └── UdemyCarBook.WebUI/          # ASP.NET Core MVC (Area), ViewComponents, API Consumers
