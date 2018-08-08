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
    public partial class MainPage : Form
    {

        ServeitDBEntities sdbe = new ServeitDBEntities();
        string name,id,access;

        public MainPage()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            
        }
        public MainPage(string uname, string uid, string uaccess)
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
        

        private void Dinein_Click(object sender, EventArgs e)
        {

            try
            {
                
                DineIn din = new DineIn(name,id,access);
                // hide main form
                this.Hide();

                // show other form
                din.ShowDialog();

                // close application
                this.Close();
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine("Exception caught: {0}", a);
            }
            
        }

        private void Takeaway_Click(object sender, EventArgs e)
        {
            try
            {
                NewReceipt nr = new NewReceipt(name, id, access);
                // hide main form
                this.Hide();

                // show other form
                nr.ShowDialog();

                // close application
                this.Close();
            }
            catch (NullReferenceException na)
            {
                Console.WriteLine("Exception caught: {0}", na);
            }
        }

        private void reprint_Click(object sender, EventArgs e)
        {
            try
            {
                RePrint rp = new RePrint();
                // hide main form

                // show other form
                rp.Show();
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine("Exception caught: {0}", a);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            try
            {
                LogIn ln = new LogIn();
                this.Hide();

                // show other form
                ln.ShowDialog();

                // close application
                this.Close();
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine("Exception caught: {0}", a);
            }
        }

        private void turnoff_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("Do you want to close the program?", "Exit", MessageBoxButtons.YesNo);
             if (dr == DialogResult.Yes)
             {
                 Application.Exit();
             }
             else if(dr ==DialogResult.No)
             {

             }
        }

        private void viewreceipt_Click(object sender, EventArgs e)
        {
            try
            {
                ViewReceipt vr = new ViewReceipt();
                this.Hide();

                // show other form
                vr.ShowDialog();

                // close application
                this.Close();
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine("Exception caught: {0}", a);
            }

        }

        private void info_Click(object sender, EventArgs e)
        {
            try
            {
                InfoForm info = new InfoForm();

                // show other form
                info.ShowDialog();

                // close application
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine("Exception caught: {0}", a);
            }
        }

        /*private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
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
        }*/

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                EditReceipt er = new EditReceipt(name, id, access);
                // hide main form
                this.Hide();

                // show other form
                er.ShowDialog();

                // close application
                this.Close();
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine("Exception caught: {0}", a);
            }
        }

        public void userInfo(string uname)
        {
           
            var x = from o in sdbe.UserLists where o.Name == uname select o;
            foreach(var y in x)
            {
                idlabel.Text = y.User_id.ToString();
                namelabel.Text = y.Name;
                accesslabel.Text = y.Access;

                name = namelabel.Text;
                id = idlabel.Text;
                access = accesslabel.Text;
            }
            
        }
    }
}
