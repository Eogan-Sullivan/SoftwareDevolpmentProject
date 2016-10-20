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
    public partial class frmMakeASale : Form
    {
        TillSysForm parent;
        frmSaleMenu saleMenu;
    
        Item listItem = new Item();
        Sales makeSale;
        SaleItem ItemSold = new SaleItem();


        public frmMakeASale(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
            makeSale = new Sales();
            saleMenu = new frmSaleMenu(parent);
        }


        // back button
        private void bck_btn_Click(object sender, EventArgs e)
        {
            parent.Visible= true;
            this.Close();
        }


        // number 1 button on calculator
        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (txtCalDisplay.Text == "0.00")
            {
                txtCalDisplay.Clear();
            }
            Button button = (Button)sender;
            txtCalDisplay.Text = txtCalDisplay.Text + button.Text;
        }

        //cash button
        private void btnCash_Click(object sender, EventArgs e)
        {

            txtDisplayChange.Text = "\u20ac" + (Double.Parse(txtCalDisplay.Text) - Double.Parse(txtTotal.Text)).ToString();
            txtCalDisplay.Text = "0.00";
            listCart.Items.Clear();
        
          
           
                double totalPrice = 0;
                string replaceEuro;
                int i;
                //for each item in the cart gets the total price and increments the price by each item
                for (i = 0; i < listCart.Items.Count; i++)
                {
                    replaceEuro = listCart.Items[i].ToString().Substring(9);
                    replaceEuro = replaceEuro.Substring(0, 2);

                    totalPrice += Double.Parse(replaceEuro);
                }


                makeSale.getNextSaleID();
                makeSale.setDate(DateTime.Now.ToString("dd-MMM-yy"));
                makeSale.setPrice(Double.Parse(txtTotal.Text));

                //inserts the sale into the table
                makeSale.insSale();
                makeSale.setSaleId(makeSale.getSaleId());
       
                
              // reset UI
                grpCheckout.Visible = false;
                
            int k = 0;
            while(listCart.Items.Count > k)
            {
                listCart.Items.RemoveAt(i);
 
            }
            txtTotal.Text = totalPrice.ToString();
            txtTotal.Text = "0.00";
            labChange.Visible = true;
            txtDisplayChange.Visible = true;
          

       
        }


        //clear button on calc
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalDisplay.Text = "0.00";
            txtDisplayChange.Text = "0.00";


        }

        //cancle on calculator
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCalDisplay.Text = "0.00";

        }

        private void frmMakeASale_Load(object sender, EventArgs e)
        {
            gridStock.DataSource = listItem.findItems(labDesc.Text = "").Tables["Items"];
        }


        // handles click on items 
        private void gridDisplaySale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //reset ui
            txtTotal.Clear();
            labChange.Visible = false;
            txtDisplayChange.Visible = false;

            //populate 
            try
            {
                string strIno = gridStock.Rows[gridStock.CurrentCell.RowIndex].Cells[0].Value.ToString();
                listItem.returnItem(int.Parse(strIno));
            }

            catch(Exception)
            {
                MessageBox.Show("no item Selected");
            }
            //display ui
            txtDesc.Text = listItem.getItemName().ToString().ToUpper();
            txtQuantity.Text = "1";
            txtPrice.Text = listItem.getPrice().ToString();

        }


        // adds Item in group box Item Details to ListCart
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {

            listCart.Items.Add(listItem.toString() + " " + txtQuantity.Text);
            listItem.setQuantity(listItem.getQuantity() - Int32.Parse(txtQuantity.Text));
            listItem.updateItems(listItem);
            gridStock.DataSource = listItem.findItems(labDesc.Text = "").Tables["Items"];




        }

        // removes selected item from cart
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                listCart.Items.RemoveAt(listCart.SelectedIndex);
            }

            catch (Exception)
            {
                MessageBox.Show("Nothing Selected");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

                 //sets Sale id of sale item to current sale id
                 ItemSold.setSaleId(makeSale.getSaleId());


                int i,id,somethingelse = 0;
                double totalPrice = 0;
            
                for (i = 0; i < listCart.Items.Count; i++)
                {
                    id = Int32.Parse(listCart.Items[i].ToString().Substring(0,1));
     
                    ItemSold.setItemId(id);
                    listItem.returnItem(id);
                    ItemSold.setItemDesc(listItem.getDesc());
                    ItemSold.setPrice(listItem.getPrice());
                    try
                    {
                        somethingelse = Int32.Parse(listCart.Items[i].ToString().Substring(12));
                    }

                    catch(ArgumentException)
                    {
                        MessageBox.Show(" cannot have minus stock ");
                    }

                    ItemSold.setQuantity(somethingelse);
                    totalPrice += listItem.getPrice() * ItemSold.getQuantity();
                    
                   ItemSold.setPrice(listItem.getPrice());
                   ItemSold.insSale();
                }

                txtTotal.Text = totalPrice.ToString();
                
                grpCheckout.Visible = true;
                




        }
    }
}

