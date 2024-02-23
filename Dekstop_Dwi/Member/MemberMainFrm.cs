using System;
using System.Collections.Generic;
using Dekstop_Dwi.UsrCtrl;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace Dekstop_Dwi
{
    public partial class MemberMainFrm : Form
    {
       EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
      
        private readonly Users User;
        public MemberMainFrm( Users user)
        {
           
            InitializeComponent();
           
            label1.Text = $"Welcome ,{user.FirstName} {user.LastName}";
            User = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new ReserveTableFrm(User));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openForm(new ReservationHistory());
        }

        void openForm<T>(T form) where T : Form
        {
            form.Show();
            form.FormClosed += FormClosed;
            Hide();
        }

        void FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
        private void MemberMainFrm_Load(object sender, EventArgs e)
        {
            usrcntrl();
            timer1.Start();
          
        }

        void usrcntrl()
        {
            flowLayoutPanel1.Controls.Clear();
            var list = new List<Reservations>();

             for(int i = 0; i < 12; i++)
             {
                list.Add(null);
             }

            db.Reservations.Where(x => x.ReservationDate == DateTime.Today).ToList().ForEach(x =>{
                list[x.TableID - 1] = x;
            });

            var l = 0;
            foreach(var item in list)
            {
                flowLayoutPanel1.Controls.Add(new TblLayout(l + 1, item));
                l++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Current Time : " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Apakah Anda Yakin Akan Logout Dari Form Ini {User.FirstName +  User.LastName}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }
    }
}
