
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans

{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarDeleted = "Araba eklendi";
        public static string CarUpdated = "Araba eklendi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandDeleted = "Marka eklendi";
        public static string BrandUpdated = "Marka eklendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorsListed = "Renkler listelendi";
        public static string ColorDeleted = "Renk eklendi";
        public static string ColorUpdated = "Renk eklendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string CustomerAdded = "Müsteri eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string CustomerDeleted = "Müsteri Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string CustomerUpdated = "Müsteri Güncellendi";
        public static string RentalAdded = "Araç Kiralandı (Rental tablosuna eklendi)";
        public static string RentalDeleted = "Arac Rental Tablsoundan Silindi";
        public static string RentalDelivered = "Araç Teslim Edildi";
        public static string RentalBusy = "Araç Suan Kullanımda";
        public static string RentalUpdated = "Arac Bilgisi Tabloda güncellendi";
        public static string NoRecording = "Kayıt Bulunamadı";
        public static string FailAddedImageLimit;
        public static string UserRegistered = "Kayıt Oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        internal static string CarImageListed;
        internal static string CarImageAdded;
        internal static string CarImageUpdated;
    }
}
