using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekstop_Dwi
{
    public partial class ManageMemberss : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        bool isInsert = true;
        public ManageMemberss()
        {
            InitializeComponent();
        }

        void enabled()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            phoneNumberTextBox.Enabled = false;
        }

        private void ManageMemberss_Load(object sender, EventArgs e)
        {
            enabled();
            bindingSource1.Clear(); 
            bindingSource1.AddNew();
            bindingSource2.DataSource = db.Users.Where(f => f.RoleID == 2).ToList();
        }

        private bool IsEmailValid(string email)
        {

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {

            return phoneNumber.All(char.IsDigit) && phoneNumber.Length >= 10 && phoneNumber.Length <= 15;
        }

        private bool IsPasswordValid(string password)
        {
              
            return password.Length >= 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                button1.Enabled = true;
                button2.Enabled = false; button3.Enabled = false;
                firstNameTextBox.Enabled = true;
                lastNameTextBox.Enabled = true;
                emailTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
                phoneNumberTextBox.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
             //   dataGridView1.Enabled = false;
                reset();
                /*   usr.RoleID = 2; 
                   usr.DateJoined = DateTime.Now;  

                   db.SaveChanges();
                   ManageMemberss_Load(sender, e); */
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Users usr)
            {
              
                    if (e.ColumnIndex == MemberSinceColumn.Index)
                    {

                    DateTime memberSinceDate = usr.DateJoined;


                    int age = DateTime.Now.Year - memberSinceDate.Year;


                    e.Value = $"{memberSinceDate:dd/MM/yyyy} {{ {age} years }}";

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(bindingSource2.Current is Users usr)
            {
                var delete = db.Users.Where(f=> f.ID == usr.ID).FirstOrDefault();

                if(delete != null)
                {
                    string nama = delete.FirstName + delete.LastName;
                    DialogResult dr = MessageBox.Show($"Yakin Akan Menghapus Data Ini {nama} ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        button1.Enabled = false;
                        button2.Enabled = false;
                        db.Users.Remove(delete);
                        db.SaveChanges();
                        MessageBox.Show("Data Berhasil Dihapus");
                        ManageMemberss_Load(sender, e);
                     
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bindingSource2.Current is Users usr)
            {
                 var ubah = db.Users.Where(f=> f.ID==usr.ID).FirstOrDefault();  

                if(ubah != null)
                {
                    string nama = ubah.FirstName + ubah.LastName;
                    DialogResult dr = MessageBox.Show($"Yakin Akan Mengubah Data Ini  {nama}?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        button1.Enabled = false;
                        button3.Enabled = false;
                        firstNameTextBox.Enabled = true;
                        lastNameTextBox.Enabled = true;
                        emailTextBox.Enabled = true;
                        passwordTextBox.Enabled = true;
                        phoneNumberTextBox.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                        isInsert = false;
                        bindingSource1.Clear();
                        bindingSource1.DataSource = ubah;   
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(bindingSource1.Current is Users usr)
            {
                if((firstNameTextBox.Text == string.Empty) || (lastNameTextBox.Text == string.Empty) || (emailTextBox.Text == string.Empty) ||(emailTextBox.Text==string.Empty) || (passwordTextBox.Text == string.Empty) || (phoneNumberTextBox.Text == string.Empty))
                {
                    MessageBox.Show("Data Tidak Boleh Kosong");

                }
                else
                {
                    if (!IsEmailValid(usr.Email))
                    {
                        MessageBox.Show("Format Email Tidak Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!IsPhoneNumberValid(usr.PhoneNumber))
                    {
                        MessageBox.Show("Nomor Telepon Tidak Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!IsPasswordValid(usr.Password))
                    {
                        MessageBox.Show("Panjang Kata Sandi Harus Setidaknya 8 Karakter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Mengecek apakah email sudah digunakan sebelumnya
                    if (db.Users.Any(u => u.Email == usr.Email))
                    {
                        MessageBox.Show("Email Sudah Digunakan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (isInsert)
                    {
                        usr.RoleID = 2;
                        usr.DateJoined = DateTime.Now;
                        db.Users.Add(usr);
                        MessageBox.Show("Data Berhasil Disimpan");
                    }
                    else
                    {
                        db.Users.AddOrUpdate(usr);
                        MessageBox.Show("Data Berhasil Diubah");
                        isInsert = false;
                    }


                    db.SaveChanges();
                    enabled();
                    ManageMemberss_Load(sender, e);
                    //isInsert = true;
                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            button2.Enabled = true;
            button2.Enabled = false;
            enabled();
            reset();
            bindingSource1.AddNew();
        }

        void reset ()
        {
            firstNameTextBox.Text = lastNameTextBox.Text = emailTextBox.Text = phoneNumberTextBox.Text = passwordTextBox.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cari = textBox1.Text.ToLower();


            var carii = db.Users.Where(p => p.FirstName.ToLower().Contains(cari) || p.LastName.ToLower().Contains(cari) || p.Email.ToLower().Contains(cari)).ToList();
            bindingSource2.DataSource = carii;
         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Users usr)
            {
                bindingSource1.DataSource = db.Users.Where(f=>f.ID ==  usr.ID).ToList();    
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
