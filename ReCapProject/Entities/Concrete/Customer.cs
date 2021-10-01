using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        // Navigation Properties
        public int UserId { get; set; }
        public User User { get; set; }
        public string CompanyName { get; set; }
        // Navigation Properties
        public List<Rental> Rentals { get; set; }
    }
}
