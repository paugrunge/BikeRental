BikeRental develop in Visual Studio Community 2017 and Visual Studio Professional 2015

BikeRental is a.NET Framework 4.6.1 class library project representing a bike rental model.
It is divided in the DAL clases consisting in Entitys for database representation and Dao class for Rental Types that are held in memory.

And the BLL clases consisting on the bussiness logic for the rentals.
Inheritance is used for the Rental representation. Rental is an abstract class to be implemented if necesarry by the different kind of rentals
The classes are extensibles and scalables.
 
# Runing Tests
* Automated tests had been generated for every case in the requirement.
* To run the tests, just Open the BikeRentalTest project in Visual Studio and use the Test Explorer to run all of them.