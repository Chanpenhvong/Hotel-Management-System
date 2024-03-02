using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemII.Entity;

public class RoomStatus
{
    [Key]
    public Guid RID { get; set; }
    public string? CheckIn { get; set; }
    public string? CheckOut { get; set; }
    public string? RNumber { get; set; }
    public string? Available { get; set; }

}
