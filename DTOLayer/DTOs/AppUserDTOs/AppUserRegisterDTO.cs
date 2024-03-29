﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.AppUserDTOs
{
    public class AppUserRegisterDTO
    {
        //[Required(ErrorMessage = "Lütfen Adınızı giriniz")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string SurName { get; set; }
        //[Required(ErrorMessage = "Lütfen Kullanıcı adınızı giriniz")]
        public string Username { get; set; }
        //[Required(ErrorMessage = "Lütfen Mail adresinizi giriniz")]
        public string Mail { get; set; }
        //[Required(ErrorMessage = "Lütfen Şifrenizi giriniz")]
        public string Password { get; set; }
        //[Required(ErrorMessage = "Lütfen Tekrar şifre giriniz"), Compare("Password", ErrorMessage = "Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }
    }
}
