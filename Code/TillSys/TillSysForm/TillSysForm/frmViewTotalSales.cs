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
    public partial class frmViewTotalSales : Form
    {
        TillSysForm parent;
        Sales mySale;

        public frmViewTotalSales(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
            mySale = new Sales();
        }

        private void frmViewTotalSales_Load(object sender, EventArgs e)
        {
            gridSales.DataSource = mySale.viewAllSales().Tables["Sales"];
            txtTotalSales.Text = mySale.totalSales().ToString();
            txtAvgPrice.Text = mySale.avgSale().ToString();
       
        }
     

        private void bthBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close(); 
        }

       
      
     

     
    }
}
