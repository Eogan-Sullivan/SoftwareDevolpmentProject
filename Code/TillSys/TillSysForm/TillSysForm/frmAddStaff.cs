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
    public partial class frmAddStaff : Form
    {

        TillSysForm parent;
        Staff firstStaff = new Staff();

        public frmAddStaff(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
     
            txtStaffID.Text = firstStaff.getNextStaffNo().ToString("0000");
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //Validate data

            //save member details in Staff Table

            firstStaff.setFirstName(txtFirstName.Text.ToString());
            firstStaff.setLastName(txtLastName.Text.ToString());
            firstStaff.setStaffId(int.Parse(txtStaffID.Text));
            //firstStaff.setStaffId(txtStaffID;
            firstStaff.insStaff();

            //display confirmation message
            MessageBox.Show("Staff Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtStaffID.Text = firstStaff.getNextStaffNo().ToString("0000");
            txtFirstName.Clear();
            txtLastName.Clear();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

  

   

  

      



    }
}
