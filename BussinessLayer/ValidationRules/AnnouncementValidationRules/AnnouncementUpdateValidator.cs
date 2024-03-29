﻿using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDTO>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez");
        }
    }
}
