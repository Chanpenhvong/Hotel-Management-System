using HotelManagementSystemII.Entity;
using HotelManagementSystemII.Features;



namespace HotelManagementSystemII;

internal static class Program
{
    
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    

    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Hotel AppHotel = new Hotel();
        AppHotel.DbContext.Database.EnsureCreated();
        var em = AppHotel.DbContext.Employees.FirstOrDefault();
        if (em == null) {
            var aem = new Employee()
            {
                Name = "VIRAPHA",
                Position = "COMPUTER",
                CardNo = "P013",
                UserAccount = new UserAccount()
                {
                    UserName = "VIRAPHA",
                    Password = "013"
                }
            };
            AppHotel.DbContext.Employees.Add(aem);
            AppHotel.DbContext.SaveChanges();
        }
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        Application.Run(new LoginForm(AppHotel));
    
    }
}