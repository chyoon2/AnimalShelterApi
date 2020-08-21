using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
    public class Cat
    {
        public int CatId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfAdmittance {get; set; }
        public string Url {get; set; }
    }
}