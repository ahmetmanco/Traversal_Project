using AutoMapper;
using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.EF;
using DTOLayer.DTOs.ContactDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;
        public ContactController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if(ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs()
                {
                    Subject = model.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    Body = model.Body,
                    Mail = model.Mail,
                    MessageStatus = model.MessageStatus,
                });
                return RedirectToAction("Index", "Default");
            }
            return View(model);
        }
    }
}
