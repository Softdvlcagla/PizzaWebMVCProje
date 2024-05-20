CREATE TABLE Yoneticiler(
    YoneticiID INT PRIMARY KEY IDENTITY,
    KullaniciAd NVARCHAR(50) NOT NULL,
    KullaniciSoyAd NVARCHAR(50) NOT NULL,
    KullaniciEposta NVARCHAR(50) NOT NULL UNIQUE,
    KullaniciSifre NVARCHAR(50) NOT NULL
);
