using Azure;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Controllers
{
    public class PDFReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult StaticPdfReport()
        //{
        //    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReport/" + "dosya1.pdf");
        //    var stream = new FileStream(path, FileMode.Create);

        //    Document document = new Document(PageSize.A4);
        //    PdfWriter.GetInstance(document, stream);

        //    document.Open();

        //    Paragraph paragraph = new Paragraph("Traversal Rezervasyon PDF Raporu");
        //    document.Add(paragraph);
        //    document.Close();

        //    return File("/PdfReport/dosya1.pdf", "application/pdf", "dosya1.pdf");
        //}
    }
}
