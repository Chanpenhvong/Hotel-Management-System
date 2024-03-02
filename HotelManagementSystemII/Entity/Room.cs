using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemII.Entity;

 public class Room
{
    [Key]
    public Guid RID { get; set; }
    public string? RNumber { get; set; }
    public string? RType { get; set; }
    public string? RBed { get; set; }   
    public string? RPrice { get; set; }
    public RoomStatus? RStatus { get; set; }
    public List<Customer>? Customer { get; set; }
    public DateTime? CheckIn { get; set; }
    public DateTime? CheckOut { get; set;}
   

}
