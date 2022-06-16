using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Store_Form : Form
    {
        public Store_Form()
        {
            InitializeComponent();
           
        }
        Store stre = null;
        Category categry = null;
        private Form openForm = null;
        private void openNewForm(Form childform)
        {
            if (openForm != null)
            {
                openForm.Close();

            }
            if (childform != null)
            {
                openForm = childform;
                childform.TopLevel = false;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                pnlStore.Controls.Add(childform);
                pnlStore.Tag = childform;
                childform.BringToFront();
                childform.Show();
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addCategoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Category Cateory =new Add_Category();
            // Cateory.Show();
            openNewForm(Cateory);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show
            Add_Store add = new Add_Store();
            //add.Show();
            openNewForm(add);

            //  guna2ComboBox5.Items.Add(add.storeNames);
            //guna2ComboBox5.DataSource = null;
            //guna2ComboBox5.DataSource = system.store;
           // guna2ComboBox5.DisplayMember = "storeName";
           // guna2ComboBox5.SelectedIndex = -1;
            foreach(Store item in system.store)
            {
                guna2ComboBox5.Items.Add(item.storeName);
            }


        }

        private void Store_Form_Load(object sender, EventArgs e)
        {
          
        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Product product = new Add_Product();
            // product.Show();
            openNewForm(product);
        }

        private void addSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Supplier supplier = new Add_Supplier();
           // supplier.Show();
            openNewForm(supplier);
        }

        private void addCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Distributer distributer = new Add_Distributer();
           // distributer.Show();
            openNewForm(distributer);
        }

        private void gviewDataStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            foreach (Store item in system.store)
            {
                if (item.storeName == guna2ComboBox5.Text)
                    stre = item;
            }
           
                cmbCategory.DataSource = null;
                cmbCategory.DataSource = stre.categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.SelectedIndex = -1;

            


            stre = null;
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (Store item in system.store)
            {
                if (item.storeName == guna2ComboBox5.Text)
                {
                    stre = item;
                    foreach (Category itm in stre.categories)
                    {
                        if (itm.CategoryName == cmbCategory.Text)
                        {
                            categry = itm;
                            gviewDataStore.DataSource = null;
                            gviewDataStore.DataSource = categry.products;
                        }
                            
                    }
                }

            }  


            stre = null;
            categry = null;

        }

        private void salesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale_Form sale_Form = new Sale_Form();
            // sale_Form.Show();
            openNewForm(sale_Form);
        }
        private void purchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buy_Form buy_Form = new Buy_Form();
            //buy_Form.Show();
            openNewForm(buy_Form);
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Store_Form strfrm = new Store_Form();
            openNewForm(null);
            //// menuStrip1.Visible=false;

        }

        private void sellsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellsReport report = new SellsReport();
            // report.Show();
            openNewForm(report);
        }

        private void buysReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyReport report = new BuyReport();
            
            openNewForm(report);
        }
    }
}
