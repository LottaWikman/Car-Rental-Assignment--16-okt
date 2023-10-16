﻿using Car_Rental.Common.Classes;

namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
    public IVehicle Vehicle { get; set; }
    public Customer Customer { get; set; }
    public int KmRented { get; set; }
    public int? KmReturned { get; set; }
    public DateTime DateRented { get; set; }
    public DateTime? DateReturned { get; set; }
    public double? Cost { get; set; }



}
