using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace TillSysForm
{
    class Sales
    {
        //variables

        private int saleId;
        private double price;
        private string date;

        //Constructors
        public Sales()
        {

            saleId = 0;
            price = 0;
            date = "Unknown";

        }

        public Sales(int saleId, double price, string date)
        {

            this.saleId = saleId;
            this.price = price;
            this.date = date;
        }

        //accessor Methods


        public int getSaleId()
        {
            return saleId;
        }


        public double getPrice()
        {
            return price;
        }

        public string getDate()
        {
            return date;
        }

        //mutator methods


        public void setSaleId(int saleId)
        {
            this.saleId = saleId;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }


        public void setDate(string date)
        {
            this.date = date;
        }

        public int getNextSaleID()
        {
            int intNextSale;

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT MAX(SALEID) FROM SALES";

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
                intNextSale = 1;
            else
                intNextSale = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return intNextSale;
        }

        public void insSale()
        {
            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define SQL query
            String strSQL = " INSERT INTO SALES VALUES(" + this.saleId + ",'" + this.date + "'," + this.price + ")";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open Db Connection
            myConn.Open();

            //Exceute
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }

        public DataSet viewAllSales()
        {
            //Connect to DataBase

            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define the SQL Query
            String strSQL = " SELECT * From SALES";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Sales");

            //Close DB Connection
            myConn.Close();
            return ds;
        }


        public int totalSales()
        {


            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT COUNT(PRICE) FROM SALES";

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
            return dr.GetInt32(0);

        }

        public int avgSale()
        {


            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT AVG(PRICE) FROM SALES";

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
            return dr.GetInt32(0);

        }
    }
}
