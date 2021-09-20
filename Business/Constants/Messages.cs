using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string UnitPriceInvalid = "Ürün Fiyatı Geçersiz";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkilendirme Reddedildi";
        public static string AccessTokenCreated = "Erişim Simgesi Oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı Zaten Var";
        public static string SuccessfulLogin="Başarılı Giriş";
        public static string PasswordError = "Hatalı Parola";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string UserRegistered = "Kullanıcı Kaydedildi";
    }
}
