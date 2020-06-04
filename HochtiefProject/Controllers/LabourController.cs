using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HochtiefProject.Models;
using HochtiefProject.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HochtiefProject.Controllers
{
    public class LabourController : Controller
    {
        private readonly ILabourRepostroy<Labour_Test> labourRepostroy;

        public LabourController(ILabourRepostroy<Labour_Test> labourRepostroy)
        {
            this.labourRepostroy = labourRepostroy;
        }
        // GET: Labour
        public ActionResult Index()
        {

            var labours = labourRepostroy.List();
           
        return View(labours);
        }

 

        // GET: Labour/Details/5
        public ActionResult Details(int id)
        {
            var labour = labourRepostroy.Find(id);
            return View(labour);
        }

        // GET: Labour/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Labour/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Labour_Test labour)
        {
            try
            {
                labourRepostroy.Add(labour);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Labour/Edit/5
        public ActionResult Edit(int id)
        {
            var labour = labourRepostroy.Find(id);
            return View(labour);
        }

        // POST: Labour/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Labour_Test labour)
        {
            try
            {
                labourRepostroy.Update(id, labour); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Labour/Delete/5
        public ActionResult Delete(int id)
        {
            var labour = labourRepostroy.Find(id); 
            return View(labour);
        }

        // POST: Labour/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Labour_Test labour)
        {
            try
            {
                labourRepostroy.Delete(id); 

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}