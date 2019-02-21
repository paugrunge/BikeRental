using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.DAL
{
    /// <summary>
    /// Rental Entity
    /// </summary>
    public class Rental
    {
        public int RentalTypeId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public long IdNumber { get; set; }
        public int NumberOfBikes { get; set; }
        public int Time { get; set; }
        public decimal RentalTotalPrice { get; internal set; }
        public DateTime Timespan { get; set; }
        public bool IsFamilyDiscount { get; set; }
    }
}
