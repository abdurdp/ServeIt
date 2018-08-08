using Serveit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serveit
{
    public partial class NewReceipt : Form
    {
        string name, id, access,a;
        float tk;
        private ServeitDBEntities sdbe = new ServeitDBEntities();
        
        BindingList<ColdBeverage> cold = new BindingList<ColdBeverage>();
        public NewReceipt()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        public NewReceipt(string uname, string uid, string uaccess,string ua)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            poslistBox.DataSource = cold;
            poslistBox.DisplayMember = "Cb_name";

            idlabel.Text = uid;
            namelabel.Text = uname;
            accesslabel.Text = uaccess;

            name = namelabel.Text;
            id = idlabel.Text;
            access = accesslabel.Text;
            a = ua;
            tableidtext.Text = a;
            var x = from o in sdbe.ReceiptHistories select o;
            foreach(var y in x)
            {
                receiptidtext.Text = y.Rt_id.ToString();

            }
            var z = from o in sdbe.UserLists select o;
            serverCBox.DataSource =z.ToList();
            serverCBox.DisplayMember = "Server";
            // serverCBox.ValueMember = "User_id";
            itemTabscreate();
           
        }

        public NewReceipt(string uname, string uid, string uaccess)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            idlabel.Text = uid;
            namelabel.Text = uname;
            accesslabel.Text = uaccess;

            name = namelabel.Text;
            id = idlabel.Text;
            access = accesslabel.Text;
            var x = from o in sdbe.ReceiptHistories select o;
            foreach (var y in x)
            {
                receiptidtext.Text = y.Rt_id.ToString();
                y.Table_id = a;
            }
            var z = from o in sdbe.UserLists select o;
            serverCBox.DataSource = z.ToList();
            serverCBox.DisplayMember = "Server";
            // serverCBox.ValueMember = "User_id";
            itemTabscreate();
           // itemsinsidetabs();

        }

        private void itemsinsidetabs()
        {

            
            foreach (TabPage tp in tabControl1.TabPages)
            {
                FlowLayoutPanel fly = new FlowLayoutPanel();
                fly.Dock = DockStyle.Fill;
                var x = from o in sdbe.ColdBeverages select o;
                foreach(var y in x)
                {
                    Button b = new Button();
                    b.Size = new Size(100, 100);
                    b.Text = y.Cb_name;
                    fly.Controls.Add(b);
                }
                tp.Controls.Add(fly);
            }
        }

        private void NewReceipt_Load(object sender, EventArgs e)
        {
            itemsinsidetabs();
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            ColdBeverage cb = new ColdBeverage()
            {
                Cb_name = "Fanta",
                Cb_price = 40
            };
            cold.Add(cb);
        }

        public void paymentcal(float a)
        {
            tk = a + tk;
            a = tk;
            amounttxt.Text = a.ToString();
            discountxt.Text = "0%";
            vattxt.Text = "15%";
            totaltxt.Text= (a + (a*.15)).ToString();

        }

        private void posViewFormat(object sender, ListControlConvertEventArgs e)
        {
            string currentItem = ((ColdBeverage)e.ListItem).Cb_name;
            string currentPrice =((ColdBeverage)e.ListItem).Cb_price.ToString();
            string pospadding = currentItem.PadRight(60);

            e.Value = pospadding + currentPrice;
           float t = (Convert.ToInt32(currentPrice));
            paymentcal(t);
        }

        private void itemTabscreate()
        {
            foreach(DrinksCategory pt in sdbe.DrinksCategories)
            {
                tabControl1.TabPages.Add(pt.Dc_id.ToString(), pt.Dc_name);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceiptHistory rh = new ReceiptHistory();
            rh.Table_id = tableidtext.Text;
            rh.Type = "Dinein";
           // rh.Amount = (Convert.ToInt32(amounttxt));
            rh.Date = dateTimePicker1.Value;
           // rh.Due = (Convert.ToInt32(duetxt));
            sdbe.ReceiptHistories.Add(rh);
            sdbe.SaveChanges();

            MessageBox.Show("Item Added");
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                MainPage mp = new MainPage(name,id, access);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DineIn din = new DineIn(name, id, access);
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
        
       /* private void NewReceipt_FormClosing(object sender, FormClosingEventArgs e)
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
