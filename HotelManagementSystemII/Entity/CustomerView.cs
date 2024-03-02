using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemII.Entity;

public class CustomerView
{
    public Guid CustomerId { get; set; }
    public string? CName { get; set; }  
    public string? CRoom { get ; set; }
    public string? CPhone { get; set; }
    public string? CNationality { get; set; }
    public string? CNICNO { get; set; } 
    public string? DateofBirth { get; set; }
    public string? CheckIn { get; set; }
    public string? CheckOut { get; set;}

}
