﻿using Core.Utilities.Security.Jwt;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarListed = "Arabalar listelendi";
        public static string CarById = "Arabalar ID göre getirildi";
        public static string ColorById = "Arabalar Color ID göre listelendi";
        public static string BrandById = "Arabalar Brand ID göre listelendi";

        public static string Error = "Listelenemedi";

        public static string CarAdded = "Araba başarı ile eklendi";
        public static string CarDeleted = "Araba başarı ile silindi";
        public static string CarListedByModelYear = "Model yılına göre filtrelenip listelendi";

        public static string GetByCarId = "İstenilen araba getirildi";

        public static string GetByColorId = "Arabalar Brand ID göre Listelendi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarNameInvalid = "Geçersiz Araba ismi";

        public static string GetByDailyPrice = "Günlük ücrete göre filtrelenip listelendi";

        public static string GetCarDetail = "Arabalar detaylarına göre listelendi";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Şifre Hatalı";
        public static string SuccessfulLogin = "Sisteme Giriş Başarılı";
        public static string UserAlreadyExists= "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated="Token başarı ile oluşturuldu";
    }
}
