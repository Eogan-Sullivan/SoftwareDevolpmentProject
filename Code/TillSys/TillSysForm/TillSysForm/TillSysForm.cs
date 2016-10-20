using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TillSysForm
{
    public partial class TillSysForm : Form
    {
        public TillSysForm()
        {
            InitializeComponent();
        }

 
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdminMenu frmNext = new frmAdminMenu(this);
            this.Hide();
            frmNext.Show();
        }

        private void btmItems_Click(object sender, EventArgs e)
        {
            frmItemMenu myMenu = new frmItemMenu(this);
            this.Hide();
            myMenu.Show();
            

        }


        private void sales1_Click(object sender, EventArgs e)
        {
           
            frmLogIn mySale = new frmLogIn(this);
            this.Hide();
            mySale.Show();
        }

      
      
    }
}
