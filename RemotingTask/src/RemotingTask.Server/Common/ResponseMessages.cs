﻿namespace RemotingTask.Server.Common
{
    public static class ResponseMessages
    {
        public const string ProductNameCannotBeEmpty = "Ürün adı boş olamaz.";
        public const string ProductPriceCannotBeZeroOrNegative = "Fiyat sıfır veya negatif olamaz.";
        public const string ProductNameAlreadyExists = "Aynı isimli ürün var.";
        public const string ProductCreatedSuccessfully = "Yeni ürün eklendi.";
        public const string ProductCouldNotBeAdded = "Yeni ürün eklenemedi.";
        public const string ProductCouldNotBeDeleted = "Ürün silinemedi.";
        public const string ProductNotFound = "Ürün bulunamadı.";
        public const string ProductDeletedSuccessfully = "Ürün silindi.";
        public const string ProductUpdatedSuccessfully = "Ürün güncellendi.";
        public const string ProductCouldNotBeUpdated = "Ürün güncellenemedi.";

        public const string ServerError = "Sunucu gerekli işlemi gerçekleştiremedi";

    }
}
