using Car_Rental.Common.Interfaces;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{

    private readonly IData _data;
    public BookingProcessor(IData data)
    {
        _data = data;
    }

    public List<IVehicle> GetVehicles()
    {
        return _data.GetVehicles();
    }

    public List<IPerson> GetPersons()
    {
        return _data.GetPersons();
    }

    public List<IBooking> GetBookings() 
    {  
        return _data.GetBookings();
    }
}
