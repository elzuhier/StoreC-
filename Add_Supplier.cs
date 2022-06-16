using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_Supplier : Form
    {
        Supplier supplier;
       

        public Add_Supplier()
        {
            InitializeComponent();
        }
        public void SystemSupplierEqualList()
        {
            
        }
        private void txtPhoneDistributer_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            supplier = new Supplier();
            //id
            Supplier LastIndex = null;
            if (system.suppliers.Count != 0)
            {
                LastIndex = system.suppliers.Last();
            }
            if (LastIndex != null)
                supplier.SupplierID = LastIndex.SupplierID + 1;
            //name 
            Regex regName = new Regex("^[a-zA-Z]");
            if (regName.IsMatch(txtNameSupplier.Text))
            {
                supplier.SupplierName = txtNameSupplier.Text;
            }
            else
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            //mobilephone
            Regex rePhone = new Regex("^0[0-9]{11}");
            if (rePhone.IsMatch(txtPhoneSupplier.Text) ||
                txtPhoneSupplier.Text.Length == 11
                || txtPhoneSupplier.Text != "")
            {
                supplier.SupplierPhone = txtPhoneSupplier.Text;
            }
            else
            {
                MessageBox.Show("Invalid  Mobile Number!!");
                return;
            }
            //city
            Regex regCity = new Regex("^[a-zA-Z]");
            if (regCity.IsMatch(txtCitySupplier.Text))
            {
                supplier.City = txtCitySupplier.Text;
            }
            else
            {
                MessageBox.Show("Invalid Address");
                return;
            }
            //ensure supplier is not exist   
            foreach (Supplier item in system.suppliers)
            {
                if (item.SupplierName.Equals(txtNameSupplier.Text))
                {
                    MessageBox.Show("Supplier is Exist");
                    txtNameSupplier.Text = "";
                    txtCitySupplier.Text = "";
                    txtPhoneSupplier.Text = "";
                    return;
                }
            }
            //add to gridview
            system.suppliers.Add(supplier);
            gViewAddSupplier.DataSource = null;
            gViewAddSupplier.DataSource = system.suppliers;
            txtNameSupplier.Text = "";
            txtPhoneSupplier.Text = "";
            txtCitySupplier.Text = "";

        }

        private void gViewAddSupplier_SelectionChanged(object sender, EventArgs e)
        {
            //select row to edit
            if (gViewAddSupplier.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in gViewAddSupplier.SelectedRows)
                {
                    txtSupplierID.Text = row.Cells[0].Value.ToString();
                    txtNameSupplier.Text = row.Cells[1].Value.ToString();
                    txtPhoneSupplier.Text = row.Cells[2].Value.ToString();
                    txtCitySupplier.Text = row.Cells[3].Value.ToString();

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (system.suppliers.Count == 0)
            {
                MessageBox.Show("please enter data first");
                return;
            }
            if (gViewAddSupplier.SelectedRows.Count > -1)
            {

                int index = gViewAddSupplier.CurrentCell.RowIndex;
                if (txtNameSupplier.Text != "" ||
                    txtPhoneSupplier.Text != "" || txtCitySupplier.Text != "")
                {
                    system.suppliers[index].SupplierID = Convert.ToInt32(txtSupplierID.Text);
                    system.suppliers[index].SupplierName = txtNameSupplier.Text;
                    system.suppliers[index].SupplierPhone = txtPhoneSupplier.Text;
                    system.suppliers[index].City = txtCitySupplier.Text;
                }
                gViewAddSupplier.DataSource = null;
                gViewAddSupplier.DataSource = system.suppliers;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (system.suppliers.Count == 0)
            {
                MessageBox.Show("No data to remove");
                return;
            }
            int index = gViewAddSupplier.CurrentCell.RowIndex;

            system.suppliers.Remove(system.suppliers[index]);
            gViewAddSupplier.DataSource = null;
            gViewAddSupplier.DataSource = system.suppliers;
        }

        private void gViewAddSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Supplier_Load(object sender, EventArgs e)
        {
            

        }
    }
}
