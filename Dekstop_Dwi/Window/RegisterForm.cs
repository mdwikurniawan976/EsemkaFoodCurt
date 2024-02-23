using Dekstop_Dwi.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Dekstop_Dwi
{
    public partial class RegisterForm : Form
    {
            EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
            public RegisterForm()
            {
                InitializeComponent();
            }

            private void button2_Click(object sender, EventArgs e)
            {
               Login form1 = new Login();
                form1.Show();
                this.Hide();
            }


        private bool password(string password)
        {
            return password.Length >= 8;
        }
        private bool phone(string phone) {
            return phone.All(char.IsDigit) && phone.Length >=10  && phone.Length <= 15;
        }

          private bool isemail(string email)
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
        private void button1_Click(object sender, EventArgs e)
        {
           if((textBox1.Text == string.Empty )|| (textBox2.Text ==string.Empty ) || (textBox3.Text ==string.Empty ) || (textBox4.Text == string.Empty) || (textBox5.Text == string.Empty)    || (textBox6.Text == string.Empty ))
            {
                MessageBox.Show("Data Tidak Boleh Kosong","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
               
            }
            else
            {
                if (!isemail(textBox3.Text))
                {
                    MessageBox.Show("Format Email Tidak Valid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(!phone(textBox4.Text))
                {
                    "Phone Number Harus Berupa Angka dan minimal 10 karakter maksimal 15 Karakter ".DialogError();
                    return;
                }
                if (!password(textBox5.Text))
                {
                    MessageBox.Show("Password Minimal 8 Digit","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                if (textBox5.Text != textBox6.Text)
                {
                    MessageBox.Show("Password dan Confirm Password tidak sesuai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Users users = new Users
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    Email = textBox3.Text,
                    PhoneNumber = textBox4.Text,
                    Password = textBox5.Text,
                    RoleID = 2,
                    DateJoined = DateTime.Now,
                };

                db.Users.Add(users);
                db.SaveChanges();
                "Register Berhasil".Dialoginfo();
                MemberMainFrm main = new MemberMainFrm(users);
                main.Show();
                this.Hide();    
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
