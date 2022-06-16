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
    public partial class Sale_Form : Form
    {
        Store stre = null;
        Category categry = null;
        Products product;

        Sales sales = new Sales();
        public Sale_Form()
        {
            InitializeComponent();
        }

        private void Sale_Form_Load(object sender, EventArgs e)
        {
            foreach (Store item in system.store)
                cboxStore.Items.Add(item.storeName);

            cboxDistributer.DataSource = null;
            cboxDistributer.DataSource = system.distributers;
            cboxDistributer.DisplayMember = "DistributerName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
            product = new Products();
            product.ProductName = cboxProductName.Text;
            sales.storeName.Add(cboxStore.Text);
            sales.categoryName.Add(cboxCategotyName.Text);
            product.ProductCategory = cboxCategotyName.Text;
            product.ProductDistributer = cboxDistributer.Text;
            product.Quantity = Convert.ToInt32(txtQuantity.Text);
                //quantity
                if (Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter numbers only");
                    return;
                }
                else
                {
                    product.ProductPrice = Convert.ToDouble(txtPrice.Text);
                }
               
            //Decrease Quantity in the main product list

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
                                {
                                    if (prod.Quantity >= product.Quantity)
                                        prod.Quantity -= product.Quantity;
                                    else
                                        MessageBox.Show("Not enough quantity");
                                }

                            }
                        }

                    }


                }


            }
            sales.TotalPrice += product.ProductPrice * product.Quantity;
            txtTotalPrice.Text = sales.TotalPrice.ToString();
            sales.products.Add(product);
            gviewSales.DataSource = null;
            gviewSales.DataSource = sales.products;

        } 
            catch(Exception)
            {
                MessageBox.Show("Enter Correct Data");
            }
    }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = gviewSales.CurrentCell.RowIndex;
            foreach (Store item in system.store)
            {
                if (item.storeName == sales.storeName[index])
                {
                    stre = item;
                    foreach (Category c in stre.categories)
                    {
                        if (c.CategoryName == sales.categoryName[index])
                        {
                            categry = c;
                            foreach (Products prod in c.products)
                            {
                                if (sales.products[index].ProductName == prod.ProductName)
                                    prod.Quantity += product.Quantity;
                            }
                        }
                    }
                }
            }

            sales.TotalPrice -= sales.products[index].ProductPrice * sales.products[index].Quantity;
            txtTotalPrice.Text = sales.TotalPrice.ToString();
            sales.products.Remove(sales.products[index]);
            gviewSales.DataSource = null;
            gviewSales.DataSource = sales.products;

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

        private void cboxDistributer_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnSale_Click(object sender, EventArgs e)
        {
            sales.DateTime = DatePicher.Value;
            system.salesList.Add(sales);
        }
    }
}

