using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekstop_Dwi
{
    public partial class Menu_Admin : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        int id;
        public Menu_Admin(int id)
        {
            var users = db.Users.Where(f=> f.ID == id).FirstOrDefault();
            InitializeComponent();
            this.id = id;
            label1.Text = $"Welcome,{users.FirstName} {users.LastName}";
        }

        private void Menu_Admin_Load(object sender, EventArgs e)
        {

        }


        void openForm<T>(T form,FormClosedEventHandler formClosed) where T :Form
        {
            form.Show();
            form.FormClosed += formClosed;

        }
        void  formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda Yakin Akan Logout Dari Form Ini ?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Login f = new Login();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ManageMemberss bs = new ManageMemberss();
            bs.Show();
          //  this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageMenuu mm = new ManageMenuu();
            mm.Show();  
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmManageMenuIngredients i = new FrmManageMenuIngredients();
            i.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          ViewReservation frmViewReservation = new ViewReservation();
            
            frmViewReservation.Show();
            //this.Hide();
        }
    }
}
