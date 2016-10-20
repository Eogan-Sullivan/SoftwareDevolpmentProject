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
    public partial class frmSaleMenu : Form
    {
        frmMakeASale firstSale;
        frmRefundSale refundSale;
        frmViewTotalSales viewSale;
        TillSysForm parent;

        public frmSaleMenu(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
                 
        }


        private void btnMakeSale_Click(object sender, EventArgs e)
        {
            this.Close();
            firstSale = new frmMakeASale(parent);
            firstSale.Show();
        }

        private void btnRefundSale_Click(object sender, EventArgs e)
        {
            this.Close();
            refundSale = new frmRefundSale(parent);
            refundSale.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            this.Close();
            viewSale = new frmViewTotalSales(parent);
            viewSale.Show();
        }

    

    


    }
}
