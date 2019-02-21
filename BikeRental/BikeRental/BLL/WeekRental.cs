using BikeRental.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.BLL
{
    /// <summary>
    /// Class for Week Rental 
    /// </summary>
    public class WeekRental : Rental
    {
        public WeekRental(int numberOfBikes, int weeks, string name, string lastName, int phone, int idNumber) : base(numberOfBikes, weeks, name, lastName, phone, idNumber)
        {
            if (weeks < 1)
                throw new ApplicationException("Weeks quantity is not valid");

            RentalType = RentalTypeDao.Instance.GetRentalType("Week");
            RentalEntity.RentalTypeId = RentalType.Id;
        }
    }
}
