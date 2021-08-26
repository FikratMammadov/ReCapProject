using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental:IEntity
    {
        public int Id { get; set; }
        // Navigation Properties
        public int CarId { get; set; }
        public Car Car { get; set; }
        // Navigation Properties
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
