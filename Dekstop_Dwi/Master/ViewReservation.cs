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
    public partial class ViewReservation : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public ViewReservation()
        {
            InitializeComponent();
        }

        private void ViewReservation_Load(object sender, EventArgs e)
        {
            Reset();
        }
        public void clickselect(Reservations reser)
        {
            bindingSource3.Clear();
            bindingSource3.Add(reser);
            if (reser != null)
                bindingSource2.DataSource = reser.ReservationDetails;
            else
                bindingSource2.Clear();
        }

        void Reset()
        {
            flowLayoutPanel1.Controls.Clear();
            bindingSource3.DataSource = db.Reservations.Where(x => x.ReservationDate == dateTimePicker1.Value).ToList();


            var list_table = new List<Reservations>();

            for (int i = 0; i < 12; i++)
            {
                list_table.Add(null);
            }

            db.Reservations.Where(x => x.ReservationDate == dateTimePicker1.Value.Date).ToList().ForEach(x =>
            {
                list_table[x.TableID - 1] = x;
            });


            var l = 0;
            foreach (var item in list_table)
            {
                flowLayoutPanel1.Controls.Add(new TableReservations(l + 1, item));
                l++;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is ReservationDetails detail)
            {
                var formatRupiah = CultureInfo.CreateSpecificCulture("id-ID");

                if (e.ColumnIndex == MenuName.Index) e.Value = detail.Menus.Name;
                if (e.ColumnIndex == PriceColumn.Index) e.Value = detail.Menus.Price.ToString("C2", formatRupiah);
                if (e.ColumnIndex == SubTColumn.Index) e.Value = (detail.Menus.Price * detail.Qty).ToString("C2", formatRupiah);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
