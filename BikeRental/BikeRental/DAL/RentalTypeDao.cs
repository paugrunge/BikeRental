using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.DAL
{
    /// <summary>
    /// Dao for RentalTypes
    /// </summary>
    public class RentalTypeDao
    {
        public static readonly RentalTypeDao Instance = new RentalTypeDao();
        // To be replaced when a DB Context is implemented
        private readonly ConcurrentDictionary<string, RentalType> rentalTypeBase = new ConcurrentDictionary<string, RentalType>();

        private RentalTypeDao()
        {
            CreateMemoryStock();
        }

        /// <summary>
        /// Adds a RentalType
        /// </summary>
        public void AddRentalType(RentalType type)
        {
            rentalTypeBase.TryAdd(type.Name, type);
        }

        /// <summary>
        /// Gets a RentalType by name
        /// </summary>
        /// <returns></returns>
        public RentalType GetRentalType(string name)
        {
            RentalType type;
            rentalTypeBase.TryGetValue(name, out type);
            return type;
        }

        /// <summary>
        /// Gets all RentalTypes
        /// </summary>
        public IList<RentalType> GetRentalTypes()
        {
            return rentalTypeBase.Values.ToList();
        }

        /// <summary>
        /// Creates a memory cache of RentalTypes
        /// </summary>
        private void CreateMemoryStock()
        {
            rentalTypeBase.TryAdd("Hour", new RentalType()
            {
                Id = 1,
                Name = "Hour",
                Price = 5
            });
            rentalTypeBase.TryAdd("Day", new RentalType()
            {
                Id = 2,
                Name = "Day",
                Price = 20
            });
            rentalTypeBase.TryAdd("Week", new RentalType()
            {
                Id = 3,
                Name = "Week",
                Price = 60
            });
        }
    }
}
