using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Threading.Tasks;

namespace TillSysForm
{
    class Item
    {
        private double price;
        private int itemId, quantity;
        private String itemName, desc;
        private char status;
        private Item returnedItem;

        // Constructors
        public Item()
        {
            itemId = 0;
            price = 0;
            quantity = 0;
            itemName = "";
            desc = "";
            status = 'A';

        }

        public Item(int itemId, String itemName, String desc, int quantity, float price)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.desc = desc;
            this.quantity = quantity;
            this.price = price;
            status = 'A';
        }
        // Accessors and Mutators
        public void setItemId(int itemId)
        {
            this.itemId = itemId;
        }
        public void setItemName(String itemName)
        {
            this.itemName = itemName;
        }

        public void setDesc(String desc)
        {
            this.desc = desc;
        }

        public void setPrice(float price)
        {
            this.price = price;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public void setStatus(char status)
        {
            this.status = status;
        }

        public int getItemId()
        {
            return itemId;
        }

        public string getItemName()
        {
            return itemName;
        }

        public string getDesc()
        {
            return desc;
        }

        public double getPrice()
        {
            return price;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public char getStatus()
        {
            return status;
        }


        public string toString()
        {
            return getItemId() +" " + getItemName().Trim() +": \u20ac" + getPrice();
        }

        //Insert Item

        public void insItem()
        {
            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define SQL query
            
           String strSQL = " INSERT INTO ITEMS VALUES(" + this.itemId + "," + this.price + "," + this.quantity + ",'" + this.itemName.ToUpper() + "','" + this.desc.ToUpper() + "')";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open Db Connection
            myConn.Open();

            //Exceute
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }


        //to go into itemno Box
        public int getNextItemNo()
        {
            int intNextIno;

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT MAX(ITEMID) FROM ITEMS";

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
                intNextIno = 1;
            else
                intNextIno = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return intNextIno;

        }



        public void returnItem(int itemno)
        {

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT *  FROM ITEMS WHERE ITEMID = " + itemno;

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

            this.itemId = dr.GetInt32(0);
            this.price = dr.GetInt32(1);
            this.quantity = dr.GetInt32(2);
            this.itemName = dr.GetString(3);
            this.desc = dr.GetString(4);




            myConn.Close();

        }


        public Item returnItem2(int itemno)
        {

            //Create database connection string
            returnedItem = new Item();
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT *  FROM ITEMS WHERE ITEMID = " + itemno;

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
       
            
                returnedItem.setItemId(dr.GetInt32(0));
                returnedItem.setPrice(dr.GetInt32(1));
                returnedItem.setPrice(dr.GetInt32(2));
                returnedItem.setItemName(dr.GetString(3));
                returnedItem.setDesc(dr.GetString(4));
            
            myConn.Close();

            return returnedItem;
            

        }

        public DataSet findItems(String itemName)
        {

            //Connect to DataBase

            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define the SQL Query
            String strSQL = " SELECT * FROM ITEMS WHERE ItemName LIKE '" + itemName.ToUpper() + "%'";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Items");

            //Close DB Connection
            myConn.Close();
            return ds;
        }

    
      

        public void updateItems(Item myItem)
        {
            //Connect to DataBase

            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define the SQL Query
            String strSQL = " UPDATE ITEMS SET ITEMNAME = '" + myItem.getItemName().ToUpper() + "', DESCRIPTION = '" + myItem.getDesc().ToUpper() + "'" + ", PRICE =  " + myItem.getPrice() + ",QUANTITY = " + myItem.getQuantity() + " WHERE  ITEMID = " + myItem.getItemId() + "";

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

           
        }

        public double returnPrice(int thisId)
        {
            //Connect to DataBase

            
            //Create datababse connection string
            OracleConnection myConn = new OracleConnection(DBConnectClass.oradb);

            //Define the SQL Query
            String strSQL = " SELECT PRICE FROM ITEMS WHERE ITEMID = " + thisId;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create an OracleDataAdapter
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            //Close DB Connection
            myConn.Close();

            return dr.GetInt32(0);
            
        }


    }
}