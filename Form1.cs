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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bduser.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" && txtpass.Text == "" && txtcnfrmpass.Text == "")
            {
                MessageBox.Show("username and password fields are empty", "registration failed", MessageBoxButtons.OK,MessageBoxIcon.Error);




            }
            else if (txtpass.Text == txtcnfrmpass.Text)
            {
                conn.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtuser.Text + "' , '" + txtpass.Text + "')";
                cmd = new OleDbCommand(register, conn);
                cmd.ExecuteNonQuery();
                conn.Close();


                txtuser.Text = "";
                txtpass.Text = "";
                txtcnfrmpass.Text = "";


                MessageBox.Show("Your account has been successfully registered.", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Password does not match", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Text = "";
                txtcnfrmpass.Text = "";
                txtpass.Focus();



            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxshowpas.Checked)
            {
                txtpass.PasswordChar = '\0';
                txtcnfrmpass.PasswordChar = '\0';
            }
        
            else
            {
                txtpass.PasswordChar = '*';
                txtcnfrmpass.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new formlogin().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
