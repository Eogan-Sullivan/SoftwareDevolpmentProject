using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//once installed 3 classes are available to use Oracle Connection(login details are paramters) and Oracle Command(sql commands, contains method execute)
using System.Data.OracleClient;
namespace TillSysForm
{
    public partial class frmRegisterStaff : Form
    {

        TillSysForm parent;
        public frmRegisterStaff(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

   

        private void staffName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }

        private void registerAnother_Click(object sender, EventArgs e)
        {

        }

        private void finish_close_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void loginCode_Click(object sender, EventArgs e)
        {

        }
    }
}
