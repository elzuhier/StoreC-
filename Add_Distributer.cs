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
    public partial class Add_Distributer : Form
    {
        public Add_Distributer()
        {
            InitializeComponent();
        }
        Distributers Distributers;
       // List<Distributers> distributersList = new List<Distributers>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Distributers = new Distributers();
                //id
                Distributers LastIndex = null;
                if (system.distributers.Count != 0)
                {
                    LastIndex = system.distributers.Last();
                }
                if (LastIndex != null)
                    Distributers.DistributerID = LastIndex.DistributerID + 1;
                //name
                Regex reName = new Regex("^[a-zA-z]");
                if (reName.IsMatch(txtNameDistributer.Text))
                {
                    Distributers.DistributerName = txtNameDistributer.Text;
                }
                else
                {
                    MessageBox.Show("Invalid  Name");
                    return;
                }
                ////mobile phone
                Regex rePhone = new Regex("^0[0-9]{11}");
                if (rePhone.IsMatch(txtPhoneDistributer.Text) ||
                    txtPhoneDistributer.Text.Length == 11 ||
                    txtPhoneDistributer.Text != "")
                {
                    Distributers.DistributerPhone = txtPhoneDistributer.Text;
                }
                else
                {
                    MessageBox.Show("Invalid  Mobile Number!!");
                    return;
                }
                //city
                Regex reCity = new Regex("^[a-zA-z]");
                if (reCity.IsMatch(txtCityDistributer.Text))
                {
                    Distributers.DistributerAddress = txtCityDistributer.Text;
                }
                else
                {
                    MessageBox.Show("Invalid  Address");
                    return;
                }


                //ensure distributer is not exist
                foreach (var item in system.distributers)
                {
                    if (item.DistributerName.Equals(txtNameDistributer.Text))
                    {
                        MessageBox.Show("Customer is Exist");
                        txtNameDistributer.Text = "";
                        txtPhoneDistributer.Text = "";
                        txtCityDistributer.Text = "";
                        return;
                    }
                }
                //add to gridview
                system.distributers.Add(Distributers);
                gViewAddDistribuers.DataSource = null;
                gViewAddDistribuers.DataSource = system.distributers;
                txtNameDistributer.Text = "";
                txtPhoneDistributer.Text = "";
                txtCityDistributer.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Enter correct data");
            }
        }
       
        private void gViewAddDistribuers_SelectionChanged(object sender, EventArgs e)
        {
             //select row to edit
            if (gViewAddDistribuers.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in gViewAddDistribuers.SelectedRows)
                {
                    txtDistributerID.Text = row.Cells[0].Value.ToString();
                    txtNameDistributer.Text = row.Cells[1].Value.ToString();
                    txtPhoneDistributer.Text = row.Cells[2].Value.ToString();
                    txtCityDistributer.Text = row.Cells[3].Value.ToString();
                }
            }
        }
        
        private void gViewAddDistribuers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDistributerID.Text = gViewAddDistribuers.SelectedRows[0].Cells[0].Value.ToString();
                txtNameDistributer.Text = gViewAddDistribuers.SelectedRows[0].Cells[1].Value.ToString();
                txtPhoneDistributer.Text = gViewAddDistribuers.SelectedRows[0].Cells[2].Value.ToString();
                txtCityDistributer.Text = gViewAddDistribuers.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (system.distributers.Count == 0)
            {
                MessageBox.Show("no data to edit");
                return;
            }

            if (gViewAddDistribuers.SelectedRows.Count > -1)
            {
                int index = gViewAddDistribuers.CurrentCell.RowIndex;
                if (txtNameDistributer.Text != "" || txtPhoneDistributer.Text != ""
                  || txtCityDistributer.Text != "")
                {
                    system.distributers[index].DistributerID = int.Parse(txtDistributerID.Text);
                    system.distributers[index].DistributerName = txtNameDistributer.Text;
                    system.distributers[index].DistributerPhone = txtPhoneDistributer.Text;
                    system.distributers[index].DistributerAddress = txtCityDistributer.Text;
                }

                gViewAddDistribuers.DataSource = null;
                gViewAddDistribuers.DataSource = system.distributers;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (system.distributers.Count == 0)
            {
                MessageBox.Show("no data to delete");
                return;
            }
            int index = gViewAddDistribuers.CurrentCell.RowIndex;
            system.distributers.Remove(system.distributers[index]);
            gViewAddDistribuers.DataSource = null;
            gViewAddDistribuers.DataSource = system.distributers;
        }

        private void gViewAddDistribuers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Distributer_Load(object sender, EventArgs e)
        {
            //gViewAddDistribuers.DataSource = system.distributers;

        }
    }
}
