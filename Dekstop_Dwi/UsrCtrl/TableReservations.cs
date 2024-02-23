using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekstop_Dwi
{
    public partial class TableReservations : UserControl
    {
        int i;
        Reservations reser = null;
        public TableReservations(int i, Reservations reservation = null)
        {
            InitializeComponent();
            this.i = i;
            reser = reservation;
          
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Parent.Parent.Parent is ViewReservation reservation)
            {
                reservation.clickselect(reser);
            }
        }

        private void TableReservations_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = reser == null ? Properties.Resources.table_free : Properties.Resources.table_reserved;
            label3.Text = i.ToString();
        }
    }
}
