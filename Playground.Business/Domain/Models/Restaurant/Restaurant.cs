﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Playground.Business.Domain.Models.Restaurant
{
    public class Restaurant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
