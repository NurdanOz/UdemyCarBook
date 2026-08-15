# 🚗 UdemyCarBook - Modern Araç Kiralama & Yönetim Portalı

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-MVC_%26_Web_API-512BD4?style=for-the-badge&logo=dotnet)
![MediatR](https://img.shields.io/badge/MediatR-CQRS-purple?style=for-the-badge)
![EF Core](https://img.shields.io/badge/Entity_Framework_Core-ORM-blue?style=for-the-badge)
![SQL Server](https://img.shields.io/badge/SQL_Server-Database-CC292B?style=for-the-badge&logo=microsoftsqlserver)

**UdemyCarBook**, kullanıcıların araç kiralayabildiği, fiyat ve teknik özellikleri inceleyebildiği; yöneticilerin ise araç, marka, konum, yorum ve rezervasyon süreçlerini yönetebildiği modern bir araç kiralama platformudur.

Proje; **Clean Architecture**, **SOLID** prensipleri, **CQRS Pattern** ve **RESTful API** standartları gözetilerek geliştirilmiştir.

---

## 📑 İçindekiler

* 📌 [Öne Çıkan Özellikler](#-öne-çıkan-özellikler)
* 🚀 [Kurulum ve Başlangıç](#-kurulum-ve-başlangıç)
* 🏗️ [Proje Yapısı](#️-proje-yapısı)
* 🔑 [Önemli Mimariler & Tasarım Desenleri](#-önemli-mimariler--tasarım-desenleri)
* 🛠️ [Teknoloji Yığını](#️-teknoloji-yığını)

---

## 📌 Öne Çıkan Özellikler

### 🏎️ Dinamik Araç & Detay Yönetimi
* Araçların vites, yakıt, koltuk sayısı, bagaj kapasitesi ve kilometre gibi teknik verilerinin sergilenmesi.
* Araçlara özel dinamik açıklama (Description) ve teknik özellik (Feature) eşleştirmeleri.
* Günlük, haftalık ve aylık bazda dinamik fiyatlandırma mimarisi.

### 📝 Değerlendirme & Yorum Sistemi
* Kiralanan araçlara kullanıcı yorumları ve puanlama (Review) ekleme.
* FluentValidation ile sunucu tarafında veri doğrulama kontrolleri.

### 👥 Kullanıcı Kayıt & Kimlik Doğrulama
* `AppUser` ve `AppRole` mimarisi ile rol tabanlı kullanıcı kaydı ve giriş sistemi.

---
