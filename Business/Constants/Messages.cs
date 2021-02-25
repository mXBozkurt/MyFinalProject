using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem İçin Bakım Zamanı";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürünler Güncellendi";
        public static string ProductCountOfCategoryError = "Bu kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu kategoride aynı isimde başka bir ürün mevcut";
        public static string CategoryLimitExceded = "Kategory Limiti Aşıldığı için yeni ürün eklenemiyor";
    }
}
