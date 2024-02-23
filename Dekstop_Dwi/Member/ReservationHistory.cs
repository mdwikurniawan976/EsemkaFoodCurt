using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekstop_Dwi
{
   
    public partial class ReservationHistory : Form
    {   
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities(); 
        public ReservationHistory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Reservations s)
            {
                if(e.ColumnIndex == TblColumn.Index)
                {
                    e.Value = s.Tables.Name;
                }
                if(e.ColumnIndex == PriceC.Index)
                {
                    if (s.ReservationDetails != null && s.ReservationDetails.Any())
                    {
                        // Ambil harga dari Menu pertama dalam ReservationDetails
                        e.Value = s.ReservationDetails.First().Menus.Price;
                    }
                }

            }
        }

        private void ReservationHistory_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = db.Reservations.ToList();
            bindingSource2.DataSource = db.ReservationDetails.ToList();
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is ReservationDetails s)
            {
                var formatRupiah = CultureInfo.CreateSpecificCulture("id-ID");
                if (e.ColumnIndex == MenuC.Index)
                {
                    e.Value = s.Menus.Name;
                }
                if(e.ColumnIndex == PriceC2.Index)
                {
                    e.Value = s.Menus.Price.ToString("C2",formatRupiah);
                }
                if(e.ColumnIndex == SubTotalC.Index)
                {
                    var total = s.Menus.Price * s.Qty;

                    e.Value = total.ToString("C2",formatRupiah);
                }
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if(bindingSource1.Current is Reservations rs)
            {
                bindingSource2.DataSource = rs.ReservationDetails.ToList();
            }
        }
    }
}
