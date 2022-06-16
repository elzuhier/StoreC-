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
    public partial class Add_Store : Form
    {
        
        public Add_Store()
        {
            InitializeComponent();
        }
        Store store;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            store = new Store();
            Regex reName = new Regex("^[a-zA-z]");
            if (reName.IsMatch(txtLocation.Text))
            {
                store.storeName = txtLocation.Text;
            }
            else
            {
                MessageBox.Show($"Plz Enter Correct Location");
                return;
            }
            
            if (txtLocation.Text == "")
            {
                MessageBox.Show("Location is Empty");
            }
            system.store.Add(store);
            txtLocation.Text = "";

        }

        private void Add_Store_Load(object sender, EventArgs e)
        {
            
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
