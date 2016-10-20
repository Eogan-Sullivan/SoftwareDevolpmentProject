using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TillSysForm
{
    public partial class frmAddItem : Form
    {
        TillSysForm parent;
        Item firstItem = new Item();
        public frmAddItem(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
           
        }

        private void submitItem_Click(object sender, EventArgs e)
        {
            //Validate data
            Boolean valid = true;
            //save member details in Item Table
            try
            {
                firstItem.setItemName(txtItemName.Text.ToString());

            }

            catch(FormatException)
            {
                MessageBox.Show("Please Enter Valid FirstName");
                valid = false;
            }
            try
            {
                firstItem.setItemId(int.Parse(txtItemID.Text));
            }
            catch(FormatException)
            {
                MessageBox.Show("Please Enter Valid Item Id");
                valid = false;
            }
            try
            {
                firstItem.setPrice(float.Parse(txtItemPrice.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter Valid Item Price");
                valid = false;
            }
            try
            {
                firstItem.setDesc(txtItemDesc.Text.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter Valid Description");
                valid = false;
            }
            try
            {
                firstItem.setQuantity(int.Parse(txtItemQuantity.Text));
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Enter Valid Quantity");
                valid = false;
            }

            catch(OverflowException)
            {
                MessageBox.Show("Fuck you Gary");
            }
            if (valid)
            {
                firstItem.insItem();
                //Display Confirmation Box
                MessageBox.Show("Item Registered", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show("Please Enter Correct Details");
        

        

            //Reset UI
            txtItemID.Text = firstItem.getNextItemNo().ToString("0000");
            txtItemName.Clear();
            txtItemDesc.Clear();
            txtItemPrice.Clear();
            txtItemQuantity.Clear();
            txtItemName.Focus();
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            
          txtItemID.Text = firstItem.getNextItemNo().ToString("0000");
        }

    

   
   
      
    }
}
