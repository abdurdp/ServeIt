using Serveit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serveit
{
    public partial class LogIn : Form
    {
        ServeitDBEntities sdbe = new ServeitDBEntities();
       
        public LogIn()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            passbox.PasswordChar = '*';
            passbox.MaxLength = 10;  
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            var x = from o in sdbe.UserLists where o.Name == useridtextbox.Text && o.PassWord == passbox.Text select o;
            try
            {
                if (x.SingleOrDefault()!=null)
                {
                  
                    MainPage mp = new MainPage();
                    mp.userInfo(useridtextbox.Text);
                    // hide main form
                    this.Hide();

                    // show other form
                    mp.ShowDialog();

                    // close application
                    this.Close();
                }
                else
                {
                    label1.Text = "username or password incorrect";
                }
                
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine("Exception caught: {0}", a);
                
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            useridtextbox.Text = "";
        }

        private void passbox_Click(object sender, EventArgs e)
        {
            passbox.Text = "";
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Registeration r = new Registeration();
            r.ShowDialog();
        }
    }
}
