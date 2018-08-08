using Serveit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveit
{
    class userInfoPassing
    {
        

        public userInfoPassing(string name)
        {
            ServeitDBEntities sdbe = new ServeitDBEntities();
            MainPage mp = new MainPage();
            DineIn din = new DineIn();
            NewReceipt nr = new NewReceipt();
            EditReceipt er = new EditReceipt();
            var x = from o in sdbe.UserLists where o.Name == name select o;
            foreach (var y in x)
            {
                mp.idlabel.Text = y.User_id.ToString();
                mp.namelabel.Text = y.Name;
                mp.accesslabel.Text = y.Access;

                din.idlabel.Text = y.User_id.ToString();
                din.namelabel.Text = y.Name;
                din.accesslabel.Text = y.Access;

                nr.idlabel.Text = y.User_id.ToString();
                nr.namelabel.Text = y.Name;
                nr.accesslabel.Text = y.Access;

                er.idlabel.Text = y.User_id.ToString();
                er.namelabel.Text = y.Name;
                er.accesslabel.Text = y.Access;

            }
        }
        
    }
}
