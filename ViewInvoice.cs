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
        public ViewInvoice(
            string roomID,string userID,
            string waterPrice,string TotalwaterNumber,
            string edcPrice, string TotaledcNumber,
            string TrashExpense,string VehicleSpaceExpense,
            string RoomPrice)
        {
            InitializeComponent();
            LB_roomid.Text = roomID;
            LB_userID.Text = userID;
            lb_RoomExpense.Text = RoomPrice;
            lb_edcExpense.Text = 
                (float.Parse(TotaledcNumber) * float.Parse(edcPrice)).ToString() ;
            lb_waterExpense.Text = 
                (float.Parse(TotalwaterNumber) * float.Parse(waterPrice)).ToString();
            lb_trashExpense.Text = 
                (float.Parse(TrashExpense)).ToString();
            lb_vehicleExpense.Text = 
                (float.Parse(VehicleSpaceExpense)).ToString();
            Total_Price.Text = 
                (float.Parse(lb_RoomExpense.Text) + float.Parse(lb_edcExpense.Text) + 
                float.Parse(lb_waterExpense.Text) + float.Parse(lb_trashExpense.Text) +
                float.Parse(lb_vehicleExpense.Text)).ToString();

        }
    }
}
