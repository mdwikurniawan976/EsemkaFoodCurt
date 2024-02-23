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
    public partial class Login : Form
    {

        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities(); 
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                MessageBox.Show("Emaill Cannot Be Empty")
                    ; return;

            }
            if(textBox2.Text == string.Empty)
            {
                MessageBox.Show("Password Cannot Be Empty");
            }
            
              Users users = db.Users.Where(f=> f.Email == textBox1.Text && f.Password == textBox2.Text).FirstOrDefault();
            
            if(users != null)
            {
                if(users.RoleID ==1)
                {
                    MessageBox.Show($"Login Succes , Welcome Back {users.FirstName + users.LastName}");
                    Menu_Admin ad = new Menu_Admin(users.ID);
                    ad.Show();
                    this.Hide();

                }
                else
                {
                  
                    MemberMainFrm a = new MemberMainFrm(users);
                    a.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("The Email Or Password Incorrect");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         /*   textBox1.Text = "dgannyt@squidoo.com";
            textBox2.Text = "dN1|qg!,xuZ";*/
            textBox1.Text = "nfirbanks4@slate.com";
            textBox2.Text = "bT9,6J643";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm a = new RegisterForm();
            a.Show();
            this.Hide();
        }
    }
}
