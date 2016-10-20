using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace TillSysForm
{
    class Staff
    {
        
        private int staffID;
        private String firstName,lastName;
 

        public Staff()
        {
            firstName = "";
            lastName = "";
            staffID = 0;
       
        }

        public Staff(int staffID,String firstName,String lastName,char status)
        {
            this.staffID = staffID;
            this.firstName = firstName;
            this.lastName = lastName;
      
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public void setStaffId(int staffID)
        {
            this.staffID = staffID;
        }

        public int getStaffId()
        {
            return staffID;
        }

        public int getNextStaffNo()
        {
            int intNextSno;

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT MAX(StaffID) FROM Staff";

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

            if (dr.IsDBNull(0))
                // no return because it wouldnt close the database connection
                intNextSno = 1;
            else
                intNextSno = Convert.ToInt16(dr.GetValue(0)) + 1;
          
            myConn.Close();
            return intNextSno;

        }

        public void insStaff()
        {
            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define SQL query
            String strSQL = " INSERT INTO Staff VALUES(" + this.staffID + ",'" + this.firstName.ToUpper() + "','" +this.lastName.ToUpper() +"')";
            
            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            
            //Open Db Connection
            myConn.Open();

            //Exceute
            cmd.ExecuteNonQuery();
            
            //Close DB connection
            myConn.Close();
        }

        public void returnStaff(int staffno)
        {

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT *  FROM Staff WHERE STAFFID = " + staffno.ToString() ;

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

            this.staffID = dr.GetInt32(0);
            this.firstName = dr.GetString(1);
            this.lastName = dr.GetString(2);

      

            myConn.Close();
            

        }

        public DataSet findStaff(String staffName)
        {
            //Connect to DataBase

            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define the SQL Query
            String strSQL = " SELECT * FROM STAFF WHERE LASTNAME LIKE '"+ staffName.ToUpper() +"%'";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Staff");

            //Close DB Connection
            myConn.Close();
            return ds;
        }

        public DataSet orderByStaffId()
        {
            //Connect to DataBase

            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define the SQL Query
            String strSQL = " SELECT * FROM STAFF ORDER BY STAFFID";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Staff");

            //Close DB connection
            myConn.Close();

            return ds;
        }


        public DataSet orderByFirstName()
        {

            //Connect to DataBase

            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define the SQL Query
            String strSQL = " SELECT * FROM STAFF ORDER BY FIRSTNAME";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Staff");

            //Close DB Connection
            myConn.Close();

            return ds;

        }
    
        

   
        }

       


   }

