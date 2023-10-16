using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Airplane : IVehicle
{

    //Properties som alla FLYGPLAN måste ha:
    public string RegNo { get; set; }
    public string Make { get; set; }
    public int Odometer { get; set; }
    public int PricePerKm { get; set; }
    public VehicleTypes VehicleType { get; set; }
    public int PricePerDay { get; set; }
    public bool Status { get; set; }

    public Airplane(string regNo, string make, int odometer, int pricePerKm, VehicleTypes vehicleType, int pricePerDay, bool status)
    {
        (RegNo, Make, Odometer, PricePerKm, VehicleType, PricePerDay, Status) =
            (regNo, make, odometer, pricePerKm, vehicleType, pricePerDay, status);
    }


}
