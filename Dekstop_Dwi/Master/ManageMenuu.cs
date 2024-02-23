using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekstop_Dwi
{
    public partial class ManageMenuu : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        bool isinsert = true;
        public ManageMenuu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Menus m)
            {
                if(e.ColumnIndex ==  CategoryColumn.Index)
                {
                    e.Value = m.Categories.Name;
                }
                if(e.ColumnIndex == PriceColumn.Index)
                {
                    e.Value = m.Price.ToString("C2");
                }
            }
        }

        private void ManageMenuu_Load(object sender, EventArgs e)
        {
            menusBindingSource.Clear();
            menusBindingSource.AddNew();
            nameTextBox.Enabled = false;
            categoryIDComboBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            priceNumericUpDown.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = true; button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            bindingSource1.DataSource = db.Menus.ToList();
            bindingSource2.DataSource = db.Categories.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                button1.Enabled = true;
                button2.Enabled = false; button3.Enabled = false;
                nameTextBox.Enabled = true;
                categoryIDComboBox.Enabled = true;
                descriptionTextBox.Enabled = true;
                priceNumericUpDown.Enabled = true;
           
                button4.Enabled = true;
                button5.Enabled = true;
            reset();
              //  dataGridView1.Enabled = false;
            
        }

        void reset()
        {
            nameTextBox.Text = categoryIDComboBox.Text = descriptionTextBox.Text = priceNumericUpDown.Text =  "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if((nameTextBox.Text == string.Empty) || (categoryIDComboBox.Text == string.Empty) || (descriptionTextBox.Text == string.Empty) || (priceNumericUpDown.Text == string.Empty))
            {
                MessageBox.Show("Data Tidak Boleh Kosong");
            }
            else
            {
                if (menusBindingSource.Current is Menus mm)
                {
                    if (isinsert)
                    {
                        db.Menus.Add(mm);
                        MessageBox.Show("Data Berhasil Disimpan");
                    }
                    else
                    {
                        db.Menus.AddOrUpdate(mm);
                        MessageBox.Show("Data Berhasil Diubah");
                    }
                    db.SaveChanges();
                    ManageMenuu_Load(sender, e);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bindingSource1.Current is Menus mm)
            {
                var ubah = db.Menus.Where(f=> f.ID == mm.ID).FirstOrDefault();  

                if(ubah != null)
                {
                    string nama = ubah.Name;
                    DialogResult dr =MessageBox.Show($"Yakin Akan Mengubah Data Ini ?{nama} ", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        button1.Enabled = false;
                        button3.Enabled = false;
                        nameTextBox.Enabled = true;
                        categoryIDComboBox.Enabled = true;
                        descriptionTextBox.Enabled = true;
                        priceNumericUpDown.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                        isinsert = false;

                        menusBindingSource.DataSource = ubah;
                        isinsert = false;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(bindingSource1.Current is Menus m )
            {
                var hapus = db.Menus.Where(f=> f.ID == m.ID).FirstOrDefault();
                if(hapus != null)
                {
                    string nama = hapus.Name;
                    DialogResult dr = MessageBox.Show($"Yakin Akan Menghapus Data Ini {nama} ?","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        db.Menus.Remove(hapus);
                        db.SaveChanges();
                        MessageBox.Show("Data Berhasil Dihapus");
                        ManageMenuu_Load(sender,e);
                    }
                }
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( bindingSource1.Current is Menus m )
            {
                   menusBindingSource.DataSource = db.Menus.Where(f=> f.ID == m.ID).ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string searchText = textBox1.Text.ToLower();

           
            var searchResults = db.Users
                .Where(u => u.FirstName.ToLower().Contains(searchText) ||
                            u.LastName.ToLower().Contains(searchText) ||
                            u.Email.ToLower().Contains(searchText))
                .ToList();

            bindingSource2.DataSource = searchResults;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nameTextBox.Enabled = false;
            categoryIDComboBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            priceNumericUpDown.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = true; button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            reset();
        }
    }
}
