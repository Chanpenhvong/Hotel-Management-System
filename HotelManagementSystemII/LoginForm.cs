using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystemII;
using HotelManagementSystemII.Features;

namespace HotelManagementSystemII;

public partial class LoginForm : Form
{
    private Hotel _hotel;
    public LoginForm(Hotel hotel)
    {
        InitializeComponent();
        _hotel = hotel;
    }
    private void btnLogin_Click(object sender, EventArgs e)
    {
        var us = TextUsername.Text.Trim();
        var pw = TextPassword.Text.Trim();
        Authentication auth = new Authentication(_hotel.DbContext, us, pw);
        try
        {
            bool result = auth.ValidateLogin();
            if (result)
            {
                this.Hide();
                MainForm mfrm = new MainForm(_hotel);
                mfrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
        }
        catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        }

    }

    private void LoginForm_Load(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
