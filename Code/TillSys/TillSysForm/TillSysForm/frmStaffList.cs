using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace TillSysForm
{
    public partial class frmStaffList : Form
    {

        TillSysForm parent;
        private Staff myStaff = new Staff();
        public frmStaffList(  TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

    

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void frmStaffList_Load(object sender, EventArgs e)
        {
            gridStaffList.DataSource = myStaff.orderByStaffId().Tables["Staff"];
        }

    

     

     

      
    }
}
