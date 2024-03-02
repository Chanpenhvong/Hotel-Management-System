using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemII.Entity;

public class Employee
{
    [Key]
    public Guid IdentityId { get; set; }
    public string? Name { get; set; }
    public string? CardNo { get; set; }
    public string? Position { get; set; }
    public UserAccount? UserAccount { get; set; }

}
