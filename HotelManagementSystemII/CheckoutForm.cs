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

public partial class CheckoutForm : Form
{
    Hotel hotel;
    public CheckoutForm(Hotel hotel)
    {
        InitializeComponent();
        this.hotel = hotel;
        LoadToGrid();
    }

    private void CheckoutForm_Load(object sender, EventArgs e)
    {

    }

    private void btnCheckout_Click(object sender, EventArgs e)
    {
        try
        {
            var co = new CheckOut()
            {
                Name = Textname.Text.Trim(),
                Date = dateCheckout.Text.Trim()
            };

            if (co.Name != "" && hotel.IsRoomFree(co.Name))
            {
                hotel.Checkout(co.Name);
                MessageBox.Show("Customer checked out successfully!");
            }
            else
            {
                MessageBox.Show("Customer not found or room not free!");
            }
        }catch(ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        }
    }
    public void LoadToGrid()
    {
        dataGridView1.DataSource = hotel.GetCustomer();
        dataGridView1.Refresh();
    }
}
