using Car_Rental.Common.Classes;
using Car_Rental.Common.Interfaces;
using Car_Rental.Common.Enums;

namespace Car_Rental.Data.Classes;

public class Data : IData
{
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    readonly List<IPerson> _persons = new List<IPerson>();
    readonly List<IBooking> _bookings = new List<IBooking>();

    public Data()
    {
        _vehicles.Add(new Car("ABC123", "Subaru", 100_000, 2, VehicleTypes.Combi, 100, true));
        _vehicles.Add(new Car("HEJ666", "Fiat", 200_000, 1, VehicleTypes.Sedan, 80, false));
        _vehicles.Add(new Car("TRE210", "Ford", 60_000, 3, VehicleTypes.Van, 110, true));
        _vehicles.Add(new Motorcycle("OOJ112", "Suzuki", 60_000, 1, VehicleTypes.Motorcycle, 50, true));
        _vehicles.Add(new Airplane("OWC747", "Boeing", 7_000_000, 100, VehicleTypes.Airplane, 1000, false));

        _persons.Add(new Customer(777777, "Johansson", "Johan"));
        _persons.Add(new Customer(444444, "Sigridsdotter", "Sigrid"));
        _persons.Add(new Customer(999999, "Eriksson", "Erik"));

        _bookings.Add(new Booking(_vehicles[2], _persons[1], 1000, 1200, DateTime.Now.AddDays(-7).Date, DateTime.Now, 300));
        _bookings.Add(new Booking(_vehicles[3], _persons[0], 300, 380, DateTime.Now.AddDays(-16).Date, DateTime.Now.AddDays(-14), 200));
        _bookings.Add(new Booking(_vehicles[1], _persons[2], 500, null, DateTime.Now.AddDays(-2), null, null));
    }

    public List<IVehicle> GetVehicles() => _vehicles;
    public List<IPerson> GetPersons() => _persons;
    public List<IBooking> GetBookings() => _bookings;
}