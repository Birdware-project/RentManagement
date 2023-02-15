using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneyhome
{
    public partial class ViewInvoice : Form
    {
        public ViewInvoice(string roomID,string waterPrice,string waterNumber, string edcTotalExpense,
            string TrashExpense,string VehicleSpaceExpense,string RoomPrice,string edcPrice,string Trashservice,string VehicleSpace)
        {
            InitializeComponent();
            lb_RoomExpense.Text = RoomPrice;
            lb_edcExpense.Text = (float.Parse(edcTotalExpense) * float.Parse(edcPrice)).ToString() ;
            lb_waterExpense.Text = (float.Parse(waterNumber) * float.Parse(waterPrice)).ToString();
            lb_trashExpense.Text = (float.Parse(TrashExpense) * float.Parse(Trashservice)).ToString();
            lb_vehicleExpense.Text = (float.Parse(VehicleSpaceExpense) * float.Parse(VehicleSpace)).ToString();
            Total_Price.Text = (float.Parse(lb_RoomExpense.Text) + float.Parse(lb_edcExpense.Text) + 
                float.Parse(lb_waterExpense.Text) + float.Parse(lb_trashExpense.Text) +
                float.Parse(lb_vehicleExpense.Text)).ToString();

        }
    }
}
