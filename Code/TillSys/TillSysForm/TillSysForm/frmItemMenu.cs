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
    public partial class frmItemMenu : Form
    {
        TillSysForm parent;
        frmAddItem addItem;
        frmAmmenditem changeItem;
        public frmItemMenu(TillSysForm Parent)
        {
            InitializeComponent();
            parent = Parent;
            addItem = new frmAddItem(parent);
            changeItem = new frmAmmenditem(parent);
        }

 

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
        
             addItem.Visible = true;
            this.Close();
            
        }

        private void btnAmmendItem_Click(object sender, EventArgs e)
        {
  
            changeItem.Visible = true;
            this.Close();
    
        
         }

  
     }


}
