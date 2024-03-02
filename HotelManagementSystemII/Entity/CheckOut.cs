using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemII.Entity;

public class CheckOut
{
    [Key]
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Date { get; set; }
}
