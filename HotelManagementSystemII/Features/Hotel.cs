using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HotelManagementSystemII.Entity;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystemII.Features;

public class Hotel
{
    public HotelDbContext DbContext { get; }
    public Hotel()
    {
        DbContext = new HotelDbContext();
    }
    
    public void AddRoom(Room rm)
    {
        if(string.IsNullOrEmpty(rm.RNumber) ||
            string.IsNullOrEmpty(rm.RBed) ||
            string.IsNullOrEmpty(rm.RPrice) ||
            string.IsNullOrEmpty(rm.RType))
        { throw new ArgumentException("Please provide all data!");
        }
        else
        {
            DbContext.Rooms.Add(rm);
            DbContext.SaveChanges();
        }
    }
    public void AddCustomer(Customer cs)
    {
        if(string.IsNullOrEmpty(cs.Name) ||
            string.IsNullOrEmpty(cs.Gender) ||
            string .IsNullOrEmpty(cs.Phone) ||
            string.IsNullOrEmpty(cs.Nationality) ||
            string.IsNullOrEmpty(cs.NICNO) ||
            string.IsNullOrEmpty(cs.DateofBirth) ||
            string.IsNullOrEmpty(cs.CheckIn) ||
            string.IsNullOrEmpty(cs.Room?.RNumber) ||
            string.IsNullOrEmpty(cs.Room.RBed) ||
            string.IsNullOrEmpty(cs.Room.RType) ||
            string.IsNullOrEmpty(cs.Room.RPrice)) 
        {
            throw new ArgumentException("Please Provide all data!");
        }
        DbContext.Customers.Add(cs);
        DbContext.SaveChanges();
           
    }
    public bool IsRoomFree(string RNumber)
    {
        foreach (var r in DbContext.Rooms)
        {
            if(r.RNumber == RNumber && r.Customer == null)
            { return false; 
            }

        }
        return true;
    }
    public void CheckOut(CheckOut co)
    {
        if(string.IsNullOrEmpty(co.Name) ||
            string.IsNullOrEmpty(co.Date))
        {
            throw new ArgumentException("Please provide all data!");
        }
        DbContext.SaveChanges();
    }
    public bool Checkout(string rNumber)
    {
        var room = DbContext.Rooms.FirstOrDefault(r => r.RNumber == rNumber);
        if(room == null)
        {
            return false;
        }
        room.Customer = null;
        DbContext.SaveChanges();
        return true;
    }
    
    public void AddEmployee(Employee em)
    {
        if(string.IsNullOrEmpty(em.Name) ||
            string.IsNullOrEmpty(em.CardNo) ||
            string.IsNullOrEmpty(em.Position) ||
            string.IsNullOrEmpty(em.UserAccount?.UserName) ||
            string.IsNullOrEmpty(em.UserAccount.Password))
        {
            throw new ArgumentException("Please Provide All data!!");
        }
        DbContext.Employees.Add(em);
        DbContext.SaveChanges();
    }

    public void UpdateRoom(string RID, string RNumber, string RType, string RBed, string RPrice)
    {
        if(string.IsNullOrEmpty(RNumber) || string.IsNullOrEmpty(RType) ||
            string.IsNullOrEmpty(RType) || string.IsNullOrEmpty(RBed) ||
            string.IsNullOrEmpty(RPrice))
        {
            throw new ArgumentException("Please Provide All Data!");
        }
        var rm = DbContext.Rooms.Find(new Guid(RNumber));
        if(rm == null )
        {
            throw new ArgumentException("Rooms not found");
        }
        rm.RNumber = RNumber;
        rm.RType = RType;
        rm.RBed = RBed;
        rm.RPrice = RPrice;
        DbContext.SaveChanges();
    }
    
    public void UpdateCustomer(string CsId, string Name, string Phone, string Nationality, string Gender, string NICNO)
    {
        if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Phone) ||
            string.IsNullOrEmpty(Nationality) ||  string.IsNullOrEmpty(Gender) ||
            string.IsNullOrEmpty(NICNO))
        {
            throw new ArgumentException("Please Provide All Data!");
        }
        var cs = DbContext.Customers.Find(new Guid(CsId));
        if(cs == null)
        {
            throw new ArgumentException("Customer Not Found");
        }
        cs.Name = Name;
        cs.Phone = Phone;
        cs.Nationality = Nationality;
        cs.Gender = Gender;
        cs.NICNO = NICNO;
        DbContext.SaveChanges();
    }
    public void UpdateEmployee(string IdentityId, string Name, string Position)
    {
        if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Position))
        {
            throw new ArgumentException("Please Provide All Data!");
        }
        var em = DbContext.Employees.Find(new Guid(IdentityId));
        if (em == null)
        {
            throw new ArgumentException("Employee Not Found");
        }
        em.Name = Name;
        em.Position = Position;
        DbContext.SaveChanges();
    }
    
    public List<RoomView> GetAllRoom()
    {
        return DbContext.Rooms.Select(rm=> new RoomView()
        {
            RoomID = rm.RID,
            RNumber = rm.RNumber,
            RBed = rm.RBed,
            RPrice = rm.RPrice,
            RType = rm.RType

        }).ToList();
    }
    public List<Room> GetAllRoom(bool isSimpleVersion)
    {
        return DbContext.Rooms.ToList();
    }
    public List<CustomerView> GetCustomer()
    {
        return DbContext.Customers.Select(cs => new CustomerView() {
            CustomerId = cs.CsId,
            CName = cs.Name,
            CRoom = cs.CRoom,
            CPhone = cs.Phone,
            CNationality = cs.Nationality,
            CNICNO = cs.NICNO,
            DateofBirth = cs.DateofBirth,
            CheckIn = cs.CheckIn
            
        }).ToList();
    }

    public List<EmployeeView> GetAllEmployee()
    {
        return DbContext.Employees.Select(em => new EmployeeView()
        {
            IdentityId = em.IdentityId,
            Name = em.Name,
            CardNo = em.CardNo,
            Position = em.Position,

        }).ToList();

    }


}
