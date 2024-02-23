using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekstop_Dwi.UsrCtrl
{
    public partial class TblLayout : UserControl
    {
        int i;
        Reservations reser;
        public TblLayout(int i, Reservations reser )
        {
            InitializeComponent();
            this.i = i;
            this.reser = reser;
        }

        private void TblLayout_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = reser == null ? Properties.Resources.table_free : Properties.Resources.table_reserved;
            label3.Text = i.ToString();
        }
    }
}
