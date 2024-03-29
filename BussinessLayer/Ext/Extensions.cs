﻿using BussinessLayer.Abstract;
using BussinessLayer.Abstract.AbstractUow;
using BussinessLayer.Concrete;
using BussinessLayer.Concrete.UnitOfWorkConcrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EF;
using DataAccessLayer.UnitOfWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BussinessLayer.Ext
{
    public static class Extensions
    {
        public static void ExtDependency(this IServiceCollection Services)
        {
            Services.AddScoped<ICommentService, CommentManager>();
            Services.AddScoped<ICommentDal, EFCommentDal>();

            Services.AddScoped<IDestinationService, DestinationManager>();
            Services.AddScoped<IDestinationDal, EFDestinationDal>();

            Services.AddScoped<IAppUserDal, EFAppUserDal>();
            Services.AddScoped<IAppUserService, AppUserManager>();

            Services.AddScoped<IRezervasyonService, RezervasyonManager>();
            Services.AddScoped<IRezervasyonDal, EFRezervasyonDal>();

            Services.AddScoped<IGuideService, GuideManager>();
            Services.AddScoped<IPdfService, PdfManager>();

            Services.AddScoped<IExcelService, ExcelManager>();
            Services.AddScoped<IGuidDal, EFGuideDal>();

            Services.AddScoped<IContactUsService, ContactUsManager>();
            Services.AddScoped<IContactUsDal, EFContactUsDal>();

            Services.AddScoped<IAnnouncementService, AnnouncementManager>();
            Services.AddScoped<IAnnouncementDal, EFAnnountcementDal>();

            Services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();

            Services.AddScoped<IAccountService, AccountManager>();
            Services.AddScoped<IAccountDal, EFAccountDal>();
        }
        public static void CustomValidator(this IServiceCollection Services)
        {
            Services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();
        }
    }
}
