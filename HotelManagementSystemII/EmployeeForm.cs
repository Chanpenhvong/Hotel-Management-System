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

public partial class EmployeeForm : Form
{
    Hotel hotel;
    public EmployeeForm(Hotel hotel)
    {
        InitializeComponent();
        this.hotel = hotel;
        LoadToGrid();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            var em = new Employee()
            {
                Name = TextName.Text.Trim(),
                CardNo = TextCardno.Text.Trim(),
                Position = TextPosition.Text.Trim(),
                UserAccount = new UserAccount()
                {
                    UserName = TextUsername.Text.Trim(),
                    Password = TextPassword.Text.Trim(),
                }
            };
            hotel.AddEmployee(em);
            LoadToGrid();
        }
        catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        }

    }
    private void LoadToGrid()
    {
        dataGridView1.DataSource = hotel.GetAllEmployee();
        dataGridView1.Refresh();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            hotel.UpdateEmployee(TextIdentityid.Text, TextName.Text, TextPosition.Text);
            LoadToGrid();
        }
        catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        }
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
        if(dataGridView1.SelectedRows != null  && dataGridView1.SelectedRows.Count > 0)
        {
            TextIdentityid.Text = dataGridView1.SelectedCells[0].Value.ToString();
            TextName.Text = dataGridView1.SelectedCells[1].Value.ToString();
            TextPosition.Text = dataGridView1.SelectedCells[2].Value.ToString();
            TextCardno.Text = dataGridView1.SelectedCells[3].Value.ToString();
            

        }
    }
}
