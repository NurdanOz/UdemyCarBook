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


<img width="1920" height="975" alt="carbook1" src="https://github.com/user-attachments/assets/5c8d1063-d192-4b3e-91e7-338ecf8d58e6" />

<img width="1920" height="960" alt="caarbook2" src="https://github.com/user-attachments/assets/207a8ce1-9a9a-451e-a01c-b45ec6242c4e" />

<img width="1920" height="955" alt="carbook2" src="https://github.com/user-attachments/assets/b8813d68-98b5-4ee0-8345-055c4aeb8d2c" />

<img width="1920" height="962" alt="carbook3" src="https://github.com/user-attachments/assets/86b29dba-330e-4e3f-b03d-140fbfa6946a" />

<img width="1920" height="975" alt="carbook4" src="https://github.com/user-attachments/assets/36a658fc-588f-4994-8361-5170059a2f0c" />

<img width="1920" height="967" alt="carbook5" src="https://github.com/user-attachments/assets/a6ac50f8-e562-4368-bb32-919b58b14f58" />

<img width="1920" height="985" alt="carbook6" src="https://github.com/user-attachments/assets/0f245e1d-0eba-497e-96c0-120541cb95db" />

<img width="1920" height="988" alt="carbook7" src="https://github.com/user-attachments/assets/db26577b-593e-4e5d-a45c-7c6a16ff0b2f" />

<img width="1920" height="975" alt="carbook8" src="https://github.com/user-attachments/assets/3d632342-a5b7-4d02-bc80-affb5c21a019" />

<img width="1920" height="985" alt="carbook9" src="https://github.com/user-attachments/assets/bb52e2cc-d1bd-4ecf-b04b-042d6be4eab0" />

<img width="1920" height="975" alt="carbook10" src="https://github.com/user-attachments/assets/80b45c82-7a3c-4fd4-9253-1ef92d3657f0" />

<img width="1920" height="981" alt="carbook11" src="https://github.com/user-attachments/assets/6e9c6ba7-7df8-4495-8059-7b497b4fd4fe" />

<img width="1920" height="975" alt="carbook12" src="https://github.com/user-attachments/assets/5da70a73-5510-4ffd-93ad-0d1ca5936f36" />

<img width="1920" height="979" alt="carbook13" src="https://github.com/user-attachments/assets/6a650af5-31f9-4226-ac19-d0f9f09cea64" />

<img width="1920" height="978" alt="carbook14" src="https://github.com/user-attachments/assets/5491c3ad-7681-408a-97af-2a6b2f6e6913" />





















