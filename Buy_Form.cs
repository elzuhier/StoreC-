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
    public partial class Buy_Form : Form
    {
        Store stre = null;
        Category categry = null;
        Products product;
        Buys buys =new Buys();
        public Buy_Form()
        {
            InitializeComponent();
        }

        private void Buy_Form_Load(object sender, EventArgs e)
        {
            foreach (Store item in system.store)
                cboxStore.Items.Add(item.storeName);
            
            cboxSupplier.DataSource = null;
            cboxSupplier.DataSource = system.suppliers;
            cboxSupplier.DisplayMember = "SupplierName";
                }
        

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            product = new Products();
            try
            {
                //name
               
                    product.ProductName = cboxProductName.Text;
                
                buys.storeName.Add(cboxStore.Text);
                buys.categoryName.Add(cboxCategotyName.Text);
                product.ProductCategory = cboxCategotyName.Text;
                product.ProductSupplier = cboxSupplier.Text;
                //quantity
                if (Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only");
                    return;
                }
                else
                {
                    product.Quantity = Convert.ToInt32(txtQuantity.Text);
                }
                //price
                if (Regex.IsMatch(txtPrice.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only");
                    return;

                }
                else
                {
                    product.ProductPrice = Convert.ToDouble(txtPrice.Text);
                }
               

                //increaing Quantity in the main product list

                foreach (Store item in system.store)
                {
                    if (item.storeName == cboxStore.Text)
                    {
                        stre = item;
                        foreach (Category c in stre.categories)
                        {
                            if (c.CategoryName == cboxCategotyName.Text)
                            {
                                categry = c;
                                foreach (Products prod in c.products)
                                {
                                    if (cboxProductName.Text == prod.ProductName)
                                        prod.Quantity += product.Quantity;
                                }
                            }

                        }


                    }


                }
                buys.TotalPrice += product.ProductPrice * product.Quantity;
                txtTotalPrice.Text = buys.TotalPrice.ToString();
                buys.products.Add(product);
                gviewPurchases.DataSource = null;
                gviewPurchases.DataSource = buys.products;
            }
            catch (Exception)
            {
                MessageBox.Show("Enter correct data please");
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = gviewPurchases.CurrentCell.RowIndex;
            foreach (Store item in system.store)
            {
                if (item.storeName == buys.storeName[index])
                {
                    stre = item;
                    foreach (Category c in stre.categories)
                    {
                        if (c.CategoryName == buys.categoryName[index])
                        {
                            categry = c;
                            foreach (Products prod in c.products)
                            {
                                if (buys.products[index].ProductName == prod.ProductName)
                                    prod.Quantity -= product.Quantity;
                            }
                        }
                    }
                }
            }

            buys.TotalPrice -= buys.products[index].ProductPrice * buys.products[index].Quantity;
            txtTotalPrice.Text = buys.TotalPrice.ToString();
            buys.products.Remove(buys.products[index]);
            gviewPurchases.DataSource = null;
            gviewPurchases.DataSource = buys.products;
            
            

        }

        private void cboxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Store item in system.store)
            {
                if (item.storeName == cboxStore.Text)
                    stre = item;
            }
            cboxCategotyName.DataSource = null;
            cboxCategotyName.DataSource = stre.categories;
            cboxCategotyName.DisplayMember = "CategoryName";

            stre = null;

        }
        private void cboxCategotyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Store item in system.store)
            {
                if (item.storeName == cboxStore.Text)
                {
                    stre = item;
                    foreach (Category c in stre.categories)
                    {
                        if (c.CategoryName == cboxCategotyName.Text)
                        {
                            categry = c;
                            cboxProductName.DataSource = null;
                            cboxProductName.DataSource = categry.products;
                            cboxProductName.DisplayMember = "ProductName";       

                            
                        }
                    }
                }

            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Store item in system.store)
            {
                if (item.storeName == cboxStore.Text)
                {
                    stre = item;
                    foreach (Category c in stre.categories)
                    {
                        if (c.CategoryName == cboxCategotyName.Text)
                        {
                            categry = c;
                            foreach (Products prod in c.products)
                            {
                                if (cboxProductName.Text == prod.ProductName)
                                    txtPrice.Text = Convert.ToString(prod.ProductPrice);
                            }
                        }

                    }


                }

            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            buys.DateTime = DatePicher.Value;
            system.BuysList.Add(buys);
        }
    }
}
