using Car_Rental.Common;
using Car_Rental.Common.Classes;

namespace Car_Rental.Common.Interfaces;

public interface IData
{
    List<IVehicle> GetVehicles();
    List<IPerson> GetPersons();
    List<IBooking> GetBookings();

}
