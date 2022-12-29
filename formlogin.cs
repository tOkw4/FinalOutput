using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace username
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bduser.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void button1_Click(object sender, EventArgs e)
        {
            
            conn.Open(); //open connection

            string login = "SELECT * FROM tbl_users WHERE username= '"+txtuser.Text+"' AND password= '"+txtpass.Text+"'";
            cmd = new OleDbCommand(login, conn);
            

            OleDbDataReader dr = cmd.ExecuteReader();
            

            if (dr.Read() == true)
            {
                new Form2().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password, please try again.", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Text = "";
                txtpass.Text = "";
                txtuser.Focus();
            }
            conn.Close(); //close the connection
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.PasswordChar = '\0';
               
            }

            else
            {
                txtpass.PasswordChar = '*';
                
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
