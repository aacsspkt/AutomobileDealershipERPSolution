using AutoDealerApplication.Models;
using AutoDealerApplication.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoDealerApplication.Controllers
{
    public class MeasurementController : Controller
    {
        private IUnitOfWork unitOfWork;

        public MeasurementController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: MeasurementController
        public ActionResult Index()
        {
            ICollection<Measurement> measurements = unitOfWork.Measurements.GetAll();
            return View(measurements);
        }

        // GET: MeasurementController/Details/5
        public ActionResult Details(Guid id)
        {
            var measurement = this.unitOfWork.Measurements.GetElementById(id);
            if (measurement == null)
            {
                return NotFound();
            }

            return View(measurement);
        }

        // GET: MeasurementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MeasurementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Measurement measurement)
        {
            try
            {
                if(ModelState.IsValid)
                {

                    measurement.Id = Guid.NewGuid();
                    unitOfWork.Measurements.Insert(measurement);
                    unitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                } 
                return View(measurement);
            }
            catch
            {
                return View();
            }
        }

        // GET: MeasurementController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var measurement = unitOfWork.Measurements.GetElementById(id);
            if (measurement == null)
            {
                return NotFound(id);
            }
            return View(measurement);
        }

        // POST: MeasurementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Measurement measurement)
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

        public ActionResult ConfirmDelete(Guid id)
        {
            var measurement = unitOfWork.Measurements.GetElementById(id);
            if (measurement == null)
            {
                return NotFound(id);
            }
            return View(measurement);
        }

        // POST: MeasurementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id)
        {
            var measurement = unitOfWork.Measurements.GetElementById(id);
            if (measurement == null)
            {
                return NotFound(id);
            }
            
            unitOfWork.Measurements.Remove(measurement);
            return RedirectToAction(nameof(Index));
        }
    }
}
