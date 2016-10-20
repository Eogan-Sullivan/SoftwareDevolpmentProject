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
    public partial class frmRefundSale : Form
    {
        TillSysForm parent;
        SaleItem refundedSale;
        public frmRefundSale(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
            refundedSale = new SaleItem();
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSaleId1.Text.ToString().Equals("")|| txtSaleId1.Text.Equals("")||txtSaleId1.Text.Equals(null))
            {
                MessageBox.Show("SaleId Not Valid");
            }
            else
            {
                gridSales.DataSource = refundedSale.findSaleItems(Int32.Parse(txtSaleId1.Text)).Tables["SalesItems"];
                gridSales.Visible = true;
            }
        }

        private void gridSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string strSno = gridSales.Rows[gridSales.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string strIno = gridSales.Rows[gridSales.CurrentCell.RowIndex].Cells[1].Value.ToString();
                refundedSale.returnSaleItem(Int32.Parse(strSno), Int32.Parse(strIno));
                grpUpdate.Visible = true;
                refundedSale.returnSaleItem(Int32.Parse(strSno), Int32.Parse(strIno));
                txtPrice.Text = (refundedSale.getPrice() * refundedSale.getQuantity()).ToString();
                txtItemId.Text = refundedSale.getItemId().ToString();
                txtSaleId.Text = refundedSale.getSaleId().ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot Find Item");
            }
            
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            // refunds item
            refundedSale.refund();
            MessageBox.Show("Item Refunded");
            //resets gui
            gridSales.Visible = false;
            grpUpdate.Visible = false;
            txtSaleId1.Focus();
            


        }

  


        
    }
}

