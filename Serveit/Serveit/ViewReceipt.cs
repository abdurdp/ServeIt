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
    public partial class ViewReceipt : Form
    {
        ServeitDBEntities sdbe = new ServeitDBEntities();
        public ViewReceipt()
        {
            InitializeComponent();
            rdataGridView.DataSource = sdbe.ReceiptHistories.ToList();
            WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                MainPage mp = new MainPage();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
