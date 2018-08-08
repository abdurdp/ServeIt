using Serveit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serveit
{
    public partial class EditMenuItem : Form
    {
        ServeitDBEntities sdbe = new ServeitDBEntities();
        Byte[] fsbytedata;
        public EditMenuItem()
        {
            InitializeComponent();
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if(result==DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                fsbytedata = new Byte[fs.Length];
                fs.Read(fsbytedata, 0, fsbytedata.Length);
                fs.Close();

                MemoryStream ms = new MemoryStream(fsbytedata);
                pictureBox1.Image = Image.FromStream(ms);

            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            ColdBeverage cb = new ColdBeverage();
            cb.Cb_name = itemnametxt.Text;
            cb.Cb_price = Convert.ToInt32(pricetxt.Text);
            cb.Cb_pic = fsbytedata;
            sdbe.ColdBeverages.Add(cb);
            sdbe.SaveChanges();

            MessageBox.Show("Item Added");
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
