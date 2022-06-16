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
    public partial class Add_Category : Form
    {
        Category category;
       //public  List<Category> categories = new List<Category>()
       //{
           
       //};
        
        public Add_Category()
        {
            InitializeComponent();
        }
        Store stre= null;
        //Category ctegry = new Category();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            category = new Category();
            try
            {
                //view store 
                foreach (Store item in system.store)
                {
                    if (item.storeName == cmbStoreName.Text)
                    {
                        stre = item;

                    }
                }
                //id
                Category LastItem = null;
                if (stre.categories.Count != 0)
                {
                    LastItem = stre.categories.Last();
                }
                if (LastItem != null)
                    category.ID = LastItem.ID + 1;
                //***name***
                Regex reName = new Regex("^[a-zA-z]");
                if (reName.IsMatch(txtbName.Text))
                {
                    category.CategoryName = txtbName.Text;
                }
                else
                {
                    MessageBox.Show($"Plz Enter Correct Name");
                    return;
                }
                //description

                Regex reDescription = new Regex("^[a-zA-z]");
                if (reDescription.IsMatch(txtbDescriotion.Text))
                {
                    category.CategoryDescription = txtbDescriotion.Text;

                }
                else
                {
                    MessageBox.Show($"Plz Enter Correct description");
                    return;
                }
                //ensure cateogry is not exist
                foreach (Category item in stre.categories)
                {

                    if (item.CategoryName.Equals(txtbName.Text))
                    {
                        MessageBox.Show("Item is Exist");
                        txtbName.Text = "";
                        txtbDescriotion.Text = "";
                        return;
                    }
                }
                //add to gridview

                stre.categories.Add(category);
                gviewCategory.DataSource = null;
                gviewCategory.DataSource = stre.categories;

                txtbName.Text = "";
                txtbDescriotion.Text = "";
                stre = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Correct Data");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //store
            foreach (Store item in system.store)
            {
                if (item.storeName == cmbStoreName.Text)
                {
                    stre = item;

                }
            }
            //****vaildate edit 
            try
            {
                if (gviewCategory.SelectedRows.Count > -1)
                {
                    int index = gviewCategory.CurrentCell.RowIndex;

                   
                    Regex reName = new Regex("^[a-zA-z]");
                    if (reName.IsMatch(txtbName.Text))
                    {
                        stre.categories[index].CategoryName = txtbName.Text;
                    }
                    else
                    {
                        MessageBox.Show($"Plz Enter Correct Name");
                        return;
                    }
                    Regex reDescription = new Regex("^[a-zA-z]");
                    if (reDescription.IsMatch(txtbDescriotion.Text))
                    {
                        stre.categories[index].CategoryDescription = txtbDescriotion.Text;
                    }
                    else
                    {
                        MessageBox.Show($"Plz Enter Correct Description");
                        return;
                    }
                    gviewCategory.DataSource = null;
                    gviewCategory.DataSource = stre.categories;

                }
                stre = null;
            }

            catch (Exception)
            {
                MessageBox.Show("please enter data first");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //store
                foreach (Store item in system.store)
                {
                    if (item.storeName == cmbStoreName.Text)
                    {
                        stre = item;

                    }
                }
                //***vaildate***
                int index = gviewCategory.CurrentCell.RowIndex;
                stre.categories.Remove(stre.categories[index]);
                gviewCategory.DataSource = null;
                gviewCategory.DataSource = stre.categories;
            }

            catch (Exception)
            {
                MessageBox.Show("Category is Empty");
            }
        }

        private void gviewCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (gviewCategory.SelectedRows.Count > -1)
            {

                foreach (DataGridViewRow row in gviewCategory.SelectedRows)
                {
                    txtbName.Text = row.Cells[0].Value.ToString();
                    txtbDescriotion.Text = row.Cells[1].Value.ToString();


                }
            }
        }

        private void gviewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Category_Load(object sender, EventArgs e)
        {
            if (system.store != null)
            {
                cmbStoreName.DataSource = system.store;
                cmbStoreName.DisplayMember = "storeName";
                cmbStoreName.SelectedIndex = -1;
            }
        }
    }
}
