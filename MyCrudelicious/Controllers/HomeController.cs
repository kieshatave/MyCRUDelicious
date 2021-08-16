using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MyCRUDelicious.Models;

namespace MyCRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.AllDishes = _context.Dishes.OrderBy(o => o.UpdatedAt);
            return View("Index");
        }
        [HttpGet("newDish")]
        public IActionResult NewDish()
        {
            return View("AddDish");
        }
        [HttpPost("AddDish")]
        public IActionResult AddDish(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("AddDish");
        }
        [HttpGet("/dish/{id}")]
        public IActionResult DishInfo(int? id)
        {
            Dish DisplayDish = _context.Dishes.FirstOrDefault(i => i.DishId == id);
            if(DisplayDish == null)
            {
                return RedirectToAction("Index");
            }
            return View("DishInfo", DisplayDish);
        }
        [HttpGet("/dish/{id}/edit")]
        public IActionResult EditDish(int id)
        {
            Dish dish = _context.Dishes.FirstOrDefault(d => d.DishId == id);
            return View("EditDish", dish);
        }
        [HttpPost("/dish/{id}/update")]
        public IActionResult UpdateDish(int id, Dish item)
        {
            if(ModelState.IsValid)
            {
                Dish dish = _context.Dishes.FirstOrDefault(i => i.DishId == id);
                dish.DishName = item.DishName;
                dish.ChefName = item.ChefName;
                dish.Calories = item.Calories;
                dish.Tastiness = item.Tastiness;
                dish.Description = item.Description;
                dish.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                item.DishId = id;
                return View("EditDish", item);
            }
        }
        [HttpGet("/dish/{id}/delete")]
        public IActionResult DeleteDish (int id)
        {
            Dish DeleteDish = _context.Dishes.FirstOrDefault(i => i.DishId == id);
            _context.Remove(DeleteDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
