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
    public partial class RePrint : Form
    {
        public RePrint()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MainPage mp = new MainPage();
                // hide main form
                this.Hide();
                
                // close application
                this.Close();
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine("Exception caught: {0}", a);
            }
        }
    }
}
