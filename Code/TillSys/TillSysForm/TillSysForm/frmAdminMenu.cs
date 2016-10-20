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
    public partial class frmAdminMenu : Form
    {
        TillSysForm parent;
        frmAddStaff addStaff;
        frmAmmendStaff change;
        frmStaffList myList;
        public frmAdminMenu(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
            addStaff = new frmAddStaff(parent);
            change = new frmAmmendStaff(parent);
            myList = new frmStaffList(parent);
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void btnRegStaff_Click(object sender, EventArgs e)
        {
            addStaff.Visible = true;
            this.Close();
        }

        private void printStaff_Click(object sender, EventArgs e)
        {
            myList.Visible = true;
            this.Close();
        }

        private void ammendStaff_Click(object sender, EventArgs e)
        {
            change.Visible = true;
            this.Close();
        }
    }
}
