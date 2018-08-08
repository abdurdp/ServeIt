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
    public partial class EditReceipt : Form
    {

        string name, id, access;
        public EditReceipt()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MainPage mp = new MainPage(name, id, access);
                // hide main form
                this.Hide();

                // show other form
                mp.ShowDialog();

                // close application
                this.Close();
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine("Exception caught: {0}", a);
            }
        }

        private void newitembtn_Click(object sender, EventArgs e)
        {           
            try
            {
                EditMenuItem emi = new EditMenuItem();
                
                // show other form
                emi.ShowDialog();
                
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine("Exception caught: {0}", a);
            }

        }

        public EditReceipt(string uname, string uid, string uaccess)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            idlabel.Text = uid;
            namelabel.Text = uname;
            accesslabel.Text = uaccess;

            name = namelabel.Text;
            id = idlabel.Text;
            access = accesslabel.Text;
        }
        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
