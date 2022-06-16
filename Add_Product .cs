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
    public partial class Add_Product : Form
    {


        Store stre = null;
        Category categry = null;
        Products Product;
        public Add_Product()
        {
            
            InitializeComponent();
            
            foreach (Store item in system.store)
            {
                cboStores.Items.Add(item.storeName);
            }

        }
        private void fillStore()
        {
            

        }

       
        private void Add_Product_Load(object sender, EventArgs e)
        {

                
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product = new Products();
            try
            {

                //store
                foreach (Store item in system.store)
                {
                    if (item.storeName == cboStores.Text)
                    {
                        stre = item;
                        //category
                        foreach (Category itm in stre.categories)
                        {
                            if (itm.CategoryName == cboxCategory.Text)
                                categry = itm;
                        }
                    }

                }
                //name
                Regex reName = new Regex("^[a-zA-z]");
                if (reName.IsMatch(txtNameProduct.Text))
                {
                    Product.ProductName = txtNameProduct.Text;
                }
                else
                {
                    MessageBox.Show($"Plz Enter Correct Name");
                    return;
                }

                //description
                Regex reDescription = new Regex("^[a-zA-z]");
                if (reDescription.IsMatch(txtPDescription.Text))
                {
                    Product.ProductDescription = txtPDescription.Text;
                }
                else
                {
                    MessageBox.Show($"Plz Enter correct Description");
                    return;
                }
                //price
                if (Regex.IsMatch(txtPPrice.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only");
                    return;

                }
                else
                {
                    Product.ProductPrice = Convert.ToDouble(txtPPrice.Text);
                }

                //quantity
                if (Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only");
                    return;
                }
                else
                {
                    Product.Quantity = int.Parse(txtQuantity.Text);
                }


                //category
                Product.ProductCategory = cboxCategory.Text;
                //add to gridview
                categry.products.Add(Product);
                gviewShowProduct.DataSource = null;
                gviewShowProduct.DataSource = categry.products;
                stre = null;
                categry = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Plz Enter Correct Data");
            }
        }
       
        private void gviewShowProduct_SelectionChanged(object sender, EventArgs e)
        {
            
            if (gviewShowProduct.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in gviewShowProduct.SelectedRows)
                {
                    txtNameProduct.Text = row.Cells[0].Value.ToString();
                    txtPDescription.Text = row.Cells[1].Value.ToString();                   
                    txtPPrice.Text = row.Cells[2].Value.ToString();
                    cboxCategory.Text = row.Cells[3].Value.ToString();
                    txtQuantity.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //store
            foreach (Store item in system.store)
            {
                if (item.storeName == cboStores.Text)
                {
                    stre = item;
                    //category
                    foreach (Category itm in stre.categories)
                    {
                        if (itm.CategoryName == cboxCategory.Text)
                            categry = itm;
                    }
                }

            }
            try
            {
                if (gviewShowProduct.SelectedRows.Count > -1)
                {
                    int index = gviewShowProduct.CurrentCell.RowIndex;
                   //name
                    Regex reName = new Regex("^[a-zA-z]");
                    if (reName.IsMatch(txtNameProduct.Text))
                    {
                        categry.products[index].ProductName = txtNameProduct.Text;
                    }
                    else
                    {
                        MessageBox.Show($"Plz Enter Correct Name");
                        return;
                    }
                    //description
                    Regex reDescription = new Regex("^[a-zA-z]");
                    if (reDescription.IsMatch(txtPDescription.Text))
                    {
                        categry.products[index].ProductDescription = txtPDescription.Text;
                    }
                    else
                    {
                        MessageBox.Show($"Plz Enter Correct Description");
                        return;
                    }
                    //price
                    if (Regex.IsMatch(txtPPrice.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter numbers only");
                        return;

                    }
                    else
                    {
                        categry.products[index].ProductPrice = Convert.ToDouble(txtPPrice.Text);
                    }
                    //quantity
                    if (Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter numbers only");
                        return;
                    }
                    else
                        categry.products[index].Quantity = Convert.ToInt32(txtQuantity.Text);
                    
                    categry.products[index].ProductCategory = cboxCategory.Text;
                    gviewShowProduct.DataSource = null;
                    gviewShowProduct.DataSource = categry.products;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("please enter data first");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //store
            foreach (Store item in system.store)
            {
                if (item.storeName == cboStores.Text)
                {
                    stre = item;
                    //catagory
                    foreach (Category itm in stre.categories)
                    {
                        if (itm.CategoryName == cboxCategory.Text)
                            categry = itm;
                    }
                }

            }
            try
            {
                int index = gviewShowProduct.CurrentCell.RowIndex;
                categry.products.Remove(categry.products[index]);
                gviewShowProduct.DataSource = null;
                gviewShowProduct.DataSource = categry.products;
                stre = null;
                categry = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Product is Empty");
            }
        }

        private void cboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void cboStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Store item in system.store)
            {
                if (item.storeName == cboStores.Text)
                    stre = item;
            }

            cboxCategory.DataSource = null;
            cboxCategory.DataSource = stre.categories;
            cboxCategory.DisplayMember = "CategoryName";
            cboxCategory.SelectedIndex = -1;




            stre = null;
        }

        private void gviewShowProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
