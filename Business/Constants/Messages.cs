using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka  silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string FailedBrandUpdate = "Marka güncelleme başarısız";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string BrandsListed = "Markalar listelendi";

        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba  silindi";
        public static string CarsListed = "Araba  silindi";
        public static string CarUpdateSuccess = "Araba güncelleme başarılı";
        public static string CarDeleteSuccess = "Araba silme başarılı";
        public static string CarUpdated = "Araba   güncellendi";
        public static string CarNameInvalid = "Araba  geçersiz";
        public static string UnavailableCarsListed = "Geçersiz araba listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk eklendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomersListedById = "Müşteriler id göre listelendi";

        public static string FailedRental = "Kiralama başarısız";
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalsListed = "Kiralamalar listelendi";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi.";

        public static string UserAdded = "Kullanıcı  eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı  güncellendi.";
        public static string UsersListed = "Kullanıcılar listelendi .";

        public static string ImagesAdded = "Resim eklendi";

        public static string FailAddedImageLimit = "Resim limitine ulaşıldı eklenemez";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }


}
