using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace TillSysForm
{
    class SaleItem
    {
        private String itemDesc;
        private int itemId;
        private int saleId;
        private int quantity;
        private double price;


        public SaleItem()
        {
            itemDesc = "";
            itemId = 0;
            saleId = 0;
            quantity = 0;
            price = 0;
        }
        public SaleItem(String itemDesc, int itemId, int saleId, double price)
        {

            this.itemDesc = itemDesc;
            this.itemId = itemId;
            this.saleId = saleId;
            this.price = price;

        }

        //accessor Methods

        public String getItemDesc()
        {
            return itemDesc;
        }

        public int getItemId()
        {
            return itemId;
        }

        public int getSaleId()
        {
            return saleId;
        }


        public double getPrice()
        {
            return price;
        }

        public int getQuantity()
        {
            return quantity;
        }



        //mutator methods

        public void setItemDesc(string itemDesc)
        {
            this.itemDesc = itemDesc;
        }
        public void setItemId(int itemId)
        {
            this.itemId = itemId;
        }

        public void setSaleId(int saleId)
        {
            this.saleId = saleId;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public void insSale()
        {
            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define SQL query
            String strSQL = " INSERT INTO SALESITEMS VALUES(" + this.saleId + "," + this.itemId + ",'" + this.itemDesc + "'," + this.quantity + "," + this.price + ")";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open Db Connection
            myConn.Open();

            //Exceute
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }


        public DataSet findSaleItems(int saleId)
        {

            //Connect to DataBase

            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define the SQL Query
            String strSQL = " SELECT * FROM SALESITEMS WHERE SALEID = " + saleId ;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "SalesItems");

            //Close DB Connection
            myConn.Close();
            return ds;
        }

        public void returnSaleItem(int saleId,int itemId)
        {
            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT *  FROM SALESITEMS WHERE SALEID = " + saleId +" AND ITEMID = " + itemId +"";

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

            this.saleId = dr.GetInt32(0);
            this.itemId = dr.GetInt32(1);
            this.itemDesc = dr.GetString(2); 
            this.quantity = dr.GetInt32(3);
            this.price = dr.GetInt32(4);




            myConn.Close();
        }


        public void refund()
        {
            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define SQL query
            String strSQL = " DELETE FROM SALESITEMS WHERE ( SALEID = "+ this.saleId + " AND ITEMID = " + this.itemId + " AND DESCRIPTION ='" + this.itemDesc + "' AND QUANTITY =" + this.quantity + " AND UNITPRICE =" + this.price +")";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open Db Connection
            myConn.Open();

            //Exceute
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }
    }
}
