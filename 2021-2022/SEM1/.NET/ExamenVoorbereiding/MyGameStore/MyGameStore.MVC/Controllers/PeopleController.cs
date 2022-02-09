using Microsoft.AspNetCore.Mvc;
using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.MVC.Controllers
{
    public class PeopleController : Controller
    {
        private IPeopleService _service;

        public PeopleController(IPeopleService services)
        {
            _service = services;
        }

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            _service.Add(person);
            return RedirectToAction("Index");
        }

        public IActionResult GetById(int id)
        {
            var person = _service.GetById(id);
            return View(person);
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var person = _service.GetById(id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Update(Person person)
        {
            _service.Update(person);
            return RedirectToAction("Index");
        }
    }
}
