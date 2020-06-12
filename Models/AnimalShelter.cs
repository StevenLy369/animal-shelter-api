using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace AnimalShelter.Models
{
    public class AnimalShelter
    {
        public int AnimalId {get;set;}
        [Required]
        [StringLength(50)]

        public string Name {get;set;}
        public string Details {get;set;}
    }
}