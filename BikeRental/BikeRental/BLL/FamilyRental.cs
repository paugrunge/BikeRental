using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.BLL
{
    /// <summary>
    /// Class for Family Rental, including a list of rentals of any kind
    /// </summary>
    public class FamilyRental : Rental
    {
        public int NumberOfBikes
        {
            get { return rentals.Sum(r => r.RentalEntity.NumberOfBikes); }
        }
        private decimal total;
        private IList<Rental> rentals = new List<Rental>();

        public FamilyRental() : base()
        {
        }

        /// <summary>
        /// Adds a rental to the family's rentals list
        /// </summary>
        /// <param name="rental"></param>
        public void AddRental(Rental rental)
        {
            if (rental.RentalEntity.NumberOfBikes + this.NumberOfBikes > 5)
            {
                throw new ApplicationException("Bikes's quantity not valid por this type of rental");
            }
            else
            {
                rental.RentalEntity.IsFamilyDiscount = true;
                rentals.Add(rental);
            }
        }

        /// <summary>
        /// Family rent implementation, applys a discount to the total price of all rents
        /// </summary>
        /// <returns></returns>
        public override decimal Rent()
        {
            if (this.NumberOfBikes < 3)
                throw new ApplicationException("You have to rent at least 3 bikes for the promotion!");

            total = 0;
            foreach (var rental in rentals)
                total += rental.Rent();

            total *= 0.7m;
            return total;
        }
    }
}
