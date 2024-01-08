﻿using BussinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Traversal.Models;

namespace Traversal.Controllers
{
    
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<DestinationModel> destinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using(var c = new Context())
            {
                destinationModels = c.Destinationss.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capasity = x.Capacity
                }).ToList();
            } 
            return destinationModels;
        }
        public IActionResult staticExcelReport()
        {

            return File(_excelService.ExcelList(destinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "dosya_3.xslx");
        }
        public IActionResult DestinationExcelRapor()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";
                int rowCount = 2;
                int sayac = 0;
                foreach (var item in destinationList())
                {
                    sayac++;
                    workSheet.Cell(rowCount,1).Value = item.City;
                    workSheet.Cell(rowCount,2).Value = item.DayNight;
                    workSheet.Cell(rowCount,3).Value = item.Price;
                    workSheet.Cell(rowCount,4).Value = item.Capasity;
                    rowCount++;
                }
                using(var stream = new  MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{sayac}_Liste.xslx");
                }
            }
        }
    }
}
