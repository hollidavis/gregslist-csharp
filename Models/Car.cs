using System;
using System.ComponentModel.DataAnnotations;

namespace gregslist_csharp.Models
{
    public class Car
    {
        public string Id {get; set;}
        [Required]
        public string Make {get; set;}
        [Required]
        public string Model {get; set;}
        [Required]
        public int Year {get; set;}
        [Required]
        public int Price {get; set;}
        [Required]
        public string Description {get; set;}
        [Required]
        public string ImgUrl {get; set;}
        public Car (string make, string model, int year, int price, string description, string imgUrl)
        {
            Id = Guid.NewGuid().ToString();
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Description = description;
            ImgUrl = imgUrl;
        }
    }
}