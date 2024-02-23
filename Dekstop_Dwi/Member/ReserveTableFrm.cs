using Dekstop_Dwi.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Dekstop_Dwi
{
    
    public partial class ReserveTableFrm : Form
    {   EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();

        private readonly Users User;
        public ReserveTableFrm(Users user)
        {
            InitializeComponent();
            User = user;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ReservationsBindingSource.Current is Reservations rs )
            {
                rs.Users = null;
                db.Reservations.AddOrUpdate(rs);
                if(ReservationsBindingSource.Count > 0)
                {
                    foreach (ReservationDetails detail in Details.List)
    
                    {
                        detail.Reservations = rs;
                        db.ReservationDetails.AddOrUpdate(detail);  
                    }


                    int result = db.SaveChanges();

                    if (result > 0)
                    {
                        MessageBox.Show("Your reservation is saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new MemberMainFrm(User).Show();
                        this.Hide();   
                    }
                    else
                    {
                        "Cannot save your reservation".DialogError();
                    }
                }
            }
        }

        private void ReserveTableFrm_Load(object sender, EventArgs e)
        {
            ReservationsBindingSource.Add(new Reservations
            {
                Users = User,
                UserID = User.ID,
                CustomerFirstName = User.FirstName,
                CustomerLastName = User.LastName,
                CustomerEmail = User.Email,
                CustomerPhoneNumber = User.PhoneNumber,
                ReservationDate = DateTime.Today
            });
            FormBindingSource.DataSource = new ReservationDetails();
            MenuDg.DataSource = db.Menus.ToList();
            comboBox2.SelectedIndex = -1;
 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (FormBindingSource.Current is ReservationDetails detail)
            {
               // bool isValid = true;
               
                   ReservationDetails x = Details.List.Cast<ReservationDetails>().Where(ex=> ex.MenuID == detail.MenuID).FirstOrDefault();
                    if (x != null)
                    {
                        x.Qty += x.Qty;
                        Details.EndEdit();
                       Details.ResetBindings(false);
                    }
                    else
                    {
                        FormBindingSource.EndEdit();
                        detail.Menus = comboBox2.SelectedItem as Menus;
                        Details.Add(detail);
                    }
                    FormBindingSource.Clear();
                    FormBindingSource.AddNew();

                    numericUpDown2.Value = 0;
                    comboBox2.SelectedIndex = -1;
                
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < Details .Count)
            {
                ReservationDetails detail = dataGridView1.Rows[e.RowIndex].DataBoundItem as ReservationDetails;
                if (e.ColumnIndex == MenuC.Index)
                {
                    e.Value = detail.Menus.Name;
                }

                if (e.ColumnIndex == PriceC.Index)
                {
                    e.Value = detail.Menus.Price.ToString("C", new CultureInfo("id-ID"));
                }

                if (e.ColumnIndex == SubTotalC.Index)
                {
                    e.Value = (detail.Menus.Price * detail.Qty).ToString("C", new CultureInfo("id-ID"));
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            customerFirstNameTextBox.ReadOnly =
              customerLastNameTextBox.ReadOnly =
              customerEmailTextBox.ReadOnly =
              customerPhoneNumberTextBox.ReadOnly = checkBox1.Checked;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;

            Tableb.DataSource = db.Tables.Where(x => x.Reservations.Where(e1 => e1.ReservationDate == date).Count() == 0).ToList();
        }

        private void Details_CurrentChanged(object sender, EventArgs e)
        {
            if (Details.List is BindingList<ReservationDetails> reservations)
            {
                double totalPrice = 0;
                foreach (ReservationDetails detail in reservations)
                {
                    totalPrice += detail.Menus.Price * detail.Qty;
                }
                label11.Text = $"Menu Total: {totalPrice.ToString("C", new CultureInfo("id-ID"))}";
                label12.Text = $"Total Price : {(totalPrice + 50000).ToString("C", new CultureInfo("id-ID"))}";

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == RemoveC.Index)
            {
                Details.Remove(dataGridView1.Rows[e.RowIndex].DataBoundItem);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MemberMainFrm(User).Show();
            this.Hide();
        }
    }
}
