﻿using BussinessLayer.Concrete;
using DataAccessLayer.EF;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    public class RezervasyonController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        RezervasyonManager rezervasyonManager = new RezervasyonManager(new EFRezervasyonDal());

        private readonly UserManager<AppUser> _userManager;

        public RezervasyonController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> MyCurrentRezervasyon()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = rezervasyonManager.GetListWithRezervasyonByAccepted(value.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyOldRezervasyon(Rezervasyon rezervasyon)
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = rezervasyonManager.GetListWithRezervasyonByPrevious(value.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyApprovalRezervasyon()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = rezervasyonManager.GetListWithRezervasyonByWaitAprroval(value.Id);
            return View(valuesList);
        }
        [HttpGet]
        public IActionResult NewRezervasyon()
        {
            List<SelectListItem> value = (from x in destinationManager.TGetList()
                                          select new SelectListItem
                                          {
                                              Text = x.City,
                                              Value = x.Id.ToString()
                                          }).ToList();
            ViewBag.v = value;
            return View();
        }
        [HttpPost]
        public IActionResult NewRezervasyon(Rezervasyon rezervasyon)
        {
            rezervasyon.Status = "Onay Bekliyor";
            rezervasyonManager.TAdd(rezervasyon);
            return RedirectToAction("MyCurrentRezervasyon");
        }

    }
}
