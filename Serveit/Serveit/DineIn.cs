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
    public partial class DineIn : Form
    {

        string name, id, access,a;
        int i = 0;
        ServeitDBEntities sdbe = new ServeitDBEntities();
        public DineIn()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;            
        }

        public DineIn(string uname, string uid, string uaccess)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                MainPage mp = new MainPage(name,id,access);
                // hide main form
                this.Hide();

                // show other form
                mp.ShowDialog();

                // close application
                this.Close();
            }
            catch (NullReferenceException na)
            {
                Console.WriteLine("Exception caught: {0}", na);
            }
        }

        private void f2t2_Click(object sender, EventArgs e)
        {
            a = "F2T2";
            if (i > 0)
            {
                f2t2.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f2t2.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f2t3_Click(object sender, EventArgs e)
        {
            a = "F2T3";
            if (i > 0)
            {
                f2t3.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f2t3.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f2t4_Click(object sender, EventArgs e)
        {
            a = "F2T4";
            f2t4.BackColor = Color.Blue;
        }

        private void f2t5_Click(object sender, EventArgs e)
        {
            a = "F2T5";
            if (i > 0)
            {
                f2t5.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f2t5.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f2t6_Click(object sender, EventArgs e)
        {
            a = "F2T6";
            if (i > 0)
            {
                f2t6.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f2t6.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f2t7_Click(object sender, EventArgs e)
        {
            a = "F2T7";
            if (i > 0)
            {
                f2t7.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f2t7.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f2t8_Click(object sender, EventArgs e)
        {
            a = "F2T8";
            if (i > 0)
            {
                f2t8.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f2t8.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f2t9_Click(object sender, EventArgs e)
        {
            a = "F2T9";
            if (i > 0)
            {
                f2t9.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f2t9.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f2t10_Click(object sender, EventArgs e)
        {
            a = "F2T10";
            if (i > 0)
            {
                f2t10.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f2t10.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f4t11_Click(object sender, EventArgs e)
        {
            a = "F4T11";
            if (i > 0)
            {
                f4t11.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f4t11.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f4t12_Click(object sender, EventArgs e)
        {
            a = "F4T12";
            if (i > 0)
            {
                f4t12.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f4t12.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f4t13_Click(object sender, EventArgs e)
        {
            a = "F4T13";
            if (i > 0)
            {
                f4t13.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f4t13.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f4t14_Click(object sender, EventArgs e)
        {
            a = "F4T14";
            if (i > 0)
            {
                f4t14.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f4t14.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f4t15_Click(object sender, EventArgs e)
        {
            a = "F4T15";
            if (i > 0)
            {
                f4t15.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f4t15.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f4t16_Click(object sender, EventArgs e)
        {
            a = "F4T16";
            if (i > 0)
            {
                f4t16.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f4t16.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f4t17_Click(object sender, EventArgs e)
        {
            a = "F4T17";
            if (i > 0)
            {
                f4t17.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f4t17.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f4t18_Click(object sender, EventArgs e)
        {
            a = "F4T18";
            if (i > 0)
            {
                f4t18.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f4t18.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f4t19_Click(object sender, EventArgs e)
        {
            a = "F4T19";
            if (i > 0)
            {
                f4t19.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f4t19.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f4t20_Click(object sender, EventArgs e)
        {
            a = "F4T20";
            if (i > 0)
            {
                f4t20.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f4t20.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f6t21_Click(object sender, EventArgs e)
        {
            a = "F6T21";
            if (i > 0)
            {
                f6t21.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f6t21.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f6t22_Click(object sender, EventArgs e)
        {
            a = "F6T22";
            if (i > 0)
            {
                f6t22.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f6t22.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f6t23_Click(object sender, EventArgs e)
        {
            a = "F6T23";
            if (i > 0)
            {
                f6t23.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f6t23.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f6t24_Click(object sender, EventArgs e)
        {
            a = "F6T24";
            if (i > 0)
            {
                f6t24.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f6t24.BackColor = Color.Blue;
                i = 1;
            }
        }

        private void f6t25_Click(object sender, EventArgs e)
        {
            
            a = "F6T25";
            if (i > 0)
            {
                f6t25.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f6t25.BackColor = Color.Blue;
                i = 1;
            }        
            
        }
        
        
        public void reserveTable(Button b,bool x)
        {
            if(x==true )
            {
                b.BackColor = Color.Black;
            }
            
        }
        

        private void f2t1_Click(object sender, EventArgs e)
        {
            a = "F2T1";
            if (i > 0)
            {
                f2t1.BackColor = Control.DefaultBackColor;
                i = 0;
            }

            else
            {
                f2t1.BackColor = Color.Blue;
                i = 1;
            }

        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                NewReceipt nr = new NewReceipt(name, id, access,a);

                // hide main form
                this.Hide();

                // show other form
                nr.ShowDialog();

                // close application
                this.Close();
            }
            catch (NullReferenceException an)
            {
                Console.WriteLine("Exception caught: {0}", an);
            }

        }
        

       /* private void DineIn_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
