using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemII.Entity;

public class Customer
{
    [Key]
    public Guid CsId { get; set; }
    public Room? Room { get; set; }
    public string? CRoom { get; set; }
    public string? Name { get; set; }   
    public string? Phone { get; set; }
    public string? Nationality { get; set; }
    public string? Gender { get; set; } 
    public string? NICNO { get; set; }
    public string? DateofBirth { get; set; }
    public string? CheckIn { get; set; }

}
