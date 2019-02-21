using BikeRental.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.BLL
{
    /// <summary>
    ///  Class for Hour Rental
    /// </summary>
    public class HourRental : Rental
    {
        /// <summary>
        /// Creates an Hour Rental with its total price
        /// </summary>
        /// <param name="numberOfBikes"></param>
        /// <param name="hours"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="phone"></param>
        /// <param name="idNumber"></param>
        public HourRental(int numberOfBikes, int hours, string name, string lastName, int phone, int idNumber) : base(numberOfBikes, hours, name, lastName, phone, idNumber)
        {
            if (hours < 1 || hours > 23)
                throw new ApplicationException("Hours quantity is not valid");

            RentalType = RentalTypeDao.Instance.GetRentalType("Hour");
            RentalEntity.RentalTypeId = RentalType.Id;
        }
    }
}
