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
    public partial class frmAmmendStaff : Form
    {
        TillSysForm parent;
        Staff nextStaff = new Staff();
        public frmAmmendStaff(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            gridStaff.DataSource = nextStaff.findStaff(txtLastName.Text).Tables["Staff"];
            gridStaff.Visible = true;

        }

        private void gridStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string strSno = gridStaff.Rows[gridStaff.CurrentCell.RowIndex].Cells[0].Value.ToString();

                nextStaff.returnStaff(int.Parse(strSno));

                labStafID.Text = nextStaff.getStaffId().ToString();
                txtFirstName.Text = nextStaff.getFirstName();
                txtLastName2.Text = nextStaff.getLastName();
                grpUpdate.Visible = true;
            }

            catch(Exception)
            {
                MessageBox.Show("Cannot Find Staff Member");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //Connect to DataBase

            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define the SQL Query
            String strSQL = " UPDATE STAFF SET FIRSTNAME = '"  + txtFirstName.Text.ToString().ToUpper() +"', LASTNAME = '" + txtLastName2.Text.ToString().ToUpper() + "' WHERE  STAFFID = " + nextStaff.getStaffId() + "";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();


            //execute
            OracleDataReader dr = cmd.ExecuteReader();

            //Aggregate function will always return one record
            //If no Stock exists, MAX value is NULL
            //If Stock exists, value returned is an integer

            //read the record in dr
            dr.Read();

            //close connection
            myConn.Close();

            MessageBox.Show("Staff Member Successly updated");


            //reset UI
            grpUpdate.Visible = false;
            gridStaff.Visible = false;
            txtLastName.Clear();
            txtLastName.Focus();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

       
      

       

      


    }
}
