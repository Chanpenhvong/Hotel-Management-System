using HotelManagementSystemII.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystemII.Features;
using HotelManagementSystemII.Entity;

namespace HotelManagementSystemII;

public partial class MainForm : Form
{
    private Hotel _hotel;

    public MainForm(Hotel hotel)
    {
        InitializeComponent();
        _hotel = hotel;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void btnAddroom_Click(object sender, EventArgs e)
    {
        RoomForm rform = new RoomForm(_hotel);
        rform.ShowDialog();
    }

    private void btnCmRegister_Click(object sender, EventArgs e)
    {
        CustomerForm csform = new CustomerForm(_hotel);
        csform.ShowDialog();
    }



    private void btnCheckout_Click(object sender, EventArgs e)
    {
        CheckoutForm ckoteform = new CheckoutForm(_hotel);
        ckoteform.ShowDialog();
    }

    private void btnEmployee_Click(object sender, EventArgs e)
    {
        EmployeeForm emform = new EmployeeForm(_hotel);
        emform.ShowDialog();
    }
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Exit or no? ",
                            "Hotel Management System",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.No)
        {
            e.Cancel = true;
        }
        else
        {
            System.Environment.Exit(1);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
