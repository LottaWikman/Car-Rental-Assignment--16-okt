using Car_Rental.Common;
using Car_Rental.Common.Classes;

namespace Car_Rental.Common.Interfaces;

public interface IData
{


    List<IVehicle> GetVehicles(); //skapar metod för att hämta fordon
    List<Customer> GetCustomers(); //metod för att hämta kunder
    List<Booking> GetBookings(); //metod för att hämta bokningar

    //vi ska göra detta med hjälp av "reflection"
    //istället för en lista




    //lista med den generisk typen T, med namnet expression
    //där typen T måste motsvara en klass:
    List<T> Get<T>(List<T> list, Func<T, bool> expression) 
        where T : class
    {
        //expression: p => p.Id > 10
        //            T       bool
        //en sorts filtrerning där alla p med Id större än 10 sparas
        return list.Where(expression).ToList(); 
        //en filtrerad lista mha ett lambda-uttryck!
    }

}
