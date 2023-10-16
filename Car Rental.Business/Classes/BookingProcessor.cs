using Car_Rental.Common.Classes;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Classes;
using System.Xml.Linq;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{
    //Allt som ska visas på razor-sidan går genom denna klass!

    //Injicerat BookingProcessor som "processor" på razor-sidan
    //Lagt till den som singleton i program

    //men hur länka till listan via processor?


    IData _data;
    public BookingProcessor(IData data)
    {
        _data = data;
    }

    public List<IVehicle> GetVehicles() //metod som hämtar fordonen från Data
    {
        return _data.GetVehicles();
    }

    public List<Customer> GetCustomers()
    {
        return _data.GetCustomers();
    }

    public List<Booking> GetBookings() 
    {
        return _data.GetBookings();
    }



    //Vi ska skapa en GENERISK METOD som kan returnera både kunder och fordon -
    //det ska vi komma på själva hur man gör!
    //Men typ en Get<Thing> kanske?



}
