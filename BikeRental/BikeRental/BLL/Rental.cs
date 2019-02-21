using BikeRental.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.BLL
{
    /// <summary>
    /// BLL abstract class to for a Rental
    /// </summary>
    public abstract class Rental
    {
        public RentalType RentalType { get; internal set; }
        public DAL.Rental RentalEntity { get; internal set; }

        public Rental()
        {
        }

        /// <summary>
        /// Rental constructor, creates a Rental entity
        /// </summary>
        public Rental(int numberOfBikes, int time, string name, string lastName, int phone, int idNumber)
        {
            if (numberOfBikes < 1)
                throw new ApplicationException("Bikes's quantity is not valid");

            RentalEntity = new DAL.Rental()
            {
                Name = name,
                LastName = lastName,
                Phone = phone,
                IdNumber = idNumber,
                NumberOfBikes = numberOfBikes,
                Time = time,
                Timespan = DateTime.Now,
                IsFamilyDiscount = false
            };
        }

        /// <summary>
        /// Obtains the total price for a rent of ani kind
        /// </summary>
        public virtual decimal Rent()
        {
            RentalEntity.RentalTotalPrice = RentalType.Price * RentalEntity.Time * RentalEntity.NumberOfBikes;
            return RentalEntity.RentalTotalPrice;
        }
    }
}
