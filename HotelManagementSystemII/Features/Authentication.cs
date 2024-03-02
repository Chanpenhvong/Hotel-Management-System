using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystemII.Entity;

namespace HotelManagementSystemII.Features;

public class Authentication
{
    private HotelDbContext _context;
    private string username;
    private string password;
    public Authentication(HotelDbContext context , string username, string password)
    {
        _context = context;
        this.username = username;
        this.password = password;
    }
    public bool IsAuthenticated { get; private set; } = false;
    public bool ValidateLogin()
    {
        if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            throw new ArgumentException("Please provide all data!!");

        }
        var user = _context.UserAccounts.
            Where(u =>  u.UserName == username.Trim() && u.Password == password.Trim()).
            FirstOrDefault();
        if(user == null)
        {
            return IsAuthenticated = false; 
        }
        return IsAuthenticated = true;
    }
    public void LogOut()
    {
        IsAuthenticated = false;
    }
}
