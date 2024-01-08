using Azure;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using iTextSharp.text;
using Microsoft.CodeAnalysis;

namespace Traversal.Controllers
{
    public class PDFReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport(byte[] pdfAsBinary, string locationOfPdfOut)
        {

            //string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReport/" + "dosya1.pdf");
            //var stream = new FileStream(path, FileMode.Create);

            //Document document = new Document(PageSize.A4);
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            //PdfWriter.GetInstance(document, stream);

            //document.Open();

            //Paragraph paragraph = new Paragraph("Traversal Rezervasyon PDF Raporu");
            //document.Add(paragraph);
            //document.Close();



            return File("/PdfReport/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }
    }
}
