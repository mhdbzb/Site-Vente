using AchatArticles.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AchatArticles.Controllers
{
    public class PaniersController : Controller
    {
        private readonly AchatArticlesContext _context;
        public PaniersController(AchatArticlesContext context)
        {
            _context = context;
        }
        // GET: PaniersController
        public ActionResult Index(int? id)
        {
        
                var panier = _context.Paniers
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (panier == null)
                {
                    return NotFound();
                }

                return View();
         
        }

        // GET: PaniersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PaniersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaniersController/Create
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

        // GET: PaniersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PaniersController/Edit/5
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

        // GET: PaniersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PaniersController/Delete/5
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
