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
    public partial class frmLogIn : Form
    {
        TillSysForm parent;
        Staff loginStaff;
        Boolean login;
        public frmLogIn(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
            loginStaff = new Staff();
            login = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            getLogin();
            if (login)
            {
    
                frmSaleMenu newMake = new frmSaleMenu(parent);
                newMake.Visible = true;
                this.Close();
            }

            else
            {
                MessageBox.Show("Login Failed", "Incorrect Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bc_btn_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void getLogin()
        {
            if (!String.IsNullOrEmpty(txtLogin.Text))
            {
                int loginCode = 0;
                int checkCode;
                
                try
                {
                    loginCode = int.Parse(txtLogin.Text.ToString());
                }

                catch (FormatException)
               {
                    MessageBox.Show("ID NOT VALID");
               }

                //Create database connection string

                OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);
                //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


                //Define SQL query
                String strSQL = "SELECT * FROM STAFF WHERE STAFFID = " + loginCode;

                //Define Oracle command
                OracleCommand cmd = new OracleCommand(strSQL, myConn);

                //Open DB connection
                myConn.Open();

                OracleDataReader dr = cmd.ExecuteReader();

                //Aggregate function will always return one record
                //If no Stock exists, MAX value is NULL
                //If Stock exists, value returned is an integer

                //read the record in dr
                if (dr.Read())
                {
                  
                    checkCode = dr.GetInt32(0);

                    if (loginCode.Equals(checkCode))
                    {
                        login = true;
                    }
                    else
                        login = false;
         
                }


                 
                 
         }
       
         


 }

      




    }
}
