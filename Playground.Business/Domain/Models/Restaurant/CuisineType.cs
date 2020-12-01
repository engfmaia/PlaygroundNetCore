using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playground.Business.Domain.Models.Restaurant
{
    public class CuisineType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }

    }
}
