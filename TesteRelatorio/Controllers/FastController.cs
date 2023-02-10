using FastReport;
using FastReport.Export.PdfSimple;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TesteRelatorio.Controllers
{
    public class FastController : Controller
    {
        // GET: FastController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FastController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FastController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        // Post: FastController/GenerateReport
        public ActionResult GenerateReport()
        {
            Report report = new Report();

            // Carrega o modelo de relatório do arquivo .frx
            report.Load("Report.frx");

            // Gera o relatório em PDF
            MemoryStream stream = new MemoryStream();
            var export = new PDFSimpleExport();
            report.Export(export, stream);

            // Retorna o relatório em PDF como resposta HTTP
            stream.Position = 0;
            return File(stream, "application/pdf", "Report.pdf");
        }
        // POST: FastController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FastController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FastController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FastController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FastController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
