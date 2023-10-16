using Car_Rental.Common.Classes;
using Car_Rental.Common.Interfaces;
using Car_Rental.Common.Enums;

namespace Car_Rental.Data.Classes;

public class Data : IData
    //enda uppgift är att hålla all data (bara en klass)
{

    List<IVehicle> _vehicles = new();
    List<Customer> _customers = new();
    List<Booking> _bookings = new();

    
    double CalculateCost(DateTime dateRented, DateTime dateReturned, int pricePerDay, int kmReturned, int kmRented, int costPerKm)
    {
        double unroundedCost = (dateReturned - dateRented).TotalDays * pricePerDay + (kmReturned - kmRented) * costPerKm;
        double cost = Math.Round(unroundedCost, 2);
        return cost;
    }
    

    public Data() //varför funkar inte Add-metoden utanför konstruktorn?
    {

        //skapar faktiska fordon som läggs till i listan _vehicles
        _vehicles.Add(new Car("ABC123", "Subaru", 100_000, 2, VehicleTypes.Combi, 100, true));
        _vehicles.Add(new Car("HEJ666", "Fiat", 200_000, 1, VehicleTypes.Sedan, 80, false));
        _vehicles.Add(new Car("TRE210", "Ford", 60_000, 3, VehicleTypes.Van, 110, true));
        _vehicles.Add(new Motorcycle("OOJ112", "Suzuki", 60_000, 1, VehicleTypes.Motorcycle, 50, true));
        _vehicles.Add(new Airplane("OWC747", "Boeing", 7_000_000, 100, VehicleTypes.Airplane, 1000, false));

        //skapar kunder som läggs till i listan _customers
        _customers.Add(new Customer(777777, "Johansson", "Johan"));
        _customers.Add(new Customer(444444, "Sigridsdotter", "Sigrid"));
        _customers.Add(new Customer(999999, "Eriksson", "Erik"));

        //skapar bokningar som lägg till i lista _bookings
        _bookings.Add(new Booking(_vehicles[2], _customers[1], 1000, 1200, DateTime.Now.AddDays(-7).Date, DateTime.Now, 
            CalculateCost(DateTime.Now.AddDays(-7).Date, DateTime.Now, _vehicles[2].PricePerDay, 1000, 1200, _vehicles[2].PricePerKm)));

        _bookings.Add(new Booking(_vehicles[3], _customers[0], 300, 380, DateTime.Now.AddDays(-16).Date, DateTime.Now.AddDays(-14),
            CalculateCost(DateTime.Now.AddDays(-16).Date, DateTime.Now.AddDays(-14), _vehicles[3].PricePerDay, 300, 380, _vehicles[3].PricePerKm)));

        _bookings.Add(new Booking(_vehicles[1], _customers[2], 500, null, DateTime.Now.AddDays(-2), null, null));
            //CalculateCost(DateTime.Now.AddDays(-2), null, _vehicles[2].PricePerDay, 500, null, _vehicles[2].PricePerKm)));


    }

    //Filterar obokade fordon

    public List<IVehicle> GetVehicles() => _vehicles;
        //Metod som returnerar fordonen
    public List<Customer> GetCustomers() => _customers;
    //Metod som returnerar kunderna
    public List<Booking> GetBookings() => _bookings;
    //Metod som returnerar bokningar


}