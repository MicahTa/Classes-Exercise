using System.Globalization;

namespace Classes
{

    public class Program
    {
        /* 
        Create a new instance of the Car class
        Set values in the properties for the object
        Print the values of each property to the Console
        */
        static void Main(string[] args)
        {
            Car parkingLot = new Car();
            parkingLot.Make = "Ford";
            parkingLot.Model = "1/2 Ton V8 6.5L";
            parkingLot.Year = 2007;

            Console.WriteLine(parkingLot.Make);
            Console.WriteLine(parkingLot.Model);
            Console.WriteLine(parkingLot.Year);
        }
    }
}
