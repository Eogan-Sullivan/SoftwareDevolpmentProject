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

    public partial class frmAmmenditem : Form
    {
        Item nextItem = new Item();
        TillSysForm parent;
        public frmAmmenditem(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //updates nextItem with values in the Text Boxes
            nextItem.setItemName(txtItemName.Text.ToUpper());
            nextItem.setPrice(int.Parse(txtPrice.Text.ToUpper()));
            nextItem.setDesc(txtDesc2.Text.ToUpper());
            try
            {
                nextItem.setQuantity(int.Parse(txtQuantity.Text));
                //updates table
                nextItem.updateItems(nextItem);

                MessageBox.Show("Item Updated");
            }
            catch(FormatException)
            {
                MessageBox.Show("Enter Valid Quantity");
            }
          
           
           

            //reset UI
            txtName.Clear();
            txtName.Focus();
            gridItem.Visible = false;
            grpUpdate.Visible = false;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            gridItem.DataSource = nextItem.findItems(txtName.Text.ToString()).Tables["Items"];
            gridItem.Visible = true;

        }

        private void gridItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string strIno = gridItem.Rows[gridItem.CurrentCell.RowIndex].Cells[0].Value.ToString();
                nextItem.returnItem(int.Parse(strIno));

                labItemID2.Text = nextItem.getItemId().ToString();
                txtItemName.Text = nextItem.getItemName();
                txtDesc2.Text = nextItem.getDesc();
                txtPrice.Text = nextItem.getPrice().ToString();
                txtQuantity.Text = nextItem.getQuantity().ToString();
                grpUpdate.Visible = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot Find Item");

            }
        }

      

   

      

    

    


  

       

    }
}
