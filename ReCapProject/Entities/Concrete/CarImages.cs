using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarImages
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
