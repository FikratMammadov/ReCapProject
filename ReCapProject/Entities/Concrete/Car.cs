using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        // Navigation Properties
        public int BrandId { get; set;}
        public Brand Brand { get; set; }
        // Navigation Properties
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public string Name { get; set; }
        public DateTime ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
