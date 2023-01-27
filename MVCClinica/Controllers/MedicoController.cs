using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCClinica.Data;
using MVCClinica.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCClinica.Controllers
{
    public class MedicoController : Controller
    {
        private readonly DBClinicaMVCContext context;

        public MedicoController(DBClinicaMVCContext context)
        {
            this.context = context;
        }


        //GET medico
        //GET medico/index
        [HttpGet]
        public IActionResult Index()
        {
            List<Medico> medicos = context.Medicos.ToList();

            return View(medicos);
        }


        //GET medico/create
        [HttpGet]
        public IActionResult Create()
        {
            Medico medico = new Medico();

            return View("create", medico);
        }


        //POST medico/create
        [HttpPost]
        public IActionResult Create(Medico medico)
        {
            if (ModelState.IsValid)
            {
                context.Medicos.Add(medico);
                context.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View(medico);
            }
        }


        // GET medico/delete/1
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Medico medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View("delete", medico);
            }
            
        }


        //POST medico/delete/1
        [ActionName("delete")]
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            Medico medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                context.Medicos.Remove(medico);
                context.SaveChanges();
                return RedirectToAction("index");
            }
        }


        //GET medico/details/1
        [HttpGet]
        public IActionResult Details(int id)
        {
            Medico medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View("details", medico);
            }
            
        }


        //GET medico/edit/1
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Medico medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View("edit", medico);
            }
        }


        //POST medico/edit/1
        [HttpPost]
        [ActionName("edit")]
        public IActionResult EditConfirmed(Medico medico)
        {
            if (ModelState.IsValid)
            {
                context.Entry(medico).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View(medico);
            }
        }


    }
}
