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
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void logInbtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> mydic = new Dictionary<string, string>()
            {
                {"admin","admin" },
                {"user","user" },
                {"user2","user2"},
                {"user3","user3"}
            };

            bool flag = true;
            foreach (KeyValuePair<string, string> item in mydic)
            {

                if ((usernametxt.Text.Equals(item.Key)) && (passwordtxt.Text.Equals(item.Value)))
                {
                    Store_Form store = new Store_Form();
                    MessageBox.Show("Loged In Successfully");
                    store.Show();
                    flag = false;
                    this.Hide();
                    return;

                }

            }
            if (flag == true)
            {
                MessageBox.Show("username or password is not correct please try again");
                usernametxt.Clear();
                passwordtxt.Clear();
                return;
            }

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logInlbl_Click(object sender, EventArgs e)
        {

        }

        private void passwordPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelpicture_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
