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

public partial class RoomForm : Form
{
    Hotel hotel;
    public RoomForm(Hotel hotel)
    {
        InitializeComponent();
        this.hotel = hotel;
        LoadToGrid();
    }

    private void RoomForm_Load(object sender, EventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            var rm = new Room()
            {
                RNumber = TextRNumber.Text.Trim(),
                RBed = cbBed.Text.Trim(),
                RType = cbRtype.Text.Trim(),
                RPrice = TextPrice.Text.Trim()
            };
            hotel.AddRoom(rm);
            LoadToGrid();
        }
        catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);

        };
    }
    private void LoadToGrid()
    {
        dataGridView1.DataSource = hotel.GetAllRoom();
        dataGridView1.Refresh();
    }
    private void LoadToGrid(bool isSimpleVersion)
    {
        dataGridView1.DataSource = hotel.GetAllRoom(isSimpleVersion);
        dataGridView1.Refresh();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            hotel.UpdateRoom(TextRoomid.Text, TextRNumber.Text, cbBed.Text, cbRtype.Text, TextPrice.Text);
            LoadToGrid();
        }
        catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        };
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
        {
            TextRoomid.Text = dataGridView1.SelectedCells[0].Value.ToString();
            TextRNumber.Text = dataGridView1.SelectedCells[1].Value.ToString();
            cbBed.Text = dataGridView1.SelectedCells[2].Value.ToString();
            cbRtype.Text = dataGridView1.SelectedCells[3].Value.ToString();
            TextPrice.Text = dataGridView1.SelectedCells[4].Value.ToString();

        }
    }
}
