using HotelManagementSystemII.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystemII.Entity;
using HotelManagementSystemII.Features;

namespace HotelManagementSystemII;

public partial class CustomerForm : Form
{
    Hotel hotel;
    public CustomerForm(Hotel hotel)
    {
        InitializeComponent();
        this.hotel = hotel;
    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    private void btnCheckin_Click(object sender, EventArgs e)
    {
        try
        {
            var cs = new Customer()
            {
                Name = TextName.Text.Trim(),
                Phone = TextPhone.Text.Trim(),
                Nationality = TextNationality.Text.Trim(),
                NICNO = TextNICNO.Text.Trim(),
                Gender = CbGender.Text.Trim(),
                CheckIn = dateTimeChechin.Text.Trim(),
                DateofBirth = dateTimeChechin.Text.Trim(),
                Room = new Room()
                {
                    RNumber = TextRnumber.Text.Trim(),
                    RType = TextRtype.Text.Trim(),
                    RBed = TextBed.Text.Trim(),
                    RPrice = TextPrice.Text.Trim(),
                }
            };
            if (hotel.IsRoomFree(cs.Room.RNumber)) {
            hotel.AddCustomer(cs);
            }
            else
            {
                MessageBox.Show("The room is not available!");
            }
            
        }
        catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        }
    }
}
