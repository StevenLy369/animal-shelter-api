using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using Microsoft.AspNetCore.Authorization;

namespace AnimalShelter.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private AnimalShelterContext _db;

        public AnimalsController(AnimalShelterContext db)
        {
            _db = db;
        }


        // GET api/animals

        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get(string name, string details, string breed)
        {
            var query = _db.Animals.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if (details != null)
            {
                query = query.Where(entry => entry.Details == details);
            }
            if (breed != null)
            {
                query = query.Where(entry => entry.Breed == breed);
            }
            return query.ToList();
        }
        //api/animals/{id}
        [HttpGet("{id}")]
        public ActionResult<Animal> GetAction(int id)
        {
            return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
        }

        // POST api/animals
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal animal)

        {
            animal.AnimalId = id;
            _db.Entry(animal).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)

        {
            var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
            _db.Animals.Remove(animalToDelete);
            _db.SaveChanges();
        }

    }
}