using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemII.Entity;

public class RoomView
{
    public Guid RoomID { get; set; }
    public string? RNumber { get; set; }
    public string? RBed { get; set; }
    public string? RPrice { get; set; }
    public string? RType { get; set; }
    public RoomStatus? RStatus { get; set; }

}
