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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_click(object sender, EventArgs e)
        {
            String username = "admin";
            String password = "admin";
            if(txtPassWord.Text == username && txtPassWord.Text == password)
            {
                MessageBox.Show("Login Succsess", "Login", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Login Succsess", "Login", MessageBoxButtons.OK);
            }
        }
    }
}
