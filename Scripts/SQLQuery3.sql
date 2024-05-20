create table Kullanicilar(
KullaniciID int primary key identity,
KullaniciAd nvarchar(50) not null,
KullaniciSoyAd nvarchar(50) not null,
KullaniciEposta nvarchar(50) not null unique,
KullaniciSifre nvarchar(50) not null,
)