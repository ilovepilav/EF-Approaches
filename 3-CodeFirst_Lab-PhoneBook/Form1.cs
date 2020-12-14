using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Context;
using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Repositories.Concrete;
using _3_CodeFirst_Lab_PhoneBook.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_CodeFirst_Lab_PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
            
        
        private void Form1_Load(object sender, EventArgs e)
        {

            EfAppUserRepository efAppUser = new EfAppUserRepository();
            if (efAppUser.GetByUsername("testtesttest")==null)
            {
                efAppUser.Add("testtesttest", "testtesttest", "testtesttest", "testtesttest");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginUsername.Text=="" | mskPassword.Text=="")
            {
                MessageBox.Show("Fields are empty");
            }
            else
            {
                EfAppUserRepository efAppUser = new EfAppUserRepository();
                if (efAppUser.GetByUsername(txtLoginUsername.Text)!=null)
                {
                    if ((efAppUser.GetByUsername(txtLoginUsername.Text)).Password==mskPassword.Text)
                    {
                        MessageBox.Show("Login Success");
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("There is no username");
                }
            }
        }
    }
}
