using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterClient.Models;
using Microsoft.AspNetCore.Authorization;
using System;

namespace AnimalShelterClient.Controllers
{
    public class AnimalsController : Controller
    {
        [HttpGet("/index")]
        public IActionResult Index()
        {
            var allAnimals = Animal.GetAnimals();
            return View(allAnimals);
        }


    }
}