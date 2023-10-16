using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking
{
    public IVehicle Vehicle { get; set; }
    public Customer Customer { get; set; }
    public int KmRented { get; set; }
    public int? KmReturned { get; set; }
    public DateTime DateRented { get; set; }
    public DateTime? DateReturned { get; set; }
    public double? Cost { get; set; }

    public Booking(IVehicle vehicle, Customer customer, int kmRented, int? kmReturned, DateTime dateRented, DateTime? dateReturned, double? cost)
         => (Vehicle, Customer, KmRented, KmReturned, DateRented, DateReturned, Cost)
        = (vehicle, customer, kmRented, kmReturned, dateRented, dateReturned, cost);
    
    
  
}
