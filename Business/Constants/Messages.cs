using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MedicineAdded = "İlaç eklendi";
        public static string MedicinesListed = "İlaçlar listelendi";
        public static string MedicineUpdated = "İlaç günclendi";
        public static string MedicineDeleted = "İlaç silindi.";


        public static string PatientAdded = "Hasta eklendi";
        public static string PatientsListed = "Hastalar listelendi";
        public static string PatientUpdated = "Hasta günclendi";
        public static string PatientDeleted = "Hasta silindi.";

        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
    }
}
