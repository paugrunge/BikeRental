using BikeRental.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.BLL
{
    /// <summary>
    /// Class for DayRental
    /// </summary>
    public class DayRental : Rental
    {
        public DayRental(int numberOfBikes, int days, string name, string lastName, int phone, int idNumber) : base(numberOfBikes, days, name, lastName, phone, idNumber)
        {
            if (days < 1 || days > 6)
                throw new ApplicationException("Days quantity is not valid");

            RentalType = RentalTypeDao.Instance.GetRentalType("Day");
            RentalEntity.RentalTypeId = RentalType.Id;
        }
    }
}
